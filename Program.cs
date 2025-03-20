using FirstProject;
using Assignment;
class MainClass
{
    static int Main(string[] args)
    {
        //Assignment1 asg1 = new Assignment1();

        //asg1.Ex7();
        //Console.WriteLine("Hello World");
        //Console.ReadLine();

        //take a string input , number,boolean,datetime,double,decimal
        //for boolean use if (a==true) or false 
        // for double 
        //string name = Console.ReadLine();
        //Console.WriteLine(name);

        //double num =Convert.ToDouble(Console.ReadLine());
        //Console.WriteLine(num);

        //Console.Write("Current Date Time : ");
        //DateTime date = DateTime.Now;
        //Console.WriteLine(date);

        //DateTime d = Convert.ToDateTime(Console.ReadLine());
        //Console.WriteLine(d);
        //decimal num = Convert.ToDecimal(Console.ReadLine());
        //Console.WriteLine(num);

        //Decimal num1 = Convert.ToDecimal(Console.ReadLine());
        //Console.WriteLine(num1);

        //int n = Convert.ToInt32(Console.ReadLine());

        //int[] number = { 1, 2, 3};
        //Console.WriteLine(number.Length);
        //for(int i = 0; i < number.Length; i++)
        //{
        //    Console.WriteLine(number[i]);

        //}
        //string name = Console.ReadLine();
        //int wordCount = name.Split(' ',StringSplitOptions.RemoveEmptyEntries).Length;
        //Console.WriteLine(name.Contains("Harish"));
        //Console.WriteLine(wordCount);

        File.AppendAllText("D:\\dotnet\\FirstProject\\Assignments\\Assignment-2.txt", "Hello");
        
        String list = File.ReadAllText("D:\\dotnet\\FirstProject\\Assignments\\Assignment-2.txt");
        //for(int i=0;i<list.Length;i++)
        //{
            Console.WriteLine(list);
        //}
        Console.ReadLine();


        return 0;
    }
}
