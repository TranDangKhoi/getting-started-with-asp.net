- Pipeline: specifies how application shoud respond to a web request. When your application receives a request from the browser, that request goes back and forth through the pipeline

![Untitled](https://s3-us-west-2.amazonaws.com/secure.notion-static.com/2741bf96-b3fc-4437-b12b-43fd610979b4/Untitled.png)

![Untitled](https://s3-us-west-2.amazonaws.com/secure.notion-static.com/e8fc880b-1b38-464f-aa24-d105796ed4bb/Untitled.png)

MVC:

- Model: Là các data mà các user sẽ hoạt động, tương tác cùng. Hãy cùng đặt 1 ví dụ như sau:
  - Bạn tạo một app để bán hàng, app của bạn phải có một table để lưu trữ dữ liệu của tất cả các danh mục sản phẩm và thông tin chi tiết sản phẩm. Vậy thì ta sẽ gọi các thứ như danh mục sản phẩm/thông tin chi tiết sản phẩm đó là một Model
  - Vậy chốt lại, Models sẽ bao gồm tca các thứ mà chương trình mình tập trung vào làm:
    - Ví dụ, bạn làm việc với web bán hàng, thì Model chính sẽ là Product, Categories, Brand, … Và cũng đồng nghĩa trong database của bạn cũng sẽ tồn tại các bảng cùng tên với các Models này
    - Trường hợp trên về cơ bản là vậy chứ không phải luôn luôn đúng! Vì sau này sẽ còn nhiều thứ phức tạp hơn
- View: Đóng vai trò là User Interface - những thứ mà người dùng nhìn thấy khi mở trang web, thứ mà người dùng vào để tương tác với chương trình của mình (Click vào nút đặt hàng thì sản phẩm sẽ nhảy vào giỏ hàng, click vào thanh toán thì thực hiện chức năng thanh toán). NHƯNG, đương nhiên nếu mà chỉ có Views thì sẽ không thực hiện được các chức năng đó, View còn phải tương tác với Model để thực hiện cập nhật thông tin, logic, … Nhưng view không thể tự mình mà làm việc đó được, nên ta sẽ phải cần nhờ tới con chữ “C” cuối cùng, đó chính là Controller
- Controller: Đóng vai trò như trái tim của cả chương trình, thực hiện handle các requests của user gửi tới (các request được gửi tới khi người dùng click vào đặt hàng/thanh toán đơn hàng/v.v) và đóng vai trò như là một interface giữa Model và View để thực thi tất cả các business logic.

![Untitled](https://s3-us-west-2.amazonaws.com/secure.notion-static.com/d5d5ce5b-5ac4-4acf-9682-dfc3575a73a8/Untitled.png)

- \_ViewStartP: chứa liên kết tới main layout
- Tag Helpers giúp code ở bên server cũng có thể tham gia vào việc tạo và render các HTML elements trong file Razor. Tag helpers là một kiến thức mới trong .NET6 mà trước đây ở các version 4-5 thường dùng là HTML Helpers, viết nhọc hơn rất nhiều

VD:

```csharp
// HTML Helper
Html.Label("FirstName", "FirstName : ", new {@class = "form-control" )}
// Tag Helper
<label asp-for="FirstName" class="form-control"></label>
```

- Ngoài ra còn nhiều thứ khác đã được cải tiến và viết dễ hơn rất nhiều
