INSERT INTO [dbo].[tblAuthor] ([AuthorId], [AuthorName], [AuthorBiography], [DateJoined], [IsBestseller], [AverageRating], [TotalBooksSold]) VALUES (21, N'John Doe                 ', N'John Doe is a famous author...', N'2023-01-01', 1, CAST(5 AS Decimal(18, 0)), 10000)
-- Insert authors from ID 1 to 20
INSERT INTO [dbo].[tblAuthor] ([AuthorId], [AuthorName], [AuthorBiography], [DateJoined], [IsBestseller], [AverageRating], [TotalBooksSold]) VALUES 
(1, N'Jane Smith', N'Jane Smith is an acclaimed author...', N'2022-01-01', 1, CAST(4.7 AS Decimal(18, 1)), 5000),
(2, N'Robert Brown', N'Robert Brown writes thrilling novels...', N'2021-05-15', 0, CAST(4.3 AS Decimal(18, 1)), 7500),
(3, N'Emily White', N'Emily White is known for her romance novels...', N'2020-07-20', 1, CAST(4.9 AS Decimal(18, 1)), 12000),
(4, N'Michael Green', N'Michael Green has a background in science fiction...', N'2019-09-10', 0, CAST(4.1 AS Decimal(18, 1)), 3000),
(5, N'Sarah Black', N'Sarah Black is a prolific writer...', N'2018-03-22', 1, CAST(4.5 AS Decimal(18, 1)), 9000),
(6, N'Chris Blue', N'Chris Blue writes captivating mysteries...', N'2017-11-11', 0, CAST(4.0 AS Decimal(18, 1)), 2000),
(7, N'Linda Gold', N'Linda Gold is a celebrated author...', N'2016-06-06', 1, CAST(4.8 AS Decimal(18, 1)), 15000),
(8, N'Paul Silver', N'Paul Silver is known for his historical fiction...', N'2015-04-14', 0, CAST(4.2 AS Decimal(18, 1)), 4000),
(9, N'Alice Brown', N'Alice Brown writes insightful non-fiction...', N'2014-08-18', 1, CAST(4.6 AS Decimal(18, 1)), 10000),
(10, N'Mark White', N'Mark White is an emerging author...', N'2013-12-01', 0, CAST(3.9 AS Decimal(18, 1)), 2500),
(11, N'Anna Grey', N'Anna Grey has published numerous bestsellers...', N'2012-07-23', 1, CAST(4.7 AS Decimal(18, 1)), 11000),
(12, N'James Black', N'James Black focuses on crime fiction...', N'2011-10-30', 0, CAST(4.1 AS Decimal(18, 1)), 3500),
(13, N'Karen Pink', N'Karen Pink is a respected writer...', N'2010-05-17', 1, CAST(4.5 AS Decimal(18, 1)), 8000),
(14, N'David Yellow', N'David Yellow writes engaging children’s books...', N'2009-03-12', 0, CAST(4.0 AS Decimal(18, 1)), 3000),
(15, N'Mary Orange', N'Mary Orange is known for her fantasy novels...', N'2008-02-28', 1, CAST(4.8 AS Decimal(18, 1)), 14000),
(16, N'John Blue', N'John Blue has a knack for storytelling...', N'2007-09-14', 0, CAST(4.2 AS Decimal(18, 1)), 4500),
(17, N'Laura Purple', N'Laura Purple has written numerous award-winning books...', N'2006-12-19', 1, CAST(4.9 AS Decimal(18, 1)), 16000),
(18, N'Steve Red', N'Steve Red specializes in thrillers...', N'2005-07-05', 0, CAST(4.3 AS Decimal(18, 1)), 6000),
(19, N'Nancy Violet', N'Nancy Violet is an expert in suspense writing...', N'2004-11-27', 1, CAST(4.6 AS Decimal(18, 1)), 9500),
(20, N'Alex Green', N'Alex Green is a novelist known for contemporary fiction...', N'2003-04-15', 0, CAST(4.1 AS Decimal(18, 1)), 3500);

-- Ensure author with ID 21 already exists
-- INSERT INTO [dbo].[tblAuthor] ([AuthorId], [AuthorName], [AuthorBiography], [DateJoined], [IsBestseller], [AverageRating], [TotalBooksSold]) VALUES 
-- (21, N'John Doe', N'John Doe is a famous author...', N'2023-01-01', 1, CAST(5 AS Decimal(18, 0)), 10000);
