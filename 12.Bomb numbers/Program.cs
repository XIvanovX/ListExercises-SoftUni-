namespace _12.Bomb_numbers;
class Program
{
    static void Main(string[] args)
    {
        List<int> numbersList = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
        List<int> comandList = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

        while (numbersList.Contains(comandList[0]))
        {
            int bomb = comandList[0];
            int power = comandList[1];
            int index = numbersList.IndexOf(bomb);

            if (numbersList.Count > index + power)
            {
                for (int i = index + 1; i < index + power + 1; i++)
                {
                    numbersList.RemoveAt(index + 1);
                }
            }
            else
            {
                for (int i = index + 1; i < numbersList.Count; i++)
                {
                    numbersList.RemoveAt(index + 1);
                }
            }

            if (index - power >= 0)
            {
                for (int i = index; i >= index - power; i--)
                {
                    numbersList.RemoveAt(i);
                }
            }
            else
            {
                for (int i = index; i >= 0; i--)
                {
                    numbersList.RemoveAt(i);
                }
            }
        }
        Console.WriteLine(numbersList.Sum());
    }
}

