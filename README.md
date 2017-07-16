<html>
<head>
	<meta charset="utf-8">
</head>
<body>
<h1>COFFESHOP</h1>
<p>Một hệ thống quản lý coffee shop có nhiệm vụ quản lý các sản phẩm, giá cả, hóa đơn giúp khách hàng dễ dàng trong việc thanh toán. Quản lý được kho hàng và các thống kê như thống kê bán hàng, nhập xuất kho, thu chi, doanh thu giúp chủ cửa hàng không gặp nhiều khó khăn trong việc quản lý cũng như kiểm tra sự phát triển của coffee shop. Hệ thống phải quản lý được việc bán hàng nhằm tiện lợi cho quản lý trong việc quản lý sản phẩm bán ra. Quản lý được nhân sự để tiện lợi cho trong việc trả lương cũng như sắp xếp lịch làm việc cho các nhân viên. Quản lý khách hàng nhằm tiện lợi cho khách hàng, khách quen sẽ có nhiều ưu đãi nhằm thu hút khách hàng tới quán nhiều hơn
Quản lý hoạt động kinh doanh về các loại sản phẩm coffce, quản lý hàng hóa, lượng sản phẩm nhập vào, bán ra, hóa đơn nhập và hóa đơn xuất, nắm bắt được sở thích khách hàng ưa chuộng loại coffee nào với từng giai cấp…
Các hoạt động trong công việc quản lý cửa hàng coffee:
  
  •	Quản lý nhân viên:
	
  Quản lý nhân viên: nhân viên phải có mã nhân viên, tên nhân viên, địa chỉ chức vụ và phải đúng chính xác và không được trùng lặp.
  
  •	Quản lý sản phẩm:
  Ghi nhận ngày tháng nhập và xuất hang.
  
  •	Quản lý danh mục:
  Cập nhật danh mục nhân viên
  Cập nhật danh mục sản phẩm
  Cập nhập danh mục nhà cung cấp
  Xem danh sách các danh mục
  
  •	Thống kê chi tiết
In báo cáo thống kê</p>

<h1>Thông tin Giấy phép</h1>

<p>
		<a href="https://github.com/QUANLYCOFFEESHOP/COFFESHOP/blob/master/Th%C3%B4ng%20tin%20v%E1%BB%81%20gi%E1%BA%A5y%20ph%C3%A9p.md">GNU License</a> Copyright &copy; 2017 DH1C Team - Telecommunications University
	</p>
<!--  -->
	<h1>Tổ chức kho code của mã nguồn</h1>
	<p>
		<blockquote>
			<p><li>Cấu trúc tổ chức kho code của DUAN-NHOM tuân theo mô hình phân nhánh Git như hình dưới</li></p>
		</blockquote>
		<p>
			<img src="https://camo.githubusercontent.com/9bde6fb64a9542a572e0e2017cbb58d9d2c440ac/687474703a2f2f6e7669652e636f6d2f696d672f6769742d6d6f64656c4032782e706e67">
		</p>
	</p>
	<p>
		<blockquote>
			<p><li>Hai nhánh (branch) đi suốt chiều dài phát triển code là Master và Develop. Trong đó:</li></p>
		</blockquote>
		<p>
			<img src="https://camo.githubusercontent.com/87b4f89d95b80c277dffea52afc37a0a1d9e5a59/687474703a2f2f6e7669652e636f6d2f696d672f6d61696e2d6272616e636865734032782e706e67">
		</p>
	</p>
	<p>
	Nhánh chính là nhánh Master, nhánh này luôn đảm bảo rằng code được lưu trữ trên đó là phiên bản chính thức mới nhất đang được phát hành. * Nhánh Develop là nhánh được cập nhật liên tục các đóng góp của tất cả mọi người ở mọi thời điểm. Nhánh này sẽ tiếp nhận các đóng góp của mọi người gửi đến thông qua việc tiếp nhận Pull Request cũng như tiếp nhận việc nhập các nhánh khác vào (integration branch). Khi nhánh Develop đạt độ chín mùi, nó sẽ được nhập vào nhánh Master đồng thời được dán nhãn phiên bản và quá trình phát hành phiên bản được tiến hành. * Ngoài 2 nhánh trên, kho code còn có các nhánh hỗ trợ phát triển, và nó chỉ tồn tại trong một giai đoạn nào đó của dự án nhằm phục vụ những mục đích nhất định, gồm có các nhánh sau: * Feature branches - Các nhánh tính năng * Release branches - Các nhánh hỗ trợ phát hành phiên bản * Hotfix branches - Các nhánh hỗ trợ vá lỗi nhanh * Để đánh dấu các mốc quan trọng (ví dụ các phiên bản được phát hành), ta sử dụng các tag. Các tag này sẽ giúp truy cập nhanh đến kho code tại thời điểm diễn ra dấu mốc sự kiện được đánh dấu.
	</p>
	<!--  -->
	<h1>Ngôn ngữ lập trình</h1>
	<p>
		<blockquote>
			<p>Phần mềm được xây dựng bằng ngôn ngữ lập trình C# sử dụng hệ quản trị SQL Server 2012.</p>
		</blockquote>
	</p>
	<!--  -->
	<h1>Tài liệu hướng dẫn sử dụng</h1>
	<p>
		Đặt liên kết đến tài liệu hướng dẫn sử dụng <a href="https://github.com/QUANLYCOFFEESHOP/COFFESHOP/blob/master/T%C3%A0i%20li%E1%BB%87u%20cho%20ng%C6%B0%E1%BB%9Di%20d%C3%B9ng.md" target="_blank"> Xem tại đây</a>.
	</p>
	<!--  -->
	<h1>Tài liệu dành cho nhà phát triển</h1>
	<p>
		Tài liệu phát triển . <a href="https://github.com/QUANLYCOFFEESHOP/COFFESHOP/blob/master/Developer.md" target="_blank">Tại đây</a>.
	</p>
	<!--  -->
	<h1>Tài liệu thiết kế</h1>
	<p>
		Tài liệu thiết kế . <a href="https://github.com/DUAN-NHOM/QLThongTinSinhVien/blob/master/Design.md" target="_blank">Tại đây</a>.
	</p>
	<!--  -->
	<h1>Dành cho cộng tác viên</h1>
	<p><li>Để tham gia phát triển code, chỉ cần 1 tài khoản trên Github.Sau đó truy cập vào kho code DUAN-NHOM(https://github.com/DUAN-NHOM/DUAN-NHOM/tree/master),ấn nút Fork để copy project có sẵn thành project của mình, rồi sau đó ta có thể tự do chỉnh sửa project đó của mình</li>
	</p>
  <p><li>Chỉnh sửa xong thì ấn nút Pull Request để gửi yêu cầu đóng góp lên cho những người quản lý kho code</li></p>
  <p><li>Những người quản lý kho code sẽ kiểm tra và phê duyệt các đóng góp này. Nếu đóng góp chưa đạt hoặc cần chỉnh sửa thì những người quản lý có thể viết góp ý ngay tại yêu cầu đóng góp và trả lại để người đóng góp chỉnh sửa theo góp ý và gửi lại sau khi đã sửa xong. Quá trình này diễn ra cho đến khi yêu cầu đóng góp được chấp nhận, đóng góp đó sẽ được trộn (merge) vào các nhánh phù hợp với dự án được đóng góp</li>
  </p>
  <p><li>Để tăng hiệu suất quản lý, toàn bộ công việc chỉnh sửa, xử lý xung đột... trước khi gửi đóng góp lên sẽ do người đóng góp xử lý. Người quản lý kho code sẽ chỉ việc kiểm tra và trả lời chứ không phải mất công để sửa lại code được đóng góp.</li>
  </p>
</body>
</html>
 
