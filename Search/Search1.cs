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
        public static int BinarySearchMaxEven()
        {
            Array.Sort(arr); // Sắp xếp mảng trước khi tìm kiếm nhị phân
            int left = 0;
            int right = arr.Length - 1;
            int index = -1;

            // Tìm kiếm ngược từ phần tử cuối của mảng
            while (right >= left)
            {
                // Kiểm tra nếu số ở cuối là số chẵn
                if (arr[right] % 2 == 0)
                {
                    return right; // trả về chỉ số ngay lập tức nếu tìm thấy số chẵn lớn nhất
                }
                right--; // Di chuyển chỉ số về bên trái
            }

            return index; // Trả về -1 nếu không tìm thấy số chẵn nào
        }

        // Phương thức tìm số chẵn nhỏ nhất bằng tìm kiếm nhị phân
        public static int BinarySearchMinEven()
        {
            Array.Sort(arr); // Sắp xếp mảng trước khi tìm kiếm nhị phân
            int left = 0;
            int right = arr.Length - 1;
            int index = -1;

            // Duyệt từ đầu mảng để tìm số chẵn nhỏ nhất
            while (left <= right)
            {
                // Kiểm tra nếu số ở đầu là số chẵn
                if (arr[left] % 2 == 0)
                {
                    return left; // trả về chỉ số ngay lập tức nếu tìm thấy số chẵn nhỏ nhất
                }
                left++; // Di chuyển chỉ số về bên phải
            }

            return index; // Trả về -1 nếu không tìm thấy số chẵn nào
        }

        // Phương thức tìm số nguyên tố đầu tiên bằng tìm kiếm nhị phân
        public static int BinarySearchFirstPrime()
        {
            Array.Sort(arr); // Sắp xếp mảng trước khi tìm kiếm nhị phân
            int left = 0;
            int right = arr.Length - 1;

            while (left <= right)
            {
                int mid = (left + right) / 2;

                // Kiểm tra số ở giữa có phải là số nguyên tố hay không
                if (IsPrime(arr[mid]))
                {
                    // Nếu phần tử giữa là số nguyên tố, kiểm tra về phía trái để tìm kiếm số nguyên tố đầu tiên
                    // Lưu chỉ số và tiếp tục tìm kiếm về bên trái
                    right = mid - 1;
                }
                else
                {
                    // Nếu không phải số nguyên tố, tìm kiếm bên phải
                    left = mid + 1;
                }
            }

            // Sau khi tìm kiếm, left sẽ ở vị trí của số nguyên tố đầu tiên nếu có
            if (left < arr.Length && IsPrime(arr[left]))
            {
                return left; // Trả về chỉ số của số nguyên tố đầu tiên
            }

            return -1; // Trả về -1 nếu không tìm thấy số nguyên nào
        }

        // Phương thức tìm số nguyên tố sau cùng bằng tìm kiếm nhị phân
        // Phương thức tìm số nguyên tố cuối cùng bằng tìm kiếm nhị phân
        public static int BinarySearchLastPrime()
        {
            Array.Sort(arr); // Sắp xếp mảng trước khi tìm kiếm nhị phân
            int left = 0;
            int right = arr.Length - 1;
            int index = -1; // Chỉ số lưu vị trí số nguyên tố cuối cùng

            while (left <= right)
            {
                int mid = (left + right) / 2;

                // Kiểm tra số ở giữa có phải là số nguyên tố hay không
                if (IsPrime(arr[mid]))
                {
                    index = mid; // Lưu lại chỉ số của số nguyên tố
                    left = mid + 1; // Tiếp tục tìm kiếm bên phải để tìm số nguyên tố cuối cùng
                }
                else
                {
                    right = mid - 1; // Nếu không phải số nguyên tố, tìm kiếm bên trái
                }
            }

            return index; // Trả về chỉ số của số nguyên tố cuối cùng (hoặc -1 nếu không có)
        }
        public static int FindLastPrime()
        {
            int index = -1; // Khởi tạo giá trị -1 nếu không tìm thấy số nguyên tố nào

            // Duyệt ngược qua mảng gốc
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                if (IsPrime(arr[i]))
                {
                    index = i; // Ghi nhận chỉ số và dừng lại
                    break;
                }
            }

            return index;
        }


        // Tìm kiếm nhị phân trả về chỉ số phần tử là số chính phương đầu tiên
        public static int BinarySearchFirstPerfectSquare()
        {
            Array.Sort(arr); // Sắp xếp mảng trước khi tìm kiếm nhị phân
            int left = 0;
            int right = arr.Length - 1;
            int index = -1;

            while (left <= right)
            {
                int mid = (left + right) / 2;

                // Kiểm tra số ở giữa có phải là số chính phương hay không
                if (IsPerfectSquare(arr[mid]))
                {
                    index = mid; // Lưu chỉ số của số chính phương
                    right = mid - 1; // Tiếp tục tìm kiếm sang trái để tìm số chính phương đầu tiên
                }
                else
                {
                    left = mid + 1; // Nếu không phải số chính phương, tìm kiếm sang phải
                }
            }

            return index; // Trả về chỉ số của số chính phương đầu tiên (hoặc -1 nếu không có)
        }
    }
}
