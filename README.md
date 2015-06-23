# VS2013
Visual Studio 2013 Projects
Tech Squad ePos
This is the development of a point of sale and back office system for Computer Shops, I have started it because 
I want to use it in my computer shop but it is also a learning project as this is my first real programming project 
since VB6. I started to do this a couple of years ago and realised that I really didn't have the skills, so I have 
been trying to improve my programming skills, I also started it again as another new project but both of the old 
projects were aborted as they were rubbish. When I started this one I wrote a feature list first and then attempted 
to implement the features on the list, this has been working much better and I feel that this project has real potential 
to deliver the type of system I want to use in my business.

Why:
For many years I have been using an ePos system in my shop, in fact a number of systems over the years, however no one 
system ever delivers all the features I want, because really I need ePos, messaging, workshop control, invoicing, reminders,
margeting and support tickets all in one system, I could use different software for each task but this leads to serious 
duplication of data and means that things go wrong and get missed, we have tried it and believe me it is tedious to use 
multiple systems and so people just don't input the data which causes more admin to get it right, or of course means that 
we just end up giving up on the other systems. This is what I am trying to fix and I am determined to get this done.

Goal:
The final goal is to have a working system that makes it easier to manage my business, in addition I want to make it 
available, free of charge, to other small computer shops so they can also benefit from having an integrated system.

Features that will be included (not all in there at the moment):
Pos
Sale orientated processing
Point of sale till
Returns supported
Email receipts
Barcode scanning
Receipt printing
Price management with automatic price points and markup
Stock management
Order management
Packages and assembled items supported
Cashier/Salesperson and technician tracking

Service
Offsite service bookings
Service contract tracking
Offsite visits sent to engineers phone/calendar
On site repair tracking
Support tickets can be attached to repairs
Printable repair ticket with terms and conditions
Auto generated Professional repair report for customer
Asset tag printing
Workshop tracking module
Email and SMS integrated
Customisable workflows

Back Office
Purchase orders
Goods received tracking
RMA’s
Customer returns
Label printing
Supplier management
Accounts payable 
Automated accounts reminders
Recurring invoices
Reporting
Stock management
Inventory pictures

Marketing
CRM System
Contact tracking
Reward cards
Newsletter integration
Mailing list management
Diary with automatic letter/SMS or email generation

e-commerce
Exports products and prices to website via csv or xml
Import products and prices from suppliers csv or xml feeds

General Features
Supports MySql or MS Sql Server
Real time reporting
Customisable System Dashboard 
Management realtime dashboard
Integration with Asterisk Phone System for reporting and caller id
Multiuser networked support
Trade-ins accepted
Store credits tracked
Gift cards vouchers created

Hardware Supported
Any USB 80cm thermal receipt printer (optional)
Any windows compatible printer (optional)
DyMo label printer 450
Any graphics tablet (optional for customer signature)
Any USB Magnetic stripe reader

Current Work 23/06/2015:
I have been working with dataTable objects and dataGridView which has been working well but after reviewing 
program design I have decided to use more classes in the program so when I am working with data I can just update the 
calss object and then throw it at the MySql class to commit the changes. Rather than spend time now re-doing existing 
work I propose to write the class objects now for all relevant classes and then implement them as I design new modules 
once all the modules are complete and ready for final testing I will re-visit the original modules and implement the 
class objects in them as well.

The priority has been to develop a core system with core functionality as quickly as possible, this has led to some 
serious corner cutting which will have to be addressed before the system goes into final testing, see ToDo for further 
details.

Coding work ToDo:
Well there is plenty to do but one of the most important jobs is to clean up the database access, I am using a class I 
have written for all database access however I am creating SQL strings and sending them to the class unchecked and some 
of the strings are built with user input so these are very, very unsafe and must be fixed before testing starts.

Error handling is almost none existant so this needs to be fixed.
