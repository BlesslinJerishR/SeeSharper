using System;
// Console App Name :  OneEnum 
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

            Console.WriteLine("");
            Console.WriteLine("Enum Indexes");
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
            
            // Don't Delete
            Console.WriteLine("");
            Console.ReadLine();
        }
    }
}