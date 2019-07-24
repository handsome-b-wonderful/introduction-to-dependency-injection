-- SQL Server Schema for Dependency Injection sample project

-- create

IF OBJECT_ID('dbo.pet', 'U') IS NOT NULL 
  DROP TABLE [dbo].[pet];
GO


CREATE TABLE [dbo].[pet]
(
	[id] INT IDENTITY NOT NULL
	, [name] NVARCHAR(100) NOT NULL
	, [serial] NVARCHAR(50) NULL
	, [age] INT NOT NULL
	, [category] NVARCHAR(50) NULL
	, [description] NVARCHAR(MAX) NULL
	, [url] NVARCHAR(1024) NULL
)
GO


ALTER TABLE [dbo].[pet]
	ADD CONSTRAINT [pet_df_age]
DEFAULT 0 FOR [age]
GO


ALTER TABLE [dbo].[pet] ADD CONSTRAINT [pet_pk] PRIMARY KEY ([id])
GO


-- populate

INSERT INTO [dbo].[pet] ([name], [serial], [age], [category], [description], [url])
VALUES('Bugs','123g44g4',1,'rabbit','Easter Bunny','https://www.petakids.com/wp-content/uploads/2015/11/Cute-Red-Bunny.jpg')
INSERT INTO [dbo].[pet] ([name], [serial], [age], [category], [description], [url])
VALUES('Reggie','vc6b5',6,'snake','Boa Constrictor','https://img.purch.com/w/660/aHR0cDovL3d3dy5saXZlc2NpZW5jZS5jb20vaW1hZ2VzL2kvMDAwLzA5NC8yODIvb3JpZ2luYWwvYm9hLWNvbnN0cmljdG9yLXNodXR0ZXJzdG9jay5qcGc=')
INSERT INTO [dbo].[pet] ([name], [serial], [age], [category], [description], [url])
VALUES('Felix','12312333',0,'hedgehog','Hedgehog','https://vetmed.illinois.edu/wp-content/uploads/2017/12/pc-keller-hedgehog.jpg')
INSERT INTO [dbo].[pet] ([name], [serial], [age], [category], [description], [url])
VALUES('Morris','1h3h5675j5',5,'cat','Orange DSH','https://news.nationalgeographic.com/content/dam/news/2018/05/17/you-can-train-your-cat/02-cat-training-NationalGeographic_1484324.jpg')
INSERT INTO [dbo].[pet] ([name], [serial], [age], [category], [description], [url])
VALUES('Turkish','43fb6j7k',17,'cat','Leopard Cat','https://www.catster.com/wp-content/uploads/2018/07/Savannah-cat-long-body-shot.jpg')
INSERT INTO [dbo].[pet] ([name], [serial], [age], [category], [description], [url])
VALUES('Whamo','44ff44',7,'dog','Frisbee Dog','https://cdn.shopify.com/s/files/1/0925/5048/products/dog-dog-frisbee-flying-disc-tooth-resistant-6_2048x2048.jpg?v=1501081336')
INSERT INTO [dbo].[pet] ([name], [serial], [age], [category], [description], [url])
VALUES('Screech','df43f',4,'dog','Newfoundland Dog','https://cdn2-www.dogtime.com/assets/uploads/gallery/newfoundland-dogs-and-puppies/newfoundland-dogs-puppies-1.jpg')
INSERT INTO [dbo].[pet] ([name], [serial], [age], [category], [description], [url])
VALUES('Skippy Jon Jones','df7df6',2,'dog','Chihuahua','https://t1.ea.ltmcdn.com/en/razas/1/0/0/img_1_chihuahua_0_600.jpg')
INSERT INTO [dbo].[pet] ([name], [serial], [age], [category], [description], [url])
VALUES('Taco','7363',2,'pig','teacup pot-belly pig','https://ilovepets.co/wp-content/uploads/2017/01/pot-belly-pig-500x375.jpg')
GO

-- review

SELECT *
FROM [dbo].[pet]
ORDER BY [name]


