using GeneratePdf.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeneratePdf.Utility
{
    public static partial class DataStorage
    {
        public static List<Employee> GetAllEmployess()
        {
            return new List<Employee>
            {
                new Employee { Name="Mike", LastName="Turner", Age=35, Gender="Male"},
                new Employee { Name="Sonja", LastName="Markus", Age=22, Gender="Female"},
                new Employee { Name="Luck", LastName="Martins", Age=40, Gender="Male"},
                new Employee { Name="Sofia", LastName="Packner", Age=30, Gender="Female"},
                new Employee { Name="John", LastName="Doe", Age=45, Gender="Male"}
            };
        }
    }

}


