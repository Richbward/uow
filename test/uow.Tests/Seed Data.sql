/****** Records for Garages table ******/
INSERT INTO Garages (Id, [Name], Street1, City, State, Zip, Contact, Phone, ClientSince, Active)
VALUES ('F98FAC6E-5CBF-42BE-8CFB-1A22CCD224D1','NYC Parking West 145th Garage Corp.','53 Bradhurst Ave','New York', 'NY','10039','Josh Murdock','(646) 243-6930', '03/03/1969',1);

INSERT INTO Garages (Id, [Name], Street1, City, State, Zip, Contact, Phone, Url, ClientSince, Active)
VALUES ('454EDE90-B9E4-472C-A4BE-762145BC6149','iPark - Hudson Yards Parking','552 W 30th St','New York', 'NY','10001','Alyssa Grittani','(212) 243-1234','https://www.spotangels.com/#id=2152284&?ref=google_maps_website','07/03/1982',1);

INSERT INTO Garages (Id, [Name], Street1, City, State, Zip, Contact, Phone, Url, ClientSince, Active)
VALUES ('D594BF03-422C-4009-89B3-98460D6C4A10','NYC Parking 80 John Garage Corp.','27 Platt St','New York', 'NY','10038','Theodore Syrianos','(315) 599-2737','https://www.bestparking.com/new-york-ny-parking/','04/01/1989',1);

INSERT INTO Garages (Id, [Name], Street1, City, State, Zip, Contact, Phone, Url, ClientSince, Active)
VALUES ('48BD5AFF-5D85-4EE3-8CF3-B53286093530','NYC Parking West 90TH Garage Corp.','103 W 90th St','New York', 'NY','10024','Eleanor Cortez','(212) 721-5265','https://www.spotangels.com/#id=2151849&?ref=google_maps_website','06/17/1975',1);

INSERT INTO Garages (Id, [Name], Street1, City, State, Zip, Contact, Phone, Url, ClientSince, Active)
VALUES ('9213E455-CE51-44CA-99FA-D9B5046DE802','Continental Garage Parking - Tower 111 Garage Parking NYC','111 W 31st St','New York', 'NY','10001','Elizabeth Lee','(800) 836-6666','https://www.spotangels.com/#id=2152373&?ref=google_maps_website','08/22/1979',1);

/****** Records for Customers table ******/
INSERT INTO Customers(Id, Prefix, FirstName, LastName, Street1, City, State, Zip, MobilePhone, Email, ClientSince, Active)
VALUES ('C5F6278D-0692-4EC1-9DBE-29DFB4AFE4C7','Mr','Gomez','Addams','0001 Cemetery Lane','New York', 'NY','10001','(666) 836-6666','gaddams@gmail.com','04/01/1918',1);

INSERT INTO Customers(Id, Prefix, FirstName, LastName, Street1, Street2, City, State, Zip, MobilePhone, Email, ClientSince, Active)
VALUES ('CF692138-EB62-45E5-86EF-5B369D679DA5','Mr','Herman','Munster','1313 Mockingbird Lane','Mockingbird Heights','Los Angeles', 'CA','90069','(323) 377-0548','hermann@gmail.com','08/22/1927',1);

INSERT INTO Customers(Id, Prefix, FirstName, LastName, Street1, City, State, Zip, MobilePhone, Email, ClientSince, Active)
VALUES ('B8859809-C8A6-41E4-A327-178D504DC45E','Mrs','Jane','Jetson','321 Liftoff Lane','Orbit City', 'CA','90001','(213) 654-3210','jjetson@gmail.com','01/03/1957',1);

/****** Records for Vehicles table ******/
INSERT INTO Vehicles (Id, CustomerId, Make, Model, PlateNumber, State)
VALUES ('ACB2D7FE-CDF2-4A7F-89E7-71F3B2D97352','C5F6278D-0692-4EC1-9DBE-29DFB4AFE4C7','Bugatti','Type 2','SCRE-1313','NY');

INSERT INTO Vehicles (Id, CustomerId, Make, Model, PlateNumber, State)
VALUES ('AD9728F3-7FC1-4633-BE58-209109255C11','CF692138-EB62-45E5-86EF-5B369D679DA5','Cadillac','Hearse','CMTRY-0001','LA');

INSERT INTO Vehicles (Id, CustomerId, Make, Model, PlateNumber, State)
VALUES ('A6960156-49D3-4CBB-8919-2BBED9B41714','B8859809-C8A6-41E4-A327-178D504DC45E','Tesla','Model 3','DEUS EX','LA');

/****** Records for Transactions table ******/
INSERT INTO Transactions (Id, GarageId, VehicleId, Entered)
VALUES ('C124E464-C853-468F-BBAF-2FA13AB66C61','F98FAC6E-5CBF-42BE-8CFB-1A22CCD224D1','ACB2D7FE-CDF2-4A7F-89E7-71F3B2D97352','08/24/2020 07:39:00');

INSERT INTO Transactions (Id, GarageId, VehicleId, Entered)
VALUES ('4CED5830-2211-424E-967E-6CFC72430A9D','F98FAC6E-5CBF-42BE-8CFB-1A22CCD224D1','AD9728F3-7FC1-4633-BE58-209109255C11','08/24/2020 11:14:00');

INSERT INTO Transactions (Id, GarageId, VehicleId, Entered)
VALUES ('4C79BF3F-1DCC-411C-A511-A6AEF4CC3D73','F98FAC6E-5CBF-42BE-8CFB-1A22CCD224D1','A6960156-49D3-4CBB-8919-2BBED9B41714','08/24/2020 09:45:00');

