# _Eau Claire's Salon_

#### _C# ASP.NET MCV w/ MySQL Project for Epicodus, October 9th, 2020_

#### By _** Daniel Schaaf **_

## Description

This Project was to create a website for Mrs. Claire's salon so she could track stylist's and clients. she can add stylist and then add clients to the stylist by using a mySql database using a one-many relationship.
<!-- Brainstorming

 -->
### Specs
| Spec | |  |
| :-------------     | :------------- | :------------- |
|  1.  Create Stylist and Client Classes | | |
|  2.  Build Stylist Controllers for Index, Create, Delete, Details, Edit |  |  |
|  3.  Build Client Controllers for Index, Create, Delete, Details, and Edit | ||
|  4.  Build Home Controllers for Index |  |  |
|  5.  Build Home Views for Index |  |  |
|  6.  Build Client Views for Index, Create, Delete, Details, Edit | |  |
|  7.  Add Links to Clients Class and HTML |  |  |
|  8.  Add CSS and Styling |  |  |


## Setup/Installation Requirements

### Project from GitHub
* Download option
  * Download files from GitHub repository by click Code and Download Zip
  * Extract files into a single directory 
  * Run GitBASH in directory
  * Type "dotnet restore" to get bin and obj files
  * Type "dotnet run" in GitBash to run the program
  * Add database per the instructions below.
  * make stylists and clients 

* Cloning options
  * For cloning please use the following GitHub [tutorial](https://docs.github.com/en/enterprise/2.16/user/github/creating-cloning-and-archiving-repositories/cloning-a-repository)
  * Place files into a single directory 
  * Run GitBASH in directory
  * Type "dotnet restore" to get bin and obj files
  * Type "dotnet run" in GitBash to run the program
  * Add database per the instructions below.
  * make stylists and clients

### Database Setup

* Setup with SQL Import
  * MySQL
    * In the Navigator > Administration window, select Data Import/Restore.
    * In Import Options select Import from Self-Contained File.
    * Navigate to daniel_schaaf.sql.
    * Under Default Schema to be Imported To, select the New button.
      * Enter 'daniel_schaaf' as the name of your database.
      * Click Ok.
    * Click Start Import.
  * Go to appsettings.json and change the password if needed.

## Known Bugs

No Known Bugs

## Technologies Used

Main Programs
* MySQL
* C# / ASP.NET Core 
* MVC
* MSTest
* CSS
* Bootstrap


### Other Links
[Daniel's GitHub](https://github.com/dschaaf89)

### License

Copyright (c) 2020 **_{ Daniel Schaaf}_**
Licensed under MIT
