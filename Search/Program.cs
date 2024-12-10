namespace Search
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 17, 83, 8, 78, 6, 2, 78, 5, 83, 4 };
            Search1 search = new Search1(array);

            // Tìm kiếm tuần tự
            int indexFirstOdd = Search1.SequentialSearchFirstOdd();            
            Console.WriteLine($"TKTT so le nho nhat dau tien: {array[indexFirstOdd]} tai chi so {indexFirstOdd}");

            Console.ReadKey();
        }
    }
}
