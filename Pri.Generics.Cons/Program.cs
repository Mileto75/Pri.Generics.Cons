// See https://aka.ms/new-console-template for more information
using Pri.Generics.Cons.Entities;
using Pri.Generics.Cons.Generics;

Console.WriteLine("Hello, World!");

Order<int> ordersInt = new Order<int>();
ordersInt.Item = 5;
ordersInt.Quantity = 5;
Order<string> ordersString = new Order<string>
{
    Item = "Orange crush",
    Quantity = 5,
};
List<string> listStrings = new List<string> { "one ", "two", "three" };
Order<List<string>> orderListString = new Order<List<string>>
{
    Item = listStrings,
    Quantity = 2
};
//Console.WriteLine(ordersInt.Item);
//Console.WriteLine(ordersString.Item);
//Console.WriteLine(orderListString.ToString());
Order<Television> televisions = new Order<Television>
{
    Item = new Television
    {
        Id = 1,
        Brand = "Sony",
        Model = "L69",
        Price = 1000M,
        ScreenSize = 1250
    }
};
//Console.WriteLine(televisions.Item.ToString());
//generic repository
IRepository<int> intRepository = new Repository<int>();
intRepository.Add(1);
intRepository.Add(2);
intRepository.Add(3);
IRepository<string> stringRepository = new Repository<string>();
stringRepository.Add("one");
stringRepository.Add("two");
stringRepository.Add("three");
IRepository<Television> televisionRepository = new Repository<Television>();
televisionRepository.Add(new Television
{
    Id = 1,
    Brand = "Sony",
    Model = "L69",
    Price = 1000M,
    ScreenSize = 1250
});
televisionRepository.Add(new Television
{
    Id = 2,
    Brand = "LG",
    Model = "L32",
    Price = 100M,
    ScreenSize = 250
});
televisionRepository.Add(new Television
{
    Id = 3,
    Brand = "Samsung",
    Model = "L9",
    Price = 1020M,
    ScreenSize = 50
});

foreach(var number in intRepository.GetAll())
{
    Console.WriteLine(number);
}
foreach(var stringNumber in stringRepository.GetAll())
{
    Console.WriteLine($"{stringNumber}");
}
foreach(var television in televisionRepository.GetAll())
{
    Console.WriteLine(television.ToString());
}
