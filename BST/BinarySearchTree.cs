using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BST
{
    internal class BinarySearchTree
    {
        // nút gốc
        public Node root;
        public BinarySearchTree()
        {
            root = null;
        }
        // 0. Hiển thị lên màn hình giá trị khóa 1 nút
        public void Display(Node node)
        {
            //Console.WriteLine("PreOrder (NLR):");
            //PreOrder(node);
            Console.WriteLine("\nInOrder (LNR):");
            InOrder(node);
            //Console.WriteLine("\nPostOrder (LRN):");
            //PostOrder(node);
            Console.WriteLine();
        }

        // Thêm nút vào cây BST
        public void Insert(int aKey)
        {
            root = InsertRec(root, aKey);
        }
        private Node InsertRec(Node aRoot, int aKey)
        {
            if (aRoot == null)
            {
                aRoot = new Node(aKey);
                return aRoot;
            }

            if (aKey < aRoot.key)
            {
                aRoot.left = InsertRec(aRoot.left, aKey);
            }
            else
            {
                aRoot.right = InsertRec(aRoot.right, aKey);
            }

            return aRoot;
        }

        // Duyệt các node => Sau đó xuất ra màn hình
        // Các phương thức duyệt Node: NLR, LNR, LRN (cả 3 phương pháp bên dưới đều dùng đệ quy)
        // NLR
        public void PreOrder(Node node)
        {
            if (node != null)
            {
                Console.Write(node.key + " ");
                PreOrder(node.left);
                PreOrder(node.right);
            }
        }
        // LNR
        public void InOrder(Node node) {
            if (node != null)
            {
                InOrder(node.left);
                Console.Write(node.key + " ");
                InOrder(node.right);
            }
        }
        // LRN
        public void PostOrder(Node node) {
            if (node != null)
            {
                PostOrder(node.left);
                PostOrder(node.right);
                Console.Write(node.key + " ");
            }
        }
        // Thêm nút có giá trị khóa X vào cây dùng phương pháp đệ quy
        // Phương thức thêm nút
        public void Add(int X)
        {
            root = AddRec(root, X);
        }

        private Node AddRec(Node aRoot, int X)
        {            
            if (aRoot == null)
            {
                return new Node(X);
            }
            // So sánh và quyết định thêm trái hay thêm phải
            if (X < aRoot.key)
            {
                aRoot.left = AddRec(aRoot.left, X); 
            }
            else
            {
                aRoot.right = AddRec(aRoot.right, X); 
            }

            return aRoot; 
        }

        // Thêm nút có giá trị khóa X vào cây dùng phương pháp lặp
        public void AddLoop(int X)
        {
            Node newNode = new Node(X);

            // Nếu cây rỗng, gán nút mới cho gốc
            if (root == null)
            {
                root = newNode;
                return;
            }

            Node current = root;
            Node parent = null;

            while (true)
            {
                parent = current;

                // So sánh và tìm vị trí chèn
                if (X < current.key)
                {
                    current = current.left;
                    
                    if (current == null)
                    {
                        parent.left = newNode;
                        return;
                    }
                }
                else
                {
                    current = current.right;

                    if (current == null)
                    {
                        parent.right = newNode;
                        return;
                    }
                }
            }
        }
        // Phương thức tạo cây từ số nhập từ bàn phím
        public void CreateTreeFromInput()
        {
            Console.WriteLine("Nhập số nguyên (nhấn Enter sau mỗi số, nhập 'q' để kết thúc):");

            while (true)
            {
                string input = Console.ReadLine();
                if (input.ToLower() == "q") // Nhập 'q' để ngừng nhập
                {
                    break;
                }

                if (int.TryParse(input, out int number)) // Kiểm tra xem input có phải là số nguyên
                {
                    Insert(number); 
                }
                else
                {
                    Console.WriteLine("Vui long nhap mot so hop le!");
                }
            }
        }

        // Tìm nút có khóa X trong cây dùng phương pháp đệ quy
        public Node Find(int X)
        {
            return FindRec(root, X);
        }

        private Node FindRec(Node aRoot, int X)
        {
            if (aRoot == null)
            {
                return null;
            }

            // Nếu nút hiện tại có khóa X, trả về nút đó
            if (X == aRoot.key)
            {
                return aRoot;
            }

            // Nếu x nhỏ hơn nút hiện tại, tìm trong cây bên trái
            if (X < aRoot.key)
            {
                return FindRec(aRoot.left, X);
            }
            else // Nếu x lớn hơn nút hiện tại, tìm trong cây bên phải
            {
                return FindRec(aRoot.right, X);
            }
        }
        // Tìm nút có khóa X trong cây dùng phương pháp lặp
        
        // Tìm nút có khóa lớn nhất trong cây
        public Node FindMax()
        {
            return FindMaxRec(root);
        }

        private Node FindMaxRec(Node node)
        {
            if (node == null)
            {
                return null; // Nếu cây rỗng, trả về null
            }

            // Di chuyển đến nút bên phải cho đến khi không còn nút nào
            while (node.right != null)
            {
                node = node.right;
            }
            return node; // Trả về nút lớn nhất
        }
        
        // Tìm nút chẵn lớn nhất trong cây
        public Node FindMaxEven()
        {
            return FindMaxEvenRec(root);
        }

        private Node FindMaxEvenRec(Node node)
        {
            Node maxEvenNode = null; // Biến để lưu trữ nút chẵn lớn nhất

            while (node != null)
            {
                // Kiểm tra nếu giá trị nút là chẵn
                if (node.key % 2 == 0)
                {
                    // Nếu chưa có maxEvenNode hoặc nút hiện tại lớn hơn nút lớn nhất đã tìm thấy
                    if (maxEvenNode == null || node.key > maxEvenNode.key)
                    {
                        maxEvenNode = node;
                    }
                }

                // Di chuyển qua cây cho tới khi không còn nút nào
                if (node.right != null)
                {
                    node = node.right; // Di chuyển sang nút bên phải
                }
                else if (node.left != null)
                {
                    node = node.left; // Di chuyển sang nút bên trái
                }
                else
                {
                    break; // Không còn nút nào để di chuyển
                }
            }

            return maxEvenNode; // Trả về nút chẵn lớn nhất
        }
        
        // Tìm nút có khóa nhỏ nhất trong cây
        public Node FindMin()
        {
            return FindMinRec(root);
        }

        private Node FindMinRec(Node node)
        {
            if (node == null)
            {
                return null; // Nếu cây rỗng, trả về null
            }

            // Di chuyển đến nút bên trái cho đến khi không còn nút nào
            while (node.left != null)
            {
                node = node.left;
            }
            return node; // Trả về nút nhỏ nhất
        }

        // Tìm nút chẵn nhỏ nhất trong cây
        public Node FindMinEven()
        {
            return FindMinEvenRec(root);
        }

        private Node FindMinEvenRec(Node node)
        {
            Node minEvenNode = null; // Biến để lưu trữ nút chẵn nhỏ nhất

            while (node != null)
            {
                // Kiểm tra nếu giá trị nút là chẵn
                if (node.key % 2 == 0)
                {
                    // Nếu chưa có minEvenNode hoặc nút hiện tại nhỏ hơn nút nhỏ nhất đã tìm thấy
                    if (minEvenNode == null || node.key < minEvenNode.key)
                    {
                        minEvenNode = node;
                    }
                }

                // Di chuyển qua cây
                if (node.left != null)
                {
                    node = node.left; // Di chuyển sang nút bên trái
                }
                else if (node.right != null)
                {
                    node = node.right; // Di chuyển sang nút bên phải
                }
                else
                {
                    break; // Không còn nút nào để di chuyển
                }
            }

            return minEvenNode; // Trả về nút chẵn nhỏ nhất
        }

        // Tìm nút lớn hơn và gần bằng nhất với nút khóa X
        // Tìm nút có khóa lớn hơn hoặc gần bằng nhất với X (******************)
        public Node FindGreaterOrEqual(int X)
        {
            return FindGreaterOrEqualRec(root, X);
        }

        private Node FindGreaterOrEqualRec(Node node, int X)
        {
            Node result = null; // Biến để lưu trữ nút lớn hơn hoặc cạnh bằng
            while (node != null)
            {
                // Nếu khóa của nút hiện tại lớn hơn hoặc bằng X
                if (node.key >= X)
                {
                    result = node; // Cập nhật kết quả
                    node = node.left; // Di chuyển sang cây bên trái để tìm nút gần hơn với X
                }
                else
                {
                    node = node.right; // Di chuyển sang cây bên phải
                }
            }
            return result; // Trả về nút tìm được
        }
        // Tìm nút nhỏ hơn và gần bằng nhất với nút khóa X
        // Tìm nút có khóa nhỏ hơn hoặc gần bằng nhất với X
        public Node FindLessOrEqual(int X)
        {
            return FindLessOrEqualRec(root, X);
        }

        private Node FindLessOrEqualRec(Node node, int X)
        {
            Node result = null; // Biến để lưu trữ nút nhỏ hơn hoặc gần bằng
            while (node != null)
            {
                // Nếu khóa của nút hiện tại nhỏ hơn hoặc bằng X
                if (node.key <= X)
                {
                    result = node; // Cập nhật kết quả
                    node = node.right; // Di chuyển sang cây bên phải để tìm nút lớn hơn nhưng vẫn nhỏ hơn hoặc bằng X
                }
                else
                {
                    node = node.left; // Di chuyển sang cây bên trái
                }
            }
            return result; // Trả về nút tìm được
        }
        // Đếm số nút trong cây
        // Đếm số nút chẵn trong cây
        // Đếm số nút lá
        // Đếm số nút chẵn
        // Đếm số nút dương
        // Đếm số nút có đúng một nút con
        // Tính tổng giá trị khóa các nút trong cây
        // Tính tổng giá trị khóa các nút chẵn trong cây
        // Tính tổng giá trị khóa các nút lá trong cây
        // Xác định mức của một nút trong cây
        // Xác định bậc của một nút trong cây
        // Xác định chiều cao của cây
        // Xóa nút có giá trị X trong cây dùng phương pháp đệ quy
        // Xóa nút sau nút có giá trị X trong cây
        // Xóa nút trước nút có giá trị X trong cây
        // Xóa nút có giá trị X trong cây dùng phương pháp lặp




    }
}
