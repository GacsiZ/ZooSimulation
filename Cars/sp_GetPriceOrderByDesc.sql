 SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[sp_GetPriceOrderByDesc]
AS
BEGIN 
	 --Készítsen egy lekérést ami elhozza az összes jelenleg forgalmazott autótípust és jelenlegi  listaárát, 
	 --legutolsó árváltozás dátuma alapján csökkenő sorrendbe rendezve.

	 select CT.Name, CP.Price, CP.FromDate, CBS.Name from CarType as CT
			join CarPrice as CP on CP.CartypeId = CT.CarBrandID
			join CarBrandStatus as CBS on CBS.Status_Id = CT.Status_Id
		Where CBS.Name= 'Forgalmazott'
			Order by CP.FromDate desc
END;