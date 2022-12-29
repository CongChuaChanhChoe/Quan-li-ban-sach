create database QLBS

use QLBS


CREATE TABLE LoaiSach
(
	MaLoai char(5) NOT NULL,
	TenLoai nvarchar(25) NULL,
	PRIMARY KEY (MaLoai)
)

CREATE TABLE Sach
(
	MaSach char(5) 	primary key,
	TenSach nvarchar(40) ,
	TacGia nvarchar(20) ,
	MaLoai char(5) ,
	DonGia int ,
	SLTon smallint ,
	MaKHO nvarchar(15) FOREIGN KEY (MaKHO) REFERENCES KHO (MaKHO),
	MaKH char(5) FOREIGN KEY (MaKH) REFERENCES KhachHang (MaKH),
	MaNV char(5) FOREIGN KEY (MaNV) REFERENCES NhanVien (MaNV),
	MaNhaSX nvarchar(5) FOREIGN KEY (MaNhaSX) REFERENCES NhaSanXuat (MaNhaSX),
	MaHD char (5) FOREIGN KEY (MaHD) REFERENCES Hoadon (MaHD),
 )

 
CREATE TABLE LUONG
(
	MaLuong char(5),
	TienLuong money NULL,
	PRIMARY KEY (MaLuong)
)

CREATE TABLE NhanVien
(
	MaNV char(5) primary key,
	HoLot nvarchar(25) NULL,
	TenNV nvarchar(10) NULL,
	Phai nvarchar(3) NULL,
	NgaySinh date NULL,
	DiaChi nvarchar(40) NULL,
	SoDienThoai varchar(20) ,
	ChucVu nvarchar (20) NULL ,
	ThoiGianLamViec nvarchar(40) NULL ,
	NgayLamViec char(5),
	MaLuong char (5) FOREIGN KEY (MaLuong) REFERENCES LUONG (MaLuong),
)

 CREATE TABLE Hoadon
 (
	MaHD char(5) ,
	NgayBan date ,
	MaNV char(5),
	ThanhTien money Null,
 PRIMARY KEY (MaHD),
 )
 
CREATE TABLE CTHD
(
	MaHD char(5) ,
	MaSach char(5) ,
	SoLuong tinyint ,
 PRIMARY KEY (MaHD,MaSach)
 )

 CREATE TABLE KhachHang
 ( MaKH char(5) ,
   HoTenKH Nvarchar(20) ,
   DC Nvarchar(40) ,
   NgMua date NULL ,
   SoDT varchar(20) ,
  PRIMARY KEY (MaKH)
	)
	

	CREATE TABLE KHO
	( MaKHO nvarchar(15) ,
	  TenKHO Nvarchar(20) ,
	  DC Nvarchar(40) ,
	  SoDT varchar(20) ,
	  NVK nvarchar(20),
   PRIMARY KEY (MaKHO),
	)
	
	
	 CREATE TABLE NhaSanXuat
	 ( MaNhaSX nvarchar (5) ,
	   TenNhaSX Nvarchar(20) ,
	   DC Nvarchar(40) ,
	   SoDT varchar(20) ,
   PRIMARY KEY (MaNhaSX) ,
	 )

	CREATE TABLE dCHI
	( MadChi nvarchar (20) ,
	  TendChi nvarchar (20) ,
	PRIMARY KEY (MadChi) ,
	)

 insert into LoaiSach values ('N001',N'Tin học')
 insert into LoaiSach values ('N002',N'Khoa học kỹ thuật')
 insert into LoaiSach values ('N003',N'Anh văn')
 insert into LoaiSach values ('N004',N'Y học')
 insert into LoaiSach values ('N005',N'Mác-Lênin')
 insert into LoaiSach values ('N006',N'Văn học')


 insert into Sach values ('S001','Tin hoc A','Binh Minh','N001',25000,40,'Thoai Son','KH01','NV01','Ag','1')
 insert into Sach values ('S002','Tin hoc B','Van Van','N001',22000,50,'My Binh','KH02','NV02','OC','2')
 insert into Sach values ('S003','PreTest B','Nguyen Hanh','N003',5500,80,'Thoai Son','KH02','NV03','ST','3')
 insert into Sach values ('S004','Thuat toan','Le Huong','N002',37500,10,'Xeo Trom' ,'KH01','NV04','Ag','4')
 insert into Sach values ('S005','Nhiep anh','Tran Chau','N002',50000,40,'Thoai Son','KH04','NV05','CB','5')
 insert into Sach values ('S006','Thuoc co truyen','Hai Nam','N004',30000,50,'My Binh','KH03','NV06','Agi','6')
 insert into Sach values ('S007','Ky nghe lanh','Cao Tuan','N002',32000,80, 'An Binh','KH01','NV07','OC','1')
 insert into Sach values ('S008','Mon qua giang sinh','O.Henry','N006',100000,10,'My Binh','KH03','NV08','Agi','2')
 insert into Sach values ('S009','Cho doi mot tinh yeu','Thach Bien','N006',150000,10, 'An Binh','KH04','NV01','ST','4')
 insert into Sach values ('S010','Tri tue nhan tao','Tuan Anh','N001',38000,10,'Xeo Trom','KH01','NV04','CB','6')

 insert into NhanVien values ('NV01','Nguyen Mai','Ngoc','Nu','5/21/1975','22 CMT8, Q3','0344237723','Nhan vien','Part time','00','L002')
 insert into NhanVien values ('NV02','Le Van','Trung','Nam','5/26/1985','12 Hai Ba Trung, Q1','094518345','Nhan vien','Part time','00','L002')
 insert into NhanVien values ('NV03','Tran Thao','My','Nu','1/1/1990','44/5 Cao Thang, Q10','0864729028','Nhan vien','Part time','00','L002')
 insert into NhanVien values ('NV04','Nguyen Bich','Chi','Nu','12/20/1978','5/1/2 Le Loi, Q1','039392316','Nhan vien','Part time','00','L002')
 insert into NhanVien values ('NV05','Ha Anh','Dao','Nu','11/16/1991','16 Nguyen Trai, Q11','0997223145','Nhan vien','Part time','00','L002')
 insert into NhanVien values ('NV06','Nguyen Ngo Nhu','Quynh','Nu','09/02/2002','Phu Hoa, Thoai Son','0296444218','Quan li','Full time','00','L001')
 insert into NhanVien values ('NV07','Truong Hoang','Hung','Nam','09/03/2002','Phu Hoa, Thoai Son','0937475767','Quan li','Full time','00','L001')
 insert into NhanVien values ('NV08','Le Minh','Anh','Nam','09/01/2002','Phu Hoa, Thoai Son','0837523678','Quan li','Full time','00','L001')

 insert into Hoadon values (1,'7/15/2015','NV01','0')
 insert into Hoadon values (2,'7/16/2015','NV02','0')
 insert into Hoadon values (3,'7/16/2015','NV02','0')
 insert into Hoadon values (4,'7/16/2015','NV02','0')
 insert into Hoadon values (5,'7/18/2015','NV01','0')
 insert into Hoadon values (6,'7/20/2015','NV03','0')

 insert into CTHD values (1,'S002',1)
 insert into CTHD values (1,'S004',1)
 insert into CTHD values (2,'S004',1)
 insert into CTHD values (3,'S003',2)
 insert into CTHD values (3,'S006',1)
 insert into CTHD values (3,'S010',2)
 insert into CTHD values (4,'S001',3)
 insert into CTHD values (5,'S001',2)
 insert into CTHD values (5,'S002',2)
 insert into CTHD values (5,'S010',1)
 insert into CTHD values (5,'S008',1)
 insert into CTHD values (6,'S009',4)

 insert into KhachHang values ('KH01','ToNy Teo','22 Ha Hoang Ho, Q3','7/13/2022', '0979993332')
 insert into KhachHang values ('KH02','Pham JackSon','so 2 Le Be Na, HCM','12/2/2022', '0979214412')
 insert into KhachHang values ('KH03','Nguyen Vuong Nguyen','123 Thi Nga, Vung Tau','2022', '0979174741')
 insert into KhachHang values ('KH04','Tong Nha Dan','Tran Hung Dao, An Giang','9/6/2022', '0979616276')

 insert into KHO values ('Thoai Son','Phu Loc','Thoai Son, An Giang', '0939291260','Han')
 insert into KHO values ('My Binh','An Phuoc','My Binh, Long Xuyen', '0939676767','Phuc')
 insert into KHO values ('Xeo Trom','Ngoc Nga','Xeo Trom, Long Xuyen', '0979128905','Nha')
 insert into KHO values ('An Binh','Hoang Minh','Thoai Son, Nui Sap', '0967312898','Dan')

 insert into NhaSanXuat values ('Ag','Nguyen Minh Minh','13 Nguyen Hue, Q1', '0939392323')
 insert into NhaSanXuat values ('ST','Vo Nhu Dan','Vo Thi Sau, Cam Ranh', '0923898989')
 insert into NhaSanXuat values ('OC','Tong Gia Bach','Hung Vuong, Q7', '0933762345')
 insert into NhaSanXuat values ('Agi','Ha Nhat Vi','Moc Lan, Q3', '0989001160')
 insert into NhaSanXuat values ('CB','Mai Xuan Huy','44 Le Loi, Ho Con Rua', '0966362757')

 insert into Luong values ('L001','0')
 insert into Luong values ('L002','0')
 


 select *from LoaiSach
 select *from Sach
 select *from NhanVien
 select *from Hoadon
 select *from CTHD
 select *from KhachHang
 select *from KHO
 select *from NhaSanXuat
 select *from LUONG


