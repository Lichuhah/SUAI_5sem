use trsis_tessier;

drop table if exists item;

create table if not exists item(
    id int primary key not null auto_increment,
    section varchar(4) not null, # [A0, A000]
    name varchar(100) not null,
    date_add date not null,
    storage_time int not null, # days
    storage_price int not null, # Decimal - better, but int simple to use
    count int
);

