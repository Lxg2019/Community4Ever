create database c4e;
use c4e;
create table city(
	id int not null auto_increment,
    name char(40) not null,
    primary key (id)
);
create table street(
	id int not null auto_increment,
    name char(40) not null,
    primary key (id)
);
create table address(
	id int not null auto_increment,
    primary key (id),
    constraint fk_cityaddress foreign key (id) references city(id),
    constraint fk_streetaddress foreign key (id) references street(id)
);
create table person (
	id int not null auto_increment,
    firstname char(40) not null,
    name char(40) not null,
	contacttype int,
	contactstring varchar(200),
	telefon varchar(100),
    primary key (Id)
);
create table role(
	id int not null auto_increment,
    discriminator char(40) not null,
    primary key (id)
);
create table roleperson(
	id int not null auto_increment,
    discriminator char(40) not null,
    primary key (id),
    foreign key (id) references person(id)
);
create table ordercontent(
	id int not null auto_increment,
    begin datetime,
    end datetime,
	additionalInfo varchar(200),
    primary key (id),
    foreign key (id) references address(id)
);
create table orderstatus(
	id int not null auto_increment,
    myproperty int not null,
    primary key (id)
);
create table `order`(
	id int not null auto_increment,
    primary key (id),
	constraint fk_orderstatusorder foreign key (id) references ordercontent(id),
    constraint fk_ordercontentorder foreign key (id) references ordercontent(id),
    constraint fk_personorder foreign key (id) references person(id)
);