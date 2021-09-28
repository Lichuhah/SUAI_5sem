insert into author
    (id_author, firstNameAuthor, secondNameAuthor, thirdNameAuthor)
    values (1,'1','1','1');

insert into author
    set id_author = -1,
        firstNameAuthor = 'Тест';

insert into author  (firstNameAuthor)
            values  ('Анна'),
                    ('Екатерина'),
                    ('Евгений'),
                    ('Александр'),
                    ('Георгий');

select * from author;

