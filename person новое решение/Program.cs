using person_новое_решение;

namespace Table
{
    public class Program
    {
        
     static Employe cslprofile = new Employe();
     static void Main()
     {
            Student clsstudent = new Student();
            Console.WriteLine("---STUDENT---");
            Console.WriteLine($"ID:{clsstudent.id}\n" +
                              $"Name:{clsstudent.name} {clsstudent.lastname}\n" +
                              $"BirthDate: {clsstudent.birthDate}\n" +
                              $"Age:{DateTime.Now.Year - clsstudent.birthDate.Year}\n" +
                              $"Email:{clsstudent.Email}\n" +
                              $"Group:{clsstudent.group}\n" +
                              $"Gender:{(clsstudent.Gender == true ? "Man" : "Girl")}\n" +
                              $"PhoneNumber:{clsstudent.phone_numb}");

            Console.WriteLine("---EMPLOY---");
            Console.WriteLine($"ID:{clsstudent.id}\n" +
                                  $"Name:{clsstudent.name} {clsstudent.lastname}\n" +
                                  $"BirthDate: {clsstudent.birthDate}\n" +
                                  $"Age:{DateTime.Now.Year - clsstudent.birthDate.Year}\n" +
                                  $"Email:{clsstudent.Email}\n" +
                                  $"Group:{clsstudent.group}\n" +
                                  $"Gender:{(clsstudent.Gender == true ? "Man" : "Girl")}\n" +
                                  $"PhoneNumber:{clsstudent.phone_numb}");






      }
    }
 }