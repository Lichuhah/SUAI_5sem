# Допустим мы создали новую таблицу author_new
# и в нее добавили отношение date_born и заполнили таблицу
#
# затем мы изменяем старую таблицу и добавляем туда новые изменения

create table if not exists author_new (
    id_author int not null auto_increment primary key,

    firstNameAuthor varchar(20) default null,
    secondNameAuthor varchar(20) default null,
    thirdNameAuthor varchar(20) default null,

    # new column
    date_born date default null;
)
AUTO_INCREMENT = 1;

alter table clothes
add column date_born date default null;

merge into clothes as c
    using clothes_new as cn
    on c.id_clothes = cn.id_clothes

    when NOT MATCHED then update
    set c.date_born = cn.date_born;
