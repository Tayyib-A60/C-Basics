namespace C_Basics
{
    public class Course
    {
        public Course(int units, float testScore, float examScore, string name, char grade, string courseCode, int gradePoint)
        {
            _units = units;
            _testScore = testScore;
            _examScore = examScore;
            _name = name;
            _grade = grade;
            _courseCode = courseCode;
            _gradePoint = gradePoint;
        }

        private int _units { get; set; }
        private float _testScore { get; set; }
        private float _examScore { get; set; }
        private string _name { get; set; }
        private char _grade { get; set; }
        private string _courseCode { get; set; }
        private int _gradePoint { get; set; }
        
        public int GetGradePoint()
        {
            return _gradePoint;
        }

        public char GetGrade()
        {
            return _grade;
        }

        private void CalculateGradePoint()
        {
            var score = _testScore + _examScore;

            // 20, 89, 0, 44, 45, 58, 63, 72, 100

            if(score < 45) {
                _gradePoint = 0;
            } else if(score < 50) {
               _gradePoint = 2;
            } else if(score < 60) {
               _gradePoint = 3;
            } else if(score < 70) {
               _gradePoint = 4;
            } else {
               _gradePoint = 5;
            }
        }

    }
}