# String Reverse Demo Project

## The following features have been implemented in this project. 
> 1. Taking an envioronment variable as input string and format it in reverse order. 
> 2. Print the output in Console window.
> 3. Save the output in a file. 
> 4. Build the application in Docker image. 
> 5. Running the application in Docker container.   

## The development has been done in the following Steps. 
> 1. Creating a Console Application in .Net 6 . > 
>     
> 2. Adding Business Logic Layer with Interface and service implementation.
>    There is a method added here which format the given string into reversed string, 
>    Here static class has been added for creating an extenstion method for string which format the string in reverse order.
>    Dependency injection class has been added in BLL for creating and extenstion method for registering String Reverse service.
>
> 3. Adding a Helper static class has been added here for creating an extenstion method for string which save the string to a file. 
>    There is also a method added which will get the string from file asynchronously.
>    
> 4. In Program.cs initializing a variable named "strInput" from Environment variables with a specific name "inputString". 
>    If the inputstring is not null then build the host with registering the services from BLL.
> 5.  Getting File path from appsettings.json file. 
>    
> 6. If the registered service of string reverse is not null then it will proceed to call the method for reversing the input string.
>    Then it calls the method for saving string to file. 
>    Then it calls the method for getting the string from file. 
>    Printing a success message.


## The deployment in docker has been done in the following Steps. 
> 1. Installing the Docker-desktop for Windows 10 Home basic OS.
> 2. Installing the Ubuntu for windows. 
> 3. Starting the Linux container as the windows container could not work due to OS.
> 4. Adding a DockerFile in the solution directory. 
> 5. Adding a Docker Compose file in the solution directory. 
> 6. Open the powershell command prompt in the solution directory. 
> 7. Build the image with the command Docker-compose build. 
> 8. Creating the container and starting the container for the image. with a valid environment variable. 

### Command with Sample Input and output : 
![image](https://user-images.githubusercontent.com/7831389/221665485-426ca32b-7967-4621-b17e-a554e5375ed8.png)

 The Output file: 
![image](https://user-images.githubusercontent.com/7831389/221666073-7393c7a2-1bfd-4c36-8f4f-ad19439667d8.png)

