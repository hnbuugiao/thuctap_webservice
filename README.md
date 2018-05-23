Thực tập - phần Webservice 
Thông số cài đặt:
- PostgreSQL 
	+ Server=127.0.0.1
	+ Port=5432
	+ Id=postgres
	+ Password=123456
	+ Database=svthuctap
- Visual Studio 2015 (IIS Server)
	+ Server=localhost
	+ Port=29444
	+ Đổi thông tin connection project: Folder Connections->ConnectionString -> Thay đổi
- Thông tin câu lệnh:

- GET
```
 http://localhost:29444/BenhNhan
```
	+ Kết quả:
	[{"mabn":"BN001","holot":"Huynh Nguyen ","ten":"Buu Giao","ngaysinh":"5/4/2018","gioitinh":1},	{"mabn":"BN002","holot":"Nguyen","ten":"Minh Nhat","ngaysinh":"4/5/2018","gioitinh":1}]


- POST 
```
 http://localhost:29444/BenhNhan
```
+Json gửi đi: 
```
{
	"mabn" : "BN00",
	"holot" : "Huynh Nguyen",
	"ten" : "Buu Giao",
	"ngaysinh" : "04/05/2018",
	"gioitinh" : 0
}
```
	+ Kết quả: Bệnh nhân có mã BN002 được thêm vào Database


- PUT 
```
 http://localhost:29444/BenhNhan
```
+Json gửi đi :
```
{
	"mabn" : "BN001",
	"holot" : "Huynh Nguyen",
	"ten" : "Buu Tuan",
	"ngaysinh" : "19/01/2018",
	"gioitinh" : 1
}
```
	+ Kết quả: Bệnh nhân có mã BN001 đã được sửa lại thông tin dựa theo sự thay đổi của holot,ten,ngaysinh,gioitinh
	+ Mã bệnh nhân không thay đổi


- DELETE
```
 http://localhost:29444/BenhNhan/BN001
```
	+ Kết quả: Bệnh nhân có mãBN001 đã được xoá khỏi Database
