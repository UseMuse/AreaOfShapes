/* В базе данных MS SQL Server есть продукты и категории. 
 * Одному продукту может соответствовать много категорий, в одной категории может быть много продуктов. 
 * Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории». 
 * Если у продукта нет категорий, то его имя все равно должно выводиться.
 */

CREATE TABLE Products (
	Id INT PRIMARY KEY,
	Title NVARCHAR(50)
);

INSERT INTO Products
VALUES
	(1, N'Крымское Ливадия бел. п/сл. стол.'),
	(2, N'Кадарка Ливадия крас. п/сл. стол.'),
	(3, N'Пиво темное');

CREATE TABLE Tags (
	Id INT PRIMARY KEY,
	Title NVARCHAR(25)
);

INSERT INTO Tags
VALUES
	(1, N'Красное'),
	(2, N'Белое'),
	(3, N'Сухое'),
	(4, N'Полусладкое'),
	(5, N'Столовое'),
	(6, N'Светлое');


CREATE TABLE ProductTags (
	ProductId INT FOREIGN KEY REFERENCES Products(Id),
	TagId INT FOREIGN KEY REFERENCES Tags(Id),
	PRIMARY KEY (ProductId, TagId)
);

INSERT INTO ProductTags
VALUES
	(1, 2),
	(1, 4),
	(1, 5),
	(2, 1),
	(2, 4),
	(2, 5);


SELECT P.Title as Product, C.Title as Tag
FROM Products P LEFT JOIN ProductTags PT ON P.Id = PT.ProductId
LEFT JOIN Tags C ON PT.TagId = C.Id;