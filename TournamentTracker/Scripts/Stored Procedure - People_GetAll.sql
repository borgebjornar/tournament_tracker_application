-- =============================================
-- Author:		<Bjørnar,Borge>
-- Create date: <13.01.2022>
-- Description:	<Get all persons>
-- =============================================
CREATE PROCEDURE [dbo].[spPeople_GetAll] 

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	select *
	from dbo.People;

END
GO
