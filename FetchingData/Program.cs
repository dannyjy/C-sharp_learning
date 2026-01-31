using FetchingData.multithreading;
// https://jsonplaceholder.typicode.com/todos/1

namespace FetchingData
{
    class Program
    {
        public static void Main(string[] args)
        {
            var t1 = Task.Run( async () => {
                try
                {
                    var todosList = await Todos.GetTodosAsync();
                    foreach (var todo in todosList)
                    {
                        Console.WriteLine($"Todo ID: {todo.UserId}, Title: {todo.title}, Completed: {todo.completed}");
                    }
                    // await Users.GetUsersAsync();
                }
                catch (Exception e)
                {
                    System.Console.WriteLine(e.Message);
                }
            });

            // Thread Class
            Thread thread = new Thread(Multi.GetValues);
            // thread.Start();

            Counter counter = new Counter();

            Thread t2 = new Thread(counter.Increment);
            Thread t3 = new Thread(counter.Increment);

            t2.Start();
            t3.Start();

            // Thread Pooling
            ThreadPool.QueueUserWorkItem((st) =>
            {
                counter.Increment();
            });
            Task.WaitAll(t1);
            // SystemInfo.GetSystemDetail();
        }
    }
}