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

 ![image](https://github.com/user-attachments/assets/8b928ba8-3f55-4e7f-b6f6-bccaa98f91e2)



After running the web application swagger endpoint is shown:
 
![image](https://github.com/user-attachments/assets/ace98db4-cd1e-4629-983d-b6d96b4cc313)


Login Functionality:

Create a Login API with any authentication mode.
Use this endpoint to generate jwt token for authorization.
Default username and password is as per the request body below:

UserName: nikita
Password: test@123

 ![image](https://github.com/user-attachments/assets/86220b0c-7eb2-4f2f-a0e3-9e3ad79912e7)


Unless the user hits this API first, others should not be accessible, giving a 401 Unauthorized Access response.

![image](https://github.com/user-attachments/assets/dd83d2e1-c0cb-4bee-900a-4f9d811cdeb6)

 

After the login : copy token and paste in the Auth header of request,
It returned the empty list since there is not data into DB.

![image](https://github.com/user-attachments/assets/a3d17efa-8de3-4c64-9be4-644363e1fe06)

 

Add a Student [Name, Email, Phone]

 ![image](https://github.com/user-attachments/assets/166a39bc-4e63-491d-8631-df80d1945eda)


Verify in DB:

 ![image](https://github.com/user-attachments/assets/8145b904-0974-4132-be7b-3a764ed42b87)



Add course data manually in database. 
 
![image](https://github.com/user-attachments/assets/d8cce134-edf2-4915-bd15-c9a9507ef880)


Assign a Student to one or more Courses

 ![image](https://github.com/user-attachments/assets/436a10e4-73ad-4789-8699-133e72de57ee)

 ![image](https://github.com/user-attachments/assets/b9516119-7899-4427-b0c1-0bd1e461b99f)

 ![image](https://github.com/user-attachments/assets/1cedb058-0787-45c2-8706-feddca047192)

![image](https://github.com/user-attachments/assets/c82a9a3f-3735-452d-a816-b4fc1852147e)


List Students [Name, Email, Phone, Course Enrolled (comma separated string)]

 ![image](https://github.com/user-attachments/assets/490f1028-19cf-4c7c-8af1-18cdf5210acb)



Thank you, Please review and revert.

