# README #

All Issues and other current NOTES can be added and edited here

### OOP2 Repository ###

* Quick summary
* Version 0.1a

### Instructions on how to set this up ###
1. You need to have MS SQL server database installed on your machine.
2. Create a database for test purposes.
3. Use SQL file to get SQL query statements for creating the database and for populating it with values
4. Use SQLStoredProcedures in order to set up required stored procedures. 
5. Make sure to add all stored procedures
6. Add your version of connection string to app.config and make sure that the name stays the same.
7. Ensure the account number of the external account number in app.config is the same as the account number in your SQL Server Database.

### Assumptions ###

1. Student are identified by Student Id
2. Initial balance can be "zero"
3. Accounts are created for students only
4. For Saving accounts overdraft can be NULL
5. Clients are existing Students
6. The output to xml option is only for account details: 
7. Student Id's start from 1002001
8. Edit only fields: Email, Phone, Address1, Addres2, City, County
9. We're not concerned with incoming Transfers.
	- transfers externally just debit the account in our system
	- transfers internally need to debit the origin account, and credit the destination account
	- That assumption will make transfers easier, and means we can delete the external account from our database.


### ISSUES ###
********************************************************

Need to make sure that data in the database is in correct format because it won't validate otherwise. 
and can cause serious problems

*******************************************************



### What Alex is working on ###
Thinking of new features to add

###What Emma is working on ###
Thinking of new features to add

### Future Work ###
1. Add SHA to encrypt the passwords
2. Input Add Account Information from XML (as import option on create account or something similar)

### NOTES ###
1. All external transfers are represented by one dummy account in Accounts table.
	- This in turn is linked to one dummy Student Account.

###RESOLVED ISSUES###
1. EXTERNAL ACCOUNT - Sorted
2. SAVING account type - Sorted
3. Money converted to decimal - remove "," - Sorted


### Who do I talk to? ###
* Any Team Member