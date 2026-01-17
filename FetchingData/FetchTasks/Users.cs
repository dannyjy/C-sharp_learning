using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FetchingData
{
    public class Users
    {
        public int age { get; set; }
        public static async Task GetUsersAsync()
        {
            HttpClient client = new HttpClient();
            var data = await client.GetAsync("https://jsonplaceholder.typicode.com/users");
            var responseData = await data.Content.ReadAsStringAsync();
            System.Console.WriteLine(responseData);
        }
    }
}