

<div class="alert alert-danger">
    <h1>@ViewData["Title"]</h1>
    <hr />
    <p> Ma sinh vien:2310900014</p>
    <p>Ho va ten: nguyen linh chi</p>
    <p>Email:nguyenlinhchi022@gmail.com</p>
    <p>dien thoai:<a href="tel:0366084921">0366084921</a></p>
    <p>lop:K23CNT2</p>


</div>
Scaffold-DbContext "Server=FENXIHALIN-2412\SQLEXPRESS;Database=NguyenHuongTra_2310900106;Trusted_Connection=True;MultipleActiveResultSets=True;TrustServerCertificate=True" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models

Scaffold-DbContext "Server=FENXIHALIN-2412\SQLEXPRESS;Database=;;uid=ngyntra;pwd=1632171; MultipleActiveResultSets=True; TrustServerCertificate=True " Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models

CREATE DATABASE NguyenHuongTra_2310900106;
GO

USE NguyenHuongTra_2310900106;
GO
CREATE TABLE NHTEmployee (
    NHTEmpId INT PRIMARY KEY,
    NHTEmpName NVARCHAR(100),
    NHTEmpLevel NVARCHAR(50),
    NHTEmpStartDate DATE,
    NHTEmpStatus BIT  -- TRUE (1): Show, FALSE (0): Hide
);
INSERT INTO NHTEmployee (NHTEmpId, NHTEmpName, NHTEmpLevel, NHTEmpStartDate, NHTEmpStatus)
VALUES
(1, N'Nguyễn Hương Trà', N'Mid', '2023-08-01', 1),
(2, N'Trần Văn B', N'Junior', '2024-01-15', 0),
(3, N'Lê Thị C', N'Senior ','2022-09-10', 1);
