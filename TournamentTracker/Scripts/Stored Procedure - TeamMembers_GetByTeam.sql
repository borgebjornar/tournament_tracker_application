-- =============================================
-- Author:		<Bjørnar Borge>
-- Create date: <16.11.2022>
-- Description:	<Get Team Members by Team>
-- =============================================
CREATE PROCEDURE dbo.spTeamMembers_GetByTeam
	-- Add the parameters for the stored procedure here
	@TeamId int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	select p.*
	from dbo.TeamMembers m
	inner join dbo.People p on m.PersonId = p.id
	where m.TeamId = @TeamId;
END
GO