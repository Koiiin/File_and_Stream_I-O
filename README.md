# Báo Cáo Bài Tập Lập Trình Mạng Căn Bản - Kỳ Báo Cáo Buổi 02: File I/O Stream trong C#

## Thông Tin Chung

*   **Môn học:** Lập Trình Mạng Căn Bản
*   **Kỳ báo cáo:** Buổi 02 (Session 02)
*   **Tên chủ đề:** File I/O Stream trong C#
*   **GV:** Đỗ Thị Hương Lan
*   **Ngày báo cáo:** 18/03/2025
*   **Lớp:** NT106.P21.ANTN
*   **Sinh viên thực hiện:** Vũ Hoàng Khôi - 23520792 - 23520792@gm.uit.edu.vn

## Nội Dung Thực Hiện

Bảng tổng hợp các công việc và kết quả tự đánh giá:

| STT | Công việc                | Kết quả tự đánh giá |
| --- | ---------------------- | ------------------ |
| 1   | Đọc và ghi file cơ bản   | 100%               |
| 2   | Đọc thông tin tập tin    | 100%               |
| 3   | Đọc và ghi file (Mở rộng) | 100%               |
| 4   | Làm việc với File/CSDL    | 100%               |
| 5   | Duyệt thư mục           | 100%               |

## Chi Tiết Các Task

### Task 1: Đọc và ghi file cơ bản

*   **Mục đích:** Chương trình cho phép người dùng:
    *   Mở tệp văn bản (.txt), đọc nội dung và hiển thị trong hộp văn bản (RichTextBox).
    *   Chỉnh sửa nội dung văn bản trong ứng dụng.
    *   Lưu nội dung đã chỉnh sửa vào một tệp .txt khác hoặc ghi đè lên tệp cũ.
*   **Chức năng chính:**
    *   Đọc nội dung từ file .txt và hiển thị lên RichTextBox.
    *   Cho phép người dùng chỉnh sửa nội dung trong RichTextBox.
    *   Lưu nội dung từ RichTextBox vào file .txt.
*   **Các thành phần chính:**
    *   **Giao diện người dùng (UI):**
        *   `RichTextBox`: Hiển thị nội dung tệp văn bản và cho phép người dùng chỉnh sửa.
        *   `Button (Read File)`: Nhấn để mở hộp thoại chọn tệp .txt và đọc nội dung.
        *   `Button (Write File)`: Nhấn để lưu nội dung hiện tại vào một tệp mới hoặc ghi đè tệp cũ.
    *   **Xử lý sự kiện:**
        *   Khi người dùng nhấn nút `Read File`, chương trình mở hộp thoại chọn tệp (`OpenFileDialog`), đọc nội dung và hiển thị vào `RichTextBox`.
        *   Khi nhấn `Write File`, chương trình mở hộp thoại lưu tệp (`SaveFileDialog`), lấy nội dung từ `RichTextBox` và ghi vào tệp .txt.
    *   **Xử lý tệp tin:**
        *   Sử dụng `StreamReader` để đọc tệp.
        *   Sử dụng `StreamWriter` để ghi tệp.
        *   Sử dụng `using` để đảm bảo tài nguyên tệp được giải phóng sau khi sử dụng.
*   **Cách hoạt động:**
    1.  Người dùng khởi động ứng dụng.
    2.  Nhấn `Read File`, chọn một tệp .txt, nội dung hiển thị trên `RichTextBox`.
    3.  Người dùng có thể chỉnh sửa nội dung.
    4.  Nhấn `Write File`, đặt tên tệp và lưu nội dung vào tệp .txt.

### Task 2: Đọc thông tin tập tin

*   **Tổng quan:** Chương trình cho phép người dùng chọn một tệp .txt, đọc nội dung và hiển thị các thông tin phân tích như:
    *   Tên tệp
    *   Đường dẫn tệp
    *   Số ký tự
    *   Số từ
    *   Số dòng
*   **Chức năng chính:**
    *   Đọc nội dung từ file .txt.
    *   Hiển thị tên file, đường dẫn, số ký tự, số từ và số dòng của file.
*   **Các thành phần chính:**
    *   **Giao diện người dùng (UI):**
        *   Nút "Read File": Mở hộp thoại để chọn tệp .txt.
        *   Hộp văn bản: Hiển thị nội dung tệp.
        *   Các `TextBox` để hiển thị thông tin về tệp:
            *   `fileName_box`: Hiển thị tên tệp.
            *   `url_box`: Hiển thị đường dẫn đầy đủ.
            *   `char_box`: Hiển thị số ký tự.
            *   `word_box`: Hiển thị số từ.
            *   `line_box`: Hiển thị số dòng.
*   **Cách hoạt động:**
    1.  **Bước 1: Mở hộp thoại chọn tệp (`OpenFileDialog`)**
        *   Chỉ cho phép chọn một tệp .txt (`Multiselect = false`).
        *   Khi người dùng chọn tệp thành công, chương trình lấy:
            *   Tên tệp (`SafeFileName`)
            *   Đường dẫn đầy đủ (`FileName`)
    2.  **Bước 2: Đọc nội dung tệp**
        *   Dùng `File.ReadAllText(path)` để đọc toàn bộ nội dung và hiển thị trong `RichTextBox`.
    3.  **Bước 3: Tính toán số ký tự, số từ, số dòng**
        *   Số ký tự (`text.Length`): Đếm tổng số ký tự trong tệp.
        *   Số từ (`text.Split(separators, StringSplitOptions.RemoveEmptyEntries).Length`): Cắt chuỗi thành mảng từ dựa trên khoảng trắng, dấu xuống dòng (`\n`), dấu “:”.
        *   Số dòng: Dùng `StreamReader.ReadLine()` để đọc từng dòng, đếm tổng số dòng.
    4.  **Bước 4: Hiển thị kết quả**
        *   Nội dung được hiển thị trong `RichTextBox`.
        *   Các thông tin về tệp (tên, đường dẫn, số ký tự, từ, dòng) được cập nhật vào `TextBox`.

### Task 3: Đọc và ghi file (Mở rộng)

*   **Tổng quan:** Chương trình có chức năng:
    *   Đọc các biểu thức toán học từ tệp .txt.
    *   Tính toán giá trị của từng biểu thức.
    *   Hiển thị kết quả lên giao diện.
    *   Lưu kết quả ra tệp .txt.
*   **Chức năng chính:**
    *   Đọc dữ liệu từ file .txt.
    *   Tính toán các biểu thức toán học.
    *   Hiển thị kết quả tính toán.
    *   Lưu kết quả vào file .txt.
*   **Các thành phần chính:**
    *   **Giao diện người dùng (UI):**
        *   Nút "Read File" (`read_btn`): Mở hộp thoại để chọn tệp chứa các biểu thức toán học.
        *   `RichTextBox richTextBox1`: Hiển thị nội dung tệp đầu vào.
        *   Nút "Calculate" (`calculate_btn`): Tính toán kết quả của các biểu thức.
        *   `RichTextBox richTextBox2`: Hiển thị kết quả tính toán.
        *   Nút "Save File" (`write_btn`): Lưu kết quả vào tệp .txt.
*   **Cách hoạt động:**
    1.  **Bước 1:** Người dùng chọn tệp văn bản chứa các phép tính đơn giản.
    2.  **Bước 2:** Chương trình đọc và hiển thị nội dung tệp.
    3.  **Bước 3:** Khi nhấn "Calculate", chương trình tính toán kết quả từng biểu thức.
    4.  Kết quả hiển thị trong `richTextBox2`.
    5.  Người dùng có thể lưu kết quả vào một tệp .txt.

### Task 4: Làm việc với File/CSDL

*   **Tổng quan:** Chương trình nhập thông tin sinh viên, hiển thị dữ liệu, và lưu dữ liệu vào file Excel bằng thư viện EPPlus.
*   **Chức năng chính:**
    *   Nhập thông tin sinh viên.
    *   Hiển thị danh sách sinh viên.
    *   Lưu danh sách sinh viên vào file Excel.
*   **Các thành phần chính:**
    *   `Info.cs`:
        *   Là form để nhập thông tin sinh viên.
        *   Khi nhấn nút lưu, dữ liệu được kiểm tra tính hợp lệ (MSSV, họ tên, SĐT, điểm số).
        *   Nếu hợp lệ, dữ liệu sẽ được lưu vào file input.txt.
    *   `Excel.cs`:
        *   Là form chính, hiển thị danh sách sinh viên từ file input.txt.
        *   Hỗ trợ các chức năng:
            *   Nhập dữ liệu (gọi Info.cs).
            *   Hiển thị danh sách (đọc dữ liệu từ input.txt và hiển thị trong ListView).
            *   Lưu danh sách vào Excel (data.xlsx).
*   **Cách hoạt động:**
    *   **Nhập dữ liệu - `Info.cs`:**
        1.  Người dùng nhập thông tin sinh viên.
        2.  Kiểm tra hợp lệ trước khi lưu vào input.txt.
        3.  Chức năng chính:
            *   Nhận MSSV, họ tên, SĐT, điểm toán, điểm văn.
            *   Kiểm tra dữ liệu nhập vào:
                *   Dữ liệu không được để trống.
                *   Điểm phải có giá trị thuộc \[0, 10].
            *   Lưu vào input.txt theo format: MSSV;Họ Tên;SĐT;Điểm Toán;Điểm Văn
    *   **Hiển thị danh sách – `Excel.cs`:**
        1.  Đọc dữ liệu từ input.txt và hiển thị lên ListView.
        2.  Chức năng chính:
            *   Đọc từng dòng từ input.txt.
            *   Phân tách dữ liệu theo dấu ;.
            *   Tính điểm trung bình (DTB).
            *   Hiển thị trên ListView.
    *   **Lưu danh sách vào Excel - `Excel.cs`:**
        1.  Ghi toàn bộ danh sách từ ListView vào file Excel (data.xlsx).
        2.  Chức năng chính:
            *   Kiểm tra nếu data.xlsx đã tồn tại hay chưa.
            *   Nếu chưa có, tạo tiêu đề (MSSV, Họ Tên, SDT, Điểm Toán, Điểm Văn, DTB).
            *   Duyệt ListView để ghi từng dòng vào file.
            *   Sử dụng EPPlus để ghi dữ liệu vào Excel.

### Task 5: Duyệt thư mục

*   **Tổng quan:** Ứng dụng giúp duyệt thư mục và hiển thị danh sách tệp tin/thư mục trong thư mục đã chọn:
    *   Chọn thư mục → Hiển thị danh sách tệp tin & thư mục con.
    *   Quay lại thư mục cha → Trở về thư mục trước đó.
    *   Hiển thị thông tin chi tiết của tệp/thư mục:
        *   Tên tệp/thư mục
        *   Kích thước (nếu là tệp tin)
        *   Loại (Tệp/Thư mục)
        *   Ngày tạo
*   **Chức năng chính:**
    *   Duyệt và chọn thư mục.
    *   Hiển thị danh sách các file và thư mục con trong thư mục đã chọn.
    *   Hiển thị thông tin chi tiết về file và thư mục (tên, kích thước, loại, ngày tạo).
    *   Quay lại thư mục cha.
*   **Giao diện UI:**
    *   Nút "Duyệt thư mục" (`browseBtn`): Mở hộp thoại để chọn thư mục.
    *   `TextBox path_box`: Hiển thị đường dẫn thư mục hiện tại.
    *   Danh sách `ListView ListFile`: Hiển thị tệp tin & thư mục con với các thông tin.
    *   Nút "Quay lại" (`BackBtn`): Quay lại thư mục cha.
*   **Cách hoạt động:**
    *   **Khởi tạo giao diện ListView:**
        *   `View.Details`: Hiển thị danh sách theo dạng bảng (chi tiết).
        *   `FullRowSelect = true`: Cho phép chọn nguyên dòng.
        *   `GridLines = true`: Hiển thị đường kẻ giữa các dòng.
        *   Thêm các cột: Tên file, Kích thước, Loại, Ngày tạo.
    *   **Chọn thư mục (`browseBtn_Click`):**
        *   Hiển thị hộp thoại chọn thư mục (`FolderBrowserDialog`).
        *   Nếu người dùng chọn thư mục → Lưu đường dẫn vào `path_box` → Gọi hàm tải tệp tin/thư mục (`LoadFilesAndDirectories`).
    *   **Đọc danh sách tệp tin & thư mục (`LoadFilesAndDirectories`):**
        *   `DirectoryInfo di = new DirectoryInfo(path);`
        *   Duyệt tất cả thư mục con trong thư mục đã chọn:
            *   Lấy tên thư mục (`dir.Name`).
            *   Không có kích thước ("").
            *   Loại là "Thư mục".
            *   Ngày tạo thư mục (`dir.CreationTime`).
            *   Lưu đường dẫn đầy đủ vào Tag để có thể sử dụng sau.
            *   Thêm vào danh sách ListView.
        *   Hiển thị tệp tin:
            *   Duyệt tất cả tệp tin trong thư mục đã chọn:
                *   Lấy tên tệp (`file.Name`).
                *   Kích thước tệp (`file.Length`).
                *   Phần mở rộng (`file.Extension`).
                *   Ngày tạo tệp (`file.CreationTime`).
                *   Lưu đường dẫn vào Tag.
    *   **Quay lại thư mục cha (`BackBtn_Click`):**
        *   Lấy đường dẫn hiện tại.
        *   Nếu thư mục có thư mục cha → Chuyển đến thư mục cha.
        *   Cập nhật lại danh sách.

--- HẾT ---
