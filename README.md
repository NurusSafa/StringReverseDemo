# String Reverse Demo Project
The following features have been implemented in this project. 
1. Taking an envioronment variable as input string and format it in reverse order. 
2. Print the output in Console window.
3. Save the output in a file. 
4. Build the application in Docker image. 
5. Running the application in Docker container.   

## The development has been done in the following Steps. 
> 1. Creating a Console Application in .Net 6 . 
> 
> 2. Adding Data Access Layer with Interface and service implementation. 
>    There are two methods have been added here. One for Get Data from File. Another for Save Data to file. 
>    A static class has been added here for creating an extenstion method for string which save the string to a file. 
>    Dependency injection class has been added in DAL for creating and extenstion method for registering Data repository service.
>     
> 3. Adding Business Logic Layer with Interface and service implementation.
>    There are three methods have been added here. One for reverse string, second one for get reversed string and third one for save string to file. 
>    Here static class has been added for creating an extenstion method for string which format the string in reverse order.
>    Dependency injection class has been added in BLL for creating and extenstion method for registering String Reverse service and DAL service. 
>    
> 4. In Program.cs initializing a variable named "strInput" from Environment variables with a specific name "inputString".
>    If the inputstring is not null then build the host with registering the services from BLL.
>    Getting File path from appsettings.json file. 
>    If the registered service of string reverse is not null then it will proceed to call the method for reversing the input string.
>    Then it calls the method for saving string to file. 
>    Then it calls the method for getting the string from file. 
>    Printing a success message.
>    
## The deployment has been done in the following Steps. 
> 1. 
Step:2: Adding an extension method  of string type named "ToReverse" which will convert the string typed parameter into reverted string and return the string. 
Step:3: Adding an extension method of string type named "SaveToFile" which will write the string typed parameter into a file and save it to location provided by input parameter.
Step:4: Coming into the Program.cs file.
Step:5: Calling the entension method ToReverse() for the variable "strInput" and setting the output to another variable named  "strOutput"
Step:6: Printing the output to the Console. 
Step:7: Calling the entension method SaveToFile() for the variable "strOutput"
Step:8: Printing a success message.
Step 9: Adding a DockerFile. 
Step 10: Adding a Docker Compose file. 
Step 11: Run powershell in the project directory. Build the Docker-compose
Step 12: Create and run the docker image and container. 

Command with Sample Input and output : 
![Docker_Command_Input_Output](https://user-images.githubusercontent.com/7831389/221422035-330076d7-0f96-423d-8175-4ed204231aee.png)

The Output file: 
![SavedFile](https://user-images.githubusercontent.com/7831389/221422060-35ad89c5-0734-4d13-ba33-f3ba391e1e08.png)
