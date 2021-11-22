--T1: Khách hàng xem số lượng các sản phẩm có số lượng = 10 của doanh nghiệp có mã 'DN83267769'
--T2: Doanh nghiệp thêm sản phẩm có số lượng = 10
--Khách hàng xem số lượng các sản phẩm có số lượng = 10 của doanh nghiệp có mã 'DN83267769' lần 1 có 3 sản phẩm
--Khách hàng xem số lượng các sản phẩm có số lượng = 10 của doanh nghiệp có mã 'DN83267769' lần 2 có 4 sản phẩm, danh sách của các sản phẩm đó


BEGIN TRAN
	INSERT INTO SAN_PHAM values (N'SP00000001', N'Mì chua cay', 15000, 10, N'Vừa chua vừa cay')
	INSERT INTO CHINHANH_SANPHAM VALUES (N'CN97887052', N'SP00000001')
COMMIT TRAN
