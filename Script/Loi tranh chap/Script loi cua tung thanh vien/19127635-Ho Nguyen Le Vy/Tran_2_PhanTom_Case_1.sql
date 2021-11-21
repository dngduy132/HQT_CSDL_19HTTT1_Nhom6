--T1: Khách hàng xem số lượng các sản phẩm có số lượng = 10.
--T2: Doanh nghiệp thêm sản phẩm.
--Khách hàng xem số lượng các sản phẩm có số lượng = 10 lần 1 có 3 sản phẩm
--Khách hàng xem số lượng các sản phẩm có số lượng = 10 lần 2 có 4 sản phẩm

BEGIN TRAN
	INSERT INTO SAN_PHAM values (N'SP00000001', N'Mì chua cay', 15000, 10, N'Vừa chua vừa cay')
COMMIT TRAN
