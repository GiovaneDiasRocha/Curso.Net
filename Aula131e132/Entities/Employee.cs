using System.Collections.Generic;
using System.Text;

namespace Aula131e132.Entities
{
    public class Employee
    {
        public string Name { get; set; }
        public int Hours { get; set; }
        public double ValuePerHour { get; set; }
        public List <Employee> ListEmployes { get; set; } = new List<Employee>();
        public OutsourcedEmployee OutsourcedEmployee { get; set; }

        public Employee() { }
        public Employee(string name, int hours, double valuePerHour)
        {
            Name = name;
            Hours = hours;
            ValuePerHour = valuePerHour;
        }

        public virtual double Payment()
        {
            return Hours * ValuePerHour;
        }

        public void addEmployeeInList (Employee employee) {
            ListEmployes.Add(employee);
        }

        public override string ToString()
        {   
            StringBuilder sb = new StringBuilder();

            foreach (Employee emp in ListEmployes)
            {
                sb.Append(emp.Name);
                sb.Append(" - $ ");
                sb.AppendLine(emp.Payment().ToString());
            }
            
            return sb.ToString();
        }
    }
}