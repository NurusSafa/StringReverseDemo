# DockerProject1
The following features have been implemented in this project. 
1. Taking an envioronment variable as input string and format it in reverse order. 
2. Print the output in Console window.
3. Save the output in a file. 
4. Build the application in Docker image. 
5. Running the application in Docker container.   


Step:1: Adding a static class called "UtilityManager.cs"
Step:2: Adding an extension method  of string type named "ToReverse" which will convert the string typed parameter into reverted string and return the string. 
Step:3: Adding an extension method of string type named "SaveToFile" which will write the string typed parameter into a file and save it to location provided by input parameter.
Step:4: Coming into the Program.cs file.Initializing a variable named "strInput" from Environment variables with a specific name "inputString".
Step:5: Calling the entension method ToReverse() for the variable "strInput" and setting the output to another variable named  "strOutput"
Step:6: Printing the output to the Console. 
Step:7: Calling the entension method SaveToFile() for the variable "strOutput"
Step:8: Printing a success message.
