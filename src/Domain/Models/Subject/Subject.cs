using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Subject;

public class Subject
{
    public string IdSubject { get; set; }
    public string SubjectName { get; set; }
    public int Duration { get; set; }
    public string Schedule { get; set; }
}
