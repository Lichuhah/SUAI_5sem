use database_design_course;

insert into performance (id_performance, namePerformance, datePerformance)
    values (1, 'Представление с принцем', '2021-10-11'),
           (2, 'Представление с королем', '2021-10-12'),
           (3, 'Представление (без ролей и одежды)', '2021-10-13'),
           (4, 'Золушка', '2021-10-18'),
           (5, 'Мастер и Маргарита', '2021-10-19'),
           (6, 'Представление (с ролями и без одежды)', '2021-10-20');


insert into author (id_author, firstNameAuthor)
    values (1, 'Имя 1'),
           (2, 'Имя 2'),
           (3, 'Имя 3'),
           (4, 'Имя 4');


insert into clothes (id_clothes, nameClothes, dataCreate, sizeClothes)
    values (1, 'Маленький принц', '2020-12-11', 30),
           (2, 'Маленький король', '2020-12-14', 30),
           (3, 'Платье Золушки', '2020-12-10', 25),
           (4, 'Костюм Мастера', '2020-12-13', 30),
           (5, 'Костюм Маргариты', '2020-12-09', 25);


insert into role (id_performance, id_role, nameRole)
    values (1, 1, 'Роль принца'),
           (2, 2, 'Роль короля'),
           (4, 3, 'Золушка'),
           (5, 4, 'Мастер'),
           (5, 5, 'Маргарита'),
           (6, 6, 'Роль для пустого представления');


insert into type_detail (id_type_detail, nameType)
    values (1, 'Плащ'),
           (2, 'Штаны'),
           (3, 'Шляпа'),
           (4, 'Брюки'),
           (5, 'Цилиндр'),
           (6, 'Ботинки');


insert into concrete_detail (id_type_detail, id_concrete_detail, colorDetail)
    values (1, 1, 'Черный'), (1, 2, 'Бардовый'), (1, 3, 'Белый'),
           (2, 4, 'Черный'), (2, 5, 'Бардовый'), (2, 6, 'Белый'),
           (3, 7, 'Черный'), (3, 8, 'Бардовый'), (3, 9, 'Белый'),
           (4, 10, 'Черный'), (4, 11, 'Бардовый'), (4, 12, 'Белый'),
           (5, 13, 'Черный'), (5, 14, 'Бардовый'), (5, 15, 'Белый'),
           (6, 16, 'Черный'), (6, 17, 'Бардовый'), (6, 18, 'Белый');


insert into clothes_author (id_clothes, id_author)
    values (1,1),
           (2,2),
           (3,2),
           (4,2),
           (4,3),
           (5,2);


insert into clothes_concrete_detail (id_clothes, id_concrete_detail)
values
       (1,1), (1,4), (1,7), (1,10), (1,13), (1,16),
       (2, 2), (2, 8), (2, 17), (2, 5),
       (3, 3),
       (4,4),
       (5,6)
       ;


insert into clothes_role (id_clothes, id_role)
    values (1,1),
           (2,2),
           (3,3),
           (4,4),
           (5,5);
