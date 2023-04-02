using System;
using System.Linq;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {
        public RankedGradeBook(string name) : base(name)
        {
            this.Name = name;
            this.Type = Enums.GradeBookType.Ranked;
        }

        public override char GetLetterGrade(double averageGrade)
        {
            if (Students.Count < 5)
            {
                throw new InvalidOperationException("Minimal number of students is 5.");
            }

            int studentsOverAverage = Students.Count(student => student.AverageGrade > averageGrade);
            double studentsPosition = (double)studentsOverAverage / Students.Count;

            if (studentsPosition < 0.2) 
            {
                return 'A';

            } else if (studentsPosition < 0.4)
            {
                return 'B';

            } else if (studentsPosition < 0.6)
            {
                return 'C';

            } else if (studentsPosition < 0.8)
            {
                return 'D';

            } else
            {
                return 'F';
            }
                

        }

        public override void CalculateStatistics()
        {
            if (Students.Count < 5)
            {
                Console.WriteLine("Ranked grading requires at least 5 students.");
            } else 
            {
                base.CalculateStatistics();
            }
                
        }

        public override void CalculateStudentStatistics(string name)
        {
            if (Students.Count < 5)
            {
                Console.WriteLine("Ranked grading requires at least 5 students.");
            } else
            {
                base.CalculateStudentStatistics(name);
            }
                
        }
    }
}
