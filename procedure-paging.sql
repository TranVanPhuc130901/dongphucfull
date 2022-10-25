USE [dongphuckhanhlinh]
GO

/****** Object:  StoredProcedure [dbo].[SanPham_GetDataPaging]    Script Date: 10/4/2022 9:52:28 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SanPham_GetDataPaging]
    @pageIndex int,
    @pageSize int,
    @whereClause nvarchar(300) ,
    @orderBy nvarchar(150)
AS 
    BEGIN
        SET NOCOUNT ON
        DECLARE @OrderClause AS NVARCHAR(200)
        IF LEN(@orderBy) > 0 SET @OrderClause = ' ORDER BY ' + @orderBy
		ELSE SET @OrderClause = ' ORDER BY dbo.[SanPham].MaSP DESC'
        
        DECLARE @topagging AS NVARCHAR(2000)
        SET @topagging = ( @pageIndex - 1 ) * @pageSize + 1
        DECLARE @frompagging AS NVARCHAR(2000)
        SET @frompagging = @pageIndex * @pageSize
			
     --== Table 0: Lấy danh sách kết quả theo điều kiện truyền vào ==--
        DECLARE @sql AS NVARCHAR(4000)
        SET @sql = ' WITH BillRecords AS (SELECT ROW_NUMBER() OVER (' + @OrderClause + ') AS RowIndex, [SanPham].* FROM [dbo].[SanPham] '
        IF LEN(@whereClause) > 0 SET @sql = @sql + ' WHERE ' + @whereClause
        SET @sql = @sql + ' ) SELECT * FROM BillRecords WHERE ( RowIndex BETWEEN ' + @topagging + ' AND ' + @frompagging + ' )'
     
		EXEC sp_executesql @sql
		
     --== Table 1: Đếm tổng kết quả để tính có bao nhiêu trang ==--
        SET @sql = ' SELECT COUNT(*) AS TotalRows FROM [dbo].[SanPham] '
        IF LEN(@whereClause) > 0 SET @sql = @sql + ' WHERE ' + @whereClause  
        EXEC sp_executesql @sql       
    END


GO


