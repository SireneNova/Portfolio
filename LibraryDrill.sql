Drop Database LibraryDrillTest
Go

Create Database LibraryDrillTest
Go

Use LibraryDrillTest
Go

Create Table Book
(
BookId int Primary Key Not Null,
Title varchar(50) Null,
PublisherName varchar(30) Null
)
Go

Create Table Publisher
(
Name varchar(30) Not Null,
[Address] varchar (60) Null,
Phone varchar(20) Null
)
Go

Create Table Book_Authors
(
BookId int Not Null,
AuthorName varchar(50) Not Null
)
Go

Create Table Book_Copies
(
BookId int Not Null,
BranchID int Null,
No_of_Copies int Null
)
Go

Create Table Book_Loans
(
BookID int Not Null,
BranchID int Null,
CardNo int Null,
DateOut varchar(30) Null,
DueDate varchar(30) Null
)
Go

Create Table Library_Branch
(
BranchID int Primary Key Not Null,
BranchName varchar(50) Null,
[Address] varchar(60) Null
)
Go

Create Table Borrower
(
CardNo int Primary Key Not Null,
Name varchar(50) Not Null,
[Address] varchar(60) Null,
Phone varchar(20) Null
)

Insert Into Book
values
(1, 'The Lost Tribe', 'NYCP'),
(2, 'Road Trip to Pluto', 'LACP'),
(3, 'Accordion for Dummies', 'UTP'),
(4, 'A Hollow Hello', 'SAP'),
(5, 'Bat Caves of North America', 'NYCP'),
(6, 'Autobiography of a Dolphin', 'BP'),
(7, 'Pirates of the Caribbean', 'WBP'),
(8, 'Touched by a Reaper', 'SAP'),
(9, 'Potions', 'Hogwarts'),
(10, 'The Elk Crossings', 'LACP'),
(11, 'Eclipses in Mythology', 'BP'),
(12, 'Rose Planting', 'COB'),
(13, 'Seconds to Finish', 'DUN'),
(14, 'Solving the Seven Wonders', 'NYCP'),
(15, 'Seeing Cancer', 'LACP'),
(16, 'Smokey the Bear: Behind the Curtain', 'WPB'),
(17, 'Shelf Surfing', 'BP'),
(18, 'Aquatics of the Arctics', 'NYCP'),
(19, 'Types of Rain', 'SAP'),
(20, 'The Meaning of Living', 'DUN')
Go

Insert Into Book_Authors
Values
(1, 'Peter Pan'),
(2, 'Invader Zim'),
(3, 'Phil Harmony'),
(4, 'Justine Greives'),
(5, 'The Count'),
(6, 'Squeaky'),
(7, 'Captain Jack'),
(8, 'Justine Greives'),
(9, 'Severus Snape'),
(10, 'Stephen King'),
(11, 'Professor Lupin'),
(12, 'Johnny Appleseed'),
(13, 'Speedy Gonzales'),
(14, 'Carmen Sandiego'),
(15, 'May Hope M.D.'),
(16, 'A. Paparatzi'),
(17, 'Belle'),
(18, 'Journal Joe'),
(19, 'Journal Joe'),
(20, 'Squeaky')
Go

Insert Into Library_Branch
Values
(1, 'Sharpstown', '1111 Village View Way, New York, NY' ),
(2, 'Central', '500 Centerpoint Dr., Los Angeles, CA'),
(3, 'Diagon Alley', '1997 Charing Cross Rd., London, England'),
(4, 'Atlantis', '56 Lost City Halocline, Atlantis, Atlantic Ocean') 
Go

Insert Into Book_Copies
Values
(1, 1, 2),
(1, 2, 2),
(1, 3, 2),
(1, 4, 8),
(2, 1, 2),
(2, 2, 2),
(2, 3, 2),
(2, 4, 5),
(3, 1, 2),
(3, 2, 2),
(3, 4, 3),
(4, 1, 2),
(4, 2, 2),
(4, 3, 2),
(4, 4, 3),
(5, 1, 2),
(5, 3, 5),
(5, 4, 5),
(6, 3, 10),
(6, 4, 15),
(7, 1, 2),
(7, 2, 2),
(7, 3, 2),
(7, 4, 20),
(8, 1, 3),
(8, 2, 3),
(8, 3, 4),
(8, 4, 6),
(9, 3, 11),
(9, 4, 9),
(10, 1, 7),
(10, 2, 6),
(10, 3, 2),
(10, 4, 13),
(11, 3, 4),
(11, 4, 12),
(12, 1, 2),
(12, 2, 2),
(12, 3, 2),
(12, 4, 5),
(13, 1, 2),
(13, 2, 2),
(13, 4, 2),
(14, 1, 3),
(14, 2, 2),
(14, 3, 2),
(14, 4, 18),
(15, 1, 5),
(15, 2, 8),
(15, 4, 7),
(16, 1, 2),
(16, 2, 4),
(16, 2, 3),
(17, 1, 2),
(17, 2, 2),
(17, 3, 3),
(17, 4, 6),
(18, 1, 2),
(18, 2, 2),
(18, 3, 4),
(18, 4, 14),
(19, 1, 2),
(19, 2, 2),
(19, 3, 5),
(19, 4, 4),
(20, 3, 9),
(20, 4, 19)
Go

Insert Into Borrower
Values
(100, 'Goofy Goof', '1313 Disneyland Drive, Mickey''s Toontown, Anaheim, CA', '012-345-6789'),
(101, 'Hermione Granger', 'Gryffindor Tower, Hogwarts, Hogsmead, Scottland UK', 'Owl Post'),
(102, 'Jean Grey', '1407 Graymalkin Lane, Salem Center, NY', '565-765-4354'),
(103, 'Lisa Simpson', '742 Evergreen Terrace, Springfield, OR', '939-555-0113'),
(104, 'Sherlock Holmes', '221B Baker Street, London, UK', '542-214-720'),
(105, 'Morticia Gomez', '001 North Cemetery Drive, Greenbriar', '236-382-7973'),
(106, 'The Beast', 'The Castle, Alsace, France', 'Magic Mirror'),
(107, 'Spongebob Squarepants', '124 Conch Street, Bikini Bottom, Pacific Ocean', '555-9196')
Go

Insert Into Book_Loans
Values
(1, 3, 101, '2016-01-01', '2016-06-06'),
(1, 2, 103, '2015-03-30', '2016-03-30'),
(1, 3, 106, '2015-09-14', '2016-08-14'),
(1, 1, 102, '2015-04-08', '2016-02-08'),
(2, 2, 103, '2015-03-30', '2016-03-30'),
(2, 4, 107, '2015-07-26', '2016-05-26'),
(3, 2, 100, '2015-05-05', '2016-05-05'),
(3, 4, 107, '2015-07-26', '2016-05-26'),
(4, 1, 102, '2015-04-08', '2016-02-08'),
(4, 1, 105, '2016-08-15', '2016-03-15'),
(4, 3, 106, '2015-09-14', '2016-08-14'),
(5, 2, 103, '2015-03-30', '2016-03-30'),
(5, 1, 105, '2016-08-15', '2016-03-15'),
(6, 4, 104, '2015-02-02', '2016-02-02'),
(6, 4, 107, '2015-07-26', '2016-05-26'),
(7, 3, 101, '2016-01-01', '2016-06-06'),
(7, 2, 103, '2015-03-30', '2016-03-30'),
(7, 4, 107, '2015-07-26', '2016-05-26'),
(8, 1, 105, '2016-08-15', '2016-03-15'),
(9, 3, 101, '2016-01-01', '2016-06-06'),
(9, 3, 105, '2015-10-30', '2016-10-30'),
(10, 3, 101, '2016-01-01', '2016-06-06'),
(10, 1, 102, '2015-04-08', '2016-02-08'),
(10, 1, 105, '2016-08-15', '2016-03-15'),
(11, 3, 101, '2016-01-01', '2016-06-06'),
(11, 4, 104, '2015-02-02', '2016-02-02'),
(12, 2, 100, '2015-05-05', '2016-05-05'),
(12, 1, 102, '2015-04-08', '2016-02-08'),
(12, 3, 106, '2015-09-14', '2016-08-14'),
(13, 2, 100, '2015-05-05', '2016-05-05'),
(14, 1, 102, '2015-04-08', '2016-02-08'),
(14, 2, 103, '2015-03-30', '2016-03-30'),
(14, 4, 104, '2015-02-02', '2016-02-02'),
(15, 4, 104, '2015-02-02', '2016-02-02'),
(16, 2, 100, '2015-05-05', '2016-05-05'),
(17, 3, 101, '2016-01-01', '2016-06-06'),
(17, 1, 102, '2015-04-08', '2016-02-08'),
(17, 3, 106, '2015-09-14', '2016-08-14'),
(18, 2, 103, '2015-03-30', '2016-03-30'),
(18, 4, 107, '2015-07-26', '2016-05-26'),
(19, 1, 102, '2015-04-08', '2016-02-08'),
(19, 4, 104, '2015-02-02', '2016-02-02'),
(19, 3, 106, '2015-09-14', '2016-08-14'),
(20, 4, 104, '2015-02-02', '2016-02-02'),
(20, 3, 106, '2015-09-14', '2016-08-14'),
(20, 4, 107, '2015-07-26', '2016-05-26')
Go

Insert into Publisher
Values
('NYCP', '123 Broad Apple Way, New York City, NY', '123-456-7890'),
('LACP','456 Sunglasses Ct., Los Angeles, CA','456-789-0123'),
('UTP','789 Snowpuff Rd., Saltlake City, UT','987-654-3210'),
('SAP','555 Puddletin St., Seattle, WA','464-979-313'),
('BP','888 Navystone Reef, Bluefin City, Pacific Ocean','777-888-999'),
('WBP','3400 Warner Blvd., Burbank, CA','818-555-5555'),
('COB','101 Cricket Corner, Oxford, UK','464-242-686'),
('DUN','600 Down Under Place, Tasmania, AU','000-333-555'),
('Hogwarts', 'Hogwarts Library, Hogsmead, Scottland, UK', 'Owl Post')
Go


--1. How many copies of the book titled The Lost Tribe are owned 
--   by the library branch whose name is"Sharpstown"?
Select BranchName, Sum(No_of_Copies) as TotalBookCopies
From Book_Copies as bc Full Join Library_Branch as lb
on bc.BranchID=lb.BranchID
Where BranchName='Sharpstown'
Group by BranchName

--2. How many copies of the book titled The Lost Tribe are owned 
--   by each library branch?
Select BranchName, Sum(No_of_Copies) as TotalBookCopies
From Book_Copies as bc Full Join Library_Branch as lb
on bc.BranchID=lb.BranchID
Group by BranchName

--3. Retrieve the names of all borrowers who do not have any books 
--   checked out.
Select Name
From Book_Loans as bl Right Join Borrower as br
on bl.CardNo=br.CardNo
Where bl.CardNo is Null
--Everyone has a book checked out...

--4. For each book that is loaned out from the "Sharpstown" branch 
--   and whose DueDate is today, retrieve the book title, the borrower's 
--   name, and the borrower's address.
Select Title, Name, [Address], DueDate
From Book_Loans as bl 
Full Join Borrower as br
on bl.CardNo=br.CardNo
Full Join Book as b
on bl.BookID=b.BookId
Where DueDate='2016-02-02'

--5. For each library branch, retrieve the branch name and the 
--   total number of books loaned out from that branch.
Select  BranchName, Count(BranchName) as BranchLoans
From Library_Branch as lb Right Join Book_Loans as bl
on lb.BranchID=bl.BranchID
Group by BranchName

--6. Retrieve the names, addresses, and number of books checked 
--   out for all borrowers who have more than five books checked out.
Select Name, [Address], Count(Name) as BooksChecked 
From Book_Loans as bl Left Join Borrower as br
on bl.CardNo=br.CardNo
Group by Name, [Address]
Having Count(Name)>5

--7. For each book authored (or co-authored) by "Stephen King", 
--   retrieve the title and the number of copies owned by the library 
--   branch whose name is "Central".
Select BranchName, AuthorName, Title, No_of_Copies
From Book_Copies as bc 
Left Join Library_Branch as lb
on bc.BranchID=lb.BranchID
Left Join Book as b
on bc.BookId=b.BookId
Left Join Book_Authors as ba
on b.BookId=ba.BookId
Where BranchName='Central'
And AuthorName='Stephen King'

--Now, create a stored procedure that will execute one or more 
--of those queries, based on user choice.

--1: Copies by Branch
Create Proc spGetBranchCopies @branch nvarchar(20)=Null
as
Select BranchName, Sum(No_of_Copies) as TotalBookCopies
From Book_Copies as bc Full Join Library_Branch as lb
on bc.BranchID=lb.BranchID
Where BranchName Like '%' + Isnull(@branch, BranchName) + '%'
Group by BranchName
Go

--Examples:
Exec spGetBranchCopies @branch='arp'
Exec spGetBranchCopies

--2: Loans by DueDate
Create Proc spGetLoanByDue @date1 nvarchar(20)='2014-12-12', @date2 nvarchar(20)= '2017-12-12'
as
Select Title, Name, [Address], DueDate
From Book_Loans as bl 
Full Join Borrower as br
on bl.CardNo=br.CardNo
Full Join Book as b
on bl.BookID=b.BookId
Where DueDate between @date1 and @date2
Order by DueDate
Go 

--Examples:
Exec spGetLoanByDue @date1='2016-02-01', @date2='2016-05-16'
Exec spGetLoanByDue @date2='2016-03-16'

--3: Title and Loans by Author and Branch
Create Proc spGetTitleLoans @author nvarchar(30) =Null, @branch nvarchar(30) =Null
as
Select BranchName, AuthorName, Title, No_of_Copies
From Book_Copies as bc 
Left Join Library_Branch as lb
on bc.BranchID=lb.BranchID
Left Join Book as b
on bc.BookId=b.BookId
Left Join Book_Authors as ba
on b.BookId=ba.BookId
Where BranchName Like '%' + Isnull(@branch, BranchName) + '%'
And AuthorName Like '%' + Isnull(@author, AuthorName) + '%'
Go

--Example:
Exec spGetTitleLoans @author=the, @branch=dia
Exec spGetTitleLoans @branch='at'
