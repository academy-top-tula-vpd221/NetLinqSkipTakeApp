using NetLinqSkipTakeApp;

List<Company> companies = new List<Company>()
{
    new(){ Title = "Yandex" },
    new(){ Title = "Google" },
    new(){ Title = "Ozon" },
    new(){ Title = "Mail Group" },
    new(){ Title = "Microsoft" },
    new(){ Title = "Intel" },
    new(){ Title = "Avito" },
    new(){ Title = "Kaspersky" },
    new(){ Title = "Samsung" },
    new(){ Title = "Rambler" },
};

int itemPage = 3;
int pageCount = companies.Count / itemPage;
int page = 0;
while(page <= pageCount)
{
    page++;
    Console.Clear();

    var pageReasult = companies.Skip((page - 1) * itemPage).Take(itemPage).ToList();
    foreach(var i in pageReasult)
        Console.WriteLine(i.Title);
    
    Console.ReadKey();
}

void LinqSkipTake()
{
    var resultSkip3 = companies.Skip(3).ToList();

    foreach (var c in resultSkip3)
        Console.WriteLine($"{c.Title}");
    Console.WriteLine();

    var resultSkipLast3 = companies.SkipLast(3).ToList();

    foreach (var c in resultSkipLast3)
        Console.WriteLine($"{c.Title}");
    Console.WriteLine();

    var resultSkipWhile = companies.SkipWhile(c => !c.Title.StartsWith("I")).ToList();

    foreach (var c in resultSkipWhile)
        Console.WriteLine($"{c.Title}");
    Console.WriteLine();

    var resultTake3 = companies.Take(3).ToList();
    foreach (var c in resultTake3)
        Console.WriteLine($"{c.Title}");
    Console.WriteLine();

    var resultSkip3Take3 = companies.Skip(3).Take(3).ToList();
    foreach (var c in resultSkip3Take3)
        Console.WriteLine($"{c.Title}");
    Console.WriteLine();

    var resultTakeWhile = companies.TakeWhile(c => !c.Title.StartsWith("I")).ToList();
    foreach (var c in resultTakeWhile)
        Console.WriteLine($"{c.Title}");
    Console.WriteLine();
}