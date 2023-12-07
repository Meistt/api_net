using Domain.Entities.Subject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.User;

public class User
{
    public string UserId { get; set; }
    public string FirstName { get; set; }
    public int LastName { get; set; }
    public string UserName { get; set; }
    public string UserEmail { get; set; }
    public string Password { get; set; }
    public bool IsActive { get; set; }
    public bool ConfirmedAccount { get; set; }
    public List<Subject.Subject> Subjects { get; set; }
}
