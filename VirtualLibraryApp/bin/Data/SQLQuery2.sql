ALTER PROC UserAdd
@Username varchar(50),
@Password varchar(50),
@FirstName varchar(50),
@LastName varchar(50)
AS 
	INSERT INTO UserTable (Username, Password, FirstName, LastName)
	VALUES(@Username, @Password, @FirstName, @LastName)