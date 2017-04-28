using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Loop that prints 1-255
            // for (int num = 1; num < 256; num++)
            // {
                // Console.WriteLine(num);
            // }
            //  for (int num = 1; num < 10; num++)
            // {
                // if(!(num % 15 == 0))
                // {
                    // if(num % 3 == 0 || num % 5 == 0)
                    // {
                        // Console.WriteLine(num);
                    // }
                // }
                
            // }

             //FizzBuzz Modification
            // for (int num = 1; num < 101; num++)
            // {
                // if(num % 3 == 0 && num % 5 == 0)
                // {
                    // Console.WriteLine("FizzBuzz");
                // }
                // else if (num % 3 == 0)
                // {
                    // Console.WriteLine("Fizz");
                // }
                // else if (num % 5 == 0)
                // {
                //    Console.WriteLine("Buzz");
                // }
            // }
            //  int three = 3;
            // int five = 5;
            // for (int num = 1; num < 10; num++)
            // {
            //     three--;
            //     five--;
            //     if (three == 0 && five == 0)
            //     {
            //         Console.WriteLine("FizzBuzz");
            //         three = 3;
            //         five = 5;
            //     }
            //     else if (three == 0)
            //     {
            //         Console.WriteLine("Fizz");
            //         three = 3;
            //     }
            //     else if (five == 0) {
            //         Console.WriteLine("Buzz");
            //         five = 5;
            //     }
            // }

             //Optional Generate 10 random values 1-100 and output Fizz or Buzz
            Random rand = new Random();
            for (int num = 0; num <= 10; num++){
                int val = rand.Next(1, 100);

                string output = "For attempt " + num + " the value is " + val + " and the word is ";

                if(val % 3 == 0 && val % 5 == 0)
                {
                    output += "FizzBuzz";
                }
                else if (val % 3 == 0)
                {
                    output += "Fizz";
                }
                else if (val % 5 == 0)
                {
                   output += "Buzz";
                } else {
                    output += "Neither";
                }

                Console.WriteLine(output);
            }
        }
    }
}


            // Console.WriteLine("Hello World!");
            // for (int j = 1; j <= 5; j++)
            // {
            //    Console.WriteLine(j);
            // }
            // int fizz = 100;
            
            // if (fizz % 3 == 0) 
            // {
            //     Console.WriteLine("buzz");
            // }
            // else if 
            // (fizz % 5 == 0)
            // {
            //     Console.WriteLine("f");
            // }
            // else
            // {
            //  Console.WriteLine("fizz");
            // }
            

        //  int i = 1;
        //  while (i < 6)
            // {
            // Console.WriteLine(i);
            //  i = i + 1;
            // }
            // Random rand = new Random();
            // for(int val = 0; val < 10; val++)
// {
    //Prints the next random value between 2 and 8
    // Console.WriteLine(rand.Next(2,8));
// }


//         }
//     }
// }
