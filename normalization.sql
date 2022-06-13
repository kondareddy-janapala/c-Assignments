create table client_rental(client_no varchar(4), c_name varchar(20), property_no varchar(4), p_address varchar(30), rent_start date, rent_finish date, rent int, owner_no varchar(4), owner_name varchar(20));
insert into client_rental values ('CR76', 'JOHN KAY', 'PG4', '6 LAWRENCE 54,GLASSGROW', '1-JUL-00', '31-AUG-01', 350, 'CO40', 'TINA MURPHY');
insert into client_rental values ('CR76', 'JOHN KAY', 'PG16', '5 NOVAR Dr,Glassgrow', '2000-09-1', '2000-09-1', 450, 'CO93', 'TONY SHAW');
insert into client_rental values ('CR56', 'Aline Mewan', 'PG4', '6 lawrence st,Glassgrow', '1999-09-1', '2000-06-10', 350, 'CO40', 'TINA MURPHY');
insert into client_rental values ('CR56', 'Aline Mewan', 'PG30', '2 Manodfid,glassgrow', '2000-10-10', '2001-12-01', 370, 'CO93', 'TONY SHAW');
insert into client_rental values ('CR56', 'Aline Mewan', 'PG36', '5 NOVAR Dr,glassgrow', '2002-11-1', '2003-08-01', 450, 'CO93', 'TONY SHAW');
select * from client_rental;

drop table client_rental;

create table client(client_no varchar(4), c_name varchar(20), primary key (client_no));
create table property(property_no varchar(4), property_address varchar(20), client_no varchar(4), primary key(property_no), foreign key (client_no) references client(client_no));
create table rent(rent_start date, rent_end date, rent int);
create table owner(owner_no varchar(4), owner_name varchar(20), property_no varchar(4), primary key(owner_no), foreign key(property_no) references property(property_no));

select * from client;
select * from property;
select * from owner;