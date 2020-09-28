using System;
using System.Collections;

namespace ArrayList_them_sua_xoa
{
    class Program
    {
        static void Main(string[] args)
        {
    // Student student=new Student();

 ArrayList studentList = new ArrayList();
//Thêm các phần tử vào ArrayList.

studentList.Add(new Student { Name = "TuanOkay", Age = 20 });
studentList.Add(new Student { Name = "KhanhSky", Age = 21 });
studentList.Add(new Student { Name = "TSike", Age = 19 });
//Sử dụng đoạn code sau để kiểm tra kết quả.

foreach (Student student in studentList)
    Console.WriteLine(student.Name + " " + student.Age);
//Thay đổi phần tử ở vị trí số 0 trong ArrayList.

studentList[0] = new Student { Name = "t1", Age = 21 };
//Sử dụng đoạn code sau để kiểm tra kết quả.

foreach (Student student in studentList)
    Console.WriteLine(student.Name + " " + student.Age);  
    studentList.RemoveAt(2);
//Sử dụng đoạn code sau để kiểm tra kết quả.

foreach (Student student in studentList)
    Console.WriteLine(student.Name + " " + student.Age);  
        }
    }
}
