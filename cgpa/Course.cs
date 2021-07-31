namespace C_Basics
{
    public class Course
    {
        public Course(int units, float testScore, float examScore, string name, string courseCode)
        {
            _units = units;
            _testScore = testScore;
            _examScore = examScore;
            _name = name;
            _courseCode = courseCode;

            CalculateGradeParameters();
        }

        private int _units { get; set; }
        private float _testScore { get; set; }
        private float _examScore { get; set; }
        private string _name { get; set; }
        private char _grade { get; set; }
        private string _courseCode { get; set; }
        private int _gradePoint { get; set; }
        private int _gradePointAverage { get; set; }
        
        public int GetGradePoint()
        {
            return _gradePoint;
        }

        public char GetGrade()
        {
            return _grade;
        }

        public int GetCourseUnits()
        {
            return _units;
        }

        public int GetGradePointAverage()
        {
            return _gradePointAverage;
        }

        private void CalculateGradeParameters()
        {
            var score = _testScore + _examScore;

            // 20, 89, 0, 44, 45, 58, 63, 72, 100

            if(score < 45) {
                _gradePoint = 0;
                _gradePointAverage = _gradePoint * _units;
                _grade = 'F';
            } else if(score < 50) {
               _gradePoint = 2;
               _gradePointAverage = _gradePoint * _units;
               _grade = 'D';
            } else if(score < 60) {
               _gradePoint = 3;
               _gradePointAverage = _gradePoint * _units;
               _grade = 'C';
            } else if(score < 70) {
               _gradePoint = 4;
               _gradePointAverage = _gradePoint * _units;
               _grade = 'B';
            } else {
               _gradePoint = 5;
               _gradePointAverage = _gradePoint * _units;
               _grade = 'A';
            }
        }

    }
}