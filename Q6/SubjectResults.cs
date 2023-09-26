namespace Q6
{
    class SubjectResult
    {
        // attributes
        private string _subjectName;
        private double _percentage;
        private string _level;

        // getter & setter methods
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
            set {
                switch (value.ToLower())
                {
                    case "higher":
                    case "ordinary":
                        _level = value.ToLower();
                        break;
                    default:
                        _level = "unknown";
                        break;
                }
            }
        }

        // constructor
        public SubjectResult(string subjectName, double percentage, string level)
        {
            _subjectName = subjectName;
            _percentage = percentage;
            switch(level.ToLower())
            {
                case "higher":
                case "ordinary":
                    _level = level.ToLower();
                    break;
                default:
                    _level = "unknown";
                    break;
            }

        }
    }
}
