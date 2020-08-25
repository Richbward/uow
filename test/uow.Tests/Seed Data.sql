/****** Records for Garages table ******/
INSERT INTO Garages ([GUID], [Name], Street1, City, State, Zip, Contact, Phone, ClientSince, Active)
VALUES (NEWID(),'NYC Parking West 145th Garage Corp.','53 Bradhurst Ave','New York', 'NY','10039','Josh Murdock','(646) 243-6930', '03/03/1969',1);

INSERT INTO Garages ([GUID], [Name], Street1, City, State, Zip, Contact, Phone, Url, ClientSince, Active)
VALUES (NEWID(),'iPark - Hudson Yards Parking','552 W 30th St','New York', 'NY','10001','Alyssa Grittani','(212) 243-1234','https://www.spotangels.com/#id=2152284&?ref=google_maps_website','07/03/1982',1);

INSERT INTO Garages ([GUID], [Name], Street1, City, State, Zip, Contact, Phone, Url, ClientSince, Active)
VALUES (NEWID(),'NYC Parking 80 John Garage Corp.','27 Platt St','New York', 'NY','10038','Theodore Syrianos','(315) 599-2737','https://www.bestparking.com/new-york-ny-parking/','04/01/1989',1);

INSERT INTO Garages ([GUID], [Name], Street1, City, State, Zip, Contact, Phone, Url, ClientSince, Active)
VALUES (NEWID(),'NYC Parking West 90TH Garage Corp.','103 W 90th St','New York', 'NY','10024','Eleanor Cortez','(212) 721-5265','https://www.spotangels.com/#id=2151849&?ref=google_maps_website','06/17/1975',1);

INSERT INTO Garages ([GUID], [Name], Street1, City, State, Zip, Contact, Phone, Url, ClientSince, Active)
VALUES (NEWID(),'Continental Garage Parking - Tower 111 Garage Parking NYC','111 W 31st St','New York', 'NY','10001','Elizabeth Lee','(800) 836-6666','https://www.spotangels.com/#id=2152373&?ref=google_maps_website','08/22/1979',1);

/****** Records for Customers table ******/
INSERT INTO Customers([GUID], Prefix, FirstName, LastName, Street1, City, State, Zip, MobilePhone, Email, ClientSince, Active)
VALUES (NEWID(),'Mr','Gomez','Addams','0001 Cemetery Lane','New York', 'NY','10001','(666) 836-6666','gaddams@gmail.com','04/01/1918',1);

INSERT INTO Customers([GUID], Prefix, FirstName, LastName, Street1, Street2, City, State, Zip, MobilePhone, Email, ClientSince, Active)
VALUES (NEWID(),'Mr','Herman','Munster','1313 Mockingbird Lane','Mockingbird Heights','Los Angeles', 'CA','90069','(323) 377-0548','hermann@gmail.com','08/22/1927',1);

INSERT INTO Customers([GUID], Prefix, FirstName, LastName, Street1, City, State, Zip, MobilePhone, Email, ClientSince, Active)
VALUES (NEWID(),'Mrs','Jane','Jetson','321 Liftoff Lane','Orbit City', 'CA','90001','(213) 654-3210','jjetson@gmail.com','01/03/1957',1);

/****** Records for Vehicles table ******/
INSERT INTO Vehicles ([GUID], CustomerId, Make, Model, PlateNumber, State)
VALUES (NEWID(),1,'Bugatti','Type 2','SCRE-1313','NY');

INSERT INTO Vehicles ([GUID], CustomerId, Make, Model, PlateNumber, State)
VALUES (NEWID(),2,'Cadillac','Hearse','CMTRY-0001','LA');

INSERT INTO Vehicles ([GUID], CustomerId, Make, Model, PlateNumber, State)
VALUES (NEWID(),3,'Tesla','Model 3','DEUS EX','LA');

/****** Records for Transactions table ******/
INSERT INTO Transactions ([GUID], GarageId, VehicleId, Entered)
VALUES (NEWID(),1,1,'08/24/2020 07:39:00');

INSERT INTO Transactions ([GUID] VehicleId, GarageId, Entered)
VALUES (NEWID(),1,2,'08/24/2020 11:14:00');

INSERT INTO Transactions ([GUID], VehicleId, GarageId, Entered)
VALUES (NEWID(),1,3,'08/24/2020 09:45:00');
