-- =============================================
-- Author:		<Bjørnar, Borge>
-- Create date: <16.01.2022>
-- Description:	<Get all teams>
-- =============================================
CREATE PROCEDURE dbo.spTeam_GetAll
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	select *
	from dbo.Teams;
END
GO