 SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[sp_GetAVGPriceBrandTypeNameByDate]
AS
BEGIN 
 -- K�sz�tsen egy lek�r�st, ami elhozza az �sszes jelenleg forgalmazott aut�m�rk�t, 
 -- valamint  t�pusainak 2019.03.01.-ei �tlag�r�t 
	select CB.Name as 'M�rka', CT.Name as 'T�pus',AVG(CP.Price) as '�tlag�r' from CarType as CT
			join CarPrice as CP on CP.CartypeId = CT.CarBrandID
			join CarBrandStatus as CBS on CBS.Status_Id = CT.Status_Id
			join CarBrand as CB on CB.Id = CT.CarBrandID
		Where CBS.Name= 'Forgalmazott' and CP.FromDate = '2019.03.01'
			Group By  CB.Name, CT.Name
END;