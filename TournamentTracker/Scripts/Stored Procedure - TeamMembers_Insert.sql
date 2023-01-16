-- =============================================
-- Author:		<Bjørnar, Borge>
-- Create date: <16.01.2021>
-- Description:	<Stored procedure for inserting team members>
-- =============================================
CREATE PROCEDURE dbo.spTeamMembers_Insert
	-- Add the parameters for the stored procedure here
	@TeamId int,
	@PersonId int,
	@id int = 0 output
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	insert into dbo.TeamMembers(TeamId, PersonId)
	values (@TeamId, @PersonId);

	select @id = SCOPE_IDENTITY();
END
GO
