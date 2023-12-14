namespace Курсовой_проект
{
    class Task_List
    {
        private List<Task> tasks = new List<Task>();

        public void Add_Employee(Task new_task)
        {
            tasks.Add(new_task);
        }

        public void Delete_Employee(Task new_task)
        {
            tasks.Remove(new_task);
        }

        public string Show_Task(int i)
        {
            return $"Задача:\n{tasks[i].Name}\nОписание:\n{tasks[i].Description}\nОтветственный:\n{tasks[i].Description}";
        }
    }
}