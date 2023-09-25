namespace Q6
{
    class SubjectResult
    {
        private string _subjectName;
        private double _percentage;
        private string _level;

        public string SubjectName
        {
            get { return _subjectName; }
            set { _subjectName = value; }
        }

        public double Percentage
        {
            get { return _percentage; }
            set { _percentage = value; }
        }
        public string Level
        {
            get { return _level; }
            set { _level = value; }
        }
    }
}
