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
            Console.WriteLine("\nNhap gia tri X can tim:");
            int X = int.Parse(Console.ReadLine());
            Node foundNode = bst.Find(X);
            if (foundNode != null)
            {
                Console.WriteLine($"Nut {X} duoc tim thay trong cay");
            }
            else { Console.WriteLine($"Nut {X} khong duoc tim thay trong cay"); }

            // Tìm nút lớn nhất trong cây và hiển thị giá trị của nó
            Node maxNode = bst.FindMax();
            if (maxNode != null)
            {
                Console.WriteLine($"Khoa nod lon nhat trong cay la: {maxNode.key}");
            }







            Console.ReadKey();
        }
    }
}
