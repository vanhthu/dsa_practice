using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class LinkedList
    {
        public Node Head { get; private set; }

        public LinkedList()
        {
            Head = null;
        }

        //1.3 Duyệt danh sách
        public void PrintList()
        {
            Node current = Head;
            while (current != null)
            {
                Console.Write(current.Data + " -> ");
                current = current.Next;
            }
            Console.WriteLine("null");
        }

        // VIẾT CÁC PHƯƠNG THỨC THÊM
        // 1.4. Thêm node có giá trị X vào đầu danh sách.
        public void AddToFront(int value)
        {
            Node newNode = new Node(value);
            newNode.Next = Head;
            Head = newNode;
        }

        //1.5. Thêm node có giá trị X vào cuối danh sách.
        public void AddToEnd(int value)
        {
            Node newNode = new Node(value);
            if (Head == null)
            {
                Head = newNode;
                return;
            }

            Node current = Head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newNode;
        }

        //1.6. Thêm node có giá trị X vào sau một node có giá trị V trong danh sách.
        public void AddAfter(int value, int afterValue)
        {
            Node current = Head;
            while (current != null && current.Data != afterValue)
            {
                current = current.Next;
            }

            if (current != null)
            {
                Node newNode = new Node(value);
                newNode.Next = current.Next;
                current.Next = newNode;
            }
        }

        //1.7. Thêm node có giá trị Y trước node có giá trị X trong danh sách.
        public void AddBefore(int value, int beforeValue)
        {
            if (Head == null)
                return;

            if (Head.Data == beforeValue)
            {
                AddToFront(value);
                return;
            }

            Node current = Head;
            while (current.Next != null && current.Next.Data != beforeValue)
            {
                current = current.Next;
            }

            if (current.Next != null)
            {
                Node newNode = new Node(value);
                newNode.Next = current.Next;
                current.Next = newNode;
            }
        }

        //Tính Tổng
        public int Sum()
        {
            int sum = 0;
            Node current = Head;
            while (current != null)
            {
                sum += current.Data;
                current = current.Next;
            }
            return sum;
        }

        //Tính trung bình cộng
        public double Average()
        {
            int count = 0;
            Node current = Head;
            while (current != null)
            {
                count++;
                current = current.Next;
            }
            if (count == 0)
                return 0;

            int sum = 0;
            current = Head;
            while (current != null)
            {
                sum += current.Data;
                current = current.Next;
            }
            return (double)sum / count;
        }

        // VIẾT CÁC PHƯƠNG THỨC TÌM
        //1.8.1. Tìm node có giá trị X trong danh sách.
        public Node Find(int value)
        {
            Node current = Head;
            while (current != null)
            {
                if (current.Data == value)
                {
                    return current;
                }
                current = current.Next;
            }
            return null;
        }

        //1.8.2. Tìm node sau nút có giá trị X trong danh sách.
        public Node FindAfter(int value)
        {
            Node current = Head;
            while (current != null)
            {
                if (current.Data == value)
                {
                    return current.Next;
                }
                current = current.Next;
            }
            return null;
        }

        //1.8.3. Tim node trước node có giá trị X trong danh sách.
        public Node FindBefore(int value)
        {
            if (Head == null || Head.Data == value)
                return null;

            Node current = Head;
            while (current.Next != null && current.Next.Data != value)
            {
                current = current.Next;
            }

            if (current.Next != null)
            {
                return current;
            }
            return null;
        }

        //1.9. Tìm nút có giá trị lớn nhất sau cùng trong danh sách. 
        public Node FindMax()
        {
            if (Head == null)
                return null;

            Node maxNode = Head;
            Node current = Head.Next;
            while (current != null)
            {
                if (current.Data > maxNode.Data)
                {
                    maxNode = current;
                    break;
                }
                current = current.Next;
            }
            return maxNode;
        }
        //1.9. Tìm nút có giá trị lớn nhất đầu tiên cùng trong danh sách. 
        public Node FindMaxFirst()
        {
            if (Head == null)
                return null;

            Node current = Head;
            Node maxNode = Head;

            while (current != null)
            {
                if (current.Data > maxNode.Data)
                {
                    maxNode = current;
                }
                current = current.Next;
            }

            return maxNode;
        }


        // Phương thức tìm nút có giá trị nhỏ nhất sau cùng trong danh sách
        public Node FindMinFirst()
        {
            if (Head == null)
                return null;

            Node current = Head;
            Node minNode = Head;

            while (current != null)
            {
                if (current.Data < minNode.Data) // Thay đổi dấu so sánh
                {
                    minNode = current; // Cập nhật minNode
                }
                current = current.Next;
            }

            return minNode;
        }

        //1.10. Tìm nút có giá trị chẵn lớn nhất trong danh sách
        public Node FindMaxEven()
        {
            if (Head == null)
                return null;

            Node maxEvenNode = null;
            Node current = Head;
            while (current != null)
            {
                if (current.Data % 2 == 0 && (maxEvenNode == null || current.Data > maxEvenNode.Data))
                {
                    maxEvenNode = current;
                }
                current = current.Next;
            }
            return maxEvenNode;
        }



        // VIẾT CÁC PHƯƠNG THỨC ĐẾM
        //1.11. Đếm số nút trong danh sách.
        public int Count()
        {
            int count = 0;
            Node current = Head;
            while (current != null)
            {
                count++;
                current = current.Next;
            }
            return count;
        }

        //1.12. Đếm số nút lẻ trong danh sách.
        public int CountOdds()
        {
            int count = 0;
            Node current = Head;
            while (current != null)
            {
                if (current.Data % 2 != 0)
                {
                    count++;
                }
                current = current.Next;
            }
            return count;
        }

        //1.13. Đếm số nút có giá trị lẻ nhỏ nhất trong danh sách. 
        public int CountSmallestOdds()
        {
            if (Head == null)
                return 0;

            int minOdd = int.MaxValue;
            Node current = Head;
            while (current != null)
            {
                if (current.Data % 2 != 0 && current.Data < minOdd)
                {
                    minOdd = current.Data;
                }
                current = current.Next;
            }

            if (minOdd == int.MaxValue)
                return 0;

            int count = 0;
            current = Head;
            while (current != null)
            {
                if (current.Data == minOdd)
                {
                    count++;
                }
                current = current.Next;
            }
            return count;
        }

        //1.14.Xóa node có giá trị X khỏi danh sách.
        public void Delete(int value)
        {
            if (Head == null)
                return;

            if (Head.Data == value)
            {
                Head = Head.Next;
                return;
            }

            Node current = Head;
            while (current.Next != null && current.Next.Data != value)
            {
                current = current.Next;
            }

            if (current.Next != null)
            {
                current.Next = current.Next.Next;
            }
        }

        //1.15.Xóa node sau nút q trong danh sách.
        public void DeleteAfter(Node q)
        {
            if (q != null && q.Next != null)
            {
                q.Next = q.Next.Next;
            }
        }

        //1.16. Xóa node đầu danh sách
        public void DeleteFirst()
        {
            if (Head != null)
            {
                Head = Head.Next;
            }
        }

        //1.17.Xóa node cuối danh sách.
        public void DeleteLast()
        {
            if (Head == null)
                return;

            if (Head.Next == null)
            {
                Head = null;
                return;
            }

            Node current = Head;
            while (current.Next.Next != null)
            {
                current = current.Next;
            }
            current.Next = null;
        }

        //1.18.Xóa tất cả các node của danh sách.
        public void Clear()
        {
            Head = null;
        }
    }
}
