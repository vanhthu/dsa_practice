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
        //1.6.1 Thêm node có giá trị X vào vị trí kề sau nút có giá trị lẻ lớn nhất sau cùng trong danh sách.
        public void AddAfterOddMaxLast(int value)
        {
            if (Head == null) return;

            Node current = Head;
            Node oddMaxNode = null;

            // Tìm nút có giá trị lẻ lớn nhất sau cùng
            while (current != null)
            {
                if (current.Data % 2 != 0) // Nếu là số lẻ
                {
                    oddMaxNode = current; // Cập nhật nút lẻ lớn nhất
                }
                current = current.Next;
            }

            // Nếu tìm thấy nút lẻ lớn nhất, thêm nút mới vào sau nó
            if (oddMaxNode != null)
            {
                Node newNode = new Node(value);
                newNode.Next = oddMaxNode.Next; // Đặt next của nút mới
                oddMaxNode.Next = newNode; // Thêm nút mới vào sau nút lẻ lớn nhất
            }
        }
        //1.6.2 Thêm node có giá trị X vào vị trí kề sau nút có giá trị lẻ nhỏ nhất sau cùng trong danh sách.
        public void AddAfterOddMinLast(int value)
        {
            if (Head == null) return;

            Node current = Head;
            Node oddMinNode = null;
            int minOddValue = int.MaxValue;

            // Tìm giá trị lẻ nhỏ nhất trong danh sách
            while (current != null)
            {
                if (current.Data % 2 != 0 && current.Data < minOddValue)
                {
                    minOddValue = current.Data; // Cập nhật giá trị nhỏ nhất
                }
                current = current.Next;
            }

            // Reset current để tìm nút lẻ nhỏ nhất sau cùng
            current = Head;

            // Tìm nút lẻ nhỏ nhất sau cùng
            while (current != null)
            {
                if (current.Data == minOddValue)
                    oddMinNode = current; // Cập nhật nút lẻ nhỏ nhất
                current = current.Next;
            }

            // Nếu tìm thấy nút lẻ nhỏ nhất, thêm nút mới vào sau nút đó
            if (oddMinNode != null)
            {
                Node newNode = new Node(value);
                newNode.Next = oddMinNode.Next; // Đặt next của nút mới
                oddMinNode.Next = newNode; // Thêm nút mới vào sau nút lẻ nhỏ nhất
            }
        }
        //1.6.3 Thêm node có giá trị X vào vị trí kề sau nút có giá trị lẻ lớn nhất đầu tiên trong danh sách.
        public void AddAfterOddMaxFirst(int value)
        {
            if (Head == null) return;

            Node current = Head;
            Node oddMaxNode = null;

            // Tìm nút lẻ lớn nhất đầu tiên
            while (current != null)
            {
                if (current.Data % 2 != 0) // Nếu là số lẻ
                {
                    if (oddMaxNode == null || current.Data > oddMaxNode.Data)
                    {
                        oddMaxNode = current; // Cập nhật nếu giá trị lớn hơn
                    }
                }
                current = current.Next;
            }

            // Nếu tìm thấy nút lẻ lớn nhất, thêm nút mới vào sau nó
            if (oddMaxNode != null)
            {
                Node newNode = new Node(value);
                newNode.Next = oddMaxNode.Next; // Gán next của nút mới
                oddMaxNode.Next = newNode; // Chèn nút mới vào sau nút lẻ lớn nhất
            }
        }
        //1.6.4 Thêm node có giá trị X vào vị trí kề sau nút có giá trị lẻ nhỏ nhất đầu tiên trong danh sách.
        public void AddAfterOddMinFirst(int value)
        {
            if (Head == null) return;

            Node current = Head;
            Node oddMinNode = null;

            // Tìm nút có giá trị lẻ nhỏ nhất đầu tiên
            while (current != null)
            {
                if (current.Data % 2 != 0) // Nếu là số lẻ
                {
                    oddMinNode = current; // Cập nhật nút lẻ nhỏ nhất đầu tiên
                    break; // Thoát vòng lặp
                }
                current = current.Next;
            }

            // Nếu tìm thấy nút lẻ nhỏ nhất, thêm nút mới vào sau nó
            if (oddMinNode != null)
            {
                Node newNode = new Node(value);
                newNode.Next = oddMinNode.Next; // Đặt next của nút mới
                oddMinNode.Next = newNode; // Thêm nút mới vào sau nút lẻ nhỏ nhất
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
        //1.7.1 Thêm node có giá trị X vào vị trí kề trước nút có giá trị lẻ lớn nhất sau cùng trong danh sách.
        public void AddBeforeOddMaxLast(int value)
        {
            if (Head == null) return;

            Node current = Head;
            Node oddMaxNode = null;
            Node prevNode = null; // Biến để lưu nút trước nút lẻ lớn nhất

            // Tìm nút lẻ lớn nhất sau cùng
            while (current != null)
            {
                if (current.Data % 2 != 0) // Nếu là số lẻ
                {
                    oddMaxNode = current; // Cập nhật nút lẻ lớn nhất
                }
                current = current.Next;
            }

            // Nếu không tìm thấy nút lẻ lớn nhất thì dừng
            if (oddMaxNode == null) return;

            // Thiết lập current lại để tìm nút trước nút lẻ lớn nhất
            current = Head;
            while (current != null)
            {
                if (current.Next == oddMaxNode)
                {
                    prevNode = current; // Lưu lại nút trước
                    break; // Thoát vòng lặp
                }
                current = current.Next;
            }

            // Nếu nút trước không phải là null tức là nút lẻ lớn nhất không phải là đầu danh sách
            if (prevNode != null)
            {
                Node newNode = new Node(value);
                newNode.Next = oddMaxNode; // Đặt next của nút mới là nút lẻ lớn nhất
                prevNode.Next = newNode; // Chèn nút mới vào trước nút lẻ lớn nhất
            }
            else
            {
                // Nếu nút lẻ lớn nhất là nút đầu tiên
                AddToFront(value); // Thêm nút mới vào đầu danh sách
            }
        }
        //1.7.2 Thêm node có giá trị X vào vị trí kề trước nút có giá trị lẻ lớn nhất đầu tiên trong danh sách.
        public void AddBeforeOddMaxFirst(int value)
        {
            if (Head == null) return; // Kiểm tra nếu danh sách rỗng

            Node current = Head;
            Node oddMaxNode = null; // Nút có giá trị lẻ lớn nhất
            Node prevNode = null; // Nút trước nút lẻ lớn nhất

            // Tìm nút lẻ lớn nhất đầu tiên
            while (current != null)
            {
                // Nếu nút hiện tại là số lẻ và (nó lớn hơn oddMaxNode hoặc oddMaxNode chưa được tìm thấy)
                if (current.Data % 2 != 0 && (oddMaxNode == null || current.Data > oddMaxNode.Data))
                {
                    oddMaxNode = current; // Cập nhật nút lẻ lớn nhất
                }
                current = current.Next;
            }

            // Nếu không tìm thấy nút lẻ lớn nhất thì dừng
            if (oddMaxNode == null) return;

            // Reset current để tìm nút trước
            current = Head;

            // Tìm nút trước nút lẻ lớn nhất
            while (current != null)
            {
                if (current.Next == oddMaxNode)
                {
                    prevNode = current; // Lưu nút trước
                    break; // Thoát vòng lặp
                }
                current = current.Next;
            }

            // Tạo nút mới với giá trị X
            Node newNode = new Node(value);

            // Nếu tìm thấy nút trước thì chèn nút mới vào trước nút lẻ lớn nhất
            if (prevNode != null)
            {
                newNode.Next = oddMaxNode; // Đặt next của nút mới là nút lẻ lớn nhất
                prevNode.Next = newNode; // Chèn nút mới vào trước nút lẻ lớn nhất
            }
            else
            {
                // Nếu nút lẻ lớn nhất là nút đầu tiên
                AddToFront(value); // Thêm nút mới vào đầu danh sách
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
