using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.SubjectGrade;

public class SubjectGrade
{
    public int FirstExam { get; set; }
    public int LastExam { get; set;}
    public float SubjectAverage { get; set; }
}
