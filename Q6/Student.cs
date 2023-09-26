namespace Q6
{
    class Student
    {
        // attributes
        private string _name;
        private string _studentNumber;
        private List<SubjectResult> _results = new List<SubjectResult>();

        // getter and setter methods
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string StudentNumber
        {
            get { return _studentNumber; }
            set { _studentNumber = value; }
        }
        public List<SubjectResult> Results
        {
            get { return _results; }
        }
        // constructor (only for name and student number)
        public Student(string name, string studentNumber)
        {
            _name = name;
            _studentNumber = studentNumber;
        }

        // method to add results to the list
        public void AddResult(SubjectResult result)
        {
            _results.Add(result);
        }
    }
}
