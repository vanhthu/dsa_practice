namespace Search
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 17, 83, 8, 78, 6, 2, 78, 5, 83, 4};
            Search1 search = new Search1(array);

            // TÌM KIẾM TUẦN TỰ
            // Số chẵn lớn nhất đầu tiên
            //int indexFirstEven = Search1.SequentialSearchFirstEven();
            //Console.WriteLine($"TKTT so chan lon nhat dau tien: {array[indexFirstEven]} tai chi so {indexFirstEven}");

            //int indexLastEven = Search1.SequentialSearchLastEven();
            //Console.WriteLine($"TKTT so chan lon nhat sau cung: {array[indexLastEven]} tai chi so {indexLastEven}");

            //int indexFirstMaxOdd = Search1.SequentialSearchFirstMaxOdd(); 
            //Console.WriteLine($"TKTT so le lon nhat dau tien: {array[indexFirstMaxOdd]} tại chỉ số {indexFirstMaxOdd}");

            //int indexFirstMinEven = Search1.SequentialSearchFirstMinEven(); 
            //Console.WriteLine($"TKTT so chan nho nhat dau tien: {array[indexFirstMinEven]} tại chỉ số {indexFirstMinEven}");

            //int indexFirstOdd = Search1.SequentialSearchFirstOdd();            
            //Console.WriteLine($"TKTT so le nho nhat dau tien: {array[indexFirstOdd]} tai chi so {indexFirstOdd}");

            //int indexFirstPrime = Search1.SequentialSearchFirstPrime();
            //Console.WriteLine($"TKTT so nguyen to dau tien: {array[indexFirstPrime]} tại chỉ số {indexFirstPrime}");

            //int indexFirstPerfectSquare = Search1.SequentialSearchFirstPerfectSquare(); 
            //Console.WriteLine($"TKTT so chinh phuong dau tien: {array[indexFirstPerfectSquare]} tại chỉ số {indexFirstPerfectSquare}");

            // TÌM KIẾM NHỊ PHÂN
            //int indexMaxEven = Search1.BinarySearchMaxEven();
            //if (indexMaxEven != -1)
            //{
            //    Console.WriteLine($"TKNB so chan lon nhat: {array[indexMaxEven]} tai chi so {indexMaxEven}");
            //}

            //int indexMinEven = Search1.BinarySearchMinEven();
            //if (indexMinEven != -1)
            //{
            //    Console.WriteLine($"TKNB so chan nho nhat: {array[indexMinEven]} tai chi so {indexMinEven}");
            //}

            //int indexPrimeFirst = Search1.BinarySearchFirstPrime();
            //if (indexPrimeFirst != -1)
            //{
            //    Console.WriteLine($"TKNB so nguyen to dau tien: {array[indexPrimeFirst]} tai chi so {indexPrimeFirst}");
            //}


            // cái này không có khả thi
            int indexPrimeLast = Search1.BinarySearchLastPrime();
            if (indexPrimeLast != -1)
            {
                Console.WriteLine($"TKNB so nguyen to cuoi cung: {array[indexPrimeLast]} tai chi so {indexPrimeLast}");
            }
            int indexPrimeLast1 = Search1.FindLastPrime();
            if (indexPrimeLast1 != -1)
            {
                Console.WriteLine($"TKNB so nguyen to cuoi cung: {array[indexPrimeLast1]} tai chi so {indexPrimeLast1}");
            }


            Console.ReadKey();
        }
    }
}
