using Microsoft.VisualBasic;

namespace BST
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Cái này là tạo cây từ mảng số nguyên
            int[] values = { 10, 6, 15, 12, 9, 26, 14, 56, 35 };
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
            //bst.AddLoop(100);

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

            // Tìm nút có giá trị X trong cay bằng phương pháp lặp
            //Console.WriteLine("Nhap gia tri X can tim");
            //int X = int.Parse(Console.ReadLine());

            //Node foundNode = bst.FindIterative(X);
            //if (foundNode != null)
            //{
            //    Console.WriteLine($"Nut {X} duoc tim thay.");
            //}
            //else
            //{
            //    Console.WriteLine($"Nut {X} khong duoc tim thay.");
            //}

            // Tìm nút lớn nhất trong cây và hiển thị giá trị của nó
            //Node maxNode = bst.FindMax();
            //if (maxNode != null)
            //{
            //    Console.WriteLine($"Khoa lon nhat trong cay la: {maxNode.key}");
            //}

            // Tìm nút chẵn lớn nhất trong cây và hiển thị giá trị của nó
            //Node maxEvenNode = bst.FindMaxEven();
            //if (maxEvenNode != null)
            //{
            //    Console.WriteLine($"Khoa lon nhat trong cay la: {maxEvenNode.key}");
            //}
            //else
            //{
            //    Console.WriteLine("Khong co nut chan trong cay.");
            //}
            // Tìm nút nhỏ nhất trong cây và hiển thị giá trị của nó
            //Node minNode = bst.FindMin();
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
            //Console.WriteLine("Nhap gia tri X:");
            //int X = int.Parse(Console.ReadLine());

            //Node lessOrEqualNode = bst.FindLessOrEqual(X);
            //if (lessOrEqualNode != null)
            //{
            //    Console.WriteLine($"Nut co khoa nho hon hoac gan bang {X} là: {lessOrEqualNode.key}");
            //}

            // Đếm số nút trong cây và hiển thị kết quả
            //int totalNodes = bst.CountNodes();
            //Console.WriteLine($"So nut co trong cay la: {totalNodes}");

            // Đếm số nút chẵn trong cây và hiển thị kết quả
            //int totalEvenNodes = bst.CountEvenNodes();
            //Console.WriteLine($"So nut chan co o trong cay la: {totalEvenNodes}");

            // Đếm số nút lá trong cây và hiển thị kết quả
            //int totalLeafNodes = bst.CountLeafNodes();
            //Console.WriteLine($"So nut la o trong cay la: {totalLeafNodes}");

            // Đếm số nút dương trong cây và hiển thị kết quả
            //int totalPositiveNodes = bst.CountPositiveNodes();
            //Console.WriteLine($"So nut duong o trong cay la: {totalPositiveNodes}");

            // Đếm số nút có đúng một nút con trong cây và hiển thị kết quả
            //int totalNodesWithOneChild = bst.CountNodesWithOneChild();
            //Console.WriteLine($"So nut co dung mot nut con o trong cay: {totalNodesWithOneChild}");

            // Tính tổng giá trị khóa của các nút trong cây và hiển thị kết quả
            //int totalSum = bst.SumOfNodes();
            //Console.WriteLine($"Tong gia tri khoa cac nut trong cay: {totalSum}");

            // Tính tổng giá trị khóa của các nút chẵn trong cây và hiển thị kết quả
            //int totalEvenSum = bst.SumOfEvenNodes();
            //Console.WriteLine($"Tong gia tri khoa cac nut chan trong cay: {totalEvenSum}");

            // Tính tổng giá trị khóa của các nút lá trong cây và hiển thị kết quả
            //int totalLeafSum = bst.SumOfLeafNodes();
            //Console.WriteLine($"Tong gia tri khoa cac nut la trong cay: {totalLeafSum}");

            // Đếm số nút và tính tổng giá trị khóa của các nút trong cây
            //int totalCount;
            //int totalSum;
            //bst.CountAndSumNodes(out totalCount, out totalSum);

            //Console.WriteLine($"So nut trong cay: {totalCount}");
            //Console.WriteLine($"Tong cac gia tri khoa: {totalSum}");

            // Đếm số nút chẵn và tính tổng giá trị khóa của các nút chẵn trong cây
            //int totalEvenCount;
            //int totalEvenSum;
            //bst.CountAndSumEvenNodes(out totalEvenCount, out totalEvenSum);

            //Console.WriteLine($"So nut chan trong cay: {totalEvenCount}");
            //Console.WriteLine($"Tong gia tri khoa cac nut chan trong cay: {totalEvenSum}");


            // ĐẾM SỐ NÚT CÓ 1 NÚT LÁ TRONG CÂY VÀ HIỂN THỊ RA KẾT QUẢ
            // Đếm số nút có một nút lá
            //int count = bst.CountNodesWithOneLeaf(bst.root);
            //Console.WriteLine("Số nút có một nút lá: " + count);

            // Nhập giá trị X để tìm mức
            //Console.WriteLine("Nhap gia tri X de xac dinh muc cua cay:");
            //int X = int.Parse(Console.ReadLine());

            //int level = bst.FindLevel(X);
            //if (level != -1)
            //{
            //    Console.WriteLine($"Muc cua nut X {X} la: {level}");
            //}

            // Nhập giá trị X để xác định bậc của nó trong cây
            //Console.WriteLine("Nhap gia tri X de xac dinh bac cua cay:");
            //int X = int.Parse(Console.ReadLine());

            //int degree = bst.FindDegree(X);
            //if (degree != -1)
            //{
            //    Console.WriteLine($"Bac cua nut X {X} la: {degree}");
            //}

            // Tính chiều cao của cây và hiển thị kết quả
            //int height = bst.FindHeight();
            //Console.WriteLine($"Chieu cao cau cay: {height}");

            // Nhập giá trị X để xóa nút
            //Console.WriteLine("Nhap gia tri X de xoa nut:");
            //int X = int.Parse(Console.ReadLine());
            //bst.root = bst.Delete(X); // Gọi phương thức xóa
            //Console.WriteLine($"Nut {X} da duoc xoa.");

            // Nhập giá trị X để xóa nút sau nút có giá trị X (************************)
            //Console.WriteLine("Nhap gia tri X de xoa nut sau gia tri X:");
            //int X = int.Parse(Console.ReadLine());

            //bst.root = bst.DeleteAfterX(X); // Gọi phương thức xóa

            //if (bst.root == null)
            //{
            //    Console.WriteLine($"Nut dung sau khoa {X} da duoc xoa.");
            //}

            // Nhập giá trị X để xóa nút
            //Console.WriteLine("Nhap X de xoa nut:");
            //int X = int.Parse(Console.ReadLine());

            //bst.root = bst.DeleteIterative(X); // Gọi phương thức xóa

            //Console.WriteLine($"Nut {X} da duoc xoa.");

            // Lấy và hiển thị các nút con trái có một nút lá
            //List<int> nutConTraiCoMotNutLa = bst.LietKeNutConTraiCoMotNutLa(bst.root);

            //Console.WriteLine("Cac nut con trai co 1 nut la:");
            //foreach (var key in nutConTraiCoMotNutLa)
            //{
            //    Console.WriteLine(key);
            //}


            // Lấy và hiển thị các nút con phải có một nút lá (*********************)
            // Lấy và hiển thị các nút con phải có một nút lá
            //List<int> nutConPhaiCoMotNutLa = bst.LietKeNutConPhaiCoMotNutLa(bst.root);

            //Console.WriteLine("Các nút con phải có 1 nút lá:");
            //if (nutConPhaiCoMotNutLa.Count == 0)
            //{
            //    Console.WriteLine("Không có nút con phải nào có một nút lá.");
            //}
            //else
            //{
            //    foreach (var key in nutConPhaiCoMotNutLa)
            //    {
            //        Console.WriteLine(key);
            //    }
            //}

            // Liệt kê các nút con phải có một nút lá
            //Console.WriteLine("Danh sách các nút con phải có nút lá:");
            //bst.ListRightChildrenWithLeaves(bst.root);

            // Liệt kê các nút con trái có một nút lá
            //Console.WriteLine("Danh sách các nút con trái có nút lá:");
            //bst.ListLeftChildrenWithLeaves(bst.root);

            // Liệt kê các nút chẵn trên cây
            //Console.WriteLine("Danh sách các nút chẵn:");
            //bst.ListEvenNodes(bst.root);

            // Liệt kê các nút lẻ trên cây
            //Console.WriteLine("Danh sách các nút lẻ:");
            //bst.ListOddNodes(bst.root);

            // Liệt kê các nút chẵn có 1 nút lá
            //Console.WriteLine("Danh sách các nút chẵn có 1 nút lá:");
            //bst.ListEvenNodesWithLeaves(bst.root);

            // Liệt kê các nút con phải có hai nút lá
            //Console.WriteLine("Danh sách các nút con phải có hai nút lá:");
            //bst.ListRightChildrenWithTwoLeaves(bst.root);

            //bst.Display(bst.root);

            // Liệt kê các nút có một nút lá
            Console.WriteLine("Danh sách các nút có một nút lá:");
            bst.ListNodesWithOneLeaf(bst.root);



            Console.ReadKey();
        }
    }
}
