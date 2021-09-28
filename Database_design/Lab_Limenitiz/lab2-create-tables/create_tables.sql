create table if not exists Clothes (
    id_clothes int primary key auto_increment,

    nameClothes nvarchar(20) not null,
    dataCreate date not null ,
    sizeClothes int not null
);

create table if not exists Performance(
    id_performance int primary key auto_increment,

    namePerformance nvarchar(20) not null,
    datePerformance date not null
);

create table if not exists Role (
    id_role int primary key auto_increment,

    id_performance int not null,
    FOREIGN KEY (id_performance) REFERENCES Performance (id_performance)
        on delete cascade
        on update restrict,

    nameRole nvarchar(20)
);

create table if not exists Author (
    id_author int not null auto_increment primary key, #TODO: переписать все ключи как здесь

    firstNameAuthor nvarchar(20) default null,
    secondNameAuthor nvarchar(20) default null,
    thirdNameAuthor nvarchar(20) default null;
)
ENGINE = InnoDB
DEFAULT CHARSET = utf8bm4
AUTO_INCREMENT = 1;


create table if not exists Type_Detail (
    id_type_detail int primary key auto_increment,

    nameType nvarchar(10)
);

create table if not exists Concrete_Detail (
    id_concrete_detail int primary key auto_increment,

    id_type_detail int not null,
    constraint FOREIGN KEY (id_type_detail) #TODO: добавить везде такой constraint
    REFERENCES Type_Detail (id_type_detail)
        on delete cascade
        on update cascade,

    colorDetail varchar(6) #hex
);

create table if not exists Clothes_Role (
    id_clothes int not null,
    FOREIGN KEY (id_clothes) REFERENCES Clothes (id_clothes)
        on delete cascade
        on update cascade,

    id_role int not null,
    FOREIGN KEY (id_role) REFERENCES Role (id_role)
        on delete cascade
        on update cascade
);

create table if not exists Clothes_Author (
    id_clothes int not null,
    FOREIGN KEY (id_clothes) REFERENCES Clothes (id_clothes)
        on delete cascade
        on update restrict,

    id_author int not null,
    FOREIGN KEY (id_author) REFERENCES Author (id_author)
        on delete restrict
        on update restrict
);

create table if not exists Clothes_Concrete_Detail (
    id_clothes int not null,
    FOREIGN KEY (id_clothes) REFERENCES Clothes (id_clothes)
        on delete cascade
        on update cascade,

    id_concrete_detail int not null,
    FOREIGN KEY (id_concrete_detail) REFERENCES Concrete_Detail (id_concrete_detail)
        on delete cascade
        on update cascade
);

