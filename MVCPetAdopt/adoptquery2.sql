SELECT TOP (1000) [Id]
      ,[Name]
      ,[Breed]
      ,[ImgName]
      ,[IsAdopted]
      ,[PetType]
  FROM [PetAdoptDB].[dbo].[Animals];

 INSERT INTO Animals(Name,Breed,ImgName,IsAdopted,PetType)
 VALUES('Lucy','Beagle', 'dog4.jpg',0,0),('Max','German Shepherd', 'dog5.jpg',1,0),('Daisy','Siamese', 'cat1.jpg',0,1),('Rocky','Persian', 'cat2.jpg',1,1),('Luna','Maine Coon', 'cat3.jpg',0,1),('Milo','Ragdoll', 'cat4.jpg',1,1),('Lola','Sphynx', 'cat5.jpg',0,1);UPDATE Animals SET PetType = 0WHERE Id = 7;