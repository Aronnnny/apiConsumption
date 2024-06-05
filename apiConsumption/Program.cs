using apiConsumption.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apiConsumption
{
    class Program
    {
        static async Task Main(string[] args)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://jsonplaceholder.typicode.com");

            string responseBody = await client.GetStringAsync("/users");
            var users = JsonConvert.DeserializeObject<List<User>>(responseBody);

            foreach (var user in users)
            {
                Console.WriteLine($"Name: {user.Name}\nEmail: {user.Email}\nUsername: {user.Username}\n" +
                    $"City: {user.Address.City}, {user.Address.Street}\n");
            }
        }
    }
}
