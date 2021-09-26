# clear table
delete from author
    where id_author >= 0;

# delete test data
delete from author
    where id_author < 0;

delete from author
    where firstNameAuthor = '1';

select * from author;

