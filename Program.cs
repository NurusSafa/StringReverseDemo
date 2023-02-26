using InumentTestApp;

try
{
    string strInput = Environment.GetEnvironmentVariable("inputString") ?? "";
    string strFilePath = $"{AppContext.BaseDirectory}\\Output.txt";

    string strOutput = strInput.ToReverse();
    await strInput.SaveToFile(strFilePath);
    Console.WriteLine(strOutput);
    
}
catch (Exception ex)
{
    Console.Error.WriteLine(ex.Message);
}
Console.WriteLine("Finished!!");
Console.ReadLine();


