using System;
namespace OneEnum
{
    public class Program
    {
        public enum Languages
        {
            Dotnet = 1,
            AWS,
            CSharp,
            MVC,
            Angular,
            DotNetCore,
            Azure
        };

        public enum Months
        {
            January = 1,
            February,
            March,
            April,
            May,
            June,
            July,
            August,
            September,
            October,
            November,
            December
        };
        
        public static void Main(string[] args)
        {
            Console.WriteLine(@"
      ___           ___           ___           ___           ___                       ___     
     /\__\         /\  \         /\  \         /\  \         /\  \                     /\__\    
    /:/  /        /::\  \        \:\  \       /::\  \       /::\  \         ___       /:/ _/_   
   /:/  /        /:/\:\  \        \:\  \     /:/\:\  \     /:/\:\__\       /|  |     /:/ /\  \  
  /:/  /  ___   /:/ /::\  \   _____\:\  \   /:/ /::\  \   /:/ /:/  /      |:|  |    /:/ /::\  \ 
 /:/__/  /\__\ /:/_/:/\:\__\ /::::::::\__\ /:/_/:/\:\__\ /:/_/:/__/___    |:|  |   /:/_/:/\:\__\
 \:\  \ /:/  / \:\/:/  \/__/ \:\~~\~~\/__/ \:\/:/  \/__/ \:\/:::::/  /  __|:|__|   \:\/:/ /:/  /
  \:\  /:/  /   \::/__/       \:\  \        \::/__/       \::/~~/~~~~  /::::\  \    \::/ /:/  / 
   \:\/:/  /     \:\  \        \:\  \        \:\  \        \:\~~\      ~~~~\:\  \    \/_/:/  /  
    \::/  /       \:\__\        \:\__\        \:\__\        \:\__\          \:\__\     /:/  /   
     \/__/         \/__/         \/__/         \/__/         \/__/           \/__/     \/__/    
                                                
                                [ Developer : Blesslin Jerish R ]
                                      [ Stack : c# .net ]
                              ");
            Console.WriteLine("");
            Console.WriteLine("Bonjour Canarys");
            DateTime now = DateTime.Now;
            Console.WriteLine(now.ToString("F"));
            Console.WriteLine("");
            
            int a = (int) Languages.Dotnet;
            int b = (int) Languages.AWS;
            int c = (int) Languages.CSharp;
            int d = (int) Languages.MVC;
            int e = (int) Languages.Angular;
            int f = (int) Languages.DotNetCore;
            int g = (int) Languages.Azure;

            int aa = (int) Months.January;
            int bb = (int) Months.February;
            int cc = (int) Months.March;
            int dd = (int) Months.April;
            int ee = (int) Months.May;
            int ff = (int) Months.June;
            int gg = (int) Months.July;
            int hh = (int) Months.August;
            int ii = (int) Months.September;
            int jj = (int) Months.October;
            int kk = (int) Months.November;
            int ll = (int) Months.December;

            Console.WriteLine("");
            Console.WriteLine("Languages - Enum Indexes");
            Console.WriteLine("x");
            Console.WriteLine("");
            
            Console.WriteLine($"Index of Dotnet : {a}" +
                              $"\nIndex of AWS : {b}" +
                              $"\nIndex of CSharp : {c}" +
                              $"\nIndex of MVC {d} : " +
                              $"\nIndex of Angular : {e}" +
                              $"\nIndex of DotNetCore : {f}" +
                              $"\nIndex of Azure : {g}");

            Console.WriteLine("");
            Console.WriteLine("Foreach Values");
            Console.WriteLine("x");
            Console.WriteLine("");

            
            foreach (string prg in Enum.GetNames(typeof(Languages)))
            {
                Console.WriteLine($"The Programming Language is : {prg}");
            }

            Console.WriteLine("");
            Console.WriteLine("Enum Index & Values");
            Console.WriteLine("x");
            Console.WriteLine("");

            int num = (int)Languages.Dotnet;
            string str = Enum.GetName(typeof(Languages), num);
            Console.WriteLine($"Index : {num}  ||  Value : {str}");
            
            int num1 = (int)Languages.AWS;
            string str1 = Enum.GetName(typeof(Languages), num1);
            Console.WriteLine($"Index : {num1}  ||  Value : {str1}");
            
            int num2 = (int)Languages.CSharp;
            string str2 = Enum.GetName(typeof(Languages), num2);
            Console.WriteLine($"Index : {num2}  ||  Value : {str2}");
            
            int num3 = (int)Languages.MVC;
            string str3 = Enum.GetName(typeof(Languages), num3);
            Console.WriteLine($"Index : {num3}  ||  Value : {str3}");
            
            int num4 = (int)Languages.Angular;
            string str4 = Enum.GetName(typeof(Languages), num4);
            Console.WriteLine($"Index : {num4}  ||  Value : {str4}");
            
            int num5 = (int)Languages.DotNetCore;
            string str5 = Enum.GetName(typeof(Languages), num5);
            Console.WriteLine($"Index : {num5}  ||  Value : {str5}");
            
            int num6 = (int)Languages.Azure;
            string str6 = Enum.GetName(typeof(Languages), num6);
            Console.WriteLine($"Index : {num6}  ||  Value : {str6}");
            
            //Months
            Console.WriteLine("");
            Console.WriteLine("Months - Enum Indexes");
            Console.WriteLine("x");
            Console.WriteLine("");
            
            Console.WriteLine($"Index of January : {aa}" +
                              $"\nIndex of February : {bb}" +
                              $"\nIndex of March : {cc}" +
                              $"\nIndex of April {dd} : " +
                              $"\nIndex of May : {ee}" +
                              $"\nIndex of June : {ff}" +
                              $"\nIndex of July : {gg}" +
                              $"\nIndex of August : {hh}" +
                              $"\nIndex of September : {ii}" +
                              $"\nIndex of October : {jj}" +
                              $"\nIndex of November : {kk}" +
                              $"\nIndex of December : {ll}");

            Console.WriteLine("");
            Console.WriteLine("Foreach Values");
            Console.WriteLine("x");
            Console.WriteLine("");

            
            foreach (string mon in Enum.GetNames(typeof(Months)))
            {
                Console.WriteLine($"The Months is : {mon}");
            }

            Console.WriteLine("");
            Console.WriteLine("Enum Index & Values");
            Console.WriteLine("x");
            Console.WriteLine("");

            int numm = (int)Months.January;
            string strr = Enum.GetName(typeof(Months), numm);
            Console.WriteLine($"Index : {numm}   ||  Value : {strr}");
            
            int numm1 = (int)Months.February;
            string strr1 = Enum.GetName(typeof(Months), numm1);
            Console.WriteLine($"Index : {numm1}   ||  Value : {strr1}");
            
            int numm2 = (int)Months.March;
            string strr2 = Enum.GetName(typeof(Months), numm2);
            Console.WriteLine($"Index : {numm2}   ||  Value : {strr2}");
             
            int numm3 = (int)Months.April;
            string strr3 = Enum.GetName(typeof(Months), numm3);
            Console.WriteLine($"Index : {numm3}   ||  Value : {strr3}");
            
            int numm4 = (int)Months.May;
            string strr4 = Enum.GetName(typeof(Months), numm4);
            Console.WriteLine($"Index : {numm4}   ||  Value : {strr4}");
            
            int numm5 = (int)Months.June;
            string strr5 = Enum.GetName(typeof(Months), numm5);
            Console.WriteLine($"Index : {numm5}   ||  Value : {strr5}");
            
            int numm6 = (int)Months.July;
            string strr6 = Enum.GetName(typeof(Months), numm6);
            Console.WriteLine($"Index : {numm6}   ||  Value : {strr6}");
            
            int numm7 = (int)Months.August;
            string strr7 = Enum.GetName(typeof(Months), numm7);
            Console.WriteLine($"Index : {numm7}   ||  Value : {strr7}");
            
            int numm8 = (int)Months.September;
            string strr8 = Enum.GetName(typeof(Months), numm8);
            Console.WriteLine($"Index : {numm8}   ||  Value : {strr8}");
            
            int numm9 = (int)Months.October;
            string strr9 = Enum.GetName(typeof(Months), numm9);
            Console.WriteLine($"Index : {numm9}  ||  Value : {strr9}");
            
            int numm10 = (int)Months.November;
            string strr10 = Enum.GetName(typeof(Months), numm10);
            Console.WriteLine($"Index : {numm10}  ||  Value : {strr10}");
            
            int numm11 = (int)Months.December;
            string strr11 = Enum.GetName(typeof(Months), numm11);
            Console.WriteLine($"Index : {numm11}  ||  Value : {strr11}");
            
            // Don't Delete
            Console.WriteLine("");
            Console.ReadLine();
        }
    }
}