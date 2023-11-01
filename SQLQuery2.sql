USE [NImport]
GO

--|--------------------------------------------------------------------------------
--| uspVENDEDORInsert - Insert Procedure Script for VENDEDOR
--|--------------------------------------------------------------------------------
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id (N'[dbo].[uspVENDEDORInsert]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[uspVENDEDORInsert]
GO

CREATE PROCEDURE uspVENDEDORInsert
(
	@Cod_Ven varchar(5),
	@VENDEDOR varchar(70) = NULL,
	@TELEFONO varchar(14) = NULL,
	@TELEF2 varchar(14) = NULL,
	@FAX varchar(14) = NULL,
	@RUC varchar(12) = NULL,
	@DIRECCION varchar(50) = NULL,
	@DISTRITO varchar(30) = NULL,
	@TRIAL858 char(1) = NULL
)
AS
	SET NOCOUNT ON

	INSERT INTO VENDEDOR
	(
		Cod_Ven,
		VENDEDOR,
		TELEFONO,
		TELEF2,
		FAX,
		RUC,
		DIRECCION,
		DISTRITO,
		TRIAL858
	)
	VALUES
	(
		@Cod_Ven,
		@VENDEDOR,
		@TELEFONO,
		@TELEF2,
		@FAX,
		@RUC,
		@DIRECCION,
		@DISTRITO,
		@TRIAL858
	)

	RETURN @@Error
GO

--|--------------------------------------------------------------------------------
--| uspVENDEDORUpdateById - Update Procedure Script for VENDEDOR
--|--------------------------------------------------------------------------------
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id (N'[dbo].[uspVENDEDORUpdateById]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[uspVENDEDORUpdateById]
GO

CREATE PROCEDURE uspVENDEDORUpdateById
(
	@Cod_Ven varchar(5),
	@VENDEDOR varchar(70) = NULL,
	@TELEFONO varchar(14) = NULL,
	@TELEF2 varchar(14) = NULL,
	@FAX varchar(14) = NULL,
	@RUC varchar(12) = NULL,
	@DIRECCION varchar(50) = NULL,
	@DISTRITO varchar(30) = NULL,
	@TRIAL858 char(1) = NULL
)
AS
	SET NOCOUNT ON
	
	UPDATE VENDEDOR
	SET
		Cod_Ven = @Cod_Ven,
		VENDEDOR = @VENDEDOR,
		TELEFONO = @TELEFONO,
		TELEF2 = @TELEF2,
		FAX = @FAX,
		RUC = @RUC,
		DIRECCION = @DIRECCION,
		DISTRITO = @DISTRITO,
		TRIAL858 = @TRIAL858
	WHERE 
		Cod_Ven = @Cod_Ven

	RETURN @@Error
GO

--|--------------------------------------------------------------------------------
--| [uspVENDEDORDeleteById] - Update Procedure Script for VENDEDOR
--|--------------------------------------------------------------------------------
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id (N'[dbo].[uspVENDEDORDeleteById]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[uspVENDEDORDeleteById]
GO

CREATE PROCEDURE uspVENDEDORDeleteById
(
	@Cod_Ven varchar(5)
)
AS
	SET NOCOUNT ON

	DELETE 
	FROM   VENDEDOR
	WHERE  
		Cod_Ven = @Cod_Ven

	RETURN @@Error
GO

--|--------------------------------------------------------------------------------
--| uspVENDEDORList - Update Procedure Script for VENDEDOR
--|--------------------------------------------------------------------------------
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id (N'[dbo].[uspVENDEDORList]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[uspVENDEDORList]
GO

CREATE PROCEDURE uspVENDEDORList
(
	@Cod_Ven varchar(5),
	@nombreVendedor varchar(70) =''
)
AS
	SET NOCOUNT ON

	SELECT
			Cod_Ven,
		VENDEDOR,
		TELEFONO,
		TELEF2,
		FAX,
		RUC,
		DIRECCION,
		DISTRITO,
		TRIAL858
	FROM   VENDEDOR
	WHERE  
		(Cod_Ven like @Cod_Ven +'%')
		and (@nombreVendedor='' or VENDEDOR like @nombreVendedor+'%')

	RETURN @@Error
GO

