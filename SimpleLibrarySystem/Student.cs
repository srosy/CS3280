namespace SimpleLibrarySystem
{
    public class Student : Person
    {
        public string StudentIdString { get; }

        public Student(string fName, string lName, long ssn, int wNum) : base(fName, lName, ssn, wNum)
        {
            StudentIdString = $"S{W_Number}";
        }
    }
}
