USE [CookBook.mdf];
Insert Users VALUES ('Nastya', 1, 'lalala');
Insert Users VALUES ('Lala', 1, 'topolya');
Insert Users VALUES ('Meow', 1, 'miu');

Insert Recipes VALUES ( 2, 'Beef', 1);
Insert Recipes VALUES ( 2, 'Pasta', 2);
Insert Recipes VALUES ( 3, 'Cake', 3);
Insert Recipes VALUES ( 1, 'Pancakes', 1);

Insert Reviews VALUES ( 1, 1, 'Perfect', GETDATE());
Insert Reviews VALUES ( 3, 2, 'Not bad', GETDATE());
Insert Reviews VALUES ( 3, 3, 'Like it', GETDATE());
Insert Reviews VALUES ( 2, 4, 'Tasty', GETDATE());

Insert Ingredients VALUES ('Meat');
Insert Ingredients VALUES ('Milk');
Insert Ingredients VALUES ('Egg');
Insert Ingredients VALUES ('Spaghetti');
Insert Ingredients VALUES ('Flour');
Insert Ingredients VALUES ('Sugar');

Insert Compositions VALUES (1, 1, 5);
Insert Compositions VALUES (2, 2, 1);
Insert Compositions VALUES (2, 3, 2);
Insert Compositions VALUES (2, 5, 1);
Insert Compositions VALUES (3, 3, 4);
Insert Compositions VALUES (3, 5, 3);
Insert Compositions VALUES (3, 6, 1);
Insert Compositions VALUES (4, 4, 3);

