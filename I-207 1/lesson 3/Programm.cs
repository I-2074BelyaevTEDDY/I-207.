using System;
using System.Collections.Generic;
using System.Text;

namespace lesson3
{
    internal class Programm
    {
        static lesson3.person clsperson = new lesson3.  person();
        static void Main()
        {
            Console.WriteLine($"Id: {clsperson.Id}\n"+
                $"FullName: {clsperson.name} {clsperson.surName} {clsperson.familyName}\n"+
                $"BirthDate: {clsperson.birthDate}\n"+
                $"Age: {DateTime.Now.Year - clsperson.birthDate.Year}\n"+
                $"Gender: {(clsperson.Gender==true?"Man":"Girl")}");
           
        }
    }
}
