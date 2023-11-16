

//using Generic;

//public class Program
//{
//    public static void Main()
//    {
//        MathUtility mathUtility = new MathUtility();
//        var a =mathUtility.Addnumber(10,20);
//        var ab =mathUtility.Addnumber(10.5,20);
//        var abc =mathUtility.Addnumber("hi ","pranto");
//        Console.WriteLine("ADD Int:"+a);
//        Console.WriteLine("ADD double:"+ab);
//        Console.WriteLine("ADD string:"+abc);
//    }
//}

//public class CompariosnUtility
//{
//    public bool Areaeqal<T>(T value1,T value2)
//    {
//        return value1.Equals(value2);
//    }
//}

//public class Program
//{
//    public static void Main()
//    {
//        CompariosnUtility compariosnUtility = new CompariosnUtility();
//        bool comparison = compariosnUtility.Areaeqal(5,5);
//        bool comparison1 = compariosnUtility.Areaeqal(10.5,10.5);
//        bool comparison2 = compariosnUtility.Areaeqal("Pranto","Pranto");

//        if(comparison == true && comparison1 == true && comparison2 == true)
//        {
//            Console.WriteLine(comparison);
//            Console.WriteLine(comparison1);
//            Console.WriteLine(comparison2);
//        }
//        else { Console.WriteLine("one is false"); }
//    }
//}


public class Program
{
    public static void Main()
    {
        int i = Convert.ToInt32(Console.ReadLine());
        int sum = 0;
            while (i > 0)
            {
                sum += i % 10;
                i /= 10;
            }
            Console.WriteLine(sum); 
    }
}