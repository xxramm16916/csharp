Вопрос №1

Выполните практическое задание ниже.
Пожалуйста, разместите код на Github и приложите ссылку. Если в задании что-то непонятно, опишите возникшие вопросы и сделанные предположения. Например, в комментариях в коде.

Задание:
Напишите на C# библиотеку для поставки внешним клиентам, которая умеет вычислять площадь круга по радиусу и треугольника по трем сторонам. Дополнительно к работоспособности оценим:
- Юнит-тесты
- Легкость добавления других фигур
- Вычисление площади фигуры без знания типа фигуры в compile-time
- Проверку на то, является ли треугольник прямоугольным

Вопрос №2
В базе данных MS SQL Server есть продукты и категории. Одному продукту может соответствовать много категорий, в одной категории может быть много продуктов. Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории». Если у продукта нет категорий, то его имя все равно должно выводиться.

По возможности — положите ответ рядом с кодом из первого вопроса.


Для Вопроса 1:
Описание: 
- Для примера создано два юнит теста XUnit.
- Для примера добавил расчет площадей треугольника и круга для Евклидовой геометрии и геометрии Лобачевского.
- Проверка на то, является ли треугольник прямоугольным, добавлена для евклидовой геометрии.

Для Вопроса 2:
Воспользовался онлайн песочницей(SQLLite) для быстроты.
https://www.jdoodle.com/execute-sql-online/

Пояснение:
Обычная работа со связью многие ко многим. Категоря, не имеющая продуктов, отражена в выводе не будет.

Скрипт:
create table Products(id INTEGER PRIMARY KEY AUTOINCREMENT, productName TEXT NOT NULL);
create table Category(id INTEGER PRIMARY KEY AUTOINCREMENT, categoryName TEXT NOT NULL);
create table Links(id INTEGER PRIMARY KEY AUTOINCREMENT, productId INTEGER NOT NULL, categoryId INTEGER NOT NULL, FOREIGN KEY (productId) REFERENCES Products(id), FOREIGN KEY (categoryId) REFERENCES Category(id));

insert into Products (productName) values('Молюски'), ('Ракообразные'), ('Мясо убойных животных'), ('Мясо диких животных'), ('Молоко');
insert into Category (categoryName) values('Морепродукты'), ('Мясо'), ('Все продукты');

insert into Links (productId, categoryId) values(1, 1), (1, 3), (2, 1), (2, 3), (3, 2), (3, 3), (4, 2), (4, 3);


select pr.productName, cat.categoryName
from Products as pr
left join Links as l on pr.id = l.productId
left join Category as cat on l.categoryId = cat.id;
--select * from Products;
--select * from Category;
--select * from Links;
