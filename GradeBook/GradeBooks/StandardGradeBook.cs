
namespace GradeBook.GradeBooks
{
    public class StandardGradeBook : BaseGradeBook
    {
        public StandardGradeBook(string name, bool isWeighted) : base(name, isWeighted)
        {
            this.Name = name;
            this.Type = Enums.GradeBookType.Standard;
            this.IsWeighted = isWeighted;
        }
    }
}
