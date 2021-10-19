#create table if not exists authors2020 (
#    id_author int not null auto_increment primary key,
#
#    firstNameAuthor varchar(20) default null,
#    secondNameAuthor varchar(20) default null,
#    thirdNameAuthor varchar(20) default null;
#)
#AUTO_INCREMENT = 1;
#
#
#merge into author as a
#    using authors2020 as an
#    on a.id_author = an.id_author
#
#    when NOT MATCHED then
#        insert values (an.firstNameAuthor, an.secondNameAuthor, an.thirdNameAuthor)
#
#    when MATCHED then
#        update set a.firstNameAuthor = an.firstNameAuthor,
#            a.secondNameAuthor = an.secondNameAuthor,
#            a.thirdNameAuthor = an.thirdNameAuthor
#;
