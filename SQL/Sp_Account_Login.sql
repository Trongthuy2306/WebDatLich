USE[OnlineDoctor]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Sp_Account_Login]
	@UserName varchar(20),
	@Password varchar(50)
as 
begin
	declare @count int
	declare @res bit
	select @count = count(*) from Account where  UserName = @UserName and  Password = @password
	if @count > 0
		set @res = 1
	else
		set @res = 0

	select @res
end