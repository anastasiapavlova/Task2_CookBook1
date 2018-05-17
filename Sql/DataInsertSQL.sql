USE [RecipeBook1.mdf];
Insert Users VALUES ('20D93B80-7028-4562-9B93-053168515FE8','Nastya', 1, 'lalala');
Insert Users VALUES ('F1F04187-3B81-4386-BC91-337647599505', 'Lala', 1, 'topolya');
Insert Users VALUES ('7E8AE5AA-1B8C-4025-BC2A-C8FE4A6D159D', 'Meow', 1, 'miu');
Insert Users VALUES (NEWID(), 'Admin', 2, 'adm');

Insert Recipes VALUES ('C1BEE23D-7F29-4EC4-B542-8FD9B2123AB9', 2, 'Beef', 'F1F04187-3B81-4386-BC91-337647599505');
Insert Recipes VALUES ('6DF78144-5678-4A39-9B48-E11DF8A033F6', 2, 'Pasta', '20D93B80-7028-4562-9B93-053168515FE8');
Insert Recipes VALUES ('7BE30999-FBB1-4C88-93D1-E77BEAD4CA0B', 3, 'Cake', '20D93B80-7028-4562-9B93-053168515FE8');
Insert Recipes VALUES ('123AB81E-2AE3-4AB2-8F1B-F5B2D4C65079', 1, 'Pancakes', '7E8AE5AA-1B8C-4025-BC2A-C8FE4A6D159D');

Insert Reviews VALUES (NEWID(), '20D93B80-7028-4562-9B93-053168515FE8', 'C1BEE23D-7F29-4EC4-B542-8FD9B2123AB9', 'Perfect', GETDATE());
Insert Reviews VALUES (NEWID(), 'F1F04187-3B81-4386-BC91-337647599505', '6DF78144-5678-4A39-9B48-E11DF8A033F6', 'Not bad', GETDATE());
Insert Reviews VALUES (NEWID(), '7E8AE5AA-1B8C-4025-BC2A-C8FE4A6D159D', '7BE30999-FBB1-4C88-93D1-E77BEAD4CA0B', 'Like it', GETDATE());
Insert Reviews VALUES (NEWID(), '20D93B80-7028-4562-9B93-053168515FE8', '123AB81E-2AE3-4AB2-8F1B-F5B2D4C65079', 'Tasty', GETDATE());

Insert Ingredients VALUES ('6EB779DA-C2B5-44CB-A177-68DC6DC3D71A', 'Meat');
Insert Ingredients VALUES ('9C7EB41F-4AEB-4798-95A0-1126D3C041AB', 'Milk');
Insert Ingredients VALUES ('1E7C34B1-5023-4A78-92B3-A540A6B616A9', 'Egg');
Insert Ingredients VALUES ('A50308B4-4851-4370-B547-93D8F3C12A52', 'Spaghetti');
Insert Ingredients VALUES ('90CC17EE-EB28-4380-A305-F2E345577C53', 'Flour');
Insert Ingredients VALUES ('25EDC8D1-F638-4814-9954-D4EBF79EA187', 'Sugar');

Insert Compositions VALUES (NEWID(), 'C1BEE23D-7F29-4EC4-B542-8FD9B2123AB9', '6EB779DA-C2B5-44CB-A177-68DC6DC3D71A', 5);
Insert Compositions VALUES (NEWID(), '6DF78144-5678-4A39-9B48-E11DF8A033F6', '9C7EB41F-4AEB-4798-95A0-1126D3C041AB', 1);
Insert Compositions VALUES (NEWID(), '6DF78144-5678-4A39-9B48-E11DF8A033F6', '1E7C34B1-5023-4A78-92B3-A540A6B616A9', 2);
Insert Compositions VALUES (NEWID(), '6DF78144-5678-4A39-9B48-E11DF8A033F6', '90CC17EE-EB28-4380-A305-F2E345577C53', 1);
Insert Compositions VALUES (NEWID(), '7BE30999-FBB1-4C88-93D1-E77BEAD4CA0B', '1E7C34B1-5023-4A78-92B3-A540A6B616A9', 4);
Insert Compositions VALUES (NEWID(), '7BE30999-FBB1-4C88-93D1-E77BEAD4CA0B', '90CC17EE-EB28-4380-A305-F2E345577C53', 3);
Insert Compositions VALUES (NEWID(), '7BE30999-FBB1-4C88-93D1-E77BEAD4CA0B', '25EDC8D1-F638-4814-9954-D4EBF79EA187', 1);
Insert Compositions VALUES (NEWID(), '123AB81E-2AE3-4AB2-8F1B-F5B2D4C65079', 'A50308B4-4851-4370-B547-93D8F3C12A52', 3);

