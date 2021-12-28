# По аналогии с примерами, приведенными в п. 1 реализовать для своей базы данных триггеры
# для всех событий (insert,delete, update) до и после. Часть из которых будет обеспечивать ссылочную
# целостность, остальные могут иметь другое назначение из 3 предложенных. Вычислимые поля
# можно добавить при необходимости

SET FOREIGN_KEY_CHECKS=0; -- to disable them
SET FOREIGN_KEY_CHECKS=1; -- to re-enable them

use database_design_course;

drop trigger if exists tr11;
drop trigger if exists tr12;
drop trigger if exists tr21;
drop trigger if exists tr22;
drop trigger if exists tr31;
drop trigger if exists tr32;
drop table if exists author_log;

# ------------------------------------------------------
create table if not exists author_log(
    id int not null auto_increment primary key,
    id_author int not null,
    firstNameAuthor varchar(40) default null,
    secondNameAuthor varchar(40) default null,
    thirdNameAuthor varchar(40) default null
);
# ======================================================
# ------------------------------------------------------
# before insert

# Если (такого типа нет):
#   добавляет "неизвестный тип";
#   связывает с "неизвестный тип";
# Либо:
#   связывает с "неизвестный тип";

create trigger tr31
    before insert on concrete_detail
        for each row begin
            if not exists(select * from type_detail
                where type_detail.id_type_detail = NEW.id_type_detail) then
                    if not exists(select * from type_detail
                        where nameType like 'unknown type') then
                            insert into type_detail (nameType)
                                values ('unknown type');
                    end if;

                    set NEW.id_type_detail =
                        (select id_type_detail from type_detail
                            where nameType like 'unknown type');
            end if;
        end;
# ------------------------------------------------------
# after insert

# logging

create trigger tr32
    after insert on author
        for each row begin
            insert into author_log
                (id_author, firstNameAuthor,
                 secondNameAuthor, thirdNameAuthor)
                values
                (NEW.id_author, concat('<insert trg> ', NEW.firstNameAuthor),
                 NEW.secondNameAuthor, NEW.thirdNameAuthor);
        end;
# ======================================================
# ------------------------------------------------------
# before delete

# При удалении автора удаляет все его связи с одеждой

create trigger tr11
    before delete on author
        for each row begin
            delete from clothes_author
                where clothes_author.id_author = OLD.id_author;
        end;
# ------------------------------------------------------
# after delete

# Если при удалении конкретной детали
#   тип, которому она принадлежала стал избыточным
#   (никому не принадлежащим, ни с чем не связанным)
#
# удаляет этот тип

create trigger tr12
    after delete on concrete_detail
        for each row begin
            if not exists(select * from concrete_detail cd
                where cd.id_type_detail = OLD.id_type_detail) then

                    delete from type_detail
                        where type_detail.id_type_detail = OLD.id_type_detail;

            end if;
        end;
# ======================================================
# ------------------------------------------------------
# before update

# Каскадное обновление первичного ключа

create trigger tr21
    before update on type_detail
        for each row begin
            declare fkc int;
            set fkc=@@foreign_key_checks;
            set @@foreign_key_checks=0;

            if (OLD.id_type_detail != NEW.id_type_detail) then
                update concrete_detail
                    set id_type_detail = NEW.id_type_detail
                    where id_type_detail = OLD.id_type_detail;
            end if;

            set @@foreign_key_checks=fkc;
        end;
# ------------------------------------------------------
# after update

# logging

create trigger tr22
    after update on author
        for each row begin
            insert into author_log
                (id_author, firstNameAuthor,
                 secondNameAuthor, thirdNameAuthor)
                values
                (OLD.id_author, concat('<before upd> ', OLD.firstNameAuthor),
                 OLD.secondNameAuthor, OLD.thirdNameAuthor);
        end;


# ######################################################
# tests
# ------------------------------------------------------
# test before insert
insert into concrete_detail (id_type_detail, colorDetail)
    values (1000, 'test trigger insert before');

select td.id_type_detail, td.nameType, cd.colorDetail
    from concrete_detail cd
        left outer join type_detail td
            on td.id_type_detail = cd.id_type_detail;
# ------------------------------------------------------
# test after insert
insert into author (firstNameAuthor)
    values ('test trigger insert');
select * from author_log;
# ------------------------------------------------------
# test before delete
delete from author where id_author = 1;

select a.id_author, a.firstNameAuthor, c.nameClothes
from clothes_author
    right outer join clothes c
        on c.id_clothes = clothes_author.id_clothes
    right outer join author a
        on a.id_author = clothes_author.id_author;
# ------------------------------------------------------
# test after delete
delete from concrete_detail cd where id_concrete_detail = 1;
delete from concrete_detail cd where id_concrete_detail = 2;
delete from concrete_detail cd where id_concrete_detail = 3;

select td.id_type_detail, td.nameType, cd.colorDetail, cd.id_concrete_detail
    from concrete_detail cd
        right outer join type_detail td
            on td.id_type_detail = cd.id_type_detail;
# ------------------------------------------------------
# test before update
update type_detail
    set id_type_detail = 300
    where id_type_detail = 3;

select td.id_type_detail, td.nameType, cd.colorDetail
    from concrete_detail cd
        join type_detail td
            on td.id_type_detail = cd.id_type_detail;
# ------------------------------------------------------
# test after update
update author
    set firstNameAuthor = 'test trigger update'
    where author.id_author = 2;
select * from author_log;

