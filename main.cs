/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {
    Console.Write("โปรแกรมหาพื้นที่วงกลมและเลขาคณิต\n===================\n1.หาพื้นที่วงกลม\n2.หาพื้นที่รูปห้าเหลี่ยม\n3.หาพื้นที่รูปแปดเหลี่ยม\n4.หาพื้นที่รูปสี่เหลี่ยมผืนผ้า\n5.หาพื้นที่รูปสี่เหลี่ยมจตุรัส\n6.หาพื้นที่สี่เหลี่ยมด้านขนาน\n===================\nกรุณากรอกเลขด้านบนที่ท่านต้องการ : ");
    int inputint;
    double output;
    string input;
    string i = Console.ReadLine();
    switch(i)
    // วงกลมอ้างอิงสูตร https://www.kidlek.com/Circle-Calculator.php
    // เลขาคณิตอ้างอิงสูตรตามเว็ป https://www.athometh.com/math/shape/
    {
        case "1":
            Console.WriteLine("===================\nโปรแกรมหาพื้นที่วงกลม");
            Console.Write("กรอกรัศมีวงกลมที่ต้องการคำนวน : ");
            input = Console.ReadLine();
            int.TryParse(input, out inputint);
	        double pi = 3.14; // สามารถใช้ Math.PI เพื่อต้องการความแม่นยำได้
	        output = pi*(inputint*inputint);
	        Console.WriteLine("พื้นที่วงกลมของรัศมีของท่านคือ : "+output);
            break;
        case "2":
            Console.WriteLine("===================\nโปรแกรมหาพื้นที่รูปห้าเหลี่ยม");
            Console.Write("กรอกด้านของรูปห้าเหลี่ยมของท่าน : ");
            input = Console.ReadLine();
            int.TryParse(input, out inputint);
	        output = 1.72*(inputint*inputint);
	        Console.WriteLine("พื้นที่รูปห้าเหลี่ยมของท่านคือ : "+output);
            break;
        case "3":
            Console.WriteLine("===================\nโปรแกรมหาพื้นที่รูปแปดเหลี่ยม");
            Console.Write("กรอกด้านของรูปแปดเหลี่ยมของท่าน : ");
            input = Console.ReadLine();
            int.TryParse(input, out inputint);
	        output = 4.828*(inputint*inputint);
	        Console.WriteLine("พื้นที่รูปแปดเหลี่ยมของท่านคือ : "+output);
            break;
        case "4":
            Console.WriteLine("===================\nโปรแกรมหาพื้นที่รูปสี่เหลี่ยมผืนผ้า");
            Console.Write("กรอกด้านของรูปสี่เหลี่ยมผืนผ้าของท่าน : ");
            input = Console.ReadLine();
            int.TryParse(input, out inputint);
	        output = inputint*inputint;
	        Console.WriteLine("พื้นที่รูปสี่เหลี่ยมผืนผ้าของท่านคือ : "+output);
            break;
        case "5":
            Console.WriteLine("===================\nโปรแกรมหาพื้นที่รูปสี่เหลี่ยมจตุรัส");
            int inputint1, inputint2;
            Console.Write("กรอกความกว้างของสี่เหลี่ยมจตุรัสของท่าน : ");
            string input1 = Console.ReadLine();
            int.TryParse(input1, out inputint1);
            Console.Write("กรอกความยาวสี่เหลี่ยมจตุรัสของท่าน : ");
            string input2 = Console.ReadLine();
            int.TryParse(input2, out inputint2);
	        output = inputint1*inputint2;
	        Console.WriteLine("พื้นที่รูปสี่เหลี่ยมจตุรัสของท่านคือ : "+output);
            break;
        case "6":
            Console.WriteLine("===================\nโปรแกรมหาพื้นที่สี่เหลี่ยมด้านขนาน");
            int inputint11, inputint22;
            Console.Write("กรอกฐานของพื้นที่สี่เหลี่ยมด้านขนานของท่าน : ");
            string input11 = Console.ReadLine();
            int.TryParse(input11, out inputint11);
            Console.Write("กรอกความสูงของพื้นที่สี่เหลี่ยมด้านขนานของท่าน :");
            string input22 = Console.ReadLine();
            int.TryParse(input22, out inputint22);
	        output = inputint11*inputint22;
	        Console.WriteLine("พื้นที่สี่เหลี่ยมด้านขนานของท่านคือ : "+output);
            break;
        default:
            Console.WriteLine("===================\nกรุณากรอกแค่ 1-6 นะจั้ฟ");
            break;
    }
	Console.WriteLine("===================\nจบการทำงานของโปรแกรม");
  }
}