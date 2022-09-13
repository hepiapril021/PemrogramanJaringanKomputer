using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;

namespace LoginClient
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public DateTimeOffset Date { get; set; }
        public int TemperatureCelsius { get; set; }
        public string? Summary { get; set; }
    }
    public class Client
    {
        public static void Main()
        {
            User user = new User();

            Console.WriteLine("username : ");
            user.Username = Console.ReadLine();
            Console.WriteLine("password : ");
            user.Password = Console.ReadLine();

            string fileName = "DataUser.json";
            string jsonString = File.ReadAllText(fileName);
            User user1 = JsonSerializer.Deserialize<User>(jsonString)!;

        
            Console.WriteLine($"Date: {weatherForecast.Date}");
            Console.WriteLine($"TemperatureCelsius: {weatherForecast.TemperatureCelsius}");
            Console.WriteLine($"Summary: {weatherForecast.Summary}");

        }
    }
}