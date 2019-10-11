using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson7
{
    class Program
    {
        static void Main(string[] args)
        { //Korrutustabel

            /* int userNumber;
             Console.WriteLine("Pleas enter a number: ");

             userNumber = int.Parse(Console.ReadLine());

             for (int i = 1; i <= 10; i++)
             {
                 Console.WriteLine($"{ userNumber} x { i}={ userNumber * i}");
             }*/


            //Leia sõna pikkus,ilma Library functionita.

            /* string userWord;
             Console.WriteLine("Enter any word here: ");
             userWord = Console.ReadLine();

             int counter = 0;

             foreach (char letter in userWord)
             {
                 counter++;
             }
             Console.WriteLine($"Your letter is {counter} letters long");*/


            //Kontrollime, kas kasutaja nime/sõna sees on A-täht

            /*string name;
            Console.WriteLine("Enter your name");
            name = Console.ReadLine();*/

            /* bool letterFound = false;

             foreach(char letter in name)
             {

                 if (letter == 'a')
                 {
                    letterFound = true;    
                 }  
             }


             if (letterFound == true)
             {
                 Console.WriteLine("Letter A found");

             }
             else 
             {
                 Console.WriteLine("Letter A not found");
             }

             string result = letterFound ? "Includes an A" : "Doesn't include an A";
             Console.WriteLine(result);*/

            /*int aTotal = 0;
            string name;
            Console.WriteLine("Enter your name");
            name = Console.ReadLine();

            for(int i = 0; i < name.Length; i++) 
            {
                if(name[i]== 'a')
                {
                    aTotal++;
                }
            }
            Console.WriteLine($"There are {aTotal} \"A\" letters in your name: ");*/


            //Kirjuta sõna nii, et tühikud jääksid vahele: H E L L O

            //foreach'ga
            /* string name;
             Console.WriteLine("Enter your name");
             name = Console.ReadLine();

             /*foreach(char letter in name)
             {
                 Console.Write($"{letter} ");
             }*/

            //for loop'ga

            /*for (int i = 0; i < name.Length; i++)
            {
                if (i == name.Length-1)
                {
                    Console.Write($"{name[i]}#"); //Prindib viimase tähe
                    break;
                }
                Console.Write($"{name[i]}*");
            }*/

            //while loop
            /*int i = 1;
            while (i <= 10) 
            {
                Console.WriteLine(i);
                i++;
            }*/

            string hello = "hello";
            int i = 0;

            while (i < hello.Length)
            {
                Console.Write($"{hello[i]}*");
                i++;
            }



            Console.ReadLine();
        }

    }
}
