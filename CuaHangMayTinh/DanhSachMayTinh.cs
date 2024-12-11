using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuaHangMayTinh

{
    // Class quản lý danh sách máy tính
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
    }
}
