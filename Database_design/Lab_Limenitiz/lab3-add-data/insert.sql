use database_design_course;

# ok
insert into performance (namePerformance, datePerformance)
    values ('Представление 1', '2021-10-11'),
           ('Представление 2', '2021-10-12'),
           ('Представление 3', '2021-10-13'),
           ('Золушка', '2021-10-18'),
           ('Мастер и Маргарита', '2021-10-19');

# ok
insert into author (firstNameAuthor)
    values ('Имя 1'),
           ('Имя 2'),
           ('Имя 3');

# ok
insert into clothes (nameClothes, dataCreate, sizeClothes)
    values ('Маленький принц', '2020-12-11', 30),
           ('Средний принц', '2020-12-12', 40),
           ('Большой принц', '2020-12-13', 50),
           ('Маленький король', '2020-12-14', 30),
           ('Средний король', '2020-12-15', 40),
           ('Большой король', '2020-12-16', 50);

# ok
insert into role (id_performance, nameRole)
    values (1, 'Роль 1'),
           (2, 'Роль 2'),
           (4, 'Золушка'),
           (5, 'Мастер'),
           (5, 'Маргарита');

# ok
insert into type_detail (nameType)
    values ('Плащ'),
           ('Штаны'),
           ('Шляпа'),
           ('Брюки'),
           ('Цилиндр'),
           ('Ботинки');

# ok
insert into concrete_detail (id_type_detail, colorDetail)
    values (1, 'Черный'), (1, 'Бардовый'), (1, 'Белый'),
           (2, 'Черный'), (2, 'Бардовый'), (2, 'Белый'),
           (3, 'Черный'), (3, 'Бардовый'), (3, 'Белый'),
           (4, 'Черный'), (4, 'Бардовый'), (4, 'Белый'),
           (5, 'Черный'), (5, 'Бардовый'), (5, 'Белый'),
           (6, 'Черный'), (6, 'Бардовый'), (6, 'Белый');


insert into clothes_author (id_clothes, id_author)
    values (1,1),
           (2,2),
           (3,3),
           (4,3);

insert into clothes_concrete_detail (id_clothes, id_concrete_detail)
values (2, 2), (2, 8), (2, 17), (2, 5),

       (1,1), (1,4), (1,7), (1,10), (1,13), (1,16);

insert into clothes_role (id_clothes, id_role)
    values (1,1),
           (2,2),
           (2,4),
           (6,2),
           (3,3),
           (4,4),
           (4,5);

insert into clothes_role (id_clothes, id_role)
    values (2,4);


# = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = =
# = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = =
# = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = =


# clothes_concrete_detail select
select c.nameClothes, cd.colorDetail, td.nameType, ccd.id_concrete_detail
    from clothes_concrete_detail ccd
        inner join concrete_detail cd
        on ccd.id_concrete_detail = cd.id_concrete_detail
        inner join type_detail td
        on cd.id_type_detail = td.id_type_detail
        inner join clothes c
        on ccd.id_clothes = c.id_clothes;

# join color detail and name detail
select colorDetail, nameType, id_concrete_detail
from concrete_detail cd
    inner join type_detail td
    on cd.id_type_detail = td.id_type_detail
group by cd.id_concrete_detail;


# select а
select p.namePerformance, r.nameRole, c.nameClothes
    from clothes_role cr
        right join clothes c
            on cr.id_clothes = c.id_clothes
        right join role r
            on cr.id_role = r.id_role
        right join performance p
            on r.id_performance = p.id_performance
;
#     where LOWER(nameClothes) LIKE '%принц%'

# select б
select c.nameClothes, cd.colorDetail, td.nameType
    from clothes c
        inner join clothes_concrete_detail ccd
            on c.id_clothes = ccd.id_clothes
        inner join concrete_detail cd
            on ccd.id_concrete_detail = cd.id_concrete_detail
        inner join type_detail td
            on cd.id_type_detail = td.id_type_detail
    where LOWER(nameType) LIKE '%плащ%' or
          LOWER(nameType) LIKE '%штаны%';

# select в
select namePerformance
    from performance
        left outer join role r
            on performance.id_performance = r.id_performance
    where ISNULL(r.id_performance);

# select г
# select * from clothes_role
#     inner join clothes c
#         on clothes_role.id_clothes = c.id_clothes
#     inner join role r
#         on clothes_role.id_role = r.id_role
#     where (c.dataCreate);

# select д

# select е

# select ж
select firstNameAuthor, nameClothes, namePerformance
    from clothes_author ca
        right join author a
            on a.id_author = ca.id_author
        right join clothes c
            on c.id_clothes = ca.id_clothes
        right join clothes_role cr
            on c.id_clothes = cr.id_clothes
        right join role r
            on cr.id_role = r.id_role
        right join performance p
            on r.id_performance = p.id_performance
    where lower(namePerformance) like lower('%Мастер%') and
          lower(namePerformance) not like lower('%Золушка%')
;


