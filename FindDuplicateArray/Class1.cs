using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindDuplicateArray
{
    class Class1

    {
        static void Main(string[] args)
        {
            string[] arr = { "java","C","C" ,"C#","Python" };
            
            Boolean flag = false;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        Console.WriteLine("Duplicate value is " + arr[i]);
                        
                        flag = true;
                      
                   
                    }
                }
               
            }
            if (flag == false)
            {
                Console.WriteLine("Duplicate value is not found");
            }

        }

        

        
    }
}
