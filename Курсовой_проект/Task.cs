namespace Курсовой_проект
{
    class Task
    {
        private string _name;
        private string _description;
        private string? _responsible;

        public string Name 
        { 
            get { return _name; }
            set
            {
                if (!string.IsNullOrEmpty(value)) _name = value;
                else throw new ArgumentOutOfRangeException("Task _name cannot be empty");
            }
        }
        public string Description
        {
            get { return _description; }
            set
            {
                if (!string.IsNullOrEmpty(value)) _description = value;
                else throw new ArgumentOutOfRangeException("Task _description cannot be empty");
            }
        }
        public string Responsible
        {
            get { return _responsible; }
            set
            {
                if (!string.IsNullOrEmpty(value)) _responsible = value;
            }
        }


    }
}