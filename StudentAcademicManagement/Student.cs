namespace StudentAcademicManagement
{
    public class Student
    {
        public string StudentNumber { get; set; }
        public string Name { get; set; }
        public string Qualification { get; set; }

        public Student(string studentNumber, string name, string qualification)
        {
            StudentNumber = studentNumber;
            Name = name;
            Qualification = qualification;
        }

        public override string ToString()
        {
            return $"{StudentNumber} - {Name} - {Qualification}";
        }
    }
}
