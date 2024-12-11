using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuaHangMayTinh

{
    // Class quản lý danh sách máy tính (QuanLyMayTinh)
    class DanhSachMayTinh
    {
        private Node Head;

        public DanhSachMayTinh()
        {
            Head = null;
        }

        // Thêm máy tính vào đầu danh sách
        public void ThemMayTinh(MayTinh mayTinh)
        {
            Node newNode = new Node(mayTinh);
            newNode.Next = Head;
            Head = newNode;
        }

        // Thêm máy tính vào cuối danh sách
        public void ThemMayTinhCuoi(MayTinh mayTinh)
        {
            Node newNode = new Node(mayTinh);
            if (Head == null)
            {
                Head = newNode; // Nếu danh sách còn trống
            }
            else
            {
                Node current = Head;
                while (current.Next != null)
                {
                    current = current.Next; // Di chuyển đến cuối danh sách
                }
                current.Next = newNode; // Gán node mới vào cuối danh sách
            }
        }

        // Xuất danh sách máy tính
        public void XuatDanhSach()
        {
            Node current = Head;
            while (current != null)
            {
                current.Data.Xuat();
                current = current.Next;
            }
        }
        // 1. Sắp xếp danh sách máy tính theo năm sản xuất sử dụng thuật toán QuickSort
        public void SapXepTheoNamSanXuat()
        {
            int count = CountNodes();
            MayTinh[] array = new MayTinh[count];
            CopyToArray(array);
            QuickSort(array, 0, count - 1);
            Head = null;  
            foreach (var item in array)
            {
                ThemMayTinhCuoi(item); // Thêm vào cuối danh sách mới
            }
        }

        // 2. Sắp xếp danh sách máy tính theo năm sản xuất sử dụng thuật toán Bubble Sort
        public void SapXepTheoNamSanXuatBubbleSort()
        {
            if (Head == null)
                return; // Nếu danh sách rỗng

            // Chuyển đổi danh sách liên kết thành mảng để thực hiện sắp xếp
            int count = CountNodes();
            MayTinh[] array = new MayTinh[count];
            CopyToArray(array);

            // Sắp xếp mảng bằng thuật toán Bubble Sort
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j].NamSX > array[j + 1].NamSX)
                    {
                        Swap(ref array[j], ref array[j + 1]);
                    }
                }
            }

            // Clear the current list
            Head = null;

            // Chuyển đổi lại mảng về danh sách liên kết
            foreach (var item in array)
            {
                ThemMayTinhCuoi(item);
            }
        }

        // 3. Sắp xếp danh sách máy tính theo năm sản xuất sử dụng thuật toán Selection Sort
        public void SapXepTheoNamSanXuatSelectionSort()
        {
            if (Head == null)
                return; // Nếu danh sách rỗng

            // Chuyển đổi danh sách liên kết thành mảng để thực hiện sắp xếp
            int count = CountNodes();
            MayTinh[] array = new MayTinh[count];
            CopyToArray(array);

            // Sắp xếp mảng bằng thuật toán Selection Sort
            for (int i = 0; i < array.Length - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j].NamSX < array[minIndex].NamSX)
                    {
                        minIndex = j; // Cập nhật chỉ số của năm sản xuất nhỏ nhất
                    }
                }
                // Hoán đổi phần tử nhỏ nhất với phần tử hiện tại
                Swap(ref array[i], ref array[minIndex]);
            }

            // Clear the current list
            Head = null;

            // Chuyển đổi lại mảng về danh sách liên kết
            foreach (var item in array)
            {
                ThemMayTinhCuoi(item);
            }
        }

        // 4. Sắp xếp danh sách máy tính theo năm sản xuất sử dụng thuật toán Insertion Sort
        public void SapXepTheoNamSanXuatInsertionSort()
        {
            if (Head == null)
                return; // Nếu danh sách rỗng

            // Chuyển đổi danh sách liên kết thành mảng để thực hiện sắp xếp
            int count = CountNodes();
            MayTinh[] array = new MayTinh[count];
            CopyToArray(array);

            // Sắp xếp mảng bằng thuật toán Insertion Sort
            for (int i = 1; i < array.Length; i++)
            {
                MayTinh key = array[i];
                int j = i - 1;

                // Di chuyển các phần tử lớn hơn key về phía trước
                while (j >= 0 && array[j].NamSX > key.NamSX)
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = key;
            }

            // Clear the current list
            Head = null;

            // Chuyển đổi lại mảng về danh sách liên kết
            foreach (var item in array)
            {
                ThemMayTinhCuoi(item);
            }
        }





        // Đếm số lượng node trong danh sách
        private int CountNodes()
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

        // Sao chép nội dung danh sách vào một mảng
        private void CopyToArray(MayTinh[] array)
        {
            Node current = Head;
            int index = 0;
            while (current != null)
            {
                array[index++] = current.Data;
                current = current.Next;
            }
        }

        // Phương thức QuickSort
        private void QuickSort(MayTinh[] array, int low, int high)
        {
            if (low < high)
            {
                int pi = Partition(array, low, high);
                QuickSort(array, low, pi - 1);
                QuickSort(array, pi + 1, high);
            }
        }

        // Phân vùng cho QuickSort
        private int Partition(MayTinh[] array, int low, int high)
        {
            int pivot = array[high].NamSX; // Pivot là năm sản xuất ở phần tử cuối
            int i = (low - 1);
            for (int j = low; j < high; j++)
            {
                if (array[j].NamSX < pivot)
                {
                    i++;
                    Swap(ref array[i], ref array[j]);
                }
            }
            Swap(ref array[i + 1], ref array[high]);
            return i + 1;
        }

        // Hoán đổi hai phần tử trong mảng
        private void Swap(ref MayTinh a, ref MayTinh b)
        {
            MayTinh temp = a;
            a = b;
            b = temp;
        }


        // VIẾT SẮP XẾP GIẢM DẦN 
        // Sắp xếp danh sách máy tính theo năm sản xuất (giảm dần) sử dụng thuật toán QuickSort
        public void SapXepGiamDanTheoNamSanXuat()
        {
            if (Head == null)
                return; // Nếu danh sách rỗng

            // Chuyển đổi danh sách liên kết thành mảng để thực hiện sắp xếp
            int count = CountNodes();
            MayTinh[] array = new MayTinh[count];
            CopyToArray(array);

            // Sắp xếp mảng bằng thuật toán Quick Sort
            QuickSort1(array, 0, array.Length - 1);

            // Clear the current list
            Head = null;

            // Chuyển đổi lại mảng về danh sách liên kết
            foreach (var item in array)
            {
                ThemMayTinhCuoi(item);
            }
        }

        // Phương thức QuickSort
        private void QuickSort1(MayTinh[] array, int low, int high)
        {
            if (low < high)
            {
                int pi = Partition1(array, low, high);
                QuickSort1(array, low, pi - 1);
                QuickSort1(array, pi + 1, high);
            }
        }

        // Phân vùng cho QuickSort
        private int Partition1(MayTinh[] array, int low, int high)
        {
            int pivot = array[high].NamSX; // Pivot là năm sản xuất ở phần tử cuối
            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                if (array[j].NamSX > pivot) // Lưu ý điều kiện > để sắp xếp giảm dần
                {
                    i++;
                    Swap(ref array[i], ref array[j]);
                }
            }
            Swap(ref array[i + 1], ref array[high]);
            return i + 1;
        }

        // Sắp xếp danh sách máy tính theo năm sản xuất (giảm dần) sử dụng thuật toán Bubble Sort
        public void SapXepGiamDanTheoNamSanXuatBubbleSort()
        {
            if (Head == null)
                return; // Nếu danh sách rỗng

            // Chuyển đổi danh sách liên kết thành mảng để thực hiện sắp xếp
            int count = CountNodes();
            MayTinh[] array = new MayTinh[count];
            CopyToArray(array);

            // Sắp xếp mảng bằng thuật toán Bubble Sort (giảm dần)
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j].NamSX < array[j + 1].NamSX) // Sắp xếp n...
                    {
                        Swap(ref array[j], ref array[j + 1]);
                    }
                }
            }

            // Clear the current list
            Head = null;

            // Chuyển đổi lại mảng về danh sách liên kết
            foreach (var item in array)
            {
                ThemMayTinhCuoi(item);
            }
        }

        // Sắp xếp danh sách máy tính theo năm sản xuất (giảm dần) sử dụng thuật toán Selection Sort
        public void SapXepGiamDanTheoNamSanXuatSelectionSort()
        {
            if (Head == null)
                return; // Nếu danh sách rỗng

            // Chuyển đổi danh sách liên kết thành mảng để thực hiện sắp xếp
            int count = CountNodes();
            MayTinh[] array = new MayTinh[count];
            CopyToArray(array);

            // Sắp xếp mảng bằng thuật toán Selection Sort (giảm dần)
            for (int i = 0; i < array.Length - 1; i++)
            {
                int maxIndex = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j].NamSX > array[maxIndex].NamSX) // Tìm phần tử lớn nhất
                    {
                        maxIndex = j; // Cập nhật index của phần tử lớn nhất
                    }
                }
                // Hoán đổi phần tử lớn nhất với phần tử hiện tại
                Swap(ref array[i], ref array[maxIndex]);
            }

            // Clear the current list
            Head = null;

            // Chuyển đổi lại mảng về danh sách liên kết
            foreach (var item in array)
            {
                ThemMayTinhCuoi(item);
            }
        }

        // Sắp xếp danh sách máy tính theo năm sản xuất (giảm dần) sử dụng thuật toán Insertion Sort
        public void SapXepGiamDanTheoNamSanXuatInsertionSort()
        {
            if (Head == null)
                return; // Nếu danh sách rỗng

            // Chuyển đổi danh sách liên kết thành mảng để thực hiện sắp xếp
            int count = CountNodes();
            MayTinh[] array = new MayTinh[count];
            CopyToArray(array);

            // Sắp xếp mảng bằng thuật toán Insertion Sort (giảm dần)
            for (int i = 1; i < array.Length; i++)
            {
                MayTinh key = array[i];
                int j = i - 1;

                // Di chuyển các phần tử nhỏ hơn key về phía trước
                while (j >= 0 && array[j].NamSX < key.NamSX) // Điều kiện < để sắp xếp giảm dần
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = key;
            }

            // Clear the current list
            Head = null;

            // Chuyển đổi lại mảng về danh sách liên kết
            foreach (var item in array)
            {
                ThemMayTinhCuoi(item);
            }
        }


    }
}
