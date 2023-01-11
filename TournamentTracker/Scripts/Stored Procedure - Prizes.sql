-- =============================================
-- Author:		<Bjørnar, Borge>
-- Create date: <11.01.2023>
-- Description:	<Stored procedure for inserting prizes>
-- =============================================
CREATE PROCEDURE dbo.spPrizes_Insert
	-- Add the parameters for the stored procedure here
	@PlaceNumber int,
	@PlaceName nvarchar(50),
	@PrizeAmount money,
	@PrizePercentage float,
	@id int = 0 output -- Id do not have to pass a value in, if not the value will be 0
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	insert into dbo.Prizes (PlaceNumber, PlaceName, PrizeAmount, PrizePercentage)
	values (@PlaceNumber, @PlaceName, @PrizeAmount, @PrizePercentage);

	select @id = SCOPE_IDENTITY(); -- In the current scope, in our case this stored procedure 
END
GO
