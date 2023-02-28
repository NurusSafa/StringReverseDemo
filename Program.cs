using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using StringReverseDemo.BLL;
using StringReverseDemo.Helper;
using StringReverseDemo.Services.Implementation;
using StringReverseDemo.Services.Interfaces;

try
{

    string strInput = Environment.GetEnvironmentVariable("inputString");
    if (strInput == null)
    {
        Console.WriteLine("Please provide a string value of the variable named inputString,e.g inputString=\"Sample Input\" ");
    }
    else
    {
        IHost host = RegisterService(args);

        var configuration = new ConfigurationBuilder()
         .AddJsonFile($"appsettings.json");
        IConfigurationRoot config = configuration.Build();
        string strFilePath = config.GetSection("FilePath").Value ?? "";

        await ProcessStringData(host, strInput, strFilePath);
    }

}
catch (Exception ex)
{
    Console.WriteLine("Sorry! The data could not be processed.");

    await File.WriteAllTextAsync("ErrorLog_" + DateTime.Now.ToString().Replace("/", "_").Replace("-", "_").Replace(":", "_").Replace("\\", "_"), ex.Message);
}

IHost RegisterService(string[] args)
{
    return Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        services.AddBusinessLayer();
    })
    .Build();
}

async Task ProcessStringData(IHost host, string strInput, string strFilePath)
{
    var service = host.Services.GetService<IStringReverseService>();
    if(service != null)
    {
        string strReversedOutput = service.ReverseString(strInput);

        await strReversedOutput.SaveToFile(strFilePath);

        string strFileOutput = await StringDataHelper.GetDataFromFile(strFilePath);
        Console.WriteLine("Output ==> ");
        Console.WriteLine(strFileOutput);
        Console.WriteLine("Output saved to file successfully !!");
    }
}
