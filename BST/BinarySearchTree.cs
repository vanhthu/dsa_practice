﻿using System;
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
        
        // Tìm nút có khóa X trong cây bằng phương pháp lặp
        public Node FindIterative(int X)
        {
            Node current = root; // Bắt đầu từ nút gốc
            while (current != null)
            {
                if (X == current.key)
                {
                    return current; // Trả về nút nếu tìm thấy
                }
                else if (X < current.key)
                {
                    current = current.left; // Di chuyển sang cây bên trái
                }
                else
                {
                    current = current.right; // Di chuyển sang cây bên phải
                }
            }
            return null; // Nếu không tìm thấy nút, trả về null
        }
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
        public int CountNodes()
        {
            return CountNodesRec(root);
        }

        private int CountNodesRec(Node node)
        {
            if (node == null)
            {
                return 0; // Nếu nút hiện tại là null, trả về 0
            }

            // Đếm nút hiện tại và cộng thêm số nút bên trái và bên phải
            return 1 + CountNodesRec(node.left) + CountNodesRec(node.right);
        }

        // Đếm số nút chẵn trong cây
        public int CountEvenNodes()
        {
            return CountEvenNodesRec(root);
        }

        private int CountEvenNodesRec(Node node)
        {
            if (node == null)
            {
                return 0; // Nếu nút hiện tại là null, trả về 0
            }

            // Kiểm tra nếu khóa của nút hiện tại là chẵn
            int count = (node.key % 2 == 0) ? 1 : 0;

            // Cộng thêm số nút chẵn bên trái và bên phải
            return count + CountEvenNodesRec(node.left) + CountEvenNodesRec(node.right);
        }
        // Nút lá là nút không có con, tức là nút mà cả hai con trái và con phải đều là null.
        // Đếm số nút lá trong cây
        public int CountLeafNodes()
        {
            return CountLeafNodesRec(root);
        }

        private int CountLeafNodesRec(Node node)
        {
            if (node == null)
            {
                return 0; // Nếu nút hiện tại là null, trả về 0
            }

            // Kiểm tra nếu nút hiện tại là nút lá
            if (node.left == null && node.right == null)
            {
                return 1; // Nút lá
            }

            // Đếm số nút lá bên trái và bên phải
            return CountLeafNodesRec(node.left) + CountLeafNodesRec(node.right);
        }
        // Đếm số nút chẵn
        // Đếm số nút dương
        // Đếm số nút dương trong cây
        public int CountPositiveNodes()
        {
            return CountPositiveNodesRec(root);
        }

        private int CountPositiveNodesRec(Node node)
        {
            if (node == null)
            {
                return 0; // Nếu nút hiện tại là null, trả về 0
            }

            // Kiểm tra nếu khóa của nút hiện tại là dương
            int count = (node.key > 0) ? 1 : 0;

            // Cộng thêm số nút dương bên trái và bên phải
            return count + CountPositiveNodesRec(node.left) + CountPositiveNodesRec(node.right);
        }
        // Đếm số nút có đúng một nút con
        // Đếm số nút có đúng một nút con trong cây
        public int CountNodesWithOneChild()
        {
            return CountNodesWithOneChildRec(root);
        }

        private int CountNodesWithOneChildRec(Node node)
        {
            if (node == null)
            {
                return 0; // Nếu nút hiện tại là null, trả về 0
            }

            // Biến để lưu trữ số nút có đúng một con
            int count = 0;

            // Kiểm tra nếu nút hiện tại có đúng một con
            if ((node.left == null && node.right != null) || (node.left != null && node.right == null))
            {
                count = 1; // Nút hiện tại có đúng một con
            }

            // Cộng thêm số nút có đúng một con bên trái và bên phải
            return count + CountNodesWithOneChildRec(node.left) + CountNodesWithOneChildRec(node.right);
        }
        // Tính tổng giá trị khóa các nút trong cây
        // Tính tổng giá trị khóa của các nút trong cây
        public int SumOfNodes()
        {
            return SumOfNodesRec(root);
        }

        private int SumOfNodesRec(Node node)
        {
            if (node == null)
            {
                return 0; // Nếu nút hiện tại là null, trả về 0
            }

            // Cộng giá trị khóa của nút hiện tại với tổng của các nút bên trái và bên phải
            return node.key + SumOfNodesRec(node.left) + SumOfNodesRec(node.right);
        }
        // Tính tổng giá trị khóa các nút chẵn trong cây
        // Tính tổng giá trị khóa của các nút chẵn trong cây
        public int SumOfEvenNodes()
        {
            return SumOfEvenNodesRec(root);
        }

        private int SumOfEvenNodesRec(Node node)
        {
            if (node == null)
            {
                return 0; // Nếu nút hiện tại là null, trả về 0
            }

            // Nếu khóa của nút hiện tại là chẵn, thêm vào tổng
            int sum = (node.key % 2 == 0) ? node.key : 0;

            // Cộng thêm tổng của các nút chẵn bên trái và bên phải
            return sum + SumOfEvenNodesRec(node.left) + SumOfEvenNodesRec(node.right);
        }
        // Tính tổng giá trị khóa các nút lá trong cây
        // Tính tổng giá trị khóa của các nút lá trong cây
        public int SumOfLeafNodes()
        {
            return SumOfLeafNodesRec(root);
        }

        private int SumOfLeafNodesRec(Node node)
        {
            if (node == null)
            {
                return 0; // Nếu nút hiện tại là null, trả về 0
            }

            // Nếu nút hiện tại là nút lá (không có con bên trái và bên phải)
            if (node.left == null && node.right == null)
            {
                return node.key; // Trả về giá trị khóa của nút lá
            }

            // Cộng thêm tổng của các nút lá bên trái và bên phải
            return SumOfLeafNodesRec(node.left) + SumOfLeafNodesRec(node.right);
        }
        // Đếm và tính tổng các nút của cây
        // Đếm số nút và tính tổng giá trị khóa của các nút trong cây
        public void CountAndSumNodes(out int count, out int sum)
        {
            count = 0; // Khởi tạo số nút
            sum = 0;   // Khởi tạo tổng giá trị khóa
            CountAndSumNodesRec(root, ref count, ref sum); // Gọi phương thức đệ quy
        }

        private void CountAndSumNodesRec(Node node, ref int count, ref int sum)
        {
            if (node == null)
            {
                return; // Nếu nút hiện tại là null, không làm gì cả
            }

            count++; // Tăng số lượng nút
            sum += node.key; // Cộng giá trị khóa của nút hiện tại vào tổng

            // Đệ quy cho các nút bên trái và bên phải
            CountAndSumNodesRec(node.left, ref count, ref sum);
            CountAndSumNodesRec(node.right, ref count, ref sum);
        }

        // Đếm số nút chẵn và tính tổng giá trị khóa của các nút chẵn trong cây
        public void CountAndSumEvenNodes(out int count, out int sum)
        {
            count = 0; // Khởi tạo số nút chẵn
            sum = 0;   // Khởi tạo tổng giá trị khóa của các nút chẵn
            CountAndSumEvenNodesRec(root, ref count, ref sum); // Gọi phương thức đệ quy
        }

        private void CountAndSumEvenNodesRec(Node node, ref int count, ref int sum)
        {
            if (node == null)
            {
                return; // Nếu nút hiện tại là null, không làm gì cả
            }

            // Kiểm tra nếu khóa của nút hiện tại là chẵn
            if (node.key % 2 == 0)
            {
                count++; // Tăng số lượng nút chẵn
                sum += node.key; // Cộng giá trị khóa của nút chẵn vào tổng
            }

            // Đệ quy cho các nút bên trái và bên phải
            CountAndSumEvenNodesRec(node.left, ref count, ref sum);
            CountAndSumEvenNodesRec(node.right, ref count, ref sum);
        }

        // Phương thức đếm số nút có một nút lá trong cây
        public int CountNodesWithOneLeaf(Node node)
        {
            // Nếu nút null, trả về 0
            if (node == null)
                return 0;

            // Đếm số nút trong cây con trái và cây con phải
            int count = CountNodesWithOneLeaf(node.left) + CountNodesWithOneLeaf(node.right);

            // Kiểm tra xem nút hiện tại có một nút lá không
            if ((node.left != null && IsLeaf(node.left) && node.right == null) ||
                (node.right != null && IsLeaf(node.right) && node.left == null))
            {
                count++; // Tăng biến đếm nếu điều kiện thỏa mãn
            }

            return count; // Trả về tổng số nút
        }
        private bool IsLeaf(Node node)
        {
            return node != null && node.left == null && node.right == null;
        }



        // Xác định mức của một nút X trong cây
        // mức của một nút được định nghĩa là khoảng cách từ nút gốc đến nút đó, với gốc cây có mức là 0.
        public int FindLevel(int X)
        {
            return FindLevelRec(root, X, 0); // Bắt đầu từ nút gốc với mức là 0
        }

        private int FindLevelRec(Node node, int X, int level)
        {
            if (node == null)
            {
                return -1; // Nếu nút null, trả về -1 để biểu thị không tìm thấy
            }

            // Nếu tìm thấy nút, trả về mức
            if (node.key == X)
            {
                return level;
            }

            // Nếu khóa X nhỏ hơn khóa của nút hiện tại, tìm trong cây bên trái
            if (X < node.key)
            {
                return FindLevelRec(node.left, X, level + 1);
            }
            else // Nếu khóa X lớn hơn khóa của nút hiện tại, tìm trong cây bên phải
            {
                return FindLevelRec(node.right, X, level + 1);
            }
        }
        // Xác định/Tìm bậc của một nút X trong cây
        // Bậc của một nút trong BST có thể là 0 (nếu không có con nào), 1 (nếu có một con) hoặc 2 (nếu có cả hai con).
        public int FindDegree(int X)
        {
            Node targetNode = FindIterative(X); // Tìm nút có khóa X
            if (targetNode == null)
            {
                return -1; // Nếu không tìm thấy nút, trả về -1
            }

            // Tính bậc của nút
            int degree = 0;
            if (targetNode.left != null) degree++; // Nếu có con trái
            if (targetNode.right != null) degree++; // Nếu có con phải

            return degree; // Trả về bậc của nút
        }


        // Xác định/Tìm chiều cao của cây
        // Chiều cao của một cây được định nghĩa là số lượng các mức (levels) từ nút gốc đến nút lá xa nhất.
        // Chiều cao của một cây trống được tính là -1, cây chỉ có một nút gốc có chiều cao là 0
        public int FindHeight()
        {
            return FindHeightRec(root); // Gọi phương thức đệ quy bắt đầu từ nút gốc
        }

        private int FindHeightRec(Node node)
        {
            if (node == null)
            {
                return -1; // Nếu nút là null, trả về -1
            }

            // Tính chiều cao của nút con trái và nút con phải
            int leftHeight = FindHeightRec(node.left);
            int rightHeight = FindHeightRec(node.right);

            // Chiều cao của cây là chiều cao lớn nhất giữa hai nút con cộng 1 cho nút hiện tại
            return Math.Max(leftHeight, rightHeight) + 1;
        }
        // Xóa nút có giá trị X trong cây dùng phương pháp đệ quy
        // Nếu nút cần xóa là nút lá (không có con nào), bạn chỉ cần xóa nút.
        // Nếu nút cần xóa có một con(trái hoặc phải), bạn thay thế nó bằng con còn lại.
        // Nếu nút cần xóa có hai con, bạn phải tìm một nút thay thế
        // (thường là nút nhỏ nhất trong cây con bên phải hoặc lớn nhất trong cây con bên trái)
        // để thay thế nút đó và sau đó xóa nút thay thế.
        public Node Delete(int X)
        {
            return DeleteRec(root, X);
        }

        private Node DeleteRec(Node node, int X)
        {
            if (node == null)
            {
                return node; // Nếu nút là null, trả về null
            }

            // Di chuyển đến nút cần xóa
            if (X < node.key)
            {
                node.left = DeleteRec(node.left, X); // Tìm và xóa trong cây bên trái
            }
            else if (X > node.key)
            {
                node.right = DeleteRec(node.right, X); // Tìm và xóa trong cây bên phải
            }
            else
            {
                // Nút cần xóa đã được tìm thấy
                // Trường hợp 1: Nút có một con hoặc không có con
                if (node.left == null)
                {
                    return node.right; // Trả về con phải (hoặc null)
                }
                else if (node.right == null)
                {
                    return node.left; // Trả về con trái (hoặc null)
                }

                // Trường hợp 2: Nút có hai con
                // Tìm nút nhỏ nhất trong cây con bên phải
                Node minNode = FindMin(node.right); // Hoặc bạn có thể dùng FindMax(node.left)
                node.key = minNode.key; // Thay khóa của nút hiện tại bằng khóa của nút nhỏ nhất
                node.right = DeleteRec(node.right, minNode.key); // Xóa nút nhỏ nhất khỏi cây con bên phải
            }

            return node; // Trả về nút (có thể đã được thay đổi)
        }

        // Phương thức để tìm nút nhỏ nhất (hoặc lớn nhất)
        private Node FindMin(Node node)
        {
            while (node.left != null)
            {
                node = node.left; // Di chuyển đến nút bên trái cùng
            }
            return node; // Trả về nút nhỏ nhất
        }


        // Xóa nút sau nút có giá trị X trong cây
        public Node DeleteAfterX(int X)
        {
            Node targetNode = FindIterative(X); // Tìm nút có giá trị X
            if (targetNode == null)
            {
                return null; // Nếu không tìm thấy nút X
            }

            Node nodeToDelete = targetNode.right; // Nút tiếp theo là nút bên phải của X
            if (nodeToDelete == null)
            {
                return null; // Không có nút nào đứng sau nút X
            }

            // Tìm nút nhỏ nhất trong nút bên phải
            Node minNode = FindMin(nodeToDelete);

            // Xóa nút đó
            if (minNode != null)
            {
                nodeToDelete = DeleteRec(nodeToDelete, minNode.key);
            }

            targetNode.right = nodeToDelete; // Cập nhật con phải của nút X

            return targetNode; // Trả về nút X đã được cập nhật
        }
        // Xóa nút trước nút có giá trị X trong cây **************
        // Xóa nút có giá trị X trong cây dùng phương pháp lặp
        // Xóa nút có giá trị X trong cây bằng phương pháp lặp
        public Node DeleteIterative(int X)
        {
            Node current = root;
            Node parent = null;

            // Tìm nút cần xóa và lưu trữ nút cha
            while (current != null && current.key != X)
            {
                parent = current;
                if (X < current.key)
                {
                    current = current.left; // Di chuyển sang cây bên trái
                }
                else
                {
                    current = current.right; // Di chuyển sang cây bên phải
                }
            }

            // Nếu không tìm thấy nút cần xóa
            if (current == null)
            {
                Console.WriteLine($"Nút có khóa {X} không tồn tại trong cây.");
                return root; // Trả về gốc cây không thay đổi
            }

            // Bắt đầu xóa nút
            // Trường hợp 1: Nút cần xóa có một con hoặc không có con
            if (current.left == null && current.right == null)
            {
                if (parent == null)
                {
                    root = null; // Nếu nút gốc được xóa
                }
                else if (parent.left == current)
                {
                    parent.left = null; // Xóa nút bên trái
                }
                else
                {
                    parent.right = null; // Xóa nút bên phải
                }
            }
            else if (current.left == null) // Nút chỉ có con phải
            {
                if (parent == null)
                {
                    root = current.right; // Cập nhật gốc
                }
                else if (parent.left == current)
                {
                    parent.left = current.right; // Thay thế bằng con phải
                }
                else
                {
                    parent.right = current.right; // Thay thế bằng con phải
                }
            }
            else if (current.right == null) // Nút chỉ có con trái
            {
                if (parent == null)
                {
                    root = current.left; // Cập nhật gốc
                }
                else if (parent.left == current)
                {
                    parent.left = current.left; // Thay thế bằng con trái
                }
                else
                {
                    parent.right = current.left; // Thay thế bằng con trái
                }
            }
            else // Trường hợp nút cần xóa có hai con
            {
                // Tìm nút nhỏ nhất trong cây con bên phải
                Node minNode = FindMin(current.right); // Nút nhỏ nhất
                int minValue = minNode.key; // Lưu giá trị của nút nhỏ nhất

                // Xóa nút nhỏ nhất
                current.right = DeleteIterative(minValue); // Có thể gọi delete cho nút nhỏ nhất

                // Cập nhật giá trị của nút cần xóa với giá trị của nút nhỏ nhất
                current.key = minValue;
            }

            return root; // Trả về gốc cây đã được cập nhật
        }


        // Phương thức để lấy các nút con trái có 1 nút lá
        public List<int> LietKeNutConTraiCoMotNutLa(Node node)
        {
            List<int> kq = new List<int>();

            // Đệ quy duyệt cây
            void LietKeNutConTraiCoMotNutLaRec(Node current)
            {
                if (current == null)
                    return;

                // Kiểm tra nếu nút bên trái có một nút lá
                if (current.left != null && current.left.left == null && current.left.right == null)
                {
                    kq.Add(current.left.key);
                }

                // Tiếp tục duyệt cây
                LietKeNutConTraiCoMotNutLaRec(current.left);
                LietKeNutConTraiCoMotNutLaRec(current.right);
            }

            LietKeNutConTraiCoMotNutLaRec(node);
            return kq;
        }

        // Phương thức liệt kê các nút con trái có nút lá cách 2
        public void ListLeftChildrenWithLeaves(Node node)
        {
            if (node != null)
            {
                // Kiểm tra xem nút có con bên trái hay không
                if (node.left != null)
                {
                    // Kiểm tra xem con bên trái có phải là nút lá hay không
                    if (node.left.left == null && node.left.right == null)
                    {
                        Console.WriteLine("Nút con trái có nút lá: " + node.left.key);
                    }
                }
                // Duyệt các nút con bên trái và bên phải
                ListLeftChildrenWithLeaves(node.left);
                ListLeftChildrenWithLeaves(node.right);
            }
        }


        // Liệt kê các nút con phải có một nút lá trên cây
        public void ListRightChildrenWithLeaves(Node node)
        {
            if (node != null)
            {
                // Kiểm tra xem nút có con bên phải hay không
                if (node.right != null)
                {
                    // Kiểm tra xem con bên phải có phải là nút lá hay không
                    if (node.right.left == null && node.right.right == null)
                    {
                        Console.WriteLine("Nút con phải có nút lá: " + node.right.key);
                    }
                }
                // Duyệt các nút con bên trái và bên phải
                ListRightChildrenWithLeaves(node.left);
                ListRightChildrenWithLeaves(node.right);
            }
        }

        // Liệt kê các nút con phải có một hai lá trên cây
        // Phương thức liệt kê các nút con phải có hai nút lá
        public void ListRightChildrenWithTwoLeaves(Node node)
        {
            if (node != null)
            {
                // Kiểm tra xem nút có con bên phải hay không
                if (node.right != null)
                {
                    // Kiểm tra cả hai con bên trái và bên phải của nút con bên phải có phải là nút lá hay không
                    if (node.right.left != null && node.right.left.left == null && node.right.left.right == null &&
                        node.right.right != null && node.right.right.left == null && node.right.right.right == null)
                    {
                        Console.WriteLine("Nút con phải có hai nút lá: " + node.right.key);
                    }
                }
                // Duyệt qua các nút con bên trái và phải
                ListRightChildrenWithTwoLeaves(node.left);
                ListRightChildrenWithTwoLeaves(node.right);
            }
        }
        /*
         // Phương thức kiểm tra xem một nút có phải là nút lá hay không
        private bool IsLeaf(Node node)
        {
            return node != null && node.left == null && node.right == null;
        }

        // Phương thức liệt kê các nút con phải có hai nút lá
        public void ListRightChildrenWithTwoLeaves(Node node)
        {
            if (node != null)
            {
                // Kiểm tra xem nút có con bên phải hay không
                if (node.right != null)
                {
                    // Kiểm tra xem cả hai con bên trái và bên phải của nút con bên phải có phải là nút lá hay không
                    if (IsLeaf(node.right.left) && IsLeaf(node.right.right))
                    {
                        Console.WriteLine("Nút con phải có hai nút lá: " + node.right.key);
                    }
                }
                // Duyệt qua các nút con bên trái và phải
                ListRightChildrenWithTwoLeaves(node.left);
                ListRightChildrenWithTwoLeaves(node.right);
            }
        }
         */

        // Liệt kê các nút chẵn trên cây
        public void ListEvenNodes(Node node)
        {
            if (node != null)
            {
                // Kiểm tra xem giá trị của nút có phải là chẵn không
                if (node.key % 2 == 0)
                {
                    Console.WriteLine("Nút chẵn: " + node.key);
                }
                // Duyệt qua các nút con trái và phải
                ListEvenNodes(node.left);
                ListEvenNodes(node.right);
            }
        }
        // Liệt kê các nút lẻ trên cây
        public void ListOddNodes(Node node)
        {
            if (node != null)
            {
                // Kiểm tra xem giá trị của nút có phải là chẵn không
                if (node.key % 2 != 0)
                {
                    Console.WriteLine("Nut le: " + node.key);
                }
                // Duyệt qua các nút con trái và phải
                ListOddNodes(node.left);
                ListOddNodes(node.right);
            }
        }
        // Liệt kê các nút chẵn có một nút lá trên cây
        public void ListEvenNodesWithLeaves(Node node)
        {
            if (node != null)
            {
                // Kiểm tra xem giá trị của nút có phải là chẵn không
                if (node.key % 2 == 0)
                {
                    // Kiểm tra con trái và con phải
                    if ((node.left != null && node.left.left == null && node.left.right == null) ||
                        (node.right != null && node.right.left == null && node.right.right == null))
                    {
                        Console.WriteLine("Nút chẵn có 1 nút lá: " + node.key);
                    }
                }
                // Duyệt qua các nút con trái và phải
                ListEvenNodesWithLeaves(node.left);
                ListEvenNodesWithLeaves(node.right);
            }
        }
        // Phương thức liệt kê các nút có một nút lá
        public void ListNodesWithOneLeaf(Node node)
        {
            if (node != null)
            {
                // Kiểm tra xem nút hiện tại có một nút lá không
                if ((node.left != null && IsLeaf(node.left) && node.right == null) ||
                    (node.right != null && IsLeaf(node.right) && node.left == null))
                {
                    Console.WriteLine("Nút có một nút lá: " + node.key);
                }

                // Duyệt qua các nút con bên trái và bên phải
                ListNodesWithOneLeaf(node.left);
                ListNodesWithOneLeaf(node.right);
            }
        }
    }
}
