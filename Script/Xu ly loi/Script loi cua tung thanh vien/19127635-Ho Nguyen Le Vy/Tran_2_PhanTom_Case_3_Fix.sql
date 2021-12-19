--T1: Khách hàng xem số lượng sản phẩm có giá > 10000 của doanh nghiệp
--T2: Doanh nghiệp cập nhật giá sản phẩm.

BEGIN TRAN
	UPDATE SAN_PHAM SET GIA = 15000 WHERE MA_SP = N'SP26049509';
COMMIT TRAN