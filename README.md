Problem: 
We need to develop a Web API application that maintains information about different students and courses in a relational database.
Following is the list of API Endpoints that we need to implement in this application:
1. Add a Student [Name, Email, Phone]
2. Assign a Student to one or more Courses
3. List Students [Name, Email, Phone, Course Enrolled (comma separated string)]
4. Create a Login API with any authentication mode. Unless the user hits this API first, others should
not be accessible, giving a 401 UnAuthorized Access response.

Solution:

Database script : to Create Database and Required Tables for the Assignment
![image](https://github.com/user-attachments/assets/e22e75cc-bf5d-4622-8a36-5201411c7581)


Initially tables are empty:

 


After running the web application swagger endpoint is shown:
 


Login Functionality:

Create a Login API with any authentication mode.
Use this endpoint to generate jwt token for authorization.
Default username and password is as per the request body below:

 

Unless the user hits this API first, others should not be accessible, giving a 401 Unauthorized Access response.

 

After the login : copy token and paste in the Auth header of request,
It returned the empty list since there is not data into DB.


 

Add a Student [Name, Email, Phone]

 

Verify in DB:

 


Add course data manually in database. 
 

Assign a Student to one or more Courses

 
 
 
 

List Students [Name, Email, Phone, Course Enrolled (comma separated string)]

 


Thank you, Please review and revert.

