--T1: Nhân viên 1 cập nhật thông tin người đại diện trong bảng doanh nghiệp trước 
--rồi cập nhật bảng hợp đồng sau  
--T2: Nhân viên 2 cập nhật thông tin người đại diện trong bảng hợp đồng trước 
--rồi cập nhật bảng doanh nghiệp sau 

BEGIN TRAN
	UPDATE dbo.HOP_DONG
	SET NGUOI_DAI_DIEN = N'Nguyễn Văn A' 
	WHERE MADN = 'DN61092796 '
	
	WAITFOR	DELAY '00:00:05'

	UPDATE dbo.DOANH_NGHIEP 
	SET NGUOI_DAI_DIEN = N'Nguyễn Văn A' 
	WHERE MADN = 'DN61092796 '
COMMIT TRAN