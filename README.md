# Kutuphanem

## Kutuphanem Nedir?

C#, Entity Framework ve Winform ile geliştirilen bir kişisel kütüphane yönetim uygulamasıdır. 

## Tablo (Entity) Yapısı

![Image of Yaktocat](https://github.com/goncadenkgelen/kutuphanem/blob/master/KutuphanemDiagram.jpg)

## SQL Sorguları
```
Create table Author
(
	AuthorID int primary key identity,
	Name nvarchar(50)
)

Create table Book
(
	BookID int primary key identity,
	Name nvarchar(50),
	PageCount int,
)

Create table AuthorBook
(
	AuthorID int not null foreign key references Author(AuthorID),
	BookID int not null foreign key references Book(BookID),
	Primary key (AuthorID, BookID)
)

Create table Genre
(
	GenreID int primary key identity,
	Name nvarchar(50),
)

Create table BookGenre
(
	BookID int not null foreign key references Book(BookID),
	GenreID int not null foreign key references Genre(GenreID)
	Primary key (BookID, GenreID)
) 

Create table Person
(
	PersonID int primary key identity,
	FirstName nvarchar(50),
	LastName nvarchar(50),
	Password nvarchar(8),
	Email nvarchar(50) Unique,
	Role nvarchar(50) not null check (Role in('Admin', 'User'))
)

Create table PersonBook
(
	BookID int not null foreign key references Book(BookID),
	PersonID int not null foreign key references Person(PersonID),
	--Status nvarchar(50) not null check (Status in('Want to Read', 'Currently Reading', 'Read'))
	Primary key (BookID, PersonID)
)
```
