SELECT TOP (1000) [Id]
      ,[Name]
      ,[Breed]
      ,[ImgName]
      ,[IsAdopted]
      ,[PetType]
  FROM [PetAdoptDB].[dbo].[Animals];

 INSERT INTO Animals(Name,Breed,ImgName,IsAdopted,PetType)
 VALUES('Lucy','Beagle', 'dog4.jpg',0,0),