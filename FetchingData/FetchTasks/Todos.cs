using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using System.Security.Principal;
using System.Net.Http.Json;

namespace FetchingData
{
    public class Todo
    {
        private int _userId;
        private int _id;
        private string _title;
        private bool _completed;

        public int UserId { 
            get { return _userId; }
            set { _userId = value; } 
        }
        public int id { 
            get { return _id; }
            set { _id = value; }
        }

        public string title {
             get { return _title; } 
             set { _title = value; }
        }
        public bool completed {
             get { return _completed; } 
             set { _completed = value; }
        }
    }
    public class Todos
    {
        public int Age { get; set; }
        public static async Task<List<Todo>> GetTodosAsync()
        {
            var client = new HttpClient();
            return await client.GetFromJsonAsync<List<Todo>>("https://jsonplaceholder.typicode.com/todos") ?? new List<Todo>();
        }
    }
}