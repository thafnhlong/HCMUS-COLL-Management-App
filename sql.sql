use master

if db_id('LTUDQL') is not null
	drop database LTUDQL
go
create database LTUDQL
go
use LTUDQL
go

create table TaiKhoan
(
	id int identity(1,1) primary key,
	tentaikhoan varchar(255) unique,
	matkhau varchar(255),
	hoten nvarchar(255),
	ngaysinh date,
	permission int default 0,
	lophocid int
)

create table LopHoc
(
	id int identity(1,1) primary key,
	tenlop nvarchar(255),
	caphocid int
)

create table CapHoc
(
	id int identity(1,1) primary key,
	tencap nvarchar(255)
)

create table MonHoc
(
	id int identity(1,1) primary key,
	tenmonhoc nvarchar(255)
)

create table CapHoc_MonHoc
(
	caphocid int ,
	monhocid int
	primary key(caphocid,monhocid)
)

create table CauHoi
(
	id int identity(1,1) primary key,
	noidung ntext,
    goiy nvarchar(255),
    dokho int,
	caphocid int,
	monhocid int,
	donggop int,
	trangthai bit
)

create table DapAn
(
	cauhoiid int,
	stt int,
	noidung ntext,
    dungsai bit
	primary key(cauhoiid,stt)
)

create table DeThi
(
	id int identity(1,1) primary key,
	loaidethi bit,
	thoigiantoida int,
	caphocid int,
	monhocid int,
    kythiid int,
	ngaythi date
)

create table DeThi_CauHoi
(
	dethiid int,
	cauhoiid int
	primary key(dethiid,cauhoiid)
)

create table HocSinhLamBai
(
	hocsinhid int,
	dethiid int,
	cauhoiid int,
	dungsai bit
	primary key(hocsinhid,dethiid,cauhoiid)
)

create table HocSinhThamGia
(
	hocsinhid int,
	dethiid int,
	socaudung int,
	thoigianlambai nvarchar(255)
	primary key(hocsinhid,dethiid)
)

create table KyThi
(
	id int identity(1,1) primary key,
	tenkythi nvarchar(255),
	ngaybatdau date,
	songay int,
	loaikythi bit
)

alter table TaiKhoan
add constraint FK_TK_LH
	foreign key (lophocid)
	references LopHoc

alter table LopHoc
add constraint FK_LH_CH
	foreign key (caphocid)
	references CapHoc

alter table CapHoc_MonHoc
add constraint FK_CapHoc_MonHoc_CH
	foreign key (caphocid)
	references CapHoc,

	constraint FK_CapHoc_MonHoc_MH
	foreign key (monhocid)
	references MonHoc

alter table CauHoi
add constraint FK_CH_CHMH
	foreign key (caphocid,monhocid)
	references CapHoc_MonHoc,

	constraint FK_CH_TK
	foreign key (donggop)
	references TaiKhoan

alter table DapAn
add constraint FK_DapAn_CH	
	foreign key (cauhoiid)
	references CauHoi

alter table DeThi
add constraint FK_DT_CHMH
	foreign key (caphocid,monhocid)
	references CapHoc_MonHoc,
    
    constraint FK_DT_KT
	foreign key (kythiid)
	references KyThi

alter table DeThi_CauHoi
add constraint FK_DTCH_DT
	foreign key (dethiid)
	references DeThi,

	constraint FK_DTCH_CH
	foreign key (cauhoiid)
	references CauHoi

alter table HocSinhLamBai
add constraint FK_HSLB_TK
	foreign key (hocsinhid)
	references TaiKhoan,

	constraint FK_HSLB_DTCH
	foreign key (dethiid,cauhoiid)
	references DeThi_CauHoi

alter table HocSinhThamGia
add constraint FK_HSTG_TK
	foreign key (hocsinhid)
	references TaiKhoan,

	constraint FK_HSTG_DT
	foreign key (dethiid)
	references DeThi
