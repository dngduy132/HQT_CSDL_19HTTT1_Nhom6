--T1: Khách hàng xem số lượng sản phẩm có giá > 10000 của doanh nghiệp
--T2: Doanh nghiệp cập nhật giá sản phẩm.
--Khách hàng xem số lượng các sản phẩm có giá > 10000 lần 1 là 21.
--Khách hàng xem số lượng các sản phẩm có giá > 10000 lần 2 là 20 và xem danh sách các sản phẩm.

BEGIN TRAN
	UPDATE SAN_PHAM SET GIA = 1000 WHERE MA_SP = N'SP26049509';
COMMIT TRAN