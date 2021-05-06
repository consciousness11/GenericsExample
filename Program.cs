using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Test<int> intObj = new Test<int>();
            
                   

            intObj.Add(1);
            intObj.Add(2);
            intObj.Add(3);
            intObj.Add(4);
            intObj.Add(5);
          

            for (int i = 0; i < 5; i++) {
                Console.WriteLine(intObj[i]);
            
            }

            Test<string> strObj = new Test<string>();

            strObj.Add("Apple");
            strObj.Add("Ball");
            strObj.Add("Cat");
            strObj.Add("Dog");
            strObj.Add("Elephant");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(strObj[i]);

            }
            Console.ReadKey();
        }

      
    }
}
