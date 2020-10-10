-- Created by Vertabelo (http://vertabelo.com)
-- Last modification date: 2019-12-16 15:10:07.128

-- tables
-- Table: Booking
CREATE TABLE Booking (
    BookingID int  NOT NULL,
    BookingDate datetime  NOT NULL,
    TableID int  NOT NULL,
    CustomerID int  NOT NULL,
    CONSTRAINT Booking_pk PRIMARY KEY  (BookingID)
);

-- Table: Category
CREATE TABLE Category (
    CategoryID int  NOT NULL,
    Name varchar(30)  NOT NULL,
    Description varchar(255)  NULL,
    ParentCategoryID int  NULL,
    CONSTRAINT Category_pk PRIMARY KEY  (CategoryID)
);

-- Table: CategoryDiscount
CREATE TABLE CategoryDiscount (
    CategoryDiscountID int  NOT NULL DEFAULT 20,
    Name varchar(100)  NOT NULL,
    CreateDate timestamp  NOT NULL,
    ValidStartDate datetime  NOT NULL,
    ValidEndDate datetime  NOT NULL,
    CouponCode varchar(20)  NOT NULL,
    DiscountPercentValue int  NOT NULL,
    MinimumOrderValue int  NOT NULL,
    CategoryID int  NOT NULL,
    CONSTRAINT CategoryDiscount_pk PRIMARY KEY  (CategoryDiscountID)
);

-- Table: Customer
CREATE TABLE Customer (
    CustomerID int  NOT NULL,
    FirstName varchar(40)  NOT NULL,
    LastName varchar(40)  NOT NULL,
    Address varchar(60)  NOT NULL,
    Phone varchar(10)  NOT NULL,
    BirthDate date  NULL,
    PostalCode varchar(10)  NOT NULL,
    Order_OrderID int  NOT NULL,
    CONSTRAINT Customer_pk PRIMARY KEY  (CustomerID)
);

-- Table: Delivery
CREATE TABLE Delivery (
    DeliveryID int  NOT NULL,
    EstimatedDeliveryTime datetime  NOT NULL,
    ActualDeliveryTime datetime  NOT NULL,
    Address varchar(100)  NOT NULL,
    DeliveryManID int  NOT NULL,
    CONSTRAINT Delivery_pk PRIMARY KEY  (DeliveryID)
);

-- Table: DeliveryMan
CREATE TABLE DeliveryMan (
    DeliveryManID int  NOT NULL,
    FirstName varchar(40)  NOT NULL,
    LastName varchar(40)  NOT NULL,
    ContactNumber varchar(10)  NOT NULL,
    CONSTRAINT DeliveryMan_pk PRIMARY KEY  (DeliveryManID)
);

-- Table: Menu
CREATE TABLE Menu (
    MenuID int  NOT NULL,
    Name varchar(100)  NOT NULL,
    StartDate datetime  NOT NULL,
    EndDate datetime  NOT NULL,
    Description text  NULL,
    CONSTRAINT Menu_pk PRIMARY KEY  (MenuID)
);

-- Table: Order
CREATE TABLE "Order" (
    OrderID int  NOT NULL,
    Amount int  NOT NULL,
    OrderType varchar(20)  NOT NULL,
    ProductID int  NOT NULL,
    DeliveryID int  NOT NULL,
    Pizza_PizzaID int  NOT NULL,
    CONSTRAINT Order_pk PRIMARY KEY  (OrderID)
);

-- Table: Pizza
CREATE TABLE Pizza (
    PizzaID int  NOT NULL,
    Name varchar(40)  NOT NULL,
    ToppingID int  NOT NULL,
    SizeID int  NOT NULL,
    MenuID int  NOT NULL,
    CategoryID int  NOT NULL,
    CONSTRAINT Pizza_pk PRIMARY KEY  (PizzaID)
);

-- Table: Product
CREATE TABLE Product (
    ProductID int  NOT NULL,
    Name varchar(50)  NOT NULL,
    Price int  NOT NULL,
    Description int  NULL,
    CONSTRAINT Product_pk PRIMARY KEY  (ProductID)
);

-- Table: Size
CREATE TABLE Size (
    SizeID int  NOT NULL,
    Name varchar(30)  NOT NULL,
    Price int  NOT NULL,
    Size varchar(20)  NOT NULL,
    CONSTRAINT Size_pk PRIMARY KEY  (SizeID)
);

-- Table: Table
CREATE TABLE "Table" (
    TableID int  NOT NULL,
    TableNumber tinyint  NOT NULL,
    NumberofSeats tinyint  NOT NULL,
    CONSTRAINT Table_pk PRIMARY KEY  (TableID)
);

-- Table: Topping
CREATE TABLE Topping (
    ToppingID int  NOT NULL,
    Name varchar(30)  NOT NULL,
    Price int  NOT NULL,
    CONSTRAINT Topping_pk PRIMARY KEY  (ToppingID)
);

-- foreign keys
-- Reference: Booking_Customer (table: Booking)
ALTER TABLE Booking ADD CONSTRAINT Booking_Customer
    FOREIGN KEY (CustomerID)
    REFERENCES Customer (CustomerID);

-- Reference: Booking_Table (table: Booking)
ALTER TABLE Booking ADD CONSTRAINT Booking_Table
    FOREIGN KEY (TableID)
    REFERENCES "Table" (TableID);

-- Reference: CategoryDiscount_Category (table: CategoryDiscount)
ALTER TABLE CategoryDiscount ADD CONSTRAINT CategoryDiscount_Category
    FOREIGN KEY (CategoryID)
    REFERENCES Category (CategoryID);

-- Reference: Customer_Order (table: Customer)
ALTER TABLE Customer ADD CONSTRAINT Customer_Order
    FOREIGN KEY (Order_OrderID)
    REFERENCES "Order" (OrderID);

-- Reference: Delivery_DeliveryMan (table: Delivery)
ALTER TABLE Delivery ADD CONSTRAINT Delivery_DeliveryMan
    FOREIGN KEY (DeliveryManID)
    REFERENCES DeliveryMan (DeliveryManID);

-- Reference: Order_Delivery (table: Order)
ALTER TABLE "Order" ADD CONSTRAINT Order_Delivery
    FOREIGN KEY (DeliveryID)
    REFERENCES Delivery (DeliveryID);

-- Reference: Order_Pizza (table: Order)
ALTER TABLE "Order" ADD CONSTRAINT Order_Pizza
    FOREIGN KEY (Pizza_PizzaID)
    REFERENCES Pizza (PizzaID);

-- Reference: Order_Product (table: Order)
ALTER TABLE "Order" ADD CONSTRAINT Order_Product
    FOREIGN KEY (ProductID)
    REFERENCES Product (ProductID);

-- Reference: ParentCategoryID (table: Category)
ALTER TABLE Category ADD CONSTRAINT ParentCategoryID
    FOREIGN KEY (ParentCategoryID)
    REFERENCES Category (CategoryID);

-- Reference: Pizza_Category (table: Pizza)
ALTER TABLE Pizza ADD CONSTRAINT Pizza_Category
    FOREIGN KEY (CategoryID)
    REFERENCES Category (CategoryID);

-- Reference: Pizza_Menu (table: Pizza)
ALTER TABLE Pizza ADD CONSTRAINT Pizza_Menu
    FOREIGN KEY (MenuID)
    REFERENCES Menu (MenuID);

-- Reference: Pizza_Size (table: Pizza)
ALTER TABLE Pizza ADD CONSTRAINT Pizza_Size
    FOREIGN KEY (SizeID)
    REFERENCES Size (SizeID);

-- Reference: Pizza_Topping (table: Pizza)
ALTER TABLE Pizza ADD CONSTRAINT Pizza_Topping
    FOREIGN KEY (ToppingID)
    REFERENCES Topping (ToppingID);

-- End of file.

