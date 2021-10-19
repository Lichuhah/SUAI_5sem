use database_design_course;

insert into performance (namePerformance, datePerformance)
    values ('Представление с принцем', '2021-10-11'),
           ('Представление с королем', '2021-10-12'),
           ('Представление (пустое)', '2021-10-13'),
           ('Золушка', '2021-10-18'),
           ('Мастер и Маргарита', '2021-10-19');


insert into author (firstNameAuthor)
    values ('Имя 1'),
           ('Имя 2'),
           ('Имя 3');


insert into clothes (nameClothes, dataCreate, sizeClothes)
    values ('Маленький принц', '2020-12-11', 30),
           ('Маленький король', '2020-12-14', 30),
           ('Платье Золушки', '2020-12-10', 25),
           ('Костюм Мастера', '2020-12-13', 30),
           ('Костюм Маргариты', '2020-12-09', 25);


insert into role (id_performance, nameRole)
    values (1, 'Роль принца'),
           (2, 'Роль короля'),
           (4, 'Золушка'),
           (5, 'Мастер'),
           (5, 'Маргарита');


insert into type_detail (nameType)
    values ('Плащ'),
           ('Штаны'),
           ('Шляпа'),
           ('Брюки'),
           ('Цилиндр'),
           ('Ботинки');


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
           (3,2),
           (4,2),
           (4,3),
           (5,2);


insert into clothes_concrete_detail (id_clothes, id_concrete_detail)
values (2, 2), (2, 8), (2, 17), (2, 5),

       (1,1), (1,4), (1,7), (1,10), (1,13), (1,16);


insert into clothes_role (id_clothes, id_role)
    values (1,1),
           (2,2),
           (3,3),
           (4,4),
           (5,5);
