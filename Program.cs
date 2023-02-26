using InumentTestApp;

try
{
    string strInput = Environment.GetEnvironmentVariable("inputString") ?? "";
    string strFilePath = "Output.txt";

    string strOutput = strInput.ToReverse();
   
    Console.WriteLine("Output ==> ");
    Console.WriteLine(strOutput);

    await strOutput.SaveToFile(strFilePath);
    Console.WriteLine("Output saved to file successfully !!");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}


