 SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[sp_GetAVGPriceBrandTypeNameByDate]
AS
BEGIN 
 -- Készítsen egy lekérést, ami elhozza az összes jelenleg forgalmazott autómárkát, 
 -- valamint  típusainak 2019.03.01.-ei átlagárát 
	select CB.Name as 'Márka', CT.Name as 'Típus',AVG(CP.Price) as 'ÁtlagÁr' from CarType as CT
			join CarPrice as CP on CP.CartypeId = CT.CarBrandID
			join CarBrandStatus as CBS on CBS.Status_Id = CT.Status_Id
			join CarBrand as CB on CB.Id = CT.CarBrandID
		Where CBS.Name= 'Forgalmazott' and CP.FromDate = '2019.03.01'
			Group By  CB.Name, CT.Name
END;