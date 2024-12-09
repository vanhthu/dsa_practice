using Microsoft.VisualBasic;

namespace BST
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Cái này là tạo cây từ mảng số nguyên
            int[] values = { 10, 6, 15, 12, 9, 12, 26, 14, 56, 35 };
            BinarySearchTree bst = new BinarySearchTree();

            // Chèn các giá trị vào cây BST 
            foreach (var value in values)
            {
                bst.Insert(value);
            }

            // Hiển thị kết quả
            bst.Display(bst.root);

            // Thêm nút có giá trị khóa X vào cây dùng phương pháp đệ quy
            //bst.Add(100);

            // Thêm nút có giá trị khóa X vào cây dùng phương pháp lặp
            bst.AddLoop(100);

            // Tạo cây từ các số nhập từ bàn phím
            //bst.CreateTreeFromInput();

            // Tìm nút có khóa X trong cây dùng phương pháp đệ quy
            //Console.WriteLine("\nNhap gia tri X can tim:");
            //int X = int.Parse(Console.ReadLine());
            //Node foundNode = bst.Find(X);
            //if (foundNode != null)
            //{
            //    Console.WriteLine($"Nut {X} duoc tim thay trong cay");
            //}
            //else { Console.WriteLine($"Nut {X} khong duoc tim thay trong cay"); }

            // Tìm nút lớn nhất trong cây và hiển thị giá trị của nó
            Node maxNode = bst.FindMax();
            if (maxNode != null)
            {
                Console.WriteLine($"Khoa lon nhat trong cay la: {maxNode.key}");
            }

            // Tìm nút chẵn lớn nhất trong cây và hiển thị giá trị của nó
            Node maxEvenNode = bst.FindMaxEven();
            if (maxEvenNode != null)
            {
                Console.WriteLine($"Khoa lon nhat trong cay la: {maxEvenNode.key}");
            }
            else
            {
                Console.WriteLine("Khong co nut chan trong cay.");
            }
            // Tìm nút nhỏ nhất trong cây và hiển thị giá trị của nó
            Node minNode = bst.FindMin();
            //if (minNode != null)
            //{
            //    Console.WriteLine($"Khoa nho nhat trong cay la: {minNode.key}");
            //}

            // Tìm nút chẵn nhỏ nhất trong cây và hiển thị giá trị của nó
            //Node minEvenNode = bst.FindMinEven();
            //if (minEvenNode != null)
            //{
            //    Console.WriteLine($"Khoa chan nho nhat trong cay la: {minEvenNode.key}");
            //}

            // Nhập giá trị X để tìm nút lớn hơn hoặc gần bằng (****************************)
            //Console.WriteLine("Nhap gia tri:");
            //int X = int.Parse(Console.ReadLine());

            //Node greaterOrEqualNode = bst.FindGreaterOrEqual(X);
            //if (greaterOrEqualNode != null)
            //{
            //    Console.WriteLine($"Nut co khoa lon hon va gan bang {X} là: {greaterOrEqualNode.key}");
            //}

            // Nhập giá trị X để tìm nút nhỏ hơn hoặc gần bằng (****************************)
            Console.WriteLine("Nhap gia tri X:");
            int X = int.Parse(Console.ReadLine());

            Node lessOrEqualNode = bst.FindLessOrEqual(X);
            if (lessOrEqualNode != null)
            {
                Console.WriteLine($"Nut co khoa nho hon hoac gan bang {X} là: {lessOrEqualNode.key}");
            }
            








            Console.ReadKey();
        }
    }
}
