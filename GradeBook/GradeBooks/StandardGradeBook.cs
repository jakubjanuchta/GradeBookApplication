
namespace GradeBook.GradeBooks
{
    internal class StandardGradeBook : BaseGradeBook
    {
        public StandardGradeBook(string name) : base(name)
        {
            this.Name = name;
            this.Type = Enums.GradeBookType.Standard;
        }
    }
}
