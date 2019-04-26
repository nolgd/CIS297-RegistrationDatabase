CREATE TABLE [dbo].[Section]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [CourseID] INT NOT NULL, 
    [FacultyID] INT NOT NULL, 
    [Day] NVARCHAR(50) NOT NULL, 
    [Time] NVARCHAR(50) NOT NULL, 
    [Semester] NVARCHAR(50) NOT NULL, 
    CONSTRAINT [FK_Section_Faculty] FOREIGN KEY (FacultyID) REFERENCES Faculty(id), 
    CONSTRAINT [FK_Section_Course] FOREIGN KEY (CourseId) REFERENCES Course(Id)
)
