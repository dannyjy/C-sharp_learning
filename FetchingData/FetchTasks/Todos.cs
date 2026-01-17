using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;

namespace FetchingData
{
    public class Todos
    {
        public static async Task GetTodosAsync()
        {
            HttpClient httpClient = new HttpClient();
            var reponse = await httpClient.GetStringAsync("https://jsonplaceholder.typicode.com/todos");
            Console.WriteLine(reponse);
        }
    }
}