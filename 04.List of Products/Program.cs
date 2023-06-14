namespace _04.List_of_Products;
class Program
{
    static void Main(string[] args)
    {
        //Read a number n and n lines of products. Print a numbered list of all the products ordered by name.


        int n = int.Parse(Console.ReadLine());

        List<string> products = new List<string>();

        for(int i=0;i<n;i++)
        {
            string input = Console.ReadLine();
            products.Add(input);


        }

        products.Sort();

        for(int i=1;i<=products.Count;i++)
        {
            Console.WriteLine($"{ i}.{products[i-1]}");
        }



    }
}

