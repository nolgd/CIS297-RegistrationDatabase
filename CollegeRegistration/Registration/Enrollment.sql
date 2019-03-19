CREATE TABLE [dbo].[Enrollment]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [SectionID] INT NOT NULL, 
    [StudentID] INT NOT NULL, 
    [Grade] NVARCHAR(2) NULL, 
    CONSTRAINT [FK_Enrollment_Student] FOREIGN KEY (StudentId) REFERENCES Student(Id), 
    CONSTRAINT [FK_Enrollment_Section] FOREIGN KEY (SectionId) REFERENCES Section(Id)
)
