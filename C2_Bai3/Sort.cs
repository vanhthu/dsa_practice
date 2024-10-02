using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2_Bai3
{
    internal class Sort
    {
        public static void XuatMang(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
        }
        // 3.1. Sắp xếp Nổi bọt với cách duyệt đưa phần tử lớn nhất về cuối mảng (Tăng dần)
        public static void BubbleSortToEnd(int[] arr)
        {
            int n = arr.Length;

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - 1 - i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }
        // 3.2. Sắp xếp Nổi bọt với cách duyệt đưa phần tử lớn nhất về đầu mảng (Giảm dần)
        public static void BubbleSortToStart(int[] arr)
        {
            int n = arr.Length;

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = n - 1; j > i; j--)
                {
                    if (arr[j] < arr[j - 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j - 1];
                        arr[j - 1] = temp;
                    }
                }
            }
        }
        // 3.3. Sắp vếp Chọn với cách duyệt đưa phần tử lớn nhất về cuối mảng (Tăng dần)
        public static void SelectionSortAscending(int[] arr)
        {
            int n = arr.Length;

            for (int i = 0; i < n - 1; i++)
            {
                int maxIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] > arr[maxIndex])
                    {
                        maxIndex = j;
                    }
                }

                // Hoán đổi phần tử lớn nhất với phần tử cuối cùng của đoạn chưa sắp xếp
                int temp = arr[maxIndex];
                arr[maxIndex] = arr[i];
                arr[i] = temp;
            }
        }

        // 3.4. Sắp xếp Chọn với cách duyệt đưa phần tử lớn nhất về cuối mảng (Giảm dần)
        public static void SelectionSortDescending(int[] arr)
        {
            int n = arr.Length;

            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }
                }

                // Hoán đổi phần tử nhỏ nhất với phần tử cuối cùng của đoạn chưa sắp xếp
                int temp = arr[minIndex];
                arr[minIndex] = arr[i];
                arr[i] = temp;
            }
        }

        // 3.5. Sắp xếp Chèn với cách duyệt xem phần tử cuối mảng là dãy sắp xếp ban đầu
        public static void InsertionSortAscending(int[] arr)
        {
            int n = arr.Length;

            for (int i = 1; i < n; i++)
            {
                int key = arr[i];
                int j = i - 1;

                // Di chuyển các phần tử lớn hơn key về phải
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }

                // Đặt key vào đúng vị trí
                arr[j + 1] = key;
            }
        }

        // 3.6. Sắp xếp Chèn với cách duyệt xem phần tử đầu mảng là dãy sắp xếp ban đầu
        public static void InsertionSortDescending(int[] arr)
        {
            int n = arr.Length;

            for (int i = 1; i < n; i++)
            {
                int key = arr[i];
                int j = i - 1;

                // Di chuyển các phần tử nhỏ hơn key về phải
                while (j >= 0 && arr[j] < key)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }

                // Đặt key vào đúng vị trí
                arr[j + 1] = key;
            }
        }

        // 3.7. Sắp xếp Nhanh, trong đó phân hoạch dùng phương pháp đệ quy
        public static void QuickSortRecursive(int[] arr, int left, int right)
        {
            int x = arr[(left + right) / 2]; // Chọn phần tử giữa làm chốt
            int i = left;
            int j = right;
            int temp;
            while (i < j)
            {
                while (arr[i] < x)
                    i++; // Tìm phần tử lớn hơn giá trị chốt nhưng ở trước chốt
                while (arr[j] > x)
                    j--; // Tìm phần tử nhỏ hơn giá trị chốt nhưng ở sau chốt

                // Hoán vị hai phần tử đó cho nhau
                if (i <= j)
                {
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;

                    i++; // Sau khi hoán đổi, tăng i đến vị trí tiếp theo
                    j--; // Sau khi hoán đổi, giảm j đến vị trí tiếp theo
                }
            }
            if (left < j)
                QuickSortRecursive(arr, left, j);
            if (i < right)
                QuickSortRecursive(arr, i, right);
        }
        // 3.8. Sắp xếp Nhanh, trong đó phân hoạch dùng phương pháp lặp
        public static void QuickSortIterative(int[] arr, int left, int right)
        {
            int[] stack = new int[right - left + 1];
            int top = -1;

            stack[++top] = left;
            stack[++top] = right;

            while (top >= 0)
            {
                right = stack[top--];
                left = stack[top--];

                int x = arr[(left + right) / 2];
                int i = left;
                int j = right;
                int temp;

                while (i < j)
                {
                    while (arr[i] < x)
                        i++;
                    while (arr[j] > x)
                        j--;

                    if (i <= j)
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;

                        i++;
                        j--;
                    }
                }

                if (i - 1 > left)
                {
                    stack[++top] = left;
                    stack[++top] = i - 1;
                }

                if (i + 1 < right)
                {
                    stack[++top] = i + 1;
                    stack[++top] = right;
                }
            }
        }

    }
}
