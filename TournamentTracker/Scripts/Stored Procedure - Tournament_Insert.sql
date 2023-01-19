-- =============================================
-- Author:		<Bjørnar Borge>
-- Create date: <18.01.2022>
-- Description:	<Tournament insert>
-- =============================================
CREATE PROCEDURE dbo.spTournaments_Insert 
	-- Add the parameters for the stored procedure here
	@TournamentName nvarchar(200),
	@EntryFee money,
	@id int = 0 output
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	insert into dbo.Tournaments (TournamentName, EntryFee, Active)
	values (@TournamentName, @EntryFee, 1);

	select @id = SCOPE_IDENTITY();
END
GO
