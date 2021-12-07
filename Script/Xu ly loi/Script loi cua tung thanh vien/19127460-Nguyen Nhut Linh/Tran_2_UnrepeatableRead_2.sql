--T1 : Khách hàng tìm xem có tồn tại doanh nghiệp có tên Trupebistor Direct ở Quận Tân Bình
--và truy xuất thông tin doanh nghiệp 
--T2 : Quản trị đổi quận của doanh nghiệp 

BEGIN TRAN
	UPDATE dbo.DOANH_NGHIEP
	SET QUAN = N'Quận 5'
	WHERE TEN_DN = 'Trupebistor Direct' AND QUAN = N'Quận Tân Bình'
COMMIT TRAN

