using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{
    public class StandardGradeBook : BaseGradeBook
    {
        //constructor
        public StandardGradeBook(string name, bool IsWeighted) : base(name, IsWeighted)
        {
            Type = Enums.GradeBookType.Standard;
        }
    }
}
