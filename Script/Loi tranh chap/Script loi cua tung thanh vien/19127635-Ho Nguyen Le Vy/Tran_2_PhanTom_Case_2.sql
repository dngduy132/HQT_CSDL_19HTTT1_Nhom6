--T1: Doanh nghiệp 'DN71715083' xem số lượng đơn hàng của mình.
--T2: Thêm đơn đặt hàng mới.
--Doanh nghiệp xem số lượng đơn hàng lần 1 là 1
--Doanh nghiệp xem số lượng đơn hàng lần 2 là 2
--Doanh nghiệp 'DN71715083' xem số lượng đơn hàng của mình lần 1
--Doanh nghiệp 'DN71715083' xem số lượng đơn hàng của mình lần 2 và danh sách đơn đặt hàng

BEGIN TRAN
	INSERT INTO DON_DAT_HANG values (N'HD11142021', N'KV69501076', N'DN71715083', N'TX57516577', N'KH30426466', '2021-11-14', N'Chờ lấy hàng', 0, 0, 0, N'Chuyển khoản')
	UPDATE DOANH_NGHIEP SET SL_DON_HANG = SL_DON_HANG + 1 WHERE MADN = N'DN71715083';
COMMIT TRAN