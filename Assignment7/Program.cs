using Assignment7.Classes;

namespace Assignment7
{
    internal class Program
    {
        static void Main01(string[] args)
        {

            Patient patient1 = new Patient(1, "Nourhan Farag", "01042047128", "12345");
            Patient patient2 = new Patient(1, "Nourhan Farag", "01042047128", "12345");

            Console.WriteLine(patient1.GetHashCode());
            Console.WriteLine(patient2.GetHashCode());
            Console.WriteLine(patient1.Equals(patient2)); //false different hashcode
            patient1 = patient2;
            Console.WriteLine(patient1.Equals(patient2));

            PatientDto patient01 = new PatientDto(1, "Nourhan Farag", "01042047128");
            PatientDto patient02 = new PatientDto(1, "Nourhan Farag", "01042047128");
            Console.WriteLine(patient01.GetHashCode());
            Console.WriteLine(patient02.GetHashCode());
            Console.WriteLine(patient01.Equals(patient02));
            // true caz value type and same hashcode                                     
            //Q3: The main difference I observed is that a class uses reference-based equality by default,
            // while a record uses value-based equality.
            // In other words, two class objects are considered different even if they have the same data,
            // but two record objects with the same values are considered equal.

            PatientDto result = PatientMapper.PatientModelToDto(patient1);
            Console.WriteLine($"Maped PatientDto is: {result}");
        }
        static void Main02(string[] args)
        {
            AppLogger logger1 = AppLogger.GetLogger();
            AppLogger logger2 = AppLogger.GetLogger();
            AppLogger logger3 = AppLogger.GetLogger();
            AppLogger logger4 = AppLogger.GetLogger();
            Console.WriteLine(logger1.GetHashCode());
            Console.WriteLine(logger2.GetHashCode());
            Console.WriteLine(logger3.GetHashCode());
            Console.WriteLine(logger4.GetHashCode());
            /*
         All four hash codes are the same because GetLogger()
         creates the AppLogger object only on the first call.
         After that, it returns the same instance every time.
         Therefore, logger1, logger2, logger3, and logger4
         all refer to the same object.
        */
        }
        static void Main03(string[] args)
        {
            Patient p1 = new Patient(1, "Nourhan Farag", "01042047128", "12345");
            var p2 = new Patient(1, "Mariam Farag", "01042047128", "12345");
            dynamic p3 = p2;
            Console.WriteLine(p3);
            /*
            Difference between var and dynamic:
            var:
              - The type is determined at compile time.
              - Once the type is determined, it cannot be changed.
            dynamic:
              - The type and member operations are resolved at run time.
              - This gives more flexibility, but errors may appear at run time instead of compile time*/
        }
        static void Main04(string[] args)
        {
            var doctor01 = new { Name = "Sara", Specialty = "Cardiology", ExperienceYears = 8, Salary = 25_000 };
            var doctor02 = new { Name = "Sara", Specialty = "Cardiology", ExperienceYears = 8, Salary = 25_000 };
            Console.WriteLine(doctor01.Name);
            Console.WriteLine(doctor01.Specialty);

            Console.WriteLine(doctor01.GetHashCode());
            Console.WriteLine(doctor02.GetHashCode());

            Console.WriteLine(doctor01.Equals(doctor02));
            Console.WriteLine(doctor01.ToString());

            /*
        Anonymous types use value-based equality, similar to records.
        So doctor01 and doctor02 have the same values, therefore
        Equals() returns True and their hash codes are the same.

        A normal class uses reference-based equality by default,
        so two different objects with the same values are not equal.

        A record uses value-based equality, just like anonymous types.
        */
        }
        static void Main(string[] args)
        {  
            Console.WriteLine("Stethoscope".IsShorterThan(5));
            string text = "Ab";
            text.Repeat(4);
            
        }
    }
}
