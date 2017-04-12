# RecCenter
1. Introduction
1.1	Overview of the Lamar University Recreational Center
The Lamar University Recreational Sports department consists of Fitness and Wellness Center, Intramural Sports Department, Sport Clubs, Outdoor Pursuits, Aquatics, and Informal Recreation. The facilities of recreational sports are the Sheila Umphrey Recreational Sports Center, the Indoor Pool, and the Golf Driving Range. The mission of the Department of Recreational Sports as mentioned on their website is to provide the finest programs, services, facilities, and equipment to develop the learning experience in the university and have maximum involvement of the students, faculty, staff, and alumni. The main priority within the Department of Recreational Sports is to provide a positive environment for all the visitors. There are three types of users who interact with the Rec center facility: - 
1.1.1	The Administrative Staff: -
The Administrative staffs are full-time employees at the university. They are the team which performs the managerial roles, which include, 
-	Director of recreational sports
-	Associate Director
-	Operations Manager
-	Administrative Assistant 
-	Student Development Coordinator

1.1.2	The Student Employee
A Student Employee is any full-time student, studying at the University who is hired by the Rec Sports Management to work for the Center. He cannot work for more than 20 hours a week. He can either supervise over the main gym, or Sign-in the visitors at the reception (turnstile), or provide equipment requested by the visitor. 
1.1.3	The Visitor
A visitor is any person who would like to use the facilities of the Rec sports with an appropriate access.
1.2	The Existing System
Instead of one centralized system, multiple softwares are used by the Recreational center to manage their work. In the existing system, a software program is installed at the Turnstile desk, which is used to sign in the visitors to the system. Another software program is installed at the equipment desk to lend equipment to the visitor. A completely different system is used by the department of Rec Sports, where the administrative staff can create shifts and the student employees can pick them up. The record for the payroll is kept by a system which has nothing to do with the previous ones.
1.3	Limitations of the Existing System
1.3.1 Reception or Turnstile: - 
-	The employee at the reception has to manually enter the person’s number. During peak hours, this causes a long waiting queue.
-	The user interaction of the system is also very poor. The software is obsolete 

1.3.2 Equipment Desk: -
-	The equipment has no proper numbering, so it is very difficult to have a count of the items in the inventory.
-	It is a very tedious task to add equipment on a patrons account if he/she is opting for more than one, e.g. if a person wants to play pool, it is very unlikely that the person 
would just opt for the pool balls set, he would take the sticks and the triangle along with it as well. But to do the same task, the employee has to select the pool ball first, then go back, select the sticks, go back and then select the triangle. It becomes very tedious and frustrating for the employee. Another scenario is, if a person has taken badminton set first, now he wants to return it and take ping pong set, the employee now has to enter the details of the patron, take off the badminton set, enter the patrons number again, add the racquets, go back and add the birdies after that. This can be frustrating at times.
-	There is no log or even a check out or a check in time for any equipment. 
1.3.3 Shift Management
-	There’s complete different online software for the employees to have an access to their shifts.
-	There are no issues with this software, it is a very user friendly website, but as employees, we have to use several different softwares for various tasks, so it would less confusing if everything were on the same system.
1.3.4 Employee Management
-	Employees at the rec center are supposed to follow certain rules and guidelines. For every rule that the employee doesn’t follow or for every mistake the employee makes, he gets a point on his name and a write-up. Many times, it’s unknown to the employees that they have gotten write-ups, so they have no idea about the points accumulated on their profile which would lead to a certain disciplinary action. Also the record of the employee payroll is kept by a complete different system.
1.4	Objective of this project
The main objective of the project is to integrate all four modules of the recreational system viz. the reception counter, the equipment desk, shift management and the employee management system. 
The proposed system will include: - 
-	At the reception counter, the id card of the patron will be scanned, which will save the time the employee will take to manually enter the person’s information in the system.
-	As soon as the card is scanned, the new system will pull up all the information about the patron, viz. his personal information.
-	Here the equipment will be assigned with a barcode or a number, so as to keep a track of the equipment and the equipment number borrowed by the patron. It will also save the time required by the employee to manually enter the item. 
-	To avoid long queues at the equipment desk, the visitor can reserve an item online for himself. To implement this functionality, the system will have to be Web-based.
-	The employee management will also be integrated in this system, so the rec sports don’t have to use a different system. The employees will have an options of picking up multiple shifts in a row. If any employee has more than 19hrs in a week, he will not be allowed to pick up more shifts. Employee could also receive notifications about their upcoming shift.
-	The employer can provide write-ups to the employees and they can view the same.
1.5 Implementations of Software Principles: -
I decided to use the following software principles in my system: -
-	Software System Integration
Software System Integration is the practice of combining independently tested software modules into one integrated system.
-	Form Authentication
Implementing this principle involves creating a Log-in page that collects the user data and includes a code to validate the credentials. If the user identifications are valid, he can be allowed to access the data.
-	Human Computer Interaction
Enforcing this principle into the project would mean that the software would become more user friendly by offering new interaction possibilities.
-	Interface
Similar to java, C# and .net do not support the concept of multiple inheritances. But this concept can be supported using Interface. Interface is the concept which has only the signatures of methods, but does not have its implementation. Implementation of the methods is done by the class which implements the interface.

-	Encapsulation
Encapsulation is the concept of forming data and methods into a particular structure which conceals the pattern in which the object is executed, i.e. it prevents access to data by any means other than those specified. Through encapsulation we can have the guarantee of the integrity of the data contained in the object.
-	Optical Character Recognition
OCR (Optical Character Recognition) is the concept where we can recognize the printed or written text characters by a system. This also consists of photo-scanning of the text character-by-character, the scanned image is analyzed, and then the character image is translated into character codes, such as ASCII, commonly used in data processing.


















2. Literature Review 


To work on the Software Design, I referred the book, ‘Software Engineering – A Practitioner’s Approach’ by Roger Pressman. In Chapter 2, ‘The Process Models’, the writer states that it is important to go through a series of predictable steps which would help in creating a design that is timely and high-quality. While skimming through this chapter, I realized that it was very difficult to take a sequential and systematic approach while designing my project. Hence, instead of implementing the waterfall model, its variation, the V-model seemed more feasible to me. The V model depicts the relationship of quality assurance actions to the actions associated with communication, modeling, and early construction activities. It states that as the software team moves down the left side of the V, basic problem requirements are developed into more detailed and technical representations of the problems and their solutions. Once code has been generated, the team moves up the right side of the V while performing a series of tests (quality assurance actions) that validate each of the models the team created as they moved down the left side. I also learned that the V-model provides a systematic way of visualizing the process of which the verification and validation actions are applied to earlier engineering work. In Chapter 11, ‘User Interface Design’, the author talks about designing user-interaction modes in such a way that they do not force users into unnecessary actions. This reminded me about the poor user-interaction with the existing system at the Rec center, which can be frustrating for the employees who work for long shifts. While designing a UI, the author asks readers to focus on three golden rules, namely: 1) Place the User in Control. 2) Reduce the User’s Memory Load. 3)Make Interface Consistent. This chapter explains how users prefer a system that functions according to his wishes, and not the wishes of the computer. This chapter mentions user-interaction, too. It explains the importance of implementing shortcuts in the application, so the user doesn’t have to often rely on his memory. My emphasis was also on chapter 13, which concentrated on Web Application Design. It helped me understand that my design goals had to have simplicity, consistency, identity, robustness, navigability, and visual appeal. This book also helped me focus on the Quality Requirements for a Web App like: 1) Usability, which includes features like Global site understandability, Online feedback and help features, Interface and aesthetic features, and Special features. 2) Functionality, which includes features like Searching and retrieving capability, Navigation and browsing features, and Application domain-related features. 3) Reliability, which has features like Correct link processing, Error recovery, and User input validation and recovery. 4) Efficiency, which has features like Response time performance, Page generation speed, and Graphics generation speed. 5) Maintainability, having features like Ease of correction, Adaptability, and Extensibility.
The research paper titled ‘IT Security Review: Privacy, Protection, Access Control, Assurance and System Security’ by Feruza and Kim gave me a broader idea about the software principles I wanted to implement in the project. This paper claims that although the terms information security, computer security, and information assurance are commonly interchanged, there is a subtle difference between all three of them. A common goal of protecting the CIA (Confidentiality, Integrity and Availability) principles is shared by them. The difference between them is based on the approach, methodologies, and the area of concentration that we choose for our project. The concepts of various software principles like Confidentiality, Integrity, Availability, Authenticity, Non-Repudiation, and Risk Management are adequately explained in this paper. This paper made me understand the fact that institutions like universities and private businesses amass a great deal of confidential information about their employees, products, customers, and financial statuses. Protecting the confidential information in many cases is an ethical and legal requirement. This paper also encouraged me in implementing Administrative Controls (e.g. Passwords must have at least one non letter or digit character, one lowercase letter and one uppercase letter) to mitigate any future risks involved. It also helped me understand the importance of implementing access control for the system, viz. the administrator can perform all operations, student employees can perform a few operations, etc. In this paper, the author also talks about how the information should be protected throughout its lifespan i.e. from its initial creation until it is destroyed. In order to enforce information protection, every component must have its own mechanism. To summarize this paper, I understood the necessity of data protection for my project.
To implement the database in my project, I had to refer to the book ‘Practical Database Programming with Visual C#.NET’ by Ying Bai. Chapter 2 discusses building a database. It discusses various steps like 1) Planning and Analysis 2) Conceptual Design 3) Logical Design 4) Physical Design 5) Implementations. Importance of a relational model is also explained in this chapter. It states that a well-planned model can give consistent results and can allow for changes if necessary. It further goes to explain the Entity relationship model. While referring this book, in Chapter 4, I understood the concept of LINQ (Language-Integrated Query). It amazed me that we can use the same type of syntax to execute queries from any kind of database, therefore I decided to use this in the project. It explains how using Visual Studio.NET one can write LINQ queries in C# with SQL Server databases and XML documents. LINQ queries can be used in projects alongside non-LINQ queries, the only requirement being the project be developed under the .NET Framework 3.5 or a better. This book claims that all LINQ query operations consist of three distinct actions:1) Obtaining the data source. 2) Creating the query. 3)  Executing the query. Chapter 8 explains how the data can be accessed in asp.net. The .NET framework is a system used to develop and integrate multiple applications like Windows, web-based, and xml-using tools like Visual C#.NET or Visual Basic.NET. Since the application can be accessed from different web browsers, this chapter helped me understand that the .NET framework and overcome this limitation. While refereeing to the book I came across MSIL feature provided by the .NET framework, which is language independent and platform independent, and allows all programs developed in any .NET - based language to be converted into this MSIL. The MSIL can be recognized by the Common Language Runtime (CLR), and the CLR can compile and execute the MSIL codes by using the Just-In-Time compiler located at the local machines or clients.
This project involves integrating many systems together, hence I referred to the dissertation titled “Software Systems In-House Integration” by Rikard Land. In this dissertation, it is explained how Software Evolution is a crucial activity for various organizations. The Software evolution process involves integrating the previously isolated systems. The main purpose of software integration is to increase the value of users of various systems by combining their functionality and being able to reduce the functionality overlap. This dissertation states that if the systems are completely owned and controlled in-house, there are other advantages in rationalizing the use of internal resources by minimizing the amount of software with the same purpose. In this thesis, Rikard has combined two perspectives: software architecture and processes. The perspective of software architecture is used to show how compatibility analysis and development of integration alternatives can be performed rapidly at a high level of abstraction. The software process perspective has led to the identification of important characteristics and practices of the integration process. The goal of this research was to develop a systematic approach that would lead to a more efficient and predictable process for executing future in-house system integration projects. To achieve this, the author surveyed, evaluated, and generalized existing practices in a number of organizations, which resulted in the formulation of guidelines for the in-house integration process. The thesis focuses on the early vision process, which should be carried out relatively rapidly while ensuring enough coverage of the most important considerations. The thesis helped my project in providing guidelines at a very high and practical level.






3. Software Design Approach 
3.1	Feasibility study: - 
The feasibility study is a formal proposal for a new system. Before I could start designing the project, I tried to determine what exactly the user might want depending upon the result of initial investigation. The survey is expanded to more detailed study.
3.2	Survey: - 
In order to make sure that I was not the only one who wanted an integrated system at the recreational center, I decided to perform a survey and ask for the responses of other student employees working at the Rec center.
Amongst the 50 employees who were requested to answer the survey, only 9 responded. 
Survey Question 1

Figure 3.2 1
Of these 9 employees, about 44% of them have been here less than 6 months and only about 11% of them have been working for more than a year. 



Survey Question 2

Figure 3.2 2
About 89% of the employees who responded, said that they would be more comfortable with a centralized system rather than using different softwares. 
3.3	System analysis: -
Once I had performed the requirement analysis, in this phase I tried studying and understanding the whole procedure in order to identify the goals and purposes. The challenge was to create the systems and the procedures which would achieve them in an efficient way. The steps include outlining the problem and trying to understand the present methods of solving the problems. It includes preliminary survey/initial investigation as well.
3.4	Programming Language and Software Tools used: -
This project was all about creating a good architecture in implementing various guidelines used for designing web application which would interact with back-end databases. 
As part of this project, the Recreational Center Module was taken as the important use-case.
The project was implemented using the following Technologies and IDE’s: -
1.	.NET Framework 4.5
2. 	asp.NET
3. 	C#
4.	Entity Framework 6.0
5.	Microsoft Visual Studio Community 2015
6.	Microsoft SQL Server Management Studio 2016
7.	Microsoft SharePoint Designer 2013
3.5	System Architecture: -
Designing the system architecture was most creative and challenging phase of this project. The process was all about defining the architecture, components, modules, interfaces, and data for a system to satisfy specified requirements. 
The Architecture of the software is divided in 4 modules: -
3.5.1	The Business Layer
This layer of the code deals with business logic and is a medium of interaction between the User Interface and the data-access layer. It defines business rules, providing validation or performing data conversions. C# programming is used to create the code in these files.
3.5.2	The Data Access Layer
This layer accesses the data from the database. This is the only layer that interacts with the database and contains the SQL statements to be used for the interactions.



Figure 3.5.2 1
3.5.3	The Entity Layer
This layer holds the property of the entity in the application, e.g. the properties of the user like name, id, age etc. are present in this layer
3.5.4	User Interface
The User Interface deals with HTML, CSS, and the page design of the code. As the name suggests, the UI deals with the content shown on the browser and the interaction with the web browser. No business logic or database interaction logic is part of this code.
3.5.5	Database
The design of the database for this project was done from the basic level. I         have used Microsoft SQL Server to design the database. The database involves various tables which represent multiple users, their roles, status. There are also tables which have equipment’s and their details. Different database concepts such as constraints (primary key, foreign key, not-null) are implemented.


Here is an example of the database of all the users of the system.

3.6	Design Flowchart
The Process of System design followed and its feasibility can be illustrated as follows: -

Figure 3.6 1
3.7	User Responsibilities 
The system has 3 types of users viz.
3.7.1 Regular Visitor: - 
A regular visitor has the following options when he logs in: - 
i.	View his entry history
ii.	Request for items from equipment desk
iii.	View/ Edit his personal details.
3.7.2 Student Employee 
A Student Employee can perform all the duties performed by a visitor in addition to: -
i.	View /Edit details of other visitors
ii.	Can Sign in to the Turnstile System 
a.	Can provide entry to visitors through turnstile
b.	View the turnstile log
iii.	Can sign in to the Equipment system 
a.	Can check-in/ Checkout equipment’s to visitors through the system
b.	Check requests made for any equipment’s
c.	View the equipment log
iv.	Shifts
a.	Can check for available shifts
b.	Can pick up shifts
c.	Can drop shifts 
d.	Check his work history
v.	Payments: - 
a.	Can check his payment history
vi.	Write-ups’
a.	Can view for write-ups given to him by the employer if any
3.7.3 Administrator: - 
An Administrator can perform all the duties that are performed by the student employee in addition to: -
i.	Add / remove/ Edit employees
ii.	Grant/ Revoke privileges to the employees
iii.	Can sign out an employee from the turnstile system
iv.	View Employee login history in the system
v.	Can add remove equipment’s
vi.	Can sign out an employee from the system
vii.	Shifts
a.	Create shifts
b.	Delete Shifts
c.	Assign shifts
d.	Drop shifts of other employees 
e.	Check work history for the employees
viii.	Payments: - 
a.	Make payment
b.	Check payment history of the employees
ix.	Write-ups’
a.	View for write-ups given to the employees
b.	Give write-ups
c.	Delete write-ups















4.  Activity Diagrams
4.1 E-R Diagram
E-R diagram is widely used in database design to-
-	Represent conceptual level of a database system
-	Describe things and their relationships in high level.
4.1.1 Basic Concepts
-	Entity set –  it is an abstraction of similar things, 
-	Attributes – they are the common properties of the entities in an entity sets
-	Relationship – they specify the relations among entities from two or more entity        sets
4.1.2 Mapping cardinality of a relationship (refer fig. 4.1.3)
Mapping cardinalities refer to expressing the number of entities to which another entity can be associated via a relationship set.
The cardinalities implemented in this project are: - 
One-to-One
For example: - One visitor has one membership.
-	One-to-Many 
For example: - One Equipment desk has much equipment.
-	Many to One
For example: - Many employees can access one turnstile desk
-	Many to Many 
For example: - Many admins can hire many employees.
4.1.3. E-R Diagram of Overall System

Figure 4.1.3 1
  4.1.4. E-R Diagram for Employee Management

Figure 4.1.4 1
4.2 Entity Framework Diagram
It is an Object/Relational Mapping (O/RM) framework, which is also an improvement to ADO.NET model that provides programmers a programmed mechanism to access and store the data in the database. Entity framework is beneficial in three scenarios. First, if a user already has designed a database or he wants to design a database before designing the other parts of the application. Second, if he wants to focus on the domain classes and later create the database from the domain classes. Third, if he wants to create the database schema first and then create the database and the classes. 
4.2.1 Entity Framework Diagram

Figure 4.2.1 1
5. Testing 
Testing has been a very important phase of this project.
I performed testing for two main purposes: - 
-	Validation: - Am I doing the right job?
-	Verification: - Am I doing the job right?
There are three reasons to test the program: -
-	Correctness
-	Implementation efficiency
-	Computational complexity
The levels of my testing included: -
-	Unit testing: - 
In Unit testing, I tested one module of the system at a time. Initially I designed the independent web pages and then tested them individually. Once I realized that the pages were functioning properly, I began designing the forms and tested them independently.



	 	 	
-	Integration Testing/ Incremental Integration Testing: - 
In this phase, I integrated two or more modules and then tested them for errors. For example, if the admin creates a shift on the ‘CreateShift’ page, the employee shall be able to view it on the update on the ‘PickShift’ page. Another example would be, if a certain table is altered, the result should be reflected in the database and also while viewing the database table in the program.
-	End-to-End testing: -
Since I did not have an access to the real world data I tested the application in situations that mimicked the real world data. For example, the database that I used was a dummy one, or since I could not implement the barcode functionality, I had to use the OCR technic to retrieve the number which represented the user-id from the image.8
-	Beta-Testing: -
Beta-testing refers to the testing done by the end-user. I requested a team with only a small amount people which was comprised of my colleagues and close peers from Lamar University to review the system. Many of the users were excited by the concept of an integrated system. The employees especially preferred this system where they would be able to access all the components in one place.8


6. Conclusion
-	The important objective of designing this system was to have all the modules of the Recreational Center in one place. I did show this project to some of my colleagues working at the recreational center, they were excited about implementing such an idea which would ensure that they wouldn’t have to sign-in into different systems to access the different modules.
-	This system is more user-friendly than the previous one.
-	At the turnstile or the reception counter, where the employee would manually enter the ID, they can scan the same ID’s in this system. This approach can save lot of time during peak hours.
-	Equipment checkout and check-in are easier.
-	In the old system, it would be difficult for the employee to reserve multiple items for a single user; this system overcomes that limitation.
-	This system allows visitors or patrons to reserve their equipment online so long queues at the equipment desk can be avoided.
-	There is no need for the employees to use a different application to pick-up and drop shifts; they can use the same application using this system.
-	Initially, the employees couldn’t view the write-ups provided to them, they can now view their write-ups in this system.


7.	Limitations and Suggestions for future work
Software Evolution is the process of updating a system on a consistent basis to achieve better results. Although I have managed to integrate all of the components necessary for the system to function, I was not able to achieve the level of accuracy that I originally desired. For example, the components that have been implemented are functioning, but they would be much more efficient if further depth and intricate details would have been implemented. Time constraint, man-power, and limitations of my knowledge were the factors that refrained me from creating a more in depth and intricate system. 
Currently, the system can be accessed only on computer. I haven’t tested it on mobile versions. In addition to the principles discussed above, had time permitted, I wanted to implement the feature where the systems could be accessed by multiple users from multiple systems. It can only be accessed from one system for now. 
Due to University Policies, I could not have access to the real time data. This system can be enhanced by using real time data, should the University decide to implement it. 
An extra feature of a Chatroom could be added to this project, where the employees and the management could interact with each other. This could be useful when the employees want to pick up or drop their shifts. As the technology is moving more and more towards mobile applications, this application could be created for Android, iOS, and Windows phone users. 




			
8. References


1.	Pressman, Roger, 2010, Chapter 2, ‘The Process Models’, Chapter 11, ‘User-Interface Design’, Chapter 13, ‘Web App Design’ in Software Engineering: A Practitioners Approach, Tata McGraw-Hill Publications, VII Edition, 
2.	Sattarova Feruza Y. and Prof.Tao-hoon, IT Security Review: Privacy, Protection, Access Control, Assurance and System Security, International Journal of Multimedia and Ubiquitous Engineering Vol. 2 No. 2 April 2007, 
3.	Bai, Ying, 2009, Chapter 2, ‘Introduction to Databases’, Chapter 4, ‘Introduction to Language-Integrated Query’, Chapter 8 ‘Accessing Data in ASP.NET’ in Practical Database Programming with Visual C#.NET, IEEE Press.
4.	Land Rikard, 2007, Software System In-House Integration, Observation and Guidelines Concerning Architecture and Process, Department of Computer Science and Electronics, Malden University.









9.	Appendix
9.1 Guidelines to run the project
The project is designed using ASP.NET and C# by using .Net framework 4.5. The software development requirements for the project are Microsoft Visual Studio Community 2015, Microsoft SQL Server Management Studio 2016, Microsoft SharePoint Designer 2013, the sharepoint is used for image processing only.  The Application is communicating with data base through ORM (Object Relation Mapping ie. Entity framework 6.0).   The project comprises of a .rar file which has all the forms, web pages and the methods implemented in it and a database backup file (LURecCenter.bak). Extract the .rar files in a folder and store the database in the following location ‘..\MicrosoftSQLServer\MSSQL13.MSSQLSERVER\MSSQL\Backup’. Then add the database using ‘Restore Database’ option in Microsoft SQL Server Management Studio. Make changes in the ‘connectionstring’ function by giving the source of your database in the following files, ‘Web.config’ which can be found in the ‘LURecCenterWeb.UI’ and ‘App.config’ which can be found in ‘LURecCenter.DAL’. Press ‘F5’ or select the option ‘Debug’ from ‘Debug Menu’. The project provides best results when the ‘Google Chrome’ browser is used. 
