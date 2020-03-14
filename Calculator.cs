using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace calculator_app
{
	class Calculator
	{
		
		
		static void Main(string[] args)
		{
			string state = "salah";
			while(state == "salah")
			{
			Console.WriteLine("Menu Calculator : \n");
            		Console.WriteLine("1. Penambahan \n");
            		Console.WriteLine("2. Pengurangan \n");
            		Console.WriteLine("3. Perkalian \n");
            		Console.WriteLine("4. Pembagian \n\n");

            		Console.Write("Pilih Menu [1-4] : ");            
            		string menu = Console.ReadLine();
			Console.Write("\n");
			
				if (menu == "1")
                		{
                    			Console.Write("input nilai a : ");
                    			int a = Int32.Parse(Console.ReadLine());
                    			Console.Write("input nilai b : ");
                    			int b = Int32.Parse(Console.ReadLine());

                   	 		Console.WriteLine("Hasil Penambahan : {0} + {1} = {2}", a, b, Penambahan(a, b));
                    			Console.WriteLine("\n tekan sembarang key untuk keluar");
                    			state = "benar";
                    			Console.ReadKey();
            			}
				else if(menu == "2")
               			{
                    			Console.Write("input nilai a : ");
                    			int a = Int32.Parse(Console.ReadLine());
                    			Console.Write("input nilai b : ");
                    			int b = Int32.Parse(Console.ReadLine());

                    			Console.WriteLine("Hasil Pengurangan: {0} - {1} = {2}", a, b, Pengurangan(a, b));
                    			Console.WriteLine("\n tekan sembarang key untuk keluar");
                    			state = "benar";
                    			Console.ReadKey();
                		}
				else if(menu == "3")
                		{
                    			Console.Write("input nilai a : ");
                    			int a = Int32.Parse(Console.ReadLine());
                    			Console.Write("input nilai b : ");
                    			int b = Int32.Parse(Console.ReadLine());

                    			Console.WriteLine("Hasil Perkalian : {0} * {1} = {2}", a, b, Perkalian(a, b));
                    			Console.WriteLine("\n tekan sembarang key untuk keluar");
                    			state = "benar";
                    			Console.ReadKey();
                		}
				else if(menu == "4")
                		{
                    			Console.Write("input nilai a : ");
                    			float a = float.Parse(Console.ReadLine());
                    			Console.Write("input nilai b : ");
                    			float b = float.Parse(Console.ReadLine());

                    			Console.WriteLine("Hasil Pembagian: {0} / {1} = {2}", a, b, Pembagian(a, b));
                    			Console.WriteLine("\n tekan sembarang key untuk keluar");
                    			state = "benar";
                    			Console.ReadKey();
                		}
				else
                		{
                    			Console.Write("\nINPUT ERROR");
                    			System.Threading.Thread.Sleep(1000);
					Console.Clear();

                		}
				
			}
			
		}
	
		static int Penambahan(int a,int b)
		{
			return a+b;
		}
	
		static int Pengurangan(int a,int b)
		{
			return a-b;
		}
		 static int Perkalian(int a, int b)
        	{
        	    return a * b;
        	}

        	static float Pembagian(float a, float b)
        	{
        	    return a / b;
        	}
		
	}
}
