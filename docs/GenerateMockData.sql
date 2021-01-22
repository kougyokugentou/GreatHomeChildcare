INSERT INTO Children(FirstName,LastName,DOB,address,race,gender) VALUES ('Joe','Smith','1/13/2021 4:56:33 PM','123 Fake Street','White','Male');
INSERT INTO Children(FirstName,LastName,DOB,address,race,gender) VALUES ('Mary','Smith','1/13/2021 4:56:33 PM','123 Fake Street','White','Female');
INSERT INTO Children(FirstName,LastName,DOB,address,race,gender) VALUES ('Katie','Admin','1/13/2021 4:56:33 PM','123 Fake Street','White','Male');

INSERT INTO Guardians(FirstName,LastName,PhoneNumber,EmailAddress,PinNumber,isAdmin) VALUES ('Main','Admin',1000000001,'main@admin.com','9999',1);
INSERT INTO Guardians(FirstName,LastName,PhoneNumber,EmailAddress,PinNumber) VALUES ('Parent','Smith',1000000001,'parent@smith.com','1234');
INSERT INTO Guardians(FirstName,LastName,PhoneNumber,EmailAddress,PinNumber) VALUES ('Parent2','Smith',1000000001,'parent2@smith.com','1235');

INSERT INTO Authorized_Guardians(child_id, guardian_id) VALUES (1,2);
INSERT INTO Authorized_Guardians(child_id, guardian_id) VALUES (1,3);
INSERT INTO Authorized_Guardians(child_id, guardian_id) VALUES (2,2);
INSERT INTO Authorized_Guardians(child_id, guardian_id) VALUES (3,1);

INSERT INTO Attendence(child_id, guardian_id,in_out) VALUES (1,2,"in");
INSERT INTO Attendence(child_id, guardian_id,in_out) VALUES (2,2,"out");
INSERT INTO Attendence(child_id, guardian_id,in_out) VALUES (3,1,"out");
