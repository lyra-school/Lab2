namespace Q6
{
    class Student
    {
        private string _name;
        private string _studentNumber;
        private List<SubjectResult> _results = new List<SubjectResult>;

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
    }
}
