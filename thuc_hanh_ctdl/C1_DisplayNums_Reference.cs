using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
namespace thuc_hanh_ctdl
{
    internal class C1_DisplayNums_Reference
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chuong trinh do thoi gian n so nguyen: ");
            Console.Write("Nhap vao n = ");

            long n = Convert.ToInt64(Console.ReadLine());
            long[] nums = new long[n];
            BuildArray(nums);
            
            Stopwatch timer = new Stopwatch();            

            timer.Start();


            DisplayNums(nums);
            timer.Stop();

            Console.WriteLine("Ket thuc thoi gian chay....");
            long ms = timer.ElapsedMilliseconds;
            Console.WriteLine("Ket qua do: T = {0} mili giay", ms.ToString());


            Console.ReadKey();
        }

        static void BuildArray(long[] arr)
        {
            for (long i = 0; i < arr.Length; i++)
                arr[i] = i;
        }

         static void DisplayNums(long[] arr)
        {
            for(long i = 0;i < arr.Length; i++)
                Console.Write(arr[i]+ " ");
        }
    }
}
