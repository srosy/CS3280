namespace SimpleLibrarySystem
{
    public class Instructor : Person
    {
        public string InstructorIdString { get; }

        public Instructor(string fName, string lName, long ssn, int wNum) : base(fName, lName, ssn, wNum)
        {
            InstructorIdString = $"E{W_Number}";
        }
    }
}
