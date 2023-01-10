create database SINDER
USe SINDER 
create table NGUOIDUNG
(
	Id int PRIMARY KEY identity(1, 1),
	TaiKhoan varchar(20) COLLATE Latin1_General_CS_AS, 
	MatKhau varchar(20) COLLATE Latin1_General_CS_As,
	TenNguoiDung nvarchar(200),
	NamSinh int,
	Truong nvarchar(200),
	GioiTinh nvarchar(5),
	NamHoc int,
	ChieuCao int,
	CanNang int,
	Bio nvarchar(max)
);

create table THICH
(
	Id int PRIMARY KEY identity(1000000, 1),
	TaiKhoan int FOREIGN KEY (TaiKhoan) REFERENCES NGUOIDUNG(Id),
	NguoiBanThich int FOREIGN KEY (NguoiBanThich) REFERENCES NGUOIDUNG(Id),
);

create table TINNHAN
(
	Id int PRIMARY KEY identity(0, 1),
	NguoiGoi int FOREIGN KEY (NguoiGoi) REFERENCES NGUOIDUNG(Id),
	NguoiNhan int FOREIGN KEY (NguoiNhan) REFERENCES NGUOIDUNG(Id),
	NoiDung nvarchar(max) default '',
	NhanDan int default -1,
	DiaChiAnh varchar(max) default '',
	DiaChiFile varchar(max) default '',
	DaDoc int default 0
)

insert into NGUOIDUNG values ('phung3521','0', N'Đăng Phụng', 2002, N'UIT', N'Nam', 3, 168, 85, N'Không có Bio') 

insert into NGUOIDUNG values ('trankhoa02','0', N'Đăng Khoa', 2002, N'UIT', N'Nam', 3, 165, 65, N'Nhà anh quận 1 mặt tiền :))') 

insert into NGUOIDUNG values ('duyngoc05','0', N'Duy Ngọc', 2000, N'UIT', N'Nam', 5, 172, 55, N'BadBoiz Xi Tình') 

insert into NGUOIDUNG values ('nhatkhadn','0', N'Nhật Kha', 1999, N'Bách Khoa', N'Nam', 6, 178, 65, N'Hotboy Đà Nẵng') 

insert into NGUOIDUNG values ('hoangtuantg','0', N'Hoàng Tuấn', 2003, N'Khoa học tự nhiên', N'Nam', 2, 174, 67, N'Điềm tĩnh trong mọi chuyện') 

insert into NGUOIDUNG values ('lquangq4','0', N'Lâm Quang', 2004, N'Văn Lang', N'Nam', 1, 173, 57, N'Sống vì đam mê') 

insert into NGUOIDUNG values ('ducphuc55','0', N'Đức Phúc', 1995, N'Văn Lang', N'Nam', 2, 178, 62, N'Ta còn yêu nhau') 

insert into NGUOIDUNG values ('isaac','0', N'Isaac', 1988, N'Khoa học tự nhiên', N'Nam', 10, 188, 85, N'Đẹp zai có gì sai') 

insert into NGUOIDUNG values ('mtp01','0', N'Sơn Tùng MTP', 1994, N'MTP Entertainment', N'Nam', 10, 170, 68, N'Sky ơi Say oh yeah!') 

insert into NGUOIDUNG values ('mono02','0', N'Mono', 2000, N'Trường đời', N'Nam', 5, 173, 57, N'Ú òa') 

insert into NGUOIDUNG values ('duonglamdn','0', N'Dương Lâm Đồng Nai', 1989, N'Xây dựng gia đình', N'Nam', 13, 171, 75, N'Sao hay ga dẻ') 

insert into NGUOIDUNG values ('kaytran2','0', N'Kay Trần', 1995, N'MTP Entertainment', N'Nam', 7, 177, 69, N'Tết đến xuân về em thích được anh lì xì không :D') 

insert into NGUOIDUNG values ('villacon','0', N'Đạt Villa', 1993, N'Hutech', N'Nam', 6, 178, 85, N'Donate anh 400 củ') 

insert into NGUOIDUNG values ('trucnhan22','0', N'Trúc Nhân', 1991, N'Bách Khoa', N'Nam', 2, 168, 65, N'Có không giữ mất đừng tìm') 

insert into NGUOIDUNG values ('jackbentre','0', N'Jack', 1997, N'Hutech', N'Nam', 7, 168, 55, N'Tháng anh cho em 5 củ') 

insert into NGUOIDUNG values ('haitu02','0', N'Hải Tú', 2000, N'MTP Entertainment', N'Nữ', 5, 168, 45, N'Người không được iu mới là người thứ 3') 

insert into NGUOIDUNG values ('hienho33','0', N'Hiền Hồ', 1999, N'Khoa học tự nhiên', N'Nữ', 3, 163, 47, N'Anh có G63 không') 

insert into NGUOIDUNG values ('toctien33','0', N'Tóc Tiên', 1994, N'UIT', N'Nữ', 4, 171, 55, N'90-60-90') 

insert into NGUOIDUNG values ('linda12','0', N'Linda', 1998, N'Bách Khoa', N'Nữ', 7, 166, 55, N'Cíu chị em ơi') 

insert into NGUOIDUNG values ('vohalinh22','0', N'Võ Hà Linh', 2003, N'UIT', N'Nữ', 2, 178, 55, N'An nhiên tự tại') 

insert into NGUOIDUNG values ('dongnhi29','0', N'Đông Nhi', 1990, N'Bách Khoa', N'Nữ', 13, 167, 49, N'Tuyển người yêu biết đàn hát') 

insert into NGUOIDUNG values ('tlinh23','0', N'TLinh', 1999, N'Văn Lang', N'Nữ', 5, 166, 45, N'Vì em là châu báu') 

insert into NGUOIDUNG values ('minzy42','0', N'Hòa Minzy', 2001, N'Văn Lang', N'Nữ', 4, 158, 39, N'Cháy hết mình với ca hát') 

insert into NGUOIDUNG values ('hariwon2','0', N'Hari Won', 1993, N'Hutech', N'Nữ', 8, 168, 58, N'Ngày xưa em thích lò cò

Ngày nay em thích tò mò về anh') 

insert into NGUOIDUNG values ('meemee00','0', N'Ameee', 2004, N'Hutech', N'Nữ', 1, 163, 43, N'Vì em là em bé') 

insert into NGUOIDUNG values ('vct214','0', N'Vũ Cát Tường', 1995, N'UIT', N'Nữ', 7, 159, 42, N'If.....') 

insert into NGUOIDUNG values ('chibi124','0', N'Hoàng Yến Chibi', 2000, N'Bách Khoa', N'Nữ', 5, 166, 49, N'Mùa thu thì có lá vàng, mùa đông se lạnh, mùa này yêu anh~~') 

insert into NGUOIDUNG values ('thuychi4u','0', N'Thùy Chi', 2002, N'Văn Lang', N'Nữ', 3, 168, 45, N'Dường như nắng đã làm má em thêm hồng') 

insert into NGUOIDUNG values ('bphuong24','0', N'Bích Phương', 2003, N'Hutech', N'Nữ', 2, 164, 44, N'Để em từ chối anh nhẹ nhàng thôi') 

insert into NGUOIDUNG values ('hduyen3','0', N'Hoàng Duyên', 1990, N'Khoa học tự nhiên', N'Nữ', 13, 168, 55, N' Anh ơi, gió lạnh đang về. Bao nhiêu lớp áo đâu bằng love anh') 

Go
CREATE FUNCTION [dbo].[fuConvertToUnsign1] ( @strInput NVARCHAR(4000) ) 
RETURNS NVARCHAR(4000) 
AS 
BEGIN 
IF @strInput IS NULL 
RETURN @strInput 
IF @strInput = '' 
RETURN @strInput 
DECLARE @RT NVARCHAR(4000) 
DECLARE @SIGN_CHARS NCHAR(136) 
DECLARE @UNSIGN_CHARS NCHAR (136) 
SET @SIGN_CHARS = N'ăâđêôơưàảãạáằẳẵặắầẩẫậấèẻẽẹéềểễệế ìỉĩịíòỏõọóồổỗộốờởỡợớùủũụúừửữựứỳỷỹỵý ĂÂĐÊÔƠƯÀẢÃẠÁẰẲẴẶẮẦẨẪẬẤÈẺẼẸÉỀỂỄỆẾÌỈĨỊÍ ÒỎÕỌÓỒỔỖỘỐỜỞỠỢỚÙỦŨỤÚỪỬỮỰỨỲỶỸỴÝ' +NCHAR(272)+ NCHAR(208) 
SET @UNSIGN_CHARS = N'aadeoouaaaaaaaaaaaaaaaeeeeeeeeee iiiiiooooooooooooooouuuuuuuuuuyyyyy AADEOOUAAAAAAAAAAAAAAAEEEEEEEEEEIIIII OOOOOOOOOOOOOOOUUUUUUUUUUYYYYYDD' 
DECLARE @COUNTER int 
DECLARE @COUNTER1 int 
SET @COUNTER = 1 
WHILE (@COUNTER <=LEN(@strInput)) 
BEGIN 
SET @COUNTER1 = 1 
WHILE (@COUNTER1 <=LEN(@SIGN_CHARS)+1) 
BEGIN 
IF UNICODE(SUBSTRING(@SIGN_CHARS, @COUNTER1,1)) = UNICODE(SUBSTRING(@strInput,@COUNTER ,1) ) 
BEGIN 
IF @COUNTER=1 
SET @strInput = SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)-1) 
ELSE 
SET @strInput = SUBSTRING(@strInput, 1, @COUNTER-1) +SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)- @COUNTER) 
BREAK 
END 
SET @COUNTER1 = @COUNTER1 +1 
END 
SET @COUNTER = @COUNTER +1 
END 
SET @strInput = replace(@strInput,' ','-') 
RETURN @strInput 
END

Go
CREATE PROC Login
@username nvarchar(20), @pass varchar(20)
as 
begin
select * from NGUOIDUNG where TaiKhoan=@username and MatKhau=@pass
end

Go
create PROC AddNewUser
@taikhoan varchar(20), @pass varchar(20), @TenNguoiDung nvarchar(200),@NamSinh int,@Truong nvarchar(200),@GioiTinh nvarchar(5),@NamHoc int,@ChieuCao int,@CanNang int
as 
begin
insert into NGUOIDUNG values(@taikhoan, @pass, @TenNguoiDung, @NamSinh, @Truong, @GioiTinh, @NamHoc, @ChieuCao, @CanNang, '')
end 

Go
create PROC UpdateUser
 @id int, @TenNguoiDung nvarchar(200),@NamSinh int,@Truong nvarchar(200),@GioiTinh nvarchar(5),@NamHoc int,@ChieuCao int,@CanNang int, @bio nvarchar(max)
as 
begin
update NGUOIDUNG set TenNguoiDung = @TenNguoiDung, NamSinh = @NamSinh, Truong = @Truong, GioiTinh = @GioiTinh, NamHoc = @NamHoc, ChieuCao = @ChieuCao, CanNang = @CanNang, Bio = @bio
where id = @id
end 

Go
CREATE PROC UpdatePass
@id int, @pass varchar(20)
as
begin
update NGUOIDUNG set MatKhau = @pass where Id= @id
end

Go
CREATE PROC AddYeuThich
@tk int, @nguoibanthich int
as 
begin
insert into THICH values (@tk, @nguoibanthich)
end

Go
CREATE PROC RemoveYeuThich
@tk int, @nguoibanthich int
as 
begin
DELETE FROM THICH WHERE TaiKhoan=@tk and NGuoiBanThich=@nguoibanthich;
end

Go
CREATE PROC AddNoiDung
@nguoigui int, @noidung nvarchar(max), @nguoinhan int
as 
begin
insert into TINNHAN values (@nguoigui, @nguoinhan, @noidung, -1, '','', 0)
end

Go
CREATE PROC AddNhanDan
@nguoigui int, @nhandan int, @nguoinhan int
as 
begin
insert into TINNHAN values (@nguoigui, @nguoinhan, '', @nhandan, '', '', 0)
end

Go
CREATE PROC AddAnh
@nguoigui int, @anh varchar(max), @nguoinhan int
as 
begin
insert into TINNHAN values (@nguoigui, @nguoinhan, '', -1, @anh, '', 0)
end

Go
CREATE PROC AddFile
@nguoigui int, @file varchar(max), @nguoinhan int
as 
begin
insert into TINNHAN values (@nguoigui, @nguoinhan, '', -1, '', @file, 0)
end


select * from TINNHAN where (NguoiGoi = 17  and NguoiNhan = 1) or (NguoiGoi = 1 and NguoiNhan = 17)