--T1: Doanh nghiệp xem số lượng đơn hàng.
--T2: Thêm đơn đặt hàng mới.
--Doanh nghiệp xem số lượng đơn hàng lần 1 là 40
--Doanh nghiệp xem số lượng đơn hàng lần 2 là 41

BEGIN TRAN
	INSERT INTO DON_DAT_HANG values (N'HD11142021', N'KV69501076', N'DN61092796', N'TX11736641', N'KH30426466', '2021-11-14', N'Chờ lấy hàng', 0, 0, 0, N'Chuyển khoản')
	UPDATE DOANH_NGHIEP SET SL_DON_HANG = SL_DON_HANG + 1 WHERE MADN = N'DN61092796';
COMMIT TRAN