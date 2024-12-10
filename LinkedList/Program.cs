

namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            

            // Thêm đầu
            list.AddToFront(5);
            list.AddToFront(3);
            //list.AddToFront(3);

            // Thêm cuối
            list.AddToEnd(7);
            list.AddToEnd(2);

            // Thêm nút X vào sau nut V
            list.AddAfter(4, 3);

            // Thêm nút X  vao truoc nut V
            list.AddBefore(6, 7);

            list.PrintList();


            //Console.WriteLine();
            //Console.WriteLine("Tong: " + list.Sum());
            //Console.WriteLine();

            //Console.WriteLine("Trung binh: " + list.Average());
            //Console.WriteLine();

            //Node foundNode = list.Find(3);
            //if (foundNode != null)
            //{
            //    Console.WriteLine("Tim thay nut co gia tri la 3.");
            //    Console.WriteLine();
            //}


            //1.8.2. Tìm node sau nút có giá trị X trong danh sách.
            //Node foundAfter = list.FindAfter(3);
            //if (foundAfter != null)
            //{
            //    Console.WriteLine("Nut sau gia tri 3 co gia tri la: " + foundAfter.Data);
            //    Console.WriteLine();
            //}

            //1.8.3. Tim node trước node có giá trị X trong danh sách.
            //Node foundBefore = list.FindBefore(7);
            //if (foundBefore != null)
            //{
            //    Console.WriteLine("Nut truoc gia tri 7 co gia tri: " + foundBefore.Data);
            //    Console.WriteLine();
            //}

            //1.9. Tìm nút có giá trị lớn nhất sau cùng trong danh sách. 
            //Node max = list.FindMax();
            //if (max != null)
            //{
            //    Console.WriteLine("Gia tri lon nhat trong danh sach la: " + max.Data);
            //    Console.WriteLine();
            //}

            //1.9.1. Tìm nút có giá trị lớn nhất đầu tiên trong danh sách. 
            //Node max = list.FindMaxFirst();
            //if (max != null)
            //{
            //    Console.WriteLine("Gia tri lon nhat trong danh sach la: " + max.Data);
            //    Console.WriteLine();
            //}

            //1.9.2. Tìm nút có giá trị nhỏ nhất sau cùng trong danh sách. 
            Node minNode = list.FindMinFirst();
            Console.WriteLine(minNode != null ? "Giá trị nhỏ nhất đầu tiên: " + minNode.Data : "Danh sách rỗng.");

            //1.10. Tìm nút có giá trị chẵn lớn nhất trong danh sách
            //Node maxEven = list.FindMaxEven();
            //if (maxEven != null)
            //{
            //    Console.WriteLine("Gia tri chan lon nhat trong danh sach la: " + maxEven.Data);
            //    Console.WriteLine();
            //}

            //Console.WriteLine("So nut trong danh sach: " + list.Count());
            //Console.WriteLine();

            //Console.WriteLine("So nut le trong danh sach: " + list.CountOdds());
            //Console.WriteLine();

            // Đếm số nút có giá trị lẻ nhỏ nhất trong danh sách.
            //Console.WriteLine("So nut co gia tri le nho nhat: " + list.CountSmallestOdds());
            //Console.WriteLine();

            //list.Delete(3);
            //list.PrintList();
            //Console.WriteLine();

            //list.DeleteAfter(list.Find(5));
            //list.PrintList();
            //Console.WriteLine();

            //list.DeleteFirst();
            //list.PrintList();
            //Console.WriteLine();

            //list.DeleteLast();
            //list.PrintList();
            //Console.WriteLine();

            //list.Clear();
            //list.PrintList();
            //Console.WriteLine();

            Console.ReadKey();
        }
    }
}
