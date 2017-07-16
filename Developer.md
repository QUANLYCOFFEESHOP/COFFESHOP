# Tài Liệu cho nhà phát triển
-Tài liệu hướng dẫn phát triển mẫu của nhóm gồm có nhiều bài viết, nhiều câu hỏi và hướng dẫn.
<p> B1: Tạo 1 project và thiết kế project theo mô hình 3 lớp (BLL,DAL,GUI), có DAL để liên kết với các Bảng trong CSDL</p>
<p><img src="http://i.imgur.com/PBDZcQO.png"></p>
<p> B2: Tạo class trong BLL để liên kết với các bảng trong csdl</p>
<p><img src="http://i.imgur.com/41kMRQh.png"></p>
<p> B3: Tạo class trong DAL. 
Trong DAL có các class chứa các chức năng kết nối với csdl</p>
<p><img src="http://i.imgur.com/6KbQlHf.png"></p>
<p> B4: Tạo class trong GUI. 
Trong GUI có các class chứa các chức năng thực thi truy vấn như thêm, sửa, xóa, cập nhật vào csdl.</p>
Ở đây câu lệnh truy vấn được đặt bên DAL và ta chỉ việc gọi lại bên GUI
<p><img src="http://i.imgur.com/zqbIypM.png"></p>
<p><img src="http://i.imgur.com/TXMA8F2.png"></p>
