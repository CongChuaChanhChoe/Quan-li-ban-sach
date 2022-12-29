CREATE TABLE [dbo].[NhanVien] (
    [MaNV]            CHAR (5)      NOT NULL,
    [HoLot]           NVARCHAR (25) NULL,
    [TenNV]           NVARCHAR (10) NULL,
    [Phai]            NVARCHAR (3)  NULL,
    [NgaySinh]        DATE          NULL,
    [DiaChi]          NVARCHAR (40) NULL,
    [SoDienThoai]     VARCHAR (20)  NULL,
    [ChucVu]          NVARCHAR (20) NULL,
    [ThoiGianLamViec] TIME (0)      NOT NULL,
    PRIMARY KEY CLUSTERED ([MaNV] ASC)
);

