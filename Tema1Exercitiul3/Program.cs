using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
namespace Lab1Ex3
/*Ex3
Scrieti un program care va afisa ultima cifra a unui numar intreg citit de la
tastaura
 */
{
    public class Program 
    { public static void Main(string[] args) 
        { 
         int a;
         int ultimaCifra;
         Console.WriteLine("Introduceti un numar"); 
         a = Convert.ToInt32(Console.ReadLine()); 
         ultimaCifra = a % 10; 
        Console.WriteLine("Ultima cifra a numarului introdus este: " + ultimaCifra);
        } 
    } 
}