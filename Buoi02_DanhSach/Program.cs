using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Buoi02_DanhSach
{
    class NhanVien
    {
        public string ManV;
        public string Hoten;
        public int Namsinh;
        public string Phongban;
        public int LuongCB;
        public int Thuong;

        public NhanVien(string manv, string hoten, int namsinh, string phongban, int luongCB, int thuong)
        {
            ManV = manv;
            Hoten = hoten;
            Namsinh = namsinh;
            Phongban = phongban;
            LuongCB = luongCB;
            Thuong = thuong;
        }
    }

    class Node
    {
        public int Data;
        public Node Next;

        public Node(int data)
        {
            Data = data;
            Next = null;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Console.InputEncoding = Encoding.UTF8;

            Console.WriteLine("=== Bài 1: Mảng n số nguyên dương (nhập, hiển thị, chèn x vào vị trí k) ===");
            Bai1();

            Console.WriteLine("\n=== Bài 2: Danh sách nhân viên (mảng đối tượng) ===");
            Bai2();

            Console.WriteLine("\n=== Bài 3: Ma trận vuông n x n ===");
            Bai3();

            Console.WriteLine("\n=== Bài 4: Danh sách liên kết đơn (pHead) ===");
            Bai4();

            Console.WriteLine("\n=== Bài 5: Danh sách liên kết đơn l ===");
            Bai5();

            Console.WriteLine("\n================ BÀI TẬP 7: QUẢN LÝ NHIỆT ĐỘ ================");
            Bai7();

            Console.WriteLine("\n================ BÀI TẬP 8: THỐNG KÊ TỪ ================");
            Bai8();

            Console.WriteLine("\n================ BÀI TẬP 9: XỬ LÝ SỐ NGUYÊN ================");
            Bai9();

            Console.WriteLine("\n================ BÀI TẬP 10: MA TRẬN XOẮN ỐC ================");
            Bai10();

            Console.WriteLine("\n================ BÀI TẬP 11: MA TRẬN ĐẶC BIỆT ================");
            Bai11();
        }

        // BÀI 1
        static int DocSoNguyen(string thongBao, int min, int max)
        {
            while (true)
            {
                Console.Write(thongBao);
                string s = Console.ReadLine();
                if (s == null) return min;
                if (int.TryParse(s, out int v) && v >= min && v <= max)
                    return v;
                Console.WriteLine("  Giá trị không hợp lệ, vui lòng nhập lại!");
            }
        }

        // a. Nhập mảng từ bàn phím
        static int[] NhapMang()
        {
            int n = DocSoNguyen("Nhập n (số phần tử, n > 0): ", 1, int.MaxValue);
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = DocSoNguyen($"  a[{i}] = ", 1, int.MaxValue);
            }
            return a;
        }

        // b. Hiển thị mảng, các phần tử cách nhau 1 khoảng trống
        static void HienThiMang(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i]);
                if (i < a.Length - 1) Console.Write(" ");
            }
            Console.WriteLine();
        }

        // c. Chèn x vào vị trí k (dùng mảng trung gian tmp)
        static int[] ChenPhanTu(int[] a, int x, int k)
        {
            int[] tmp = new int[a.Length + 1];
            for (int i = 0; i < k; i++)
                tmp[i] = a[i];
            tmp[k] = x;
            for (int i = k; i < a.Length; i++)
                tmp[i + 1] = a[i];
            return tmp;
        }

        static void Bai1()
        {
            int[] a = NhapMang();

            Console.Write("Danh sách vừa nhập: ");
            HienThiMang(a);

            int x = DocSoNguyen("Nhập giá trị x cần chèn (x > 0): ", 1, int.MaxValue);
            int k = DocSoNguyen($"Nhập vị trí k cần chèn (0 <= k <= {a.Length}): ", 0, a.Length);

            a = ChenPhanTu(a, x, k);
            Console.Write($"Danh sách sau khi chèn {x} vào vị trí {k}: ");
            HienThiMang(a);
        }

        // BÀI2
        static NhanVien[] DS;
        const int MUC_THUONG = 1200000;

        static void KhoiTaoDS()
        {
            DS = new NhanVien[]
            {
                new NhanVien("NV01", "Nguyễn Văn An",  1995, "Kinh doanh", 8000000,  1500000),
                new NhanVien("NV02", "Trần Thị Bình",  1998, "Kế toán",    7000000,  1000000),
                new NhanVien("NV03", "Lê Minh Cường",  1990, "Kinh doanh", 9500000,  2000000),
                new NhanVien("NV04", "Phạm Thu Dung",  2000, "Nhân sự",    6500000,  800000),
                new NhanVien("NV05", "Hoàng Quốc Em",  1993, "Kế toán",    6500000,  1200000),
                new NhanVien("NV06", "Vũ Thanh Hà",    1996, "Kỹ thuật",   10000000, 3000000)
            };
        }

        static void InTieuDe()
        {
            Console.WriteLine($"{"Mã NV",-6} {"Họ tên",-18} {"Năm sinh",-9} {"Phòng ban",-11} {"Lương CB",12} {"Thưởng",12}");
        }

        static void InNhanVien(NhanVien nv)
        {
            Console.WriteLine($"{nv.ManV,-6} {nv.Hoten,-18} {nv.Namsinh,-9} {nv.Phongban,-11} {nv.LuongCB,12:N0} {nv.Thuong,12:N0}");
        }

        static void InDanhSach(NhanVien[] ds)
        {
            InTieuDe();
            foreach (NhanVien nv in ds)
                InNhanVien(nv);
        }

        // a. Thực lĩnh của nhân viên thứ x
        static int ThucLinh(int x)
        {
            return DS[x].LuongCB + DS[x].Thuong;
        }

        static long TongThucLinh()
        {
            long tong = 0;
            for (int i = 0; i < DS.Length; i++)
                tong += ThucLinh(i);
            return tong;
        }

        // b. In danh sách nhân viên có lương cơ bản thấp nhất
        static void InLuongCBThapNhat()
        {
            int min = int.MaxValue;
            for (int i = 0; i < DS.Length; i++)
            {
                if (DS[i].LuongCB < min)
                    min = DS[i].LuongCB;
            }

            InTieuDe();
            for (int i = 0; i < DS.Length; i++)
            {
                if (DS[i].LuongCB == min)
                    InNhanVien(DS[i]);
            }
        }

        // c. Đếm số nhân viên có thưởng >= 1200000
        static int DemThuong()
        {
            int dem = 0;
            for (int i = 0; i < DS.Length; i++)
            {
                if (DS[i].Thuong >= MUC_THUONG)
                    dem++;
            }
            return dem;
        }

        // d. Sắp xếp: phòng ban tăng dần; cùng phòng ban thì mã nhân viên giảm dần
        static bool PhaiDungSau(NhanVien x, NhanVien y)
        {
            int ss = string.Compare(x.Phongban, y.Phongban);
            if (ss != 0) return ss > 0;                
            return string.Compare(x.ManV, y.ManV) < 0;  
        }

        static NhanVien[] SapXepTheoPhongBan()
        {
            NhanVien[] ds = (NhanVien[])DS.Clone(); 
            for (int i = 0; i < ds.Length - 1; i++)
            {
                for (int j = 0; j < ds.Length - 1 - i; j++)
                {
                    if (PhaiDungSau(ds[j], ds[j + 1]))
                    {
                        NhanVien tam = ds[j];
                        ds[j] = ds[j + 1];
                        ds[j + 1] = tam;
                    }
                }
            }
            return ds;
        }

        // e. Tăng lương cơ bản của tất cả nhân viên lên 5%
        static void TangLuong5PhanTram()
        {
            for (int i = 0; i < DS.Length; i++)
            {
                DS[i].LuongCB = (int)(DS[i].LuongCB * 1.05);
            }
        }

        static void Bai2()
        {
            KhoiTaoDS();

            Console.WriteLine("Danh sách nhân viên ban đầu:");
            InDanhSach(DS);

            Console.WriteLine($"\na. Tổng thực lĩnh tháng của tất cả nhân viên: {TongThucLinh():N0}");

            Console.WriteLine("\nb. Nhân viên có lương cơ bản thấp nhất:");
            InLuongCBThapNhat();

            Console.WriteLine($"\nc. Số nhân viên có mức thưởng >= {MUC_THUONG:N0}: {DemThuong()}");

            Console.WriteLine("\nd. Danh sách sắp xếp theo phòng ban tăng dần (trùng phòng ban thì mã NV giảm dần):");
            InDanhSach(SapXepTheoPhongBan());

            TangLuong5PhanTram();
            Console.WriteLine("\ne. Danh sách sau khi tăng lương cơ bản thêm 5%:");
            InDanhSach(DS);
        }

        //  BÀI 3 
        static void InMaTran(int[,] m, int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    Console.Write($"{m[i, j],4}");
                Console.WriteLine();
            }
        }

        // a. Tổng tất cả phần tử
        static int TongMaTran(int[,] m, int n)
        {
            int t = 0;
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    t += m[i, j];
            return t;
        }

        // b. Giá trị dương nhỏ nhất
        static int DuongNhoNhat(int[,] m, int n)
        {
            int min = int.MaxValue;
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    if (m[i, j] > 0 && m[i, j] < min)
                        min = m[i, j];
            return min;
        }

        // c. Tổng các phần tử trên đường chéo phụ
        static int TongCheoPhu(int[,] m, int n)
        {
            int t = 0;
            for (int i = 0; i < n; i++)
                t += m[i, (n - 1) - i];
            return t;
        }

        // d. Đường chéo chính có tăng dần khôn
        static bool CheoChinhTangDan(int[,] m, int n)
        {
            int[] tg = new int[n];
            for (int i = 0; i < n; i++)
                tg[i] = m[i, i];

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (!(tg[i] < tg[j]))
                        return false;
                }
            }
            return true;
        }

        static void Bai3()
        {
            int[][,] testCases =
            {
                new int[,] { { 1, 2, 3, 4 }, { -5, 6, 7, 8 }, { 9, 0, 11, 12 }, { 13, 14, 15, 16 } },
                new int[,] { { 5, -1, 2 }, { 0, 3, 8 }, { 7, 4, 1 } },
                new int[,] { { -1, 0 }, { -2, -3 } }
            };

            int stt = 1;
            foreach (int[,] m in testCases)
            {
                int n = m.GetLength(0);
                Console.WriteLine($"--- Ma trận {stt++} (n = {n}) ---");
                InMaTran(m, n);

                Console.WriteLine($"a. Tổng tất cả các phần tử: {TongMaTran(m, n)}");

                int min = DuongNhoNhat(m, n);
                if (min == int.MaxValue)
                    Console.WriteLine("b. Giá trị dương nhỏ nhất: không có số dương nào");
                else
                    Console.WriteLine($"b. Giá trị dương nhỏ nhất: {min}");

                Console.WriteLine($"c. Tổng đường chéo phụ: {TongCheoPhu(m, n)}");

                Console.WriteLine("d. Đường chéo chính " + (CheoChinhTangDan(m, n) ? "có" : "không") + " tăng dần");
                Console.WriteLine();
            }
        }

        //BÀI 4
        static Node pHead;

        // Tạo danh sách liên kết từ mảng
        static Node TaoDS(int[] arr)
        {
            Node head = null, tail = null;
            foreach (int v in arr)
            {
                Node moi = new Node(v);
                if (head == null) head = tail = moi;
                else
                {
                    tail.Next = moi;
                    tail = moi;
                }
            }
            return head;
        }

        static void InDS(Node head)
        {
            for (Node p = head; p != null; p = p.Next)
                Console.Write(p.Data + " -> ");
            Console.WriteLine("null");
        }

        // a. Đếm số phần tử bằng x
        static int DemX(Node head, int x)
        {
            int d = 0;
            for (Node p = head; p != null; p = p.Next)
                if (p.Data == x) d++;
            return d;
        }

        // b. Phần tử dương nhỏ nhất
        static int DuongNhoNhatDS(Node head)
        {
            int minduong = int.MaxValue;
            for (Node p = head; p != null; p = p.Next)
                if (p.Data > 0 && p.Data < minduong)
                    minduong = p.Data;
            return minduong;
        }

        // c. Xóa phần tử x xuất hiện đầu tiên
        static bool XoaX(int x)
        {
            Node p = pHead, t = null;
            while (p != null && p.Data != x)
            {
                t = p;
                p = p.Next;
            }

            if (p == null) return false;      
            if (p == pHead) pHead = pHead.Next; 
            else t.Next = p.Next;               
            return true;
        }

        static void Bai4()
        {
            pHead = TaoDS(new int[] { 5, 3, 8, 3, 1, 9, 3 });
            Console.Write("Danh sách ban đầu: ");
            InDS(pHead);

            int[] cacX = { 3, 7 };
            foreach (int x in cacX)
                Console.WriteLine($"a. Số lượng phần tử bằng {x}: {DemX(pHead, x)}");

            int min = DuongNhoNhatDS(pHead);
            if (min == int.MaxValue)
                Console.WriteLine("b. Phần tử dương nhỏ nhất: không có");
            else
                Console.WriteLine($"b. Phần tử dương nhỏ nhất: {min}");

            int[] cacXoa = { 5, 3, 9, 100 };
            foreach (int x in cacXoa)
            {
                bool ketQua = XoaX(x);
                Console.Write($"c. Xóa {x} " + (ketQua ? "(thành công): " : "(không tìm thấy): "));
                InDS(pHead);
            }
        }

        //BÀI 5
        static Node l;

        // a. Phần tử lớn nhất
        static int LonNhat(Node head)
        {
            int max = int.MinValue;
            for (Node p = head; p != null; p = p.Next)
                if (p.Data > max) max = p.Data;
            return max;
        }

        // b. Tổng các phần tử
        static long TongDS(Node head)
        {
            long t = 0;
            for (Node p = head; p != null; p = p.Next)
                t += p.Data;
            return t;
        }

        // c. Kiểm tra số nguyên tố
        static bool KTNT(int x)
        {
            if (x < 2) return false;
            for (int i = 2; i * i <= x; i++)
                if (x % i == 0) return false;
            return true;
        }

        static int DemNguyenTo(Node head)
        {
            int dem = 0;
            for (Node p = head; p != null; p = p.Next)
                if (KTNT(p.Data)) dem++;
            return dem;
        }

        // d. Đếm số âm, số 0, số dương
        static (int am, int khong, int duong) DemAmKhongDuong(Node head)
        {
            int am = 0, khong = 0, duong = 0;
            for (Node p = head; p != null; p = p.Next)
            {
                if (p.Data < 0) am++;
                else if (p.Data > 0) duong++;
                else khong++;
            }
            return (am, khong, duong);
        }

        static void Bai5()
        {
            l = TaoDS(new int[] { 7, -3, 0, 12, 5, -8, 0, 2, 9, 11, 7 });
            Console.Write("Danh sách l: ");
            InDS(l);

            Console.WriteLine($"a. Phần tử lớn nhất: {LonNhat(l)}");
            Console.WriteLine($"b. Tổng các phần tử: {TongDS(l)}");
            Console.WriteLine($"c. Số lượng số nguyên tố: {DemNguyenTo(l)}");

            var (am, khong, duong) = DemAmKhongDuong(l);
            Console.WriteLine($"d. Số âm: {am}, số bằng 0: {khong}, số dương: {duong}");

            int[] cacX = { 7, 0, 4 };
            foreach (int x in cacX)
                Console.WriteLine($"e. Số lượng phần tử bằng {x}: {DemX(l, x)}");

            int min = DuongNhoNhatDS(l);
            if (min == int.MaxValue)
                Console.WriteLine("f. Phần tử dương nhỏ nhất: không có");
            else
                Console.WriteLine($"f. Phần tử dương nhỏ nhất: {min}");
        }



            //Bai7
            static void Bai7()
        {
            // Khai báo mảng nhiệt độ của n = 7 ngày trong tuần
            double[] nhietDo = { 28.5, 31.0, 26.2, 33.4, 29.8, 25.0, 30.1 };
            int n = nhietDo.Length;

            double max = nhietDo[0];
            double min = nhietDo[0];
            int ngayMax = 1, ngayMin = 1;
            double tong = 0;

            for (int i = 0; i < n; i++)
            {
                if (nhietDo[i] > max)
                {
                    max = nhietDo[i];
                    ngayMax = i + 1;
                }
                if (nhietDo[i] < min)
                {
                    min = nhietDo[i];
                    ngayMin = i + 1;
                }
                tong += nhietDo[i];
            }

            double trungBinh = tong / n;

            Console.WriteLine($"Dữ liệu nhiệt độ {n} ngày: {string.Join("°C, ", nhietDo)}°C");
            Console.WriteLine($"- Ngày có nhiệt độ cao nhất: Ngày {ngayMax} ({max}°C)");
            Console.WriteLine($"- Ngày có nhiệt độ thấp nhất: Ngày {ngayMin} ({min}°C)");
            Console.WriteLine($"- Nhiệt độ trung bình tuần: {trungBinh:F2}°C");
        }
    
                //Bai8
            static void Bai8()
                {
            string vanBan = "Học lập trình C#, học cấu trúc dữ liệu và giải thuật. Lập trình C# rất thú vị!";
            Console.WriteLine($"Chuỗi gốc: \"{vanBan}\"");

            // 1. Chuẩn hóa chuỗi: chuyển về chữ thường và xóa ký tự đặc biệt/dấu câu
            string chuanHoa = Regex.Replace(vanBan.ToLower(), @"[^\p{L}\p{N}\s]", "");

            // 2. Tách chuỗi thành mảng từ (bỏ qua khoảng trắng thừa)
            string[] cacTu = chuanHoa.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

            // 3. Sử dụng Dictionary để đếm tần suất
            Dictionary<string, int> tanSuat = new Dictionary<string, int>();
            foreach (string tu in cacTu)
            {
                if (tanSuat.ContainsKey(tu))
                    tanSuat[tu]++;
                else
                    tanSuat[tu] = 1;
            }

            // 4. Sắp xếp giảm dần theo tần suất (nếu bằng nhau xếp theo bảng chữ cái) và hiển thị
            Console.WriteLine("Bảng thống kê tần suất xuất hiện của từng từ:");
            foreach (var item in tanSuat.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"   - \"{item.Key}\": {item.Value} lần");
            }
        }

        //Bai9
        static bool KiemTraSoHoanHao(int x)
        {
            if (x <= 1) return false;
            int tongUoc = 1;
            for (int i = 2; i <= x / 2; i++)
            {
                if (x % i == 0)
                    tongUoc += i;
            }
            return tongUoc == x;
        }

        static void Bai9()
        {
            int[] daySo = { 2, 4, 6, 7, 11, 12, 28, 15, 20, 496 };
            Console.WriteLine($"Dãy số nguyên: {string.Join(", ", daySo)}");

            List<int> soNguyenTo = new List<int>();
            List<int> soChan = new List<int>();
            List<int> soHoanHao = new List<int>();

            foreach (int x in daySo)
            {
                if (KTNT(x)) soNguyenTo.Add(x);
                if (x % 2 == 0) soChan.Add(x);
                if (KiemTraSoHoanHao(x)) soHoanHao.Add(x);
            }

            Console.WriteLine($"- Các số nguyên tố ({soNguyenTo.Count}): {string.Join(", ", soNguyenTo)}");
            Console.WriteLine($"- Các số chẵn ({soChan.Count}): {string.Join(", ", soChan)}");
            Console.WriteLine($"- Các số hoàn hảo ({soHoanHao.Count}): {string.Join(", ", soHoanHao)}");
        }

            //Bai1-=0

            static void InMaTranXoanOc(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            // 1. Sử dụng 4 biến xác định biên
            int top = 0, bottom = rows - 1;
            int left = 0, right = cols - 1;

            Console.Write("Kết quả duyệt xoắn ốc: ");
            while (top <= bottom && left <= right)
            {
                for (int i = left; i <= right; i++)
                    Console.Write(matrix[top, i] + " ");
                top++; 

                for (int i = top; i <= bottom; i++)
                    Console.Write(matrix[i, right] + " ");
                right--; 

                if (top <= bottom)
                {
                    for (int i = right; i >= left; i--)
                        Console.Write(matrix[bottom, i] + " ");
                    bottom--;
                }

                if (left <= right)
                {
                    for (int i = bottom; i >= top; i--)
                        Console.Write(matrix[i, left] + " ");
                    left++; 
                }
            }
            Console.WriteLine();
        }

        static void Bai10()
        {
            int[,] matrix = {
                {  1,  2,  3,  4 },
                { 12, 13, 14,  5 },
                { 11, 16, 15,  6 },
                { 10,  9,  8,  7 }
            };

            Console.WriteLine("Ma trận đầu vào (4x4):");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                    Console.Write($"{matrix[i, j],4}");
                Console.WriteLine();
            }

            InMaTranXoanOc(matrix);
        }

        //Bai11
        static bool LaMaTranDonVi(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            if (rows != cols) return false; 

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (i == j && matrix[i, j] != 1)
                        return false;
                    if (i != j && matrix[i, j] != 0)
                        return false;
                }
            }
            return true;
        }

        static bool LaMaTranDoiXung(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            if (rows != cols) return false; 

            for (int i = 0; i < rows; i++)
            {
                for (int j = i + 1; j < cols; j++)
                {
                    if (matrix[i, j] != matrix[j, i])
                        return false;
                }
            }
            return true;
        }

        static void Bai11()
        {
            int[,] mtDonVi = {
                { 1, 0, 0 },
                { 0, 1, 0 },
                { 0, 0, 1 }
            };

            int[,] mtDoiXung = {
                { 2, 5, 9 },
                { 5, 3, 7 },
                { 9, 7, 4 }
            };

            Console.WriteLine($"Test Ma trận 1 -> Ma trận đơn vị: {LaMaTranDonVi(mtDonVi)} | Ma trận đối xứng: {LaMaTranDoiXung(mtDonVi)}");
            Console.WriteLine($"Test Ma trận 2 -> Ma trận đơn vị: {LaMaTranDonVi(mtDoiXung)} | Ma trận đối xứng: {LaMaTranDoiXung(mtDoiXung)}");
        }
    }
}