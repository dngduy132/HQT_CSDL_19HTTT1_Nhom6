--T1 : Khách hàng tìm xem có tồn tại doanh nghiệp có tên Trupebistor Direct ở Quận Tân Bình
--và truy xuất thông tin doanh nghiệp 
--T2 : Quản trị đổi quận của doanh nghiệp 

BEGIN TRAN
	SELECT COUNT(MADN)
	FROM dbo.DOANH_NGHIEP
	WHERE TEN_DN = 'Trupebistor Direct' AND QUAN = N'Quận Tân Bình'
	WAITFOR DELAY '00:00:05'
	SELECT * 
	FROM dbo.DOANH_NGHIEP
	WHERE TEN_DN = 'Trupebistor Direct' AND QUAN = N'Quận Tân Bình'
COMMIT TRAN

