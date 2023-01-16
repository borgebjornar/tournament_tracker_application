-- =============================================
-- Author:		<Bjørnar,Borge>
-- Create date: <16.01.2021>
-- Description:	<Stored procecure for inserting teams>
-- =============================================
CREATE PROCEDURE dbo.spTeams_Insert
	-- Add the parameters for the stored procedure here
	@TeamName nvarchar(100),
	@id int = 0 output
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	insert into dbo.Teams (TeamName)
	values (@TeamName)

	select @id = SCOPE_IDENTITY();
END
GO
