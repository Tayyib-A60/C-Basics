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

        private void ComputeGrade()
        {
            var score = _testScore + _examScore;

            if(score < 40) {
                _grade = 'F';
            } else if(score > 40 & score < 45){
               _grade = 'E';
            } else if(score >= 45 & score < 50) {
               _grade = 'D';
            } else if(score >= 50 & score < 60) {
               _grade = 'C';
            } else if(score >= 60 & score < 70){
               _grade = 'B';
            } else if(score >= 60){
                _grade = 'A';
            }

        }

    }
}