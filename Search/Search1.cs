using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search
{
    internal class Search1
    {
        static int[] arr;
        public Search1(int[] inputArray)
        {
            arr = inputArray;
        }
        // VIẾT THEO KIỂU TÌM KIẾM TUẦN TỰ 
        // Tìm kiếm tuần tự trả về chỉ số phần tử là "số chẵn lớn nhất đầu tiên"
        public static int SequentialSearchFirstEven()
        {
            int index = -1;
            int maxEven = int.MinValue;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0 && arr[i] > maxEven) // do so sánh > 
                {
                    maxEven = arr[i];
                    index = i;
                }
            }

            return index;
        }

        // Tìm kiếm tuần tự trả về chỉ số phần tử là "số chẵn lớn nhất sau cùng" 
        public static int SequentialSearchLastEven()
        {
            int index = -1;
            int maxEven = int.MinValue;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0 && arr[i] >= maxEven) // Sử dụng '>= để có thể lấy chỉ số phần tử sau cùng
                {
                    maxEven = arr[i];
                    index = i;
                }
            }

            return index;
        }

        // *Tìm kiếm tuần tự trả về chỉ số phần tử là số lẻ lớn nhất đầu tiên
        public static int SequentialSearchFirstMaxOdd()
        {
            int index = -1;
            int maxOdd = int.MinValue;

            for (int i = 0; i < arr.Length; i++)
            {
                
                if (arr[i] % 2 != 0 && arr[i] > maxOdd) // Sử dụng '>= để có thể lấy chỉ số phần tử sau cùng
                {
                    maxOdd = arr[i];
                    index = i;
                }
            }

            return index;
        }

        // *Tìm kiếm tuần tự trả về chỉ số phần tử là số chẵn nhỏ nhất đầu tiên
        public static int SequentialSearchFirstMinEven()
        {
            int index = -1;
            int minEven = int.MaxValue;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0 && arr[i] < minEven) // Sử dụng '>= để có thể lấy chỉ số phần tử sau cùng
                {
                    minEven = arr[i];
                    index = i;
                }
            }

            return index;
        }        
        // Tìm kiếm tuần tự trả về chỉ số phần tử là số lẻ nhỏ nhất đầu tiên

        public static int SequentialSearchFirstOdd()
        {
            int index = -1;
            int minOdd = int.MaxValue;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0 && arr[i] < minOdd) // Sử dụng '>= để có thể lấy chỉ số phần tử sau cùng
                {
                    minOdd = arr[i];
                    index = i;
                }
            }

            return index;
        }

        // Tìm kiếm tuần tự trả về chỉ số phần tử là số nguyên tố đầu tiên
        // Hàm kiểm tra số nguyên tố
        private static bool IsPrime(int number)
        {
            if (number <= 1) return false; // Số nguyên tố phải lớn hơn 1
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0) return false;
            }
            return true;
        }

        // Tìm kiếm tuần tự để tìm số nguyên tố đầu tiên
        public static int SequentialSearchFirstPrime()
        {
            int index = -1;

            for (int i = 0; i < arr.Length; i++)
            {
                if (IsPrime(arr[i]))
                {
                    index = i; // Lưu chỉ số và thoát ngay khi tìm thấy số nguyên tố đầu tiên
                    // đối với trường hợp sau cùng thì bỏ break --> số nguyên tố sau cùng
                    break;
                }
            }

            return index;
        }
        // Tìm kiếm tuần tự trả về chỉ số phần tử là số chính phương đầu tiên
        // Hàm kiểm tra số chính phương
        private static bool IsPerfectSquare(int number)
        {
            if (number < 0) return false; // Số chính phương không thể âm
            int sqrt = (int)Math.Sqrt(number);
            return (sqrt * sqrt == number); // Kiểm tra xem số có phải là chính phương hay không
        }

        // Tìm kiếm tuần tự để tìm số chính phương đầu tiên
        public static int SequentialSearchFirstPerfectSquare()
        {
            int index = -1;

            for (int i = 0; i < arr.Length; i++)
            {
                if (IsPerfectSquare(arr[i]))
                {
                    index = i; // Lưu chỉ số và thoát ngay khi tìm thấy số chính phương đầu tiên
                    break;
                }
            }

            return index;
        }

        // VIẾT THEO KIỂU TÌM KIẾM NHỊ PHÂN            
        // Phương thức tìm số chẵn lớn nhất bằng tìm kiếm nhị phân             
        // Phương thức tìm số chẵn nhỏ nhất bằng tìm kiếm nhị phân
        // Phương thức tìm số lẻ lớn nhất bằng tìm kiếm nhị phân
        // Phương thức tìm số lẻ nhỏ nhất bằng tìm kiếm nhị phân
        // Phương thức tìm số nguyên tố đầu tiên bằng tìm kiếm nhị phân        
        // Tìm kiếm nhị phân trả về chỉ số phần tử là số chính phương đầu tiên
    }
}
