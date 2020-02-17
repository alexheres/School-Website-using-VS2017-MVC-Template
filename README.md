# School Website using VS2017 MVC Template

This project uses the ASP.NET framework and an MVC 5 template provided by Visual Studios (2017) to create a website, specifically a generic website suitable for an academic insitution. 

To help set up the project in Visual Studios, I followed this tutorial over at the Microsoft Docs: https://docs.microsoft.com/en-us/aspnet/mvc/overview/getting-started/introduction/getting-started

# -------- Program and Functionalities ---------

Basic Role Functionality. There are currently 3 roles: Administrator, Instructor, and Student. Only a user with the administrator role can change what roles there are and who is assigned to them.
I made an account to test each role. There are their credentials:
Administrator: "Admin@Admin.com" | "Password#1"
Instructor: "professor@test.com" | "Test1!"
Student: "student@test.com" | "Test1!"

Based on the role of the user that is currently logged in, you may see different content on the navigation bar at the top.

A (local) database to store the following: Students, Instructors, Courses. There are basic Create, Read, Update, and Delete (CRUD) functions, and only certain roles can perform certain functions.

We also have Tables in our database for Enrollments, which also contains grade information, but the application currently only reads the enrollment info.

Students can only see information for student, instructors, and courses.
While Students can only view students' First and Last names, Instructors and Admin can view the classes in which they are enrolled.

Administrators can do everything that a student or instructor can, but more; admins have the power to create and delete students, instructors, or courses. The information in the database for each table is updated accordingly.

All of the required HTML code is done for each of the aforementioned features (Views for Admin, Student, Instructor, Course).

# -------- How to Build ---------

Open the solution file (.sln) in Visual Studios 2017, run the application in debug mode (F5 hotkey), and website should automatically execute on your primary web browser using localhost.

If the program still doesn't run, then the filepath name is likely too long. Visual Studios throws the error: "The specified path, file name, or both are too long. The fully qualified file name must be less than 260 characters, and the directory name must be less than 248 characters." If this is the case, move the project files to a directory of a lower level, then reload the project (In VS2017, click the project in the Solution Explorer, then in the toolbar go to Project > Reload Project).
