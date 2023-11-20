# InheritanceDemo

Phần 9: tính kế thừa và thông tin thêm về oop
Kế thừa là một khái niệm cơ bản trong lập trình hướng đối tượng (OOP), bao gồm cả C#. Nó cho phép bạn tạo các lớp mới dựa trên các lớp hiện có. Lớp hiện có được gọi là lớp cơ sở hoặc lớp cha và lớp mới được gọi là lớp dẫn xuất hoặc lớp con. Kế thừa được sử dụng để thiết lập mối quan hệ giữa các lớp trong đó lớp dẫn xuất kế thừa các đặc điểm (trường, thuộc tính, phương thức) của lớp cơ sở và cũng có thể giới thiệu các thành viên của chính nó. Dưới đây là tổng quan về cách hoạt động của tính kế thừa trong C#:

1. **Lớp cơ sở (Lớp cha):** Đây là lớp mà bạn muốn kế thừa. Nó định nghĩa các thuộc tính và hành vi chung có thể được chia sẻ với các lớp dẫn xuất. Nó đôi khi còn được gọi là siêu lớp.

     public class Vehicle
{
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }

    public void StartEngine()
    {
        Console.WriteLine("Engine started.");
    }
}

2. **Lớp dẫn xuất (Lớp con):** Đây là lớp kế thừa từ lớp cơ sở. Nó có thể mở rộng hoặc ghi đè hành vi của lớp cơ sở và giới thiệu các thuộc tính và phương thức riêng của nó. Nó đôi khi còn được gọi là lớp con.

     public class Car : Vehicle
{
    public int NumberOfDoors { get; set; }

    public void LockDoors()
    {
        Console.WriteLine("Doors locked.");
    }
}

3. **Tuyên bố kế thừa:** Để khai báo rằng một lớp kế thừa từ một lớp khác, bạn sử dụng dấu hai chấm (:) theo sau là tên của lớp cơ sở trong định nghĩa lớp dẫn xuất.

4. **Quyền truy cập vào các Thành viên Lớp Cơ sở:** Một lớp dẫn xuất có thể truy cập các thành viên công khai và được bảo vệ (trường, thuộc tính và phương thức) của lớp cơ sở. Nó có thể sử dụng các thành viên này như thể chúng được định nghĩa trong lớp dẫn xuất.

     Car myCar = new Car();
myCar.Make = "Toyota";
myCar.Model = "Camry";
myCar.Year = 2023;
myCar.StartEngine(); // Inherited from the base class

5. **Phương thức ghi đè:** Lớp dẫn xuất có thể ghi đè các phương thức từ lớp cơ sở. Điều này có nghĩa là nó có thể cung cấp cách triển khai riêng cho một phương thức có cùng tên. Để ghi đè một phương thức, bạn sử dụng từ khóa `override`.

     public class SportsCar : Car
{
    public new void StartEngine()
    {
        Console.WriteLine("Vroom, vroom!");
    }
}

6. **Trình xây dựng lớp cơ sở:** Khi bạn tạo một phiên bản của lớp dẫn xuất, hàm tạo của lớp cơ sở cũng được gọi. Bạn có thể gọi một cách rõ ràng một hàm tạo của lớp cơ sở cụ thể bằng cách sử dụng từ khóa `base`.

     public Car(string make, string model, int year, int doors)
{
    Make = make;
    Model = model;
    Year = year;
    NumberOfDoors = doors;
}

Kế thừa là một công cụ mạnh mẽ để tạo hệ thống phân cấp lớp, thúc đẩy việc sử dụng lại mã và cấu trúc mã của bạn theo cách có tổ chức hơn. Nó khuyến khích việc tạo mã có cấu trúc tốt, mô-đun và có thể bảo trì bằng cách cho phép bạn mô hình hóa mối quan hệ giữa các đối tượng một cách tự nhiên.

129. Simple Inheritance Example

My code:
ElectricalDevice.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    //parent - Base
    internal class ElectricalDevice
    {
        // boolean to determine the state of the Electrical Device
        public bool IsOn { get; set; }
        // string for the brand name of the Electrical Device
        public string Brand { get; set; }

        public ElectricalDevice(bool isOn, string brand)
        {
            IsOn = isOn;
            Brand = brand;
        }

        //switch on the Electrical Device
        public void SwitchOn()
        {
            IsOn = true;
        }
        //switch off the Electrical Device
        public void SwitchOff()
        {
            IsOn &= false;
        }
    }
}
Radio.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    //Child class
    internal class Radio : ElectricalDevice
    {

        public Radio(bool isOn, string brand) : base(isOn, brand)
        {
            
        }

        public void ListenRadio()
        {
            //first check if the radio is on
            if (IsOn)
            {
                // listen to radio
                Console.WriteLine("Listening to the Radio!");
            }
            else
            {
                //print error message
                Console.WriteLine("Radio is switched off, switch it on first");
            }        
        }
    }
}
TV.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class TV : ElectricalDevice
    {

        //simple constructor
        public TV(bool isOn, string brand) : base(isOn, brand)
        {

        }

        //method to watch the TV
        public void WatchTV()
        {
            //first check if the TV is on
            if (IsOn)
            {
                //watch the TV
                Console.WriteLine("Watching TV!");
            }
            else
            {
                //print error message
                Console.WriteLine("TV is switched off, switch it on first");
            }
        }
    }
}
Program.cs
namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Radio myRadio = new Radio(false, "Sony");
            myRadio.SwitchOn();
            myRadio.ListenRadio();

            TV myTV = new TV(false, "Samsung");
            // method of parent class
            myTV.SwitchOn();
            // method of child class
            myTV.WatchTV();
        }
    }
}
130. Virtual and Override Keywords
Trong C#, từ khóa `virtual` và `override` được sử dụng để triển khai tính đa hình, một khái niệm cơ bản trong lập trình hướng đối tượng. Các từ khóa này được sử dụng để cho phép một lớp cung cấp cách triển khai cụ thể của một phương thức trong lớp cơ sở, cho phép các lớp dẫn xuất cung cấp cách triển khai riêng của chúng nếu cần. Dưới đây là giải thích về cách hoạt động của những từ khóa này:

1. **`ảo` Từ khóa:**

     - Từ khóa `virtual` được sử dụng trong lớp cơ sở để chỉ ra rằng một phương thức có thể bị ghi đè trong lớp dẫn xuất.
     - Khi bạn khai báo một phương thức là `ảo`, về cơ bản bạn đang nói rằng bạn mong muốn phương thức này được các lớp dẫn xuất tùy chỉnh, nhưng bạn cung cấp một cách triển khai mặc định.
     - Người ta thường sử dụng `ảo` cho các phương thức trong lớp cơ sở có hành vi mặc định nhưng phải mở để tùy chỉnh.

 public class Animal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("Animal makes a generic sound.");
    }
}
2. **`ghi đè` Từ khóa:**

     - Từ khóa `override` được sử dụng trong lớp dẫn xuất để cung cấp cách triển khai mới của phương thức `ảo` được xác định trong lớp cơ sở.
     - Phương thức ở lớp dẫn xuất phải có cùng tên, kiểu trả về và tham số giống với phương thức `virtual` ở lớp cơ sở.
     - Việc sử dụng `ghi đè` cho biết rằng bạn đang thay thế cách triển khai mặc định trong lớp cơ sở bằng cách triển khai tùy chỉnh.

     public class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Dog barks.");
    }
}
3. **`cơ sở` Từ khóa:**

     - Trong phương thức được ghi đè của lớp dẫn xuất, bạn có thể sử dụng từ khóa `base` để gọi phần triển khai ban đầu của phương thức từ lớp cơ sở.
     - Điều này cho phép bạn mở rộng hoặc sửa đổi hành vi được xác định trong lớp cơ sở.

     public class Cat : Animal
{
    public override void MakeSound()
    {
        base.MakeSound(); // Call the base class implementation first.
        Console.WriteLine("Cat meows.");
    }
}
Sau đây là ví dụ minh họa cách sử dụng từ khóa `ảo` và `ghi đè`:

class Program
{
    static void Main()
    {
        Animal animal = new Animal();
        Animal dog = new Dog();
        Animal cat = new Cat();

        animal.MakeSound(); // Outputs: "Animal makes a generic sound."
        dog.MakeSound();    // Outputs: "Dog barks."
        cat.MakeSound();    // Outputs: "Animal makes a generic sound." (from base) "Cat meows."
    }
}
Trong ví dụ này, `MakeSound` là `virtual` trong lớp cơ sở `Animal` và được ghi đè trong các lớp dẫn xuất `Dog` và `Cat` để cung cấp các hành vi cụ thể. Việc sử dụng `ảo` và `ghi đè` sẽ thúc đẩy khả năng mở rộng và tính đa hình của mã, cho phép bạn viết mã linh hoạt và dễ bảo trì hơn.

134. Inheritance Challenge 2 - Employees, Bosses and Trainees

Required:
Inheritance Challenge 2 - Employees, Bosses and Trainees
Create a main class with the Main Method, then a base class Employee with the properties Name, FirstName, Salary, and the methods Work() and Pause().

Create a deriving class boss with the property CompanyCar and the method Lead().  Create another deriving class of employees - trainees with the properties WorkingHours and SchoolHours and a method Learn().

Override the methods Work() of the trainee class so that it indicates the working hours of the trainee.

Don’t forget to create constructors.

Create an object of each of the three classes (with arbitrary values)

and call the methods, Lead() of Boss and Work() of Trainee.

Just print out the respective text, what the respective employees do.
E.g. Lead() should print out something like. I'm leading. It is up to you what you print out.

My Code:
https://github.com/Jeussu/InheritanceDemo/tree/master/InheritanceChallenge2

135. Interfaces Intro

Interface không có thuộc tính, chỉ chứa các abstract method, không dùng được method đó ngay trong interface đó mà phải dùng thông qua một class khác đã được implements các method của interface đó. Tức là đằng này đẻ ra phương thức chỉ để cho người khác(đã có sẵn thuộc tính) dùng, vì thế nó cũng chỉ có thể kế thừa interface mà không thể kế thừa class.
https://www.w3schools.com/cs/cs_interface.php





// interface
interface Animal 
{
  void animalSound(); // interface method (does not have a body)
  void run(); // interface method (does not have a body)
}
137. IEnumerator and Ienumerable
IEnumerable : Đây là giao diện cung cấp phương thức để truy xuất điều tra viên cho một bộ sưu tập. Bất kỳ lớp nào triển khai IEnumerable đều có thể được sử dụng với vòng lặp foreach.

IEnumerator : Giao diện này cung cấp các phương thức để lặp qua một bộ sưu tập, cho phép di chuyển con trỏ chỉ về phía trước qua bộ sưu tập.

Chỉ có IEnumerable dùng trong vòng lặp foreach. Còn IEnumerator sử dụng while, MoveNext, current khi duyệt. Khi duyệt thì IEnumerator lưu lại trạng thái của phần tử duyệt còn IEbumerable không lưu lại.
https://www.advancesharp.com/blog/1053/ienumerable-and-ienumerator-in-c-with-real-time-example
