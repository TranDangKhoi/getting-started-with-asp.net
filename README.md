- Pipeline: specifies how application shoud respond to a web request. When your application receives a request from the browser, that request goes back and forth through the pipeline

![Untitled](https://i.ibb.co/vxDSJdh/pipeline.png)

MVC:

- Model: Là các data mà các user sẽ hoạt động, tương tác cùng. Hãy cùng đặt 1 ví dụ như sau:
  - Bạn muón tạo một app để bán hàng, app của bạn phải có một bảng để lưu trữ dữ liệu của tất cả danh mục sản phẩm hoặc thông tin chi tiết sản phẩm.
    -> Vậy thì về cơ bản ta sẽ gọi những thứ như danh mục sản phẩm hay thông tin chi tiết sản phẩm đó là Models
- View: Đóng vai trò là User Interface - những thứ mà người dùng nhìn thấy khi mở trang web, là thứ mà người dùng vào để tương tác với chương trình của mình (Nút đặt hàng - Click vào là sẽ chuyển tới trang đặt hàng, Nút thanh toán - Click vào sẽ hiển thị giao thức thanh toán, ...)
- **NHƯNG**, đương nhiên nếu mà chỉ có Views thì sẽ không thực hiện được các chức năng đó, View còn phải tương tác với Model để thực hiện cập nhật thông tin, logic, … Nhưng view không thể tự mình mà làm việc đó được, nên ta sẽ phải cần nhờ tới Controller.
- Controller: Đóng vai trò như trái tim của cả chương trình, thực hiện handle các requests của user gửi tới (các request được gửi tới khi người dùng click vào đặt hàng/thanh toán đơn hàng/v.v) và đóng vai trò như là một interface giữa Model và View để thực thi tất cả các business logic.

![Untitled](https://i.ibb.co/17kByKG/mvc.png)

- Khái niệm:

- \_ViewStartP: chứa liên kết tới main layout
- Tag Helpers giúp code ở bên server cũng có thể tham gia vào việc tạo và render các HTML elements trong file Razor. Tag helpers là một kiến thức mới trong .NET6 mà trước đây ở các version 4-5 thường dùng là HTML Helpers, viết nhọc hơn rất nhiều

VD:

```csharp
// HTML Helper
Html.Label("FirstName", "FirstName : ", new {@class = "form-control" )}
// Tag Helper
<label asp-for="FirstName" class="form-control"></label>
```
