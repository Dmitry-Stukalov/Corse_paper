namespace Курсовой_проект
{
    class List_Of_Employees
    {
        private List<Employee> employees = new List<Employee>();
        static private int id;


        public int ID { get { return id; } set { id = value; } }


        public void ID_Increment()
        {
            ID++;
        }
        public void Add_Employee(Employee new_employee)
        {
            employees.Add(new_employee);
        }

        public void Delete_Employee(Employee new_employee)
        {
            employees.Remove(new_employee);
        }

        public Employee Search_Employee(int id) => employees.Find(emp => emp.Equals(id));               //Проверить на работоспособность

    }
}