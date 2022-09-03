using Has.Duplicates;

internal partial class Program
{
    static void Main(string[] args)
    {
        var list = new List<int> { 1, 2, 3 };
        var listDup = new List<int> {
            1,
            2,
            3, 3, 3, 3,
            4,
            5, 5,
            6,
            7,
            8,
            9,
            0, 0 };

        Console.WriteLine($"Número de itens duplicados: {list.DuplicatesCount()}");
        list.Duplicates().DistinctList().OrderByList().ForEach(x => Console.WriteLine($"Item duplicado: {x}"));

        Console.WriteLine($"Número de itens duplicados: {listDup.DuplicatesCount()}");
        listDup.Duplicates().DistinctList().OrderByList().ForEach(x => Console.WriteLine($"Item duplicado: {x}"));
    }
}

