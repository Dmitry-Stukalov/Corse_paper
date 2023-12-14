namespace Курсовой_проект
{
    abstract class Human
    {
        abstract public string Name { get; set; }
        abstract public string Surname { get; set; }
        abstract public string Patronymic { get; set; }
        abstract public int Salary { get; set; }

        public Human(string name, string surname, string patronymic, int salary)
        {
            Name = name;
            Surname = surname;
            Patronymic = patronymic;
            Salary = salary;
        }

        abstract public void Prize(int prize);
    }
}