CREATE TABLE "Guardians" (
	"id"	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE,
	"FirstName"	TEXT NOT NULL,
	"LastName"	TEXT NOT NULL,
	"PhoneNumber"	INTEGER NOT NULL,
	"EmailAddress"	TEXT NOT NULL,
	"PinNumber" INTEGER NOT NULL UNIQUE,
	"isAdmin" INTEGER NOT NULL
);

CREATE TABLE "Children" (
	"id"	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE,
	"FirstName"	TEXT NOT NULL,
	"LastName"	TEXT COLLATE nocase NOT NULL,
	"DOB"	TEXT NOT NULL,
	"address"	TEXT NOT NULL,
	"race"	TEXT NOT NULL,
	"gender"	TEXT NOT NULL,
	"photo"	BLOB
);

CREATE TABLE "Attendence" (
	"id"	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE,
	"child_id"	INTEGER NOT NULL,
	"guardian_id"	INTEGER NOT NULL,
	"in_out"	TEXT NOT NULL,
	"timestamp" TEXT NOT NULL DEFAULT CURRENT_TIMESTAMP,
	FOREIGN KEY("child_id") REFERENCES "Children"("id"),
	FOREIGN KEY("guardian_id") REFERENCES "Guardians"("id")
);

CREATE TABLE "Authorized_Guardians" (
	"id"	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE,
	"child_id" INTEGER NOT NULL,
	"guardian_id" INTEGER NOT NULL,
	FOREIGN KEY("child_id") REFERENCES "Children"("id"),
	FOREIGN KEY("guardian_id") REFERENCES "Guardians"("id")	
);

CREATE TRIGGER trgUpdateTimestampToLocal AFTER INSERT ON Attendence
BEGIN
	UPDATE Attendence
	SET timestamp = datetime(timestamp, 'localtime')
	WHERE id = new.id;
END;
