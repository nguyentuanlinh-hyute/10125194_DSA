# Buổi 02 – Danh sách

Họ tên: Nguyễn Tuấn Linh · MSV: 10125194

## Bài đã làm
Bài 1, 2, 3, 4, 5, 7, 8, 9, 10, 11

## Cách chạy
```
dotnet run --project Buoi02_DanhSach
```

## Kết quả chạy
```
=== Bài 1: Mảng n số nguyên dương (nhập, hiển thị, chèn x vào vị trí k) ===
Nhập n (số phần tử, n > 0):   a[0] =   a[1] =   a[2] =   a[3] =   a[4] = Danh sách vừa nhập: 12 7 20 35 18
Nhập giá trị x cần chèn (x > 0): Nhập vị trí k cần chèn (0 <= k <= 5): Danh sách sau khi chèn 99 vào vị trí 2: 12 7 99 20 35 18

=== Bài 2: Danh sách nhân viên (mảng đối tượng) ===
Danh sách nhân viên ban đầu:
Mã NV  Họ tên             Năm sinh  Phòng ban       Lương CB       Thưởng
NV01   Nguyễn Văn An      1995      Kinh doanh     8,000,000    1,500,000
NV02   Trần Thị Bình      1998      Kế toán        7,000,000    1,000,000
NV03   Lê Minh Cường      1990      Kinh doanh     9,500,000    2,000,000
NV04   Phạm Thu Dung      2000      Nhân sự        6,500,000      800,000
NV05   Hoàng Quốc Em      1993      Kế toán        6,500,000    1,200,000
NV06   Vũ Thanh Hà        1996      Kỹ thuật      10,000,000    3,000,000

a. Tổng thực lĩnh tháng của tất cả nhân viên: 57,000,000

b. Nhân viên có lương cơ bản thấp nhất:
Mã NV  Họ tên             Năm sinh  Phòng ban       Lương CB       Thưởng
NV04   Phạm Thu Dung      2000      Nhân sự        6,500,000      800,000
NV05   Hoàng Quốc Em      1993      Kế toán        6,500,000    1,200,000

c. Số nhân viên có mức thưởng >= 1,200,000: 4

d. Danh sách sắp xếp theo phòng ban tăng dần (trùng phòng ban thì mã NV giảm dần):
Mã NV  Họ tên             Năm sinh  Phòng ban       Lương CB       Thưởng
NV05   Hoàng Quốc Em      1993      Kế toán        6,500,000    1,200,000
NV02   Trần Thị Bình      1998      Kế toán        7,000,000    1,000,000
NV03   Lê Minh Cường      1990      Kinh doanh     9,500,000    2,000,000
NV01   Nguyễn Văn An      1995      Kinh doanh     8,000,000    1,500,000
NV06   Vũ Thanh Hà        1996      Kỹ thuật      10,000,000    3,000,000
NV04   Phạm Thu Dung      2000      Nhân sự        6,500,000      800,000

e. Danh sách sau khi tăng lương cơ bản thêm 5%:
Mã NV  Họ tên             Năm sinh  Phòng ban       Lương CB       Thưởng
NV01   Nguyễn Văn An      1995      Kinh doanh     8,400,000    1,500,000
NV02   Trần Thị Bình      1998      Kế toán        7,350,000    1,000,000
NV03   Lê Minh Cường      1990      Kinh doanh     9,975,000    2,000,000
NV04   Phạm Thu Dung      2000      Nhân sự        6,825,000      800,000
NV05   Hoàng Quốc Em      1993      Kế toán        6,825,000    1,200,000
NV06   Vũ Thanh Hà        1996      Kỹ thuật      10,500,000    3,000,000

=== Bài 3: Ma trận vuông n x n ===
--- Ma trận 1 (n = 4) ---
   1   2   3   4
  -5   6   7   8
   9   0  11  12
  13  14  15  16
a. Tổng tất cả các phần tử: 116
b. Giá trị dương nhỏ nhất: 1
c. Tổng đường chéo phụ: 24
d. Đường chéo chính có tăng dần

--- Ma trận 2 (n = 3) ---
   5  -1   2
   0   3   8
   7   4   1
a. Tổng tất cả các phần tử: 29
b. Giá trị dương nhỏ nhất: 1
c. Tổng đường chéo phụ: 12
d. Đường chéo chính không tăng dần

--- Ma trận 3 (n = 2) ---
  -1   0
  -2  -3
a. Tổng tất cả các phần tử: -6
b. Giá trị dương nhỏ nhất: không có số dương nào
c. Tổng đường chéo phụ: -2
d. Đường chéo chính không tăng dần


=== Bài 4: Danh sách liên kết đơn (pHead) ===
Danh sách ban đầu: 5 -> 3 -> 8 -> 3 -> 1 -> 9 -> 3 -> null
a. Số lượng phần tử bằng 3: 3
a. Số lượng phần tử bằng 7: 0
b. Phần tử dương nhỏ nhất: 1
c. Xóa 5 (thành công): 3 -> 8 -> 3 -> 1 -> 9 -> 3 -> null
c. Xóa 3 (thành công): 8 -> 3 -> 1 -> 9 -> 3 -> null
c. Xóa 9 (thành công): 8 -> 3 -> 1 -> 3 -> null
c. Xóa 100 (không tìm thấy): 8 -> 3 -> 1 -> 3 -> null

=== Bài 5: Danh sách liên kết đơn l ===
Danh sách l: 7 -> -3 -> 0 -> 12 -> 5 -> -8 -> 0 -> 2 -> 9 -> 11 -> 7 -> null
a. Phần tử lớn nhất: 12
b. Tổng các phần tử: 42
c. Số lượng số nguyên tố: 5
d. Số âm: 2, số bằng 0: 2, số dương: 7
e. Số lượng phần tử bằng 7: 2
e. Số lượng phần tử bằng 0: 2
e. Số lượng phần tử bằng 4: 0
f. Phần tử dương nhỏ nhất: 2

================ BÀI TẬP 7: QUẢN LÝ NHIỆT ĐỘ ================
Dữ liệu nhiệt độ 7 ngày: 28.5°C, 31°C, 26.2°C, 33.4°C, 29.8°C, 25°C, 30.1°C
- Ngày có nhiệt độ cao nhất: Ngày 4 (33.4°C)
- Ngày có nhiệt độ thấp nhất: Ngày 6 (25°C)
- Nhiệt độ trung bình tuần: 29.14°C

================ BÀI TẬP 8: THỐNG KÊ TỪ ================
Chuỗi gốc: "Học lập trình C#, học cấu trúc dữ liệu và giải thuật. Lập trình C# rất thú vị!"
Bảng thống kê tần suất xuất hiện của từng từ:
   - "c": 2 lần
   - "học": 2 lần
   - "lập": 2 lần
   - "trình": 2 lần
   - "cấu": 1 lần
   - "dữ": 1 lần
   - "giải": 1 lần
   - "liệu": 1 lần
   - "rất": 1 lần
   - "thú": 1 lần
   - "thuật": 1 lần
   - "trúc": 1 lần
   - "và": 1 lần
   - "vị": 1 lần

================ BÀI TẬP 9: XỬ LÝ SỐ NGUYÊN ================
Dãy số nguyên: 2, 4, 6, 7, 11, 12, 28, 15, 20, 496
- Các số nguyên tố (3): 2, 7, 11
- Các số chẵn (7): 2, 4, 6, 12, 28, 20, 496
- Các số hoàn hảo (3): 6, 28, 496

================ BÀI TẬP 10: MA TRẬN XOẮN ỐC ================
Ma trận đầu vào (4x4):
   1   2   3   4
  12  13  14   5
  11  16  15   6
  10   9   8   7
Kết quả duyệt xoắn ốc: 1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 16 

================ BÀI TẬP 11: MA TRẬN ĐẶC BIỆT ================
Test Ma trận 1 -> Ma trận đơn vị: True | Ma trận đối xứng: True
Test Ma trận 2 -> Ma trận đơn vị: False | Ma trận đối xứng: True
```
