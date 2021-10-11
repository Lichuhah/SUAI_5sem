# clear table
delete from author
    where id_author >= 0;

# delete test data
delete from author
    where id_author < 0;

select * from author;

