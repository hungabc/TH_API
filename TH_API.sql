CREATE TABLE NHANVIEN(
	maNV varchar(30) PRIMARY KEY,
	TenNV nvarchar(50) NOT NULL,
	GioiTinh nvarchar(30) default N'Nam',
	NgaySinh date,
	email varchar(30),
	SDT char(30),
	--ChiTiet nvarchar(100)
)
create proc getallnv as begin select*from NHANVIEN end
create proc getbyid @id varchar(30) as begin select *from NhanVien where maNV=@id end
create proc createnv @maNV varchar(30),
	@TenNV nvarchar(50),
	@GioiTinh nvarchar(30),
	@NgaySinh date,
	@email varchar(30),
	@SDT char(30)
	as begin insert into NhanVien values( @maNV,@TenNV,
	@GioiTinh,
	@NgaySinh ,
	@email ,
	@SDT)
	end
	create proc editnhanvien @maNV varchar(30),
	@TenNV nvarchar(50),
	@GioiTinh nvarchar(30),
	@NgaySinh date,
	@email varchar(30),
	@SDT char(30)
	as begin 
	update NhanVien set TenNV=@TenNV,NgaySinh=@NgaySinh,GioiTinh=@GioiTinh,email=@email,SDT=@sdt where MaNV=@maNV
	end
	create proc deletenv @maNV varchar(30) as begin delete from nhanvien where manv=@maNV end