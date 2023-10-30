Create Database QuanLyQuanCafe
Go

Use QuanLyQuanCafe
Go

Create Table FoodTable
(
	id int identity primary key,
	displayname nvarchar(100) not null,
	status nvarchar(100) not null default N'Trống',

)
Go
Create table Account
(
	username nvarchar(100) primary key,
	displayname nvarchar(100) not null,
	password nvarchar(1000) not null default 1,
	Type Int not null default 0
)
Go

Create table Category
(
	id int identity primary key,
	displayname nvarchar(100) not null,
)
Go

Create table Food
(
	id int identity primary key,
	displayname nvarchar(100) not null,
	idCategory int not null,
	price float not null

	foreign key (idCategory) references dbo.Category(id)
)
Go

Create table Bill
(
	id int identity primary key,
	datecheckin Date Not null default getdate(),
	datecheckout Date,
	idTable int not null,
	status int not null default 0,
	discount int not null default 0,
	totalprice float

	foreign key (idTable) references dbo.FoodTable(id)
)
Go

Create table BillInfor
(
	id int identity primary key,
	idBill int not null,
	idFood int not null,
	count int not null default 0,
	totalprize float not null


	foreign key (idBill) references dbo.Bill(id),
	foreign key (idFood) references dbo.Food(id)
)
Go

--tạo ra store procedure trong database vào sử dụng nó trên windowform
Create Proc USP_GetAccountByUserName
@userName nvarchar(100)
as
begin
	Select * From dbo.Account Where username = @userName
end
go


Create proc USP_Login
@userName nvarchar(100), @passWord nvarchar(100)
as
begin
	Select *From dbo.Account Where username = @userName And password = @passWord
end
go




Create proc USP_GetFoodTable
as Select * from dbo.FoodTable
go



Create proc USP_AddBill
@idTable INT
AS
BEGIN
	INSERT dbo.Bill
	(
		datecheckin,
		datecheckout,
		idTable,
		status,
		discount
	)
	VALUES (GETDATE(),
		NULL,
		@idTable,
		0,0
	)
END
GO



Create proc USP_AddBillInfor
@idBill INT, @idFood INT, @count INT, @totalprize FLOAT
AS
BEGIN
	DECLARE @isIdBill INT
	DECLARE @foodCount INT = 1
	SELECT @isIdBill = id FROM dbo.BillInfor WHERE idBill = @idBill AND idFood = @idFood --Kiểm tra xem trong BillInfor tồn tại idBill và chứa idFood hay chưa
	--Nếu có thì update số lượng đồ uống
	IF(@isIdBill>0)
	BEGIN
		DECLARE @newCount INT = @foodCount + @count
		IF(@newCount>0)
			UPDATE dbo.BillInfor SET count = @foodCount + @count WHERE idFood = @idFood--Update số lượng đồ uống đã có trong billinfor
		ELSE
			DELETE dbo.BillInfor WHERE idBill = @idBill AND idFood = @idFood -- Xóa thức ăn trong bill nếu count âm
	END
	--Nếu không thì tạo mới
	ELSE
	BEGIN -- Nếu chưa có idBill trong billInfor thì thêm mới vào
		INSERT dbo.BillInfor
	(
		idBill,
		idFood,
		count,
		totalprize
	)
	VALUES (
		@idBill,
		@idFood,
		@count,
		@totalprize
	)
	END
END
GO



CREATE PROC USP_SwitchTable
@idTable1 INT, @idTable2 INT
AS
BEGIN
	DECLARE @idBill1 INT --khai báo idBill của bàn thứ nhất
	DECLARE @idBill2 INT --khai báo idBill của bàn thứ hai

	DECLARE @isEmpty1 INT = 1 --Cho mặc định là bàn thứ nhất không trống BillInfor
	DECLARE @isEmpty2 INT = 1 --Cho mặc định là bàn thứ hai không trống BillInfor

	SELECT @idBill1 = id FROM dbo.Bill WHERE idTable = @idTable1 AND status =0
	SELECT @idBill2 = id FROM dbo.Bill WHERE idTable = @idTable2 AND status =0

	IF(@idBill1 IS NULL)
	BEGIN
		Insert dbo.Bill
			(datecheckin,
			datecheckout,
			idTable,
			status
			)
		Values (GETDATE(),
		NULL,
		@idTable1,
		0)
		SELECT @idBill1 = MAX(id) FROM dbo.Bill WHERE idTable = @idTable1 AND status = 0
		
		
	END
	SELECT @isEmpty1 = COUNT(*) FROM dbo.BillInfor WHERE idBill = @idBill1 --Nếu có idBill nhưng không có idBillInfor thì không có người
	IF(@idBill2 IS NULL)
	BEGIN
		Insert dbo.Bill
			(datecheckin,
			datecheckout,
			idTable,
			status
			)
		Values (GETDATE(),
		NULL,
		@idTable2,
		0)
		SELECT @idBill2 = MAX(id) FROM dbo.Bill WHERE idTable = @idTable2 AND status = 0
		
	END
	SELECT @isEmpty2 = COUNT(*) FROM dbo.BillInfor WHERE idBill = @idBill2
	
	SELECT id INTO IdBillInforTable FROM dbo.BillInfor WHERE idBill = @idBill2 --Lưu idBillInfor của idBill bàn thứ 2
	UPDATE dbo.BillInfor SET idBill = @idBill2 WHERE idBill = @idBill1 --Chuyển idBill của bàn thứ 1 sang bàn thứ 2
	UPDATE dbo.BillInfor SET idBill = @idBill1 WHERE id IN (SELECT * FROM IdBillInforTable) --Chuyển idBill của bàn thứ 2 sang bàn thứ 1 bằng cách đổi idBill thành bàn 1 khi mà thỏa mãn id của BillInfor bằng với dữ liệu trong bảng IdBillInforTable
	DROP TABLE IdBillInforTable

	--Đổi status của bàn dựa theo việc có hay không Bill có chứa BillInfor  
	IF(@isEmpty1 = 0)
	BEGIN
		UPDATE dbo.FoodTable SET status = N'Trống' WHERE id = @idTable2 -- Đổi từ bàn 1 qua bàn 2 nên bàn 2 sẽ trống
	END
	IF(@isEmpty2 = 0)
	BEGIN
		UPDATE dbo.FoodTable SET status = N'Trống' WHERE id = @idTable1
	END
END
GO


CREATE PROC USP_GetListBillByDate
@dateIn DATE, @dateOut DATE
AS
BEGIN
	SELECT ft.displayname AS [Tên bàn], b.datecheckin AS [Ngày gọi đồ],datecheckout AS [Ngày thanh toán],discount AS [Giảm giá],totalprice AS [Thành tiền]
	FROM dbo.Bill as b, dbo.FoodTable as ft
	WHERE datecheckin >=@dateIn AND datecheckout <= @dateOut AND b.status = 1 AND ft.id = b.idTable
END
GO



CREATE PROC USP_GetPageBillByDate
@dateIn DATE, @dateOut DATE, @page INT
AS
BEGIN
	DECLARE @pageCount INT  = 10
	DECLARE @selectedPage INT = @pageCount * @page
	DECLARE @exceptPage INT = @pageCount * (@page - 1)
	;WITH ShowBill AS (SELECT ft.displayname AS [Tên bàn], b.datecheckin AS [Ngày gọi đồ],datecheckout AS [Ngày thanh toán],discount AS [Giảm giá],totalprice AS [Thành tiền]
	FROM dbo.Bill as b, dbo.FoodTable as ft
	WHERE datecheckin >=@dateIn AND datecheckout <= @dateOut AND b.status = 1 AND ft.id = b.idTable)

	SELECT TOP (@selectedPage) * FROM dbo.Bill
	EXCEPT
	SELECT TOP (@exceptPage) * FROM dbo.Bill
END
GO

CREATE PROC USP_GetNumBill
@dateIn DATE, @dateOut DATE
AS
BEGIN
	SELECT COUNT(*)
	FROM dbo.Bill as b, dbo.FoodTable as ft
	WHERE datecheckin >=@dateIn AND datecheckout <= @dateOut AND b.status = 1 AND ft.id = b.idTable
END
GO


CREATE PROC USP_GetListBillByDateForReport
@dateIn DATE, @dateOut DATE
AS
BEGIN
	SELECT ft.displayname , b.datecheckin,datecheckout ,discount ,totalprice
	FROM dbo.Bill as b, dbo.FoodTable as ft
	WHERE datecheckin >=@dateIn AND datecheckout <= @dateOut AND b.status = 1 AND ft.id = b.idTable
END
GO




-----Trigger---


--Trigger sau khi update hoặc insert BillInfor
CREATE TRIGGER After_EditBillInfor
ON dbo.BillInfor FOR INSERT, UPDATE
AS
BEGIN
	DECLARE @idBill INT
	SELECT @idBill = idBill FROM inserted --Lấy idBill vừa thêm 
	DECLARE @idTable INT
	SELECT @idTable = idTable FROM dbo.Bill WHERE id = @idBill AND status = 0-- Lấy idTable nằm trong Bill theo idBill vừa add
	DECLARE @countBillInfor INT
	SELECT @countBillInfor = COUNT(*) FROM dbo.BillInfor WHERE idBill = @idBill --Lấy số lượng IdbillInfor theo idBill
	--Chạy trigger--
	IF(@countBillInfor > 0)
	BEGIN
		 UPDATE dbo.FoodTable SET status =N'Có người' WHERE id = @idTable
	END
	ELSE
		UPDATE dbo.FoodTable SET status =N'Trống' WHERE id = @idTable
END
GO

--Trigger sau khi Update Bill
CREATE TRIGGER After_UpdateBill
ON dbo.Bill FOR UPDATE
AS
BEGIN
	DECLARE @idBill INT
	SELECT @idBill =id FROM inserted -- Lấy ra idBill 
	DECLARE @idTable INT
	SELECT @idTable = idTable FROM dbo.Bill WHERE id = @idBill -- Lấy idTable từ trong Bill theo idBill
	DECLARE @count INT = 0
	SELECT @count = COUNT(*) FROM dbo.Bill WHERE idTable = @idTable AND status = 0 -- Kiểm tra xem có bill nào chưa thanh toán ở bàn này hay không

	IF(@count=0)
		UPDATE dbo.FoodTable SET status = N'Trống' WHERE id = @idTable
END
GO
	
---Trigger sau khi xóa billinfor 

CREATE TRIGGER After_DeleteBillInfor
ON dbo.BillInfor FOR DELETE
AS
BEGIN
	DECLARE @idBillInfor INT
	DECLARE @idBill INT
	SELECT @idBillInfor = id , @idBill = deleted.idBill FROM deleted
	DECLARE @idTable INT
	SELECT @idTable = idTable FROM dbo.Bill WHERE id = @idBill

	DECLARE @count INT
	SELECT @count = COUNT(*) FROM dbo.BillInfor AS bi, dbo.Bill AS b WHERE b.id = bi.idBill AND b.id =  @idBill  AND b.status = 0

	IF(@count = 0)
		UPDATE dbo.FoodTable SET status = N'Trống' WHERE id = @idTable
END
GO


--Phần truy vấn
Select *from dbo.Category
Select *from dbo.Food
Select *from dbo.FoodTable
Select *from dbo.Bill
Select *from dbo.BillInfor
Select *from dbo.Account


SELECT @@SERVERNAME 
---Instert dữ liệu bảng FoodTable---
Declare @i INT = 0

While @i<=10
Begin
	Insert dbo.FoodTable (displayname)Values (N'Bàn ' + CAST(@i As nvarchar(100)))
	Set @i = @i + 1
End

---Insert dữ liệu bảng Category---
Insert dbo.Category (displayname)Values (N'Cafe Việt Nam')
Insert dbo.Category (displayname)Values (N'Cafe Máy')
Insert dbo.Category (displayname)Values (N'Cafe Đá Xay')
Insert dbo.Category (displayname)Values (N'Cold Brew')
Insert dbo.Category (displayname)Values (N'Trà Trái Cây')
Insert dbo.Category (displayname)Values (N'Macchiato')
Insert dbo.Category (displayname)Values (N'Thức Uống Trái Cây')
Insert dbo.Category (displayname)Values (N'Match-Socola')


---Insert dữ liệu bảng Food---
Insert dbo.Food(displayname,idCategory,price)Values (N'Cafe Đen',1,35000)
Insert dbo.Food(displayname,idCategory,price)Values (N'Latte',2,45000)
Insert dbo.Food(displayname,idCategory,price)Values (N'Cold Brew sữa tươi',4,45000)
Insert dbo.Food(displayname,idCategory,price)Values (N'Trà Đào Cam Sả',5,35000)
Insert dbo.Food(displayname,idCategory,price)Values (N'Trà Đen Macchiato',6,50000)
Insert dbo.Food(displayname,idCategory,price)Values (N'Cafe Đá Xay',3,59000)
Insert dbo.Food(displayname,idCategory,price)Values (N' Sinh Tố Việt Quất',7,55000)
Insert dbo.Food(displayname,idCategory,price)Values (N'SôCôLA',8,65000)

Insert dbo.Account(username,displayname,type)VALUES (N'admin',N'admin',0)