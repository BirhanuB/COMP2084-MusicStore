COMP2084_Assignment1
Dynamic ASP.NET MVC Site

Birhanu Bishaw

The purpose of this application is to manage customers and billing information for bill collection agencies using relational database models. Two models named Customer and Bill are created to store the respective data in an SQL database. The EER diagram below shows the relationship between the two entities.

EER

There is one-to-many relationship between the two models, a customer can have many unpaid bills but a bill can not have many customers, assuming that the primary account holder is responsible for any outstanding payments. Each table contains various fields that store different data types such as integer, decimal (displayed as currency), string, and datetime (displayed in mm/dd/yyyy format).

Users can perform all the CRUD functions on both entities. The SQL database is hosted on Microsoft Azure and the whole application is also deployed there. The link is provided below.

https://comp2084f19.azurewebsites.net/

I have updated the default site view by editing the css file, added background and some other images, added information to the footer, and included sample privacy and contact pages.

*All data added to the database is based on randomly generated information just for testing purposes and if any similarity exists, it is purely coincidental.