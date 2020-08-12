create database webdata
use webdata

create table users
(
	userid int,
	username nvarchar(50),
	matkhau varchar(50),
	loai int,
	primary key (userid)
)

create table games
(
	magame int,
	tengame nvarchar(100),
	gia float,
	fname nvarchar(100),
	primary key (magame)
)

create table hoadon
(
	mahd int,
	userid int,
	ngaylap date,
	thanhtoan int,
	primary key(mahd)
)

create table ct_hoadon
(
	mahd int,
	magame int,
	primary key(mahd,magame)
)

alter table hoadon
add constraint fk_hd_userid foreign key(userid) references users(userid)
alter table ct_hoadon
add constraint fk_cthd_magame foreign key(magame) references games(magame)
alter table ct_hoadon
add constraint fk_cthd_mahd foreign key(mahd) references hoadon(mahd)

insert into users values (0,'admin','admin123',0)

insert into games values
(1,'Death Stranding',41.99,'1.jpg'),
(2,'Assassins Creed - Odyssey',41.99,'2.jpg'),
(3,'Assassins Creed - Origin',59.99,'3.jpg'),
(4,'Far Cry 5',31.99,'4.jpg'),
(5,'GTV V',24.99,'5.jpg'),
(6,'Raft',11.59,'6.jpg'),
(7,'Sea of Thieves',30.99,'7.jpg'),
(8,'Red Dead Redemption II',59.99,'8.jpg')