use master
go

create database DB_QLSANBONG
go

use DB_QLSANBONG
go

create table LoaiSan
(
	MaLoai char(10) not null,
	TenLoai nvarchar(50),
	Gia money check(Gia>0),
	constraint PK_LoaiSan primary key(MaLoai)
);
go


create table San
(
	MaSan char(10) not null,
	MaLoai char(10),
	TenSan nvarchar(100),
	TinhTrang nvarchar(50) check(TinhTrang in (N'Bình thường',N'Bảo trì')),
	constraint PK_San primary key(MaSan),
	constraint FK_San_LoaiSan foreign key (MaLoai) references LoaiSan (MaLoai),
);
go

create table NhanVien
(
	MaNhanVien char(10) NOT NULL,
	TenNhanVien nvarchar(100),
	NgaySinh date CHECK(NgaySinh <= DATEADD(YEAR, -18, GETDATE())),
	ChucVu nvarchar(20),
	SoDT nvarchar(11) CHECK(LEN(SoDT)=10 AND ISNUMERIC(SoDT)=1),
	MatKhau nvarchar(20),
	DiaChi nvarchar(255),
	GioiTinh nvarchar(5) CHECK(GioiTinh in ('Nam',N'Nữ',N'Khác')),
	HinhDaiDien char(255),
	constraint PK_NhanVien primary key(MaNhanVien) ,
);
go

create table KhachHang
(
	MaKhachHang char(10) NOT NULL,
	TenKhachHang nvarchar(100),
	LienHe nvarchar(11) CHECK(LEN(LienHe)=10 AND ISNUMERIC(LienHe)=1),
	CCCD nvarchar(15) CHECK(LEN(CCCD)=12 AND ISNUMERIC(CCCD)=1),
	GioiTinh nvarchar(5) CHECK(GioiTinh in ('Nam',N'Nữ',N'Khác')),
	constraint PK_KhachHang primary key(MaKhachHang),
);
go

create table CaThue
(
	MaCaThue char(10) not null,
	ThoiGianBD time,
	ThoiGianKT time,
	constraint PK_CaThue primary key (MaCaThue),
);

go
create table HoaDonDatSan
(
	MaDatSan char(20) not null,
	MaNhanVien char(10),
	MaKhachHang char(10),
	NgayDatSan date check(NgayDatSan >= CONVERT(date, GETDATE())),
	TinhTrang nvarchar(255) check(TinhTrang in (N'Đã thanh toán',N'Chưa thanh toán')),
	constraint PK_HoaDonDatSan primary key(MaDatSan),
	constraint FK_HoaDonDatSan_KhachHang foreign key(MaKhachHang) references KhachHang(MaKhachHang),
	constraint FK_HoaDonDatSan_NhanVien foreign key(MaNhanVien) references NhanVien(MaNhanVien),
);

create table ChiTietHoaDonDatSan
(
	MaDatSan char(20),
	MaSan char(10),
	MaCaThue char(10),
	ThanhTien money CHECK(THANHTIEN>0),
	constraint PK_ChiTietHoaDonDatSan primary key(MaDatSan,MaSan,MaCaThue),
	constraint FK_ChiTietHoaDonDatSan_HoaDonDatSan foreign key (MaDatSan) references HoaDonDatSan(MaDatSan),
	constraint FK_HoaDonDatSan_San foreign key(MaSan) references San(MaSan),
	constraint FK_HoaDonDatSan_CaThue foreign key(MaCaThue) references CaThue(MaCaThue),
);

insert into LoaiSan values
	('LS001', N'Sân 5 người', 200000),
	('LS002', N'Sân 7 người', 300000),
	('LS003', N'Sân 9 người', 500000);
select * from LoaiSan
go

insert into San values
	('S001', 'LS001', N'Sân A 5 người', N'Bình thường'),
	('S002', 'LS002', N'Sân B 7 người', N'Bình thường'),
	('S003', 'LS003', N'Sân C 9 người', N'Bảo trì'),
	('S004', 'LS001', N'Sân D 5 người', N'Bình thường'),
	('S005', 'LS002', N'Sân E 7 người', N'Bảo trì');
select * from San
go


insert into NhanVien values
	('NV001', N'Nguyễn Văn A', '1990-05-12', N'Quản lý', '0901234567','123', N'Số 1, Đường ABC, Quận 1, TP.HCM', N'Nam','NV001.jpg'),
	('NV002', N'Trần Thị B', '1985-08-22', N'Nhân viên', '0907654321','123', N'Số 2, Đường DEF, Quận 3, TP.HCM', N'Nữ',null),
	('NV003', N'Lê Văn C', '1993-12-05', N'Nhân viên', '0909876543','123', N'Số 3, Đường GHI, Quận 5, TP.HCM', N'Nam',null),
	('NV004', N'Phạm Minh D', '1987-03-15', N'Nhân viên', '0912345678','123', N'Số 4, Đường JKL, Quận 7, TP.HCM', N'Nam',null),
	('NV005', N'Hoàng Thu E', '1992-09-25', N'Nhân viên', '0913456789','123', N'Số 5, Đường MNO, Quận 9, TP.HCM', N'Nữ',null),
	('NV006', N'Nguyễn Hải F', '1991-04-10', N'Nhân viên', '0919876543','123', N'Số 6, Đường PQR, Quận 10, TP.HCM', N'Khác',null);
select * from NhanVien
go

insert into KhachHang  values
	('KH001', N'Nguyễn Anh Tuấn', '0901234567', '012345678901','Nam'),
	('KH002', N'Hoàng Thị Lan', '0907654321', '098765432109',N'Nữ'),
	('KH003', N'Lê Đình Hoàng', '0909876543', '123456789012','Nam'),
	('KH004', N'Trần Thị Mai', '0912345678', '234567890123',N'Nữ');
select * from KhachHang

go

insert into CaThue values 
	('CTS001', '08:00', '09:30'),
	('CTS002', '10:00', '11:30'),
	('CTC001', '14:00', '15:30'),
	('CTC002', '16:00', '18:30'),
	('CTT001', '19:00', '20:30'),
	('CTT002', '21:00', '22:30');
select * from CaThue
go

insert into HoaDonDatSan values
	('HD31122024001', 'NV001', 'KH001', '2024-12-31', N'Đã thanh toán'),
	('HD30122024001', 'NV002', 'KH002', '2024-12-30', N'Chưa thanh toán'),
	('HD29122024001', 'NV003', 'KH003', '2024-12-29', N'Đã thanh toán'),
	('HD28122024001', 'NV004', 'KH004', '2024-12-28', N'Chưa thanh toán');
select * from HoaDonDatSan
go

select * from ChiTietHoaDonDatSan
select * from ChiTietHoaDonDatSan,HoaDonDatSan where Chitiethoadondatsan.MaDatSan = HoaDonDatSan.MaDatSan
go

select*from LoaiSan
select*from NhanVien

select MaNhanVien, TenNhanVien, SoDT, ChucVu,DiaChi, NgaySinh, GioiTinh, HinhDaiDien from NhanVien