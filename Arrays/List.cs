class ListsClass
{
  public void Display()
  {
    List<String> food = new List<String>
    {
      "pizza",
      "chappite",
      "Rollex",
      "chicken",
      "beef"  
    };

    var f2 = new List<String> {"beans","lentiles"};
    string myfavirate = "cowpeas";

    // Console.WriteLine(food.TrueForAll(val => val.IsNormalized()));
    food.Add("matoki");
    food.AddRange(myfavirate);


    // food.ForEach((food) => Console.WriteLine(food));
  }
}