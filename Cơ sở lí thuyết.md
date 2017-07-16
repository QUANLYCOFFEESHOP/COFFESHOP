
I.	Hệ quản trị CSDL SQL SERVER 
1.	Giới thiệu SQL Server
Microsoft SQL Server là một hệ quản trị cơ sở dữ liệu quan hệ (Relation Database Management System - RDBMS), cung cấp cách tổ chức dữ liệu bằng cách lưu chúng vào các bảng. Dữ liệu quan hệ được lưu trữ trong các bảng và các quan hệ đó được định nghĩa giữa các bảng với nhau. Người dùng truy cập dữ liệu trên Server thông qua ứng dụng. Người quản trị CSDL truy cập Server trực tiếp để thực hiện các chức năng cấu hình, quản trị và thực hiện các thao tác bảo trì CSDL. Ngoài ra, SQL Server là một CSDL có khả năng mở rộng, nghĩa là chúng có thể lưu một lượng lớn dữ liệu và hỗ trợ tính năng cho phép nhiều người dùng truy cập dữ liệu đồng thời. Các phiên bản của SQL Server phổ biến hiện này trên thị trường là SQL Server 7.0, SQL Server 2000, SQL Server 2005, SQL Server 2008. 
SQL Server là một hệ quản trị cơ sở dữ liệu quan hệ (Relational Database Management System (RDBMS) ) sử dụng câu lệnh SQL (Transact-SQL) để trao đổi dữ liệu giữa máy Client và máy cài SQL Server.

2.	Lịch sử phát triển SQL Server

	1970: IBM giới thiệu ngôn ngữ SEQUEL.
	1987: IBM tích hợp phần mềm quản trị CSDL vào hệ điều hành OS2.
	1988: Hệ quản trị CSDL Ashton-Tate được MS kết hợp với Sybase giới thiệu.
	MS bắt đầu phát triển SQL Server trên nền Ashton-Tate và đưa vào WinNT Server sau đó.
	Các phiên bản được sử dụng của SQL Server: 4.2, 4.21, 6.0, 6.5, 7.0, 2000, 2005, 2008, 2010, 2012, 2012, 2014, 2016.

3.	Ngôn ngữ cơ sở dữ liệu:
Một hệ quản trị cơ sở dữ liệu thường cung cấp hai kiểu ngôn ngữ khác nhau đó là: ngôn ngữ mô tả sơ đồ cơ sở dữ liệu và ngôn ngữ biểu diễn các truy vấn và các cập nhật cơ sở dữ liệu. 

Ngôn ngữ định nghĩa dữ liệu (Data Definition Language - DDL) : 
	Một sơ đồ CSDL đặc tả bởi một tập các định nghĩa được biểu diễn bởi một ngôn ngữ đặc biệt được gọi là ngôn ngữ định nghĩa dữ liệu. Kết quả của việc dịch các ngôn ngữ này là một tập các bảng được lưu trữ trong một tệp đặc biệt được gọi là từ điển dữ liệu hay thư mục dữ liệu.  
	Một từ điển dữ liệu là một tệp chứa các siêu dữ liệu có nghĩa là các dữ liệu về dữ liệu. Tệp này được tra cứu trước khi dữ liệu thực sự được đọc hay được sửa đổi trong hệ CSDL.  
	Cấu trúc và các phương pháp truy nhập được sử dụng bởi hệ CSDL được đặc tả bởi một tập các định nghĩa trong một kiểu đặc biệt của DDL là ngôn ngữ định nghĩa và lưu trữ dữ liệu. 
Ngôn ngữ thao tác dữ liệu (Data Manipulation Language - DML):  
Các yêu cầu về thao tác dữ liệu bao gồm:  
	Tìm kiếm thông tin được lưu trữ trong CSDL.
	Thêm thông tin mới vào CSDL. 
	Xoá thông tin từ CSDL.  
	Thay đổi thông tin được lưu trữ trong CSDL.

Một ngôn ngữ thao tác dữ liệu (DML) là một ngôn ngữ cho phép người sử dụng truy nhập hay thao tác dữ liệu được tổ chức bởi mô hình dữ liệu thích hợp. Có hai kiểu ngôn ngữ thao tác dữ liệu cơ bản:  
	Các DML thủ tục đòi hỏi người sử dụng phải đặc tả dữ liệu nào cần tìm kiếm và tìm kiếm những dữ liệu này như thế nào.  
	Các DML phi thủ tục đòi hỏi người sử dụng đặc tả dữ liệu nào cần tìm kiếm mà không phải đặc tả tìm kiếm những dữ liệu này như thế nào. 
4.	Khái niệm mô hình dữ liệu quan hệ:
Miền (domain): là một tập các giá trị hoặc các đối tượng. 
Thực thể: Thực thể là một đối tượng cụ thể hay trừu tượng trong thế giới thực mà nó tồn tại và có thể phân biệt được với các đối tượng khác.  
Ví dụ: Bạn Nguyễn Văn A là một thực thể cụ thể. Hay Sinh viên cũng là một thực thể, thực thể trừu tượng. 
Thuộc tính (Attribute): Là tính chất của thực thể. 
	Các thực thể có các đặc tính, được gọi là các thuộc tính. Nó kết hợp với một thực thể trong tập thực thể từ miền giá trị của thuộc tính. Thông thường, miền giá trị của một thuộc tính là một tập các số nguyên, các số thực, hay các xâu ký tự. 
	Một thuộc tính hay một tập thuộc tính mà giá trị của nó xác định duy nhất mỗi thực thể trong tập các thực thể được gọi là khoá đối với tập thực thể này.
	Mỗi một thuộc tính nhận tập số các giá trị nhất định được gọi là domain của thuộc tính đó.
Một quan hệ (Relation): Định nghĩa một cách đơn giản, một quan hệ là một bảng dữ liệu có các cột là các thuộc tính và các hàng là các bộ dữ liệu cụ thể của quan hệ. 
Các liên kết: Một liên kết là một sự kết hợp giữa một số thực thể (hay quan hệ). Ví dụ: Mối liên kết giữa phòng ban và nhân viên thể hiện: Một nhân viên A sẽ thuộc một phòng ban B nào đó.
	Các liên kết một – một: đây là dạng liên kết đơn giản, liên kết trên hai thực thể là một – một, có nghĩa là mỗi thực thể trong tập thực thể này có nhiều nhất một thực thể trong tập thực thể kia kết hợp với nó và ngược lại.  
	Các liên kết một – nhiều: Trong một liên kết một – nhiều, một thực thể trong tập thực thể A được kết hợp với không hay nhiều thực thể trong tập thực thể B. Nhưng mỗi thực thể trong tập thực thể B được kết hợp với nhiều nhất một thực thể trong tập thực thể A.  
	Các liên kết nhiều – nhiều: Ðây là dạng liên kết mà mỗi thực thể trong tập thực thể này có thể liên kết với không hay nhiều thực thể trong tập thực thể kia và ngược lại.
Mô hình dữ liệu quan hệ: Làm việc trên bảng hay trên quan hệ trong đó: Mỗi cột là một thuộc tính, mỗi dòng là một bộ (một bản ghi).
	Các ưu điểm của mô hình dữ liệu quan hệ 
	Cấu trúc dữ liệu dễ dùng, không cần hiểu biết sâu về kỹ thuật cài đặt.  
	Cải thiện tính độc lập dữ liệu và chương trình. 
	Cung cấp ngôn ngữ thao tác phi thủ tục. 
	Tối ưu hoá cách truy xuất dữ liệu. 
	Tăng tính bảo mật và toàn vẹn dữ liệu. 
	Cung cấp các phương pháp thiết kế có hệ thống. Và mở ra cho nhiều loại ứng dụng (lớn và nhỏ).  
Khoá của quan hệ: 
	Khoá của quan hệ (key): Là tập các thuộc tính dùng để phân biệt hai bộ bất kỳ trong quan hệ.  
	Khoá ngoại của quan hệ (Foreign Key): Một thuộc tính được gọi là khoá ngoại của quan hệ nếu nó là thuộc tính không khoá của quan hệ này nhưng là thuộc tính khoá của quan hệ khác.

II.	Visual Studio.NET và ngôn ngữ lập trình C#
1.	VISUAL STUDIO.net:
Microsoft Visual Studio là một môi trường phát triển tích hợp (IDE) từ Microsoft. Nó được sử dụng để phát triển chương trình máy tính cho Microsoft Windows, cũng như các trang web, các ứng dụng web và các dịch vụ web. Visual Studio sử dụng nền tảng phát triển phần mềm của Microsoft như Windows API, Windows Forms, Windows Presentation Foundation, Windows Store và Microsoft Silverlight. Nó có thể sản xuất cả hai ngôn ngữ máy và mã số quản lý.
Visual Studio bao gồm một trình soạn thảo mã hỗ trợ IntelliSense cũng như cải tiến mã nguồn. Trình gỡ lỗi tích hợp hoạt động cả về trình gỡ lỗi mức độ mã nguồn và gỡ lỗi mức độ máy. Công cụ tích hợp khác bao gồm một mẫu thiết kế các hình thức xây dựng giao diện ứng dụng, thiết kế web, thiết kế lớp và thiết kế giản đồ cơ sở dữ liệu. Nó chấp nhận các plug-in nâng cao các chức năng ở hầu hết các cấp bao gồm thêm hỗ trợ cho các hệ thống quản lý phiên bản (như Subversion) và bổ sung thêm bộ công cụ mới như biên tập và thiết kế trực quan cho các miền ngôn ngữ cụ thể hoặc bộ công cụ dành cho các khía cạnh khác trong quy trình phát triển phần mềm.
Visual Studio hỗ trợ nhiều ngôn ngữ lập trình khác nhau và cho phép trình biên tập mã và gỡ lỗi để hỗ trợ (mức độ khác nhau) hầu như mọi ngôn ngữ lập trình. 
Các ngôn ngữ tích hợp gồm
	 C, C++ và C++/CLI (thông qua Visual C++), VB.NET (thông qua Visual Basic.NET) 
	C# ( thông qua Visual C# ) và F# ( như của Visual Studio 2010 ). Hỗ trợ cho các ngôn ngữ khác như J++/J#, Python và Ruby thông qua dịch vụ cài đặt riêng rẽ.
	Ngoài ra Visual Studio cũng hỗ trợ XML/XSLT, HTML/XHTML, JavaScript và CSS. Microsoft cung cấp phiên bản "Express" ( đối với phiên bản Visual Studio 2013 trở về trước ) và "Comunity" (đối với bản Visual Studio 2015) là phiên bản miễn phí của Visual Studio. 
2.	Ngôn ngữ C#	
C # là một ngôn ngữ lập trình hiện đại được phát triển bởi Microsoft và được phê duyệt bởi ECMA “European Computer Manufacturers Association” và  ISO “International Standards Organization”. 
C # được phát triển bởi Anders Hejlsberg và nhóm của ông trong việc phát triển .Net Framework.
C # được thiết kế cho các ngôn ngữ chung cơ sở hạ tầng (Common Language Infrastructure – CLI), trong đó bao gồm các mã (Executable Code) và môi trường thực thi (Runtime Environment) cho phép sử dụng các ngôn ngữ cấp cao khác nhau trên đa nền tảng máy tính và kiến trúc khác nhau.
Ngôn ngữ ra đời cùng với .NET
	Kết hợp C++ và Java.
	Hướng đối tượng.
	Hướng thành phần.
	Mạnh mẽ (robust) và bền vững (durable).
	Mọi thứ trong C# đều Object oriented.
	Kể cả kiểu dữ liệu cơ bản.
	Chỉ cho phép đơn kế thừa.
	Dùng interface để khắc phục.
	Lớp Object là cha của tất cả các lớp.
	Mọi lớp đều dẫn xuất từ Object.
	Cho phép chia chương trình thành các thành phần nhỏ độc lập nhau.
	Mỗi lớp gói gọn trong một file, không cần file header như C/C++.
	Bổ sung khái niệm namespace để gom nhóm các lớp.
	Bổ sung khái niệm “property” cho các lớp.
	Khái niệm delegate & event.



C# – mạnh mẽ & bền vững
	Garbage Collector
	Tự động thu hồi vùng nhớ không dùng.
	Kiểm soát và xử lý ngoại lệ exception
	Đoạn mã bị lỗi sẽ không được thực thi.
	Type – safe
	Không cho gán các kiểu dữ liệu khác nhau.
	Versioning
	Đảm bảo sự tương thích giữa lớp con và lớp cha.
Vai trò C# trong .NET Framework
	.NET runtime sẽ phổ biến và được cài trong máy client.
	Việc cài đặt App C# như là tái phân phối các thành phần .NET
	Nhiều App thương mại sẽ được cài đặt bằng C#.
	C# tạo cơ hội cho tổ chức xây dựng các App Client/Server n-tier.
	Kết nối ADO.NET cho phép truy cập nhanh chóng & dễ dàng với SQL Server, Oracle…
	Cách tổ chức .NET cho phép hạn chế những vấn đề phiên bản.
	Loại bỏ “DLL Hell”…
	ASP.NET viết bằng C#.
	GUI thông minh.
	Chạy nhanh hơn (đặc tính của .NET)
	Mã ASP.NET ko còn là mới hỗn độn.
	Khả năng bẫy lỗi tốt, hỗ trợ mạnh trong quá trình xây dựng App Web.
Quá trình dịch CT C#

	Mã nguồn C# (tập tin *.cs) được biên dịch qua MSIL.
	MSIL: tập tin .exe hoặc .dll
	MSIL được CLR thông dịch qua mã máy.





