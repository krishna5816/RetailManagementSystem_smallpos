
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/07/2019 12:50:36
-- Generated from EDMX file: E:\NeedTechnosoft\RetailManagementSystem\stockmanagementsystem\RetailManagementSystem\RetailManagementSystem\Models\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [HamroSuperMarket];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK__advances__employ__2E1BDC42]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[advances] DROP CONSTRAINT [FK__advances__employ__2E1BDC42];
GO
IF OBJECT_ID(N'[dbo].[FK__billitems__bill___1FCDBCEB]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[billitems] DROP CONSTRAINT [FK__billitems__bill___1FCDBCEB];
GO
IF OBJECT_ID(N'[dbo].[FK__billitems__item___1ED998B2]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[billitems] DROP CONSTRAINT [FK__billitems__item___1ED998B2];
GO
IF OBJECT_ID(N'[dbo].[FK__bills__customer___1BFD2C07]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[bills] DROP CONSTRAINT [FK__bills__customer___1BFD2C07];
GO
IF OBJECT_ID(N'[dbo].[FK__items__category___1273C1CD]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[items] DROP CONSTRAINT [FK__items__category___1273C1CD];
GO
IF OBJECT_ID(N'[dbo].[FK__customerp__custo__05D8E0BE]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[customerpaids] DROP CONSTRAINT [FK__customerp__custo__05D8E0BE];
GO
IF OBJECT_ID(N'[dbo].[FK__salaries__employ__2B3F6F97]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[salaries] DROP CONSTRAINT [FK__salaries__employ__2B3F6F97];
GO
IF OBJECT_ID(N'[dbo].[FK__expences__expenc__32E0915F]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[expences] DROP CONSTRAINT [FK__expences__expenc__32E0915F];
GO
IF OBJECT_ID(N'[dbo].[FK__supplyite__item___267ABA7A]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[supplyitems] DROP CONSTRAINT [FK__supplyite__item___267ABA7A];
GO
IF OBJECT_ID(N'[dbo].[FK__variances__item___15502E78]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[variances] DROP CONSTRAINT [FK__variances__item___15502E78];
GO
IF OBJECT_ID(N'[dbo].[FK__suppliera__vendo__2BFE89A6]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[supplieradvances] DROP CONSTRAINT [FK__suppliera__vendo__2BFE89A6];
GO
IF OBJECT_ID(N'[dbo].[FK__supplierp__suppl__02FC7413]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[supplierpaids] DROP CONSTRAINT [FK__supplierp__suppl__02FC7413];
GO
IF OBJECT_ID(N'[dbo].[FK__supplies__vendor__22AA2996]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[supplies] DROP CONSTRAINT [FK__supplies__vendor__22AA2996];
GO
IF OBJECT_ID(N'[dbo].[FK__supplyite__suppl__25869641]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[supplyitems] DROP CONSTRAINT [FK__supplyite__suppl__25869641];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[admins]', 'U') IS NOT NULL
    DROP TABLE [dbo].[admins];
GO
IF OBJECT_ID(N'[dbo].[advances]', 'U') IS NOT NULL
    DROP TABLE [dbo].[advances];
GO
IF OBJECT_ID(N'[dbo].[billitems]', 'U') IS NOT NULL
    DROP TABLE [dbo].[billitems];
GO
IF OBJECT_ID(N'[dbo].[bills]', 'U') IS NOT NULL
    DROP TABLE [dbo].[bills];
GO
IF OBJECT_ID(N'[dbo].[categories]', 'U') IS NOT NULL
    DROP TABLE [dbo].[categories];
GO
IF OBJECT_ID(N'[dbo].[customerpaids]', 'U') IS NOT NULL
    DROP TABLE [dbo].[customerpaids];
GO
IF OBJECT_ID(N'[dbo].[customers]', 'U') IS NOT NULL
    DROP TABLE [dbo].[customers];
GO
IF OBJECT_ID(N'[dbo].[employees]', 'U') IS NOT NULL
    DROP TABLE [dbo].[employees];
GO
IF OBJECT_ID(N'[dbo].[expencecategories]', 'U') IS NOT NULL
    DROP TABLE [dbo].[expencecategories];
GO
IF OBJECT_ID(N'[dbo].[expences]', 'U') IS NOT NULL
    DROP TABLE [dbo].[expences];
GO
IF OBJECT_ID(N'[dbo].[items]', 'U') IS NOT NULL
    DROP TABLE [dbo].[items];
GO
IF OBJECT_ID(N'[dbo].[salaries]', 'U') IS NOT NULL
    DROP TABLE [dbo].[salaries];
GO
IF OBJECT_ID(N'[dbo].[supplieradvances]', 'U') IS NOT NULL
    DROP TABLE [dbo].[supplieradvances];
GO
IF OBJECT_ID(N'[dbo].[supplierpaids]', 'U') IS NOT NULL
    DROP TABLE [dbo].[supplierpaids];
GO
IF OBJECT_ID(N'[dbo].[supplies]', 'U') IS NOT NULL
    DROP TABLE [dbo].[supplies];
GO
IF OBJECT_ID(N'[dbo].[supplyitems]', 'U') IS NOT NULL
    DROP TABLE [dbo].[supplyitems];
GO
IF OBJECT_ID(N'[dbo].[variances]', 'U') IS NOT NULL
    DROP TABLE [dbo].[variances];
GO
IF OBJECT_ID(N'[dbo].[vendors]', 'U') IS NOT NULL
    DROP TABLE [dbo].[vendors];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'admins'
CREATE TABLE [dbo].[admins] (
    [id] int IDENTITY(1,1) NOT NULL,
    [name] varchar(50)  NULL,
    [pass] varchar(255)  NULL,
    [role] int  NULL,
    [email] varchar(50)  NULL,
    [sync_id] int  NULL,
    [lastsync] datetime  NULL,
    [updated_at] datetime  NULL,
    [created_at] datetime  NULL
);
GO

-- Creating table 'advances'
CREATE TABLE [dbo].[advances] (
    [id] int IDENTITY(1,1) NOT NULL,
    [employee_id] int  NULL,
    [amount] decimal(18,4)  NULL,
    [dates] datetime  NULL,
    [sync_id] int  NULL,
    [lastsync] datetime  NULL,
    [updated_at] datetime  NULL,
    [created_at] datetime  NULL,
    [year] int  NULL,
    [month] int  NULL,
    [day] int  NULL
);
GO

-- Creating table 'billitems'
CREATE TABLE [dbo].[billitems] (
    [id] int IDENTITY(1,1) NOT NULL,
    [item_id] int  NULL,
    [rate] decimal(18,4)  NULL,
    [amount] decimal(18,4)  NULL,
    [bill_id] int  NULL,
    [sync_id] int  NULL,
    [lastsync] datetime  NULL,
    [updated_at] datetime  NULL,
    [created_at] datetime  NULL,
    [quantity] decimal(18,4)  NULL
);
GO

-- Creating table 'bills'
CREATE TABLE [dbo].[bills] (
    [id] int IDENTITY(1,1) NOT NULL,
    [dates] datetime  NULL,
    [customer_id] int  NULL,
    [total] decimal(18,4)  NULL,
    [paid] decimal(18,4)  NULL,
    [due] decimal(18,4)  NULL,
    [sync_id] int  NULL,
    [lastsync] datetime  NULL,
    [updated_at] datetime  NULL,
    [created_at] datetime  NULL,
    [grosstotal] decimal(18,4)  NULL,
    [discount] decimal(18,4)  NULL,
    [tax] decimal(18,4)  NULL,
    [year] int  NULL,
    [month] int  NULL,
    [day] int  NULL,
    [bill_no] varchar(max)  NULL
);
GO

-- Creating table 'categories'
CREATE TABLE [dbo].[categories] (
    [id] int IDENTITY(1,1) NOT NULL,
    [name] varchar(50)  NULL,
    [sync_id] int  NULL,
    [lastsync] datetime  NULL,
    [updated_at] datetime  NULL,
    [created_at] datetime  NULL
);
GO

-- Creating table 'customerpaids'
CREATE TABLE [dbo].[customerpaids] (
    [id] int IDENTITY(1,1) NOT NULL,
    [paiddate] datetime  NULL,
    [amount] decimal(18,0)  NULL,
    [customer_id] int  NULL,
    [year] int  NULL,
    [month] int  NULL,
    [day] int  NULL
);
GO

-- Creating table 'customers'
CREATE TABLE [dbo].[customers] (
    [id] int IDENTITY(1,1) NOT NULL,
    [name] varchar(50)  NULL,
    [adress] varchar(50)  NULL,
    [phone] varchar(15)  NULL,
    [email] varchar(50)  NULL,
    [lastvisit] datetime  NULL,
    [due] decimal(18,4)  NULL,
    [sync_id] int  NULL,
    [lastsync] datetime  NULL,
    [updated_at] datetime  NULL,
    [created_at] datetime  NULL
);
GO

-- Creating table 'employees'
CREATE TABLE [dbo].[employees] (
    [id] int IDENTITY(1,1) NOT NULL,
    [name] varchar(50)  NULL,
    [adress] varchar(50)  NULL,
    [phone] varchar(15)  NULL,
    [photo] varchar(200)  NULL,
    [docs] varchar(1000)  NULL,
    [startdate] datetime  NULL,
    [salary] decimal(18,4)  NULL,
    [email] varchar(50)  NULL,
    [sync_id] int  NULL,
    [lastsync] datetime  NULL,
    [updated_at] datetime  NULL,
    [created_at] datetime  NULL
);
GO

-- Creating table 'expencecategories'
CREATE TABLE [dbo].[expencecategories] (
    [id] int IDENTITY(1,1) NOT NULL,
    [name] varchar(50)  NULL,
    [sync_id] int  NULL,
    [lastsync] datetime  NULL,
    [updated_at] datetime  NULL,
    [created_at] datetime  NULL
);
GO

-- Creating table 'expences'
CREATE TABLE [dbo].[expences] (
    [id] int IDENTITY(1,1) NOT NULL,
    [expencecategory_id] int  NULL,
    [dates] datetime  NULL,
    [amount] decimal(18,4)  NULL,
    [descriptions] varchar(1000)  NULL,
    [sync_id] int  NULL,
    [lastsync] datetime  NULL,
    [updated_at] datetime  NULL,
    [created_at] datetime  NULL,
    [name] varchar(50)  NULL,
    [year] int  NULL,
    [month] int  NULL,
    [day] int  NULL
);
GO

-- Creating table 'items'
CREATE TABLE [dbo].[items] (
    [id] int IDENTITY(1,1) NOT NULL,
    [name] varchar(50)  NULL,
    [category_id] int  NULL,
    [pic] varchar(200)  NULL,
    [exps] datetime  NULL,
    [Discription] varchar(1000)  NULL,
    [sync_id] int  NULL,
    [lastsync] datetime  NULL,
    [updated_at] datetime  NULL,
    [created_at] datetime  NULL,
    [stock] decimal(18,4)  NULL,
    [rate] decimal(18,4)  NULL,
    [itemcode] varchar(max)  NULL,
    [barcode] varchar(max)  NULL
);
GO

-- Creating table 'salaries'
CREATE TABLE [dbo].[salaries] (
    [id] int IDENTITY(1,1) NOT NULL,
    [employee_id] int  NULL,
    [amount] decimal(18,4)  NULL,
    [form] datetime  NULL,
    [toto] datetime  NULL,
    [dates] datetime  NULL,
    [sync_id] int  NULL,
    [lastsync] datetime  NULL,
    [updated_at] datetime  NULL,
    [created_at] datetime  NULL,
    [year] int  NULL,
    [month] int  NULL,
    [day] int  NULL
);
GO

-- Creating table 'supplieradvances'
CREATE TABLE [dbo].[supplieradvances] (
    [id] int IDENTITY(1,1) NOT NULL,
    [amount] decimal(18,2)  NULL,
    [vendor_id] int  NULL,
    [year] int  NULL,
    [month] int  NULL,
    [day] int  NULL
);
GO

-- Creating table 'supplierpaids'
CREATE TABLE [dbo].[supplierpaids] (
    [id] int IDENTITY(1,1) NOT NULL,
    [paiddate] datetime  NULL,
    [amount] decimal(18,0)  NULL,
    [supplier_id] int  NULL,
    [year] int  NULL,
    [month] int  NULL,
    [day] int  NULL
);
GO

-- Creating table 'supplies'
CREATE TABLE [dbo].[supplies] (
    [id] int IDENTITY(1,1) NOT NULL,
    [vendor_id] int  NULL,
    [transport_cost] decimal(18,4)  NULL,
    [dates] datetime  NULL,
    [total] decimal(18,4)  NULL,
    [paid] decimal(18,4)  NULL,
    [due] decimal(18,4)  NULL,
    [sync_id] int  NULL,
    [lastsync] datetime  NULL,
    [updated_at] datetime  NULL,
    [created_at] datetime  NULL,
    [vendorname] varchar(30)  NULL,
    [discount] decimal(18,0)  NULL,
    [tax] decimal(18,0)  NULL,
    [grosstotal] decimal(18,0)  NULL,
    [year] int  NULL,
    [month] int  NULL,
    [day] int  NULL,
    [bill_num] varchar(max)  NULL,
    [bill_no] varchar(max)  NULL
);
GO

-- Creating table 'supplyitems'
CREATE TABLE [dbo].[supplyitems] (
    [id] int IDENTITY(1,1) NOT NULL,
    [supply_id] int  NULL,
    [item_id] int  NULL,
    [amount] decimal(18,4)  NULL,
    [rate] decimal(18,4)  NULL,
    [sync_id] int  NULL,
    [lastsync] datetime  NULL,
    [updated_at] datetime  NULL,
    [created_at] datetime  NULL,
    [quantity] decimal(18,0)  NULL
);
GO

-- Creating table 'variances'
CREATE TABLE [dbo].[variances] (
    [id] int IDENTITY(1,1) NOT NULL,
    [item_id] int  NULL,
    [name] varchar(50)  NULL,
    [price] decimal(18,4)  NULL,
    [stock] decimal(18,4)  NULL,
    [sync_id] int  NULL,
    [lastsync] datetime  NULL,
    [updated_at] datetime  NULL,
    [created_at] datetime  NULL
);
GO

-- Creating table 'vendors'
CREATE TABLE [dbo].[vendors] (
    [id] int IDENTITY(1,1) NOT NULL,
    [name] varchar(50)  NULL,
    [adress] varchar(50)  NULL,
    [phoneno] varchar(15)  NULL,
    [email] varchar(50)  NULL,
    [due] decimal(18,4)  NULL,
    [advance] decimal(18,4)  NULL,
    [panno] varchar(20)  NULL,
    [vatno] varchar(20)  NULL,
    [sync_id] int  NULL,
    [lastsync] datetime  NULL,
    [updated_at] datetime  NULL,
    [created_at] datetime  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [id] in table 'admins'
ALTER TABLE [dbo].[admins]
ADD CONSTRAINT [PK_admins]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'advances'
ALTER TABLE [dbo].[advances]
ADD CONSTRAINT [PK_advances]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'billitems'
ALTER TABLE [dbo].[billitems]
ADD CONSTRAINT [PK_billitems]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'bills'
ALTER TABLE [dbo].[bills]
ADD CONSTRAINT [PK_bills]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'categories'
ALTER TABLE [dbo].[categories]
ADD CONSTRAINT [PK_categories]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'customerpaids'
ALTER TABLE [dbo].[customerpaids]
ADD CONSTRAINT [PK_customerpaids]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'customers'
ALTER TABLE [dbo].[customers]
ADD CONSTRAINT [PK_customers]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'employees'
ALTER TABLE [dbo].[employees]
ADD CONSTRAINT [PK_employees]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'expencecategories'
ALTER TABLE [dbo].[expencecategories]
ADD CONSTRAINT [PK_expencecategories]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'expences'
ALTER TABLE [dbo].[expences]
ADD CONSTRAINT [PK_expences]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'items'
ALTER TABLE [dbo].[items]
ADD CONSTRAINT [PK_items]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'salaries'
ALTER TABLE [dbo].[salaries]
ADD CONSTRAINT [PK_salaries]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'supplieradvances'
ALTER TABLE [dbo].[supplieradvances]
ADD CONSTRAINT [PK_supplieradvances]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'supplierpaids'
ALTER TABLE [dbo].[supplierpaids]
ADD CONSTRAINT [PK_supplierpaids]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'supplies'
ALTER TABLE [dbo].[supplies]
ADD CONSTRAINT [PK_supplies]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'supplyitems'
ALTER TABLE [dbo].[supplyitems]
ADD CONSTRAINT [PK_supplyitems]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'variances'
ALTER TABLE [dbo].[variances]
ADD CONSTRAINT [PK_variances]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'vendors'
ALTER TABLE [dbo].[vendors]
ADD CONSTRAINT [PK_vendors]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [employee_id] in table 'advances'
ALTER TABLE [dbo].[advances]
ADD CONSTRAINT [FK__advances__employ__2E1BDC42]
    FOREIGN KEY ([employee_id])
    REFERENCES [dbo].[employees]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__advances__employ__2E1BDC42'
CREATE INDEX [IX_FK__advances__employ__2E1BDC42]
ON [dbo].[advances]
    ([employee_id]);
GO

-- Creating foreign key on [bill_id] in table 'billitems'
ALTER TABLE [dbo].[billitems]
ADD CONSTRAINT [FK__billitems__bill___1FCDBCEB]
    FOREIGN KEY ([bill_id])
    REFERENCES [dbo].[bills]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__billitems__bill___1FCDBCEB'
CREATE INDEX [IX_FK__billitems__bill___1FCDBCEB]
ON [dbo].[billitems]
    ([bill_id]);
GO

-- Creating foreign key on [item_id] in table 'billitems'
ALTER TABLE [dbo].[billitems]
ADD CONSTRAINT [FK__billitems__item___1ED998B2]
    FOREIGN KEY ([item_id])
    REFERENCES [dbo].[items]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__billitems__item___1ED998B2'
CREATE INDEX [IX_FK__billitems__item___1ED998B2]
ON [dbo].[billitems]
    ([item_id]);
GO

-- Creating foreign key on [customer_id] in table 'bills'
ALTER TABLE [dbo].[bills]
ADD CONSTRAINT [FK__bills__customer___1BFD2C07]
    FOREIGN KEY ([customer_id])
    REFERENCES [dbo].[customers]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__bills__customer___1BFD2C07'
CREATE INDEX [IX_FK__bills__customer___1BFD2C07]
ON [dbo].[bills]
    ([customer_id]);
GO

-- Creating foreign key on [category_id] in table 'items'
ALTER TABLE [dbo].[items]
ADD CONSTRAINT [FK__items__category___1273C1CD]
    FOREIGN KEY ([category_id])
    REFERENCES [dbo].[categories]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__items__category___1273C1CD'
CREATE INDEX [IX_FK__items__category___1273C1CD]
ON [dbo].[items]
    ([category_id]);
GO

-- Creating foreign key on [customer_id] in table 'customerpaids'
ALTER TABLE [dbo].[customerpaids]
ADD CONSTRAINT [FK__customerp__custo__05D8E0BE]
    FOREIGN KEY ([customer_id])
    REFERENCES [dbo].[customers]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__customerp__custo__05D8E0BE'
CREATE INDEX [IX_FK__customerp__custo__05D8E0BE]
ON [dbo].[customerpaids]
    ([customer_id]);
GO

-- Creating foreign key on [employee_id] in table 'salaries'
ALTER TABLE [dbo].[salaries]
ADD CONSTRAINT [FK__salaries__employ__2B3F6F97]
    FOREIGN KEY ([employee_id])
    REFERENCES [dbo].[employees]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__salaries__employ__2B3F6F97'
CREATE INDEX [IX_FK__salaries__employ__2B3F6F97]
ON [dbo].[salaries]
    ([employee_id]);
GO

-- Creating foreign key on [expencecategory_id] in table 'expences'
ALTER TABLE [dbo].[expences]
ADD CONSTRAINT [FK__expences__expenc__32E0915F]
    FOREIGN KEY ([expencecategory_id])
    REFERENCES [dbo].[expencecategories]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__expences__expenc__32E0915F'
CREATE INDEX [IX_FK__expences__expenc__32E0915F]
ON [dbo].[expences]
    ([expencecategory_id]);
GO

-- Creating foreign key on [item_id] in table 'supplyitems'
ALTER TABLE [dbo].[supplyitems]
ADD CONSTRAINT [FK__supplyite__item___267ABA7A]
    FOREIGN KEY ([item_id])
    REFERENCES [dbo].[items]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__supplyite__item___267ABA7A'
CREATE INDEX [IX_FK__supplyite__item___267ABA7A]
ON [dbo].[supplyitems]
    ([item_id]);
GO

-- Creating foreign key on [item_id] in table 'variances'
ALTER TABLE [dbo].[variances]
ADD CONSTRAINT [FK__variances__item___15502E78]
    FOREIGN KEY ([item_id])
    REFERENCES [dbo].[items]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__variances__item___15502E78'
CREATE INDEX [IX_FK__variances__item___15502E78]
ON [dbo].[variances]
    ([item_id]);
GO

-- Creating foreign key on [vendor_id] in table 'supplieradvances'
ALTER TABLE [dbo].[supplieradvances]
ADD CONSTRAINT [FK__suppliera__vendo__2BFE89A6]
    FOREIGN KEY ([vendor_id])
    REFERENCES [dbo].[vendors]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__suppliera__vendo__2BFE89A6'
CREATE INDEX [IX_FK__suppliera__vendo__2BFE89A6]
ON [dbo].[supplieradvances]
    ([vendor_id]);
GO

-- Creating foreign key on [supplier_id] in table 'supplierpaids'
ALTER TABLE [dbo].[supplierpaids]
ADD CONSTRAINT [FK__supplierp__suppl__02FC7413]
    FOREIGN KEY ([supplier_id])
    REFERENCES [dbo].[vendors]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__supplierp__suppl__02FC7413'
CREATE INDEX [IX_FK__supplierp__suppl__02FC7413]
ON [dbo].[supplierpaids]
    ([supplier_id]);
GO

-- Creating foreign key on [vendor_id] in table 'supplies'
ALTER TABLE [dbo].[supplies]
ADD CONSTRAINT [FK__supplies__vendor__22AA2996]
    FOREIGN KEY ([vendor_id])
    REFERENCES [dbo].[vendors]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__supplies__vendor__22AA2996'
CREATE INDEX [IX_FK__supplies__vendor__22AA2996]
ON [dbo].[supplies]
    ([vendor_id]);
GO

-- Creating foreign key on [supply_id] in table 'supplyitems'
ALTER TABLE [dbo].[supplyitems]
ADD CONSTRAINT [FK__supplyite__suppl__25869641]
    FOREIGN KEY ([supply_id])
    REFERENCES [dbo].[supplies]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__supplyite__suppl__25869641'
CREATE INDEX [IX_FK__supplyite__suppl__25869641]
ON [dbo].[supplyitems]
    ([supply_id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------