
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 07/21/2016 08:10:57
-- Generated from EDMX file: C:\GIT_Solutions_RK\Training\QuestionReviewer\QuestionReviewer\Quiz.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Training];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[QuestionCards]', 'U') IS NOT NULL
    DROP TABLE [dbo].[QuestionCards];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'QuestionCards'
CREATE TABLE [dbo].[QuestionCards] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Question] nvarchar(max)  NOT NULL,
    [Answer1] nvarchar(max)  NOT NULL,
    [Answer2] nvarchar(max)  NOT NULL,
    [Answer3] nvarchar(max)  NOT NULL,
    [CorrectAnswer] int  NOT NULL,
    [Category_Id] int  NOT NULL
);
GO

-- Creating table 'Categories'
CREATE TABLE [dbo].[Categories] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'QuestionCards'
ALTER TABLE [dbo].[QuestionCards]
ADD CONSTRAINT [PK_QuestionCards]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Categories'
ALTER TABLE [dbo].[Categories]
ADD CONSTRAINT [PK_Categories]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Category_Id] in table 'QuestionCards'
ALTER TABLE [dbo].[QuestionCards]
ADD CONSTRAINT [FK_CategoryQuestionCard]
    FOREIGN KEY ([Category_Id])
    REFERENCES [dbo].[Categories]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CategoryQuestionCard'
CREATE INDEX [IX_FK_CategoryQuestionCard]
ON [dbo].[QuestionCards]
    ([Category_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------