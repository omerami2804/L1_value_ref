using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstEmployee;
            string secondEmployee;

            firstEmployee = "Danny Shovevany";
            secondEmployee = "Yonatan Hakatan";

            //string interpolation = $
            //Escape characters - \[enter letter here] - gives you a specific command. for example \n means new line 
            Console.WriteLine($"inside Main Method\n--------\n{firstEmployee}\n{secondEmployee}\n\n");

            //ChangeName(firstEmployee, secondEmployee);

            ChangeName(ref firstEmployee, ref secondEmployee);

            //ChangeName(out string firstEmployee, out string secondEmployee);

            Console.WriteLine($"inside Main Method\n--------\n{firstEmployee}\n{secondEmployee}\n\n");
        }
        //Passing by value
       /* public static void ChangeName(string fEmp, string sEmp)
        {
            fEmp = "Geveret Pilpelet";
            sEmp = "Moosh haShor";

            Console.WriteLine($"Outside Main Method\n--------\n{fEmp}\n{sEmp}\n\n"); 
            */

          /*  public static void ChangeName(ref string fEmp,ref string sEmp)
            { //reference takes "address" from existing "ref string"
                fEmp = "Geveret Pilpelet";
                sEmp = "Moosh haShor";

                Console.WriteLine($"Outside Main Method\n--------\n{fEmp}\n{sEmp}\n\n");
                */

            public static void ChangeName( ref string fEmp, ref string sEmp)
            { //reference takes "address" from existing "ref string"
                fEmp = "Geveret Pilpelet";
                sEmp = "Moosh haShor";

                Console.WriteLine($"Outside Main Method\n--------\n{fEmp}\n{sEmp}\n\n");
            }
    }
}
