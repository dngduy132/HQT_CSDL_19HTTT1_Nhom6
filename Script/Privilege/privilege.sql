--Phân quyền khách hàng: Hồ Nguyễn Lê Vy
exec sp_addrole 'KhachHangRole'
exec sp_addLogin 'KhachHangLogin1','KhachHangLogin1'
Create User KH1 For Login KhachHangLogin1
exec sp_addrolemember 'KhachHangRole','KH1'

grant select on DOANH_NGHIEP(MADN, TEN_DN, THANH_PHO, DIA_CHI, QUAN) to KhachHangRole
grant select on SAN_PHAM(TEN_SP, GIA, SO_LUONG, MO_TA) to KhachHangRole
grant select on DON_DAT_HANG to KhachHangRole

-- Phân quyền đối tác, nhân viên: Nguyễn Nhựt Linh
--Đối tác
exec sp_addrole 'DoiTacRole'
exec sp_addLogin 'DoiTacLogin1', 'DoiTacLogin1'
create user DT1 for login DoiTacLogin1
exec sp_addrolemember 'DoiTacRole', 'DT1'

grant select, insert,update,delete on CHI_NHANH to DoiTacRole
grant select, insert,update,delete on CHINHANH_SANPHAM to DoiTacRole
grant select on Hop_Dong to DoiTacRole
grant select, insert,update,delete on San_pham to DoiTacRole
grant select, update ON DON_DAT_HANG(TINH_TRANG) to DoiTacRole

--Nhân viên 
exec sp_addrole 'NhanVienRole'
exec sp_addLogin 'NhanVienLogin1', 'NhanVienLogin1'
create user NV1 for login NhanVienLogin1
exec sp_addrolemember 'NhanVienRole', 'NV1'

grant select on HOP_DONG to NhanVienRole

-- Phân quyền tài xế, quản trị: Đặng Nguyễn Duy
--Tài xế
exec sp_addrole 'TaiXeRole'
exec sp_addLogin 'TaiXeLogin1', 'TaiXeLogin1'
create user TX1 for login TaiXeLogin1
exec sp_addrolemember 'TaiXeRole', 'TX1'

grant select on DON_DAT_HANG to TaiXeRole 
grant update on DON_DAT_HANG(TINH_TRANG) to TaiXeRole 

--Quản trị
exec sp_addLogin 'QuanTriLogin1', 'QuanTriLogin1'
create user QT1 for login QuanTriLogin1

exec sp_addsrvrolemember 'QuanTriLogin1', 'securityadmin'
exec sp_addrolemember 'db_accessadmin', 'QT1'
exec sp_addrolemember 'db_securityadmin', 'QT1'

exec sp_addrole 'QuanTriRole'
exec sp_addrolemember 'QuanTriRole', 'QT1'

grant update on DOANH_NGHIEP to QuanTriRole
grant update on KHACH_HANG to QuanTriRole
grant update on TAI_XE to QuanTriRole