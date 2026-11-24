/* =====================================================================
   AppUser.sql  -  Employee login table and stored procedures
   Owner: Leonardo Orta (User Login)

   Safe to run more than once:
   - the table is only created if it does not exist yet
   - the procedures use CREATE OR ALTER, so re-running updates them
   ===================================================================== */

/* ---------- Table ---------------------------------------------------- */
IF OBJECT_ID(N'dbo.AppUser', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.AppUser
    (
        UserID        INT IDENTITY(1,1) NOT NULL
                      CONSTRAINT PK_AppUser PRIMARY KEY,
        UserName      NVARCHAR(50)  NOT NULL
                      CONSTRAINT UQ_AppUser_UserName UNIQUE,
        FirstName     NVARCHAR(50)  NOT NULL,
        LastName      NVARCHAR(50)  NOT NULL,
        EmailAddress  NVARCHAR(50)  NULL,          -- optional for now
        PasswordHash  VARCHAR(128)  NOT NULL,      -- PBKDF2 hash, Base64 text
        PasswordSalt  VARCHAR(50)   NOT NULL,      -- random salt, Base64 text
        Role          NVARCHAR(20)  NOT NULL
                      CONSTRAINT DF_AppUser_Role DEFAULT (N'Employee'),
        ModifiedDate  DATETIME      NOT NULL
                      CONSTRAINT DF_AppUser_ModifiedDate DEFAULT (GETDATE())
    );
END
GO

/* ---------- uspUserLogin --------------------------------------------
   Gets one user by username. Used by Log In (to check the password)
   and by Forgot Password (to compare the new password to the old one).
   Returns no rows if the username does not exist.                     */
CREATE OR ALTER PROCEDURE dbo.uspUserLogin
    @UserName NVARCHAR(50)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT UserID, UserName, FirstName, LastName, EmailAddress,
           PasswordHash, PasswordSalt, Role, ModifiedDate
    FROM dbo.AppUser
    WHERE UserName = @UserName;
END
GO

/* ---------- uspUserNameExists ---------------------------------------
   Returns 1 if the username is taken, 0 if it is free.
   Used by Create Account and Forgot Username.                         */
CREATE OR ALTER PROCEDURE dbo.uspUserNameExists
    @UserName NVARCHAR(50)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT CAST(CASE WHEN EXISTS (SELECT 1 FROM dbo.AppUser
                                  WHERE UserName = @UserName)
                     THEN 1 ELSE 0 END AS BIT) AS UserNameExists;
END
GO

/* ---------- uspUserInsert -------------------------------------------
   Adds a new user and returns the new UserID.
   A duplicate username raises error 2627 (unique constraint).         */
CREATE OR ALTER PROCEDURE dbo.uspUserInsert
    @UserName     NVARCHAR(50),
    @FirstName    NVARCHAR(50),
    @LastName     NVARCHAR(50),
    @EmailAddress NVARCHAR(50) = NULL,
    @PasswordHash VARCHAR(128),
    @PasswordSalt VARCHAR(50),
    @Role         NVARCHAR(20) = N'Employee'
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO dbo.AppUser
        (UserName, FirstName, LastName, EmailAddress,
         PasswordHash, PasswordSalt, Role)
    VALUES
        (@UserName, @FirstName, @LastName, @EmailAddress,
         @PasswordHash, @PasswordSalt, @Role);

    SELECT CAST(SCOPE_IDENTITY() AS INT) AS UserID;
END
GO

/* ---------- uspUserUpdatePassword -----------------------------------
   Saves a new hash and salt. Returns how many rows changed
   (1 = updated, 0 = username not found).                              */
CREATE OR ALTER PROCEDURE dbo.uspUserUpdatePassword
    @UserName     NVARCHAR(50),
    @PasswordHash VARCHAR(128),
    @PasswordSalt VARCHAR(50)
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE dbo.AppUser
    SET PasswordHash = @PasswordHash,
        PasswordSalt = @PasswordSalt,
        ModifiedDate = GETDATE()
    WHERE UserName = @UserName;

    SELECT @@ROWCOUNT AS RowsUpdated;
END
GO
