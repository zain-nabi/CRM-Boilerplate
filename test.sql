create table ExternalUser
(
	UserID int primary key identity(1,1),
	UserName varchar(255),
	FirstName varchar(255),
	LastName varchar(255),
	PasswordHash varchar(255),
	SecurityStamp varchar(255),
	PhoneNumber varchar(255),
	PhoneNumberConfirmed bit,
	Email varchar(255),
	EmailConfirmed bit,
	LockoutEndDateUtc datetime,
	LockoutEnabled bit,
	AccessFailedCount int
)


create table [Role]
(
	RoleID int primary key identity(1,1),
	[Role] varchar(255),
	Detail varchar(255)
)


create table ExternalUserRole
(
	ExternalUserRoleID int primary key identity(1,1),
	UserID int foreign key references ExternalUser(UserID),
	RoleID int foreign key references Role(RoleID),
	CreatedOn datetime,
	CreatedByUserID int,
	DeletedOn DateTime,
	DeletedByUserID int
)
