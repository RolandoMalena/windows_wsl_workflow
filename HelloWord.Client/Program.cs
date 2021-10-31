using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace HelloWord.Client
{
  class Program
  {
    static async Task Main(string[] args)
    {
      string baseUrl;

      if (args.Length == 0)
        baseUrl = Environment.GetEnvironmentVariable("BaseURL");
      else
        baseUrl = string.Join(" ", args);

      HttpClient client = new HttpClient();
      var result = await client.GetAsync(baseUrl);

      if (!result.IsSuccessStatusCode)
        throw new Exception("Ping could not be made :(");

      Console.WriteLine("Ping made successfully :)");
    }
  }
}
