﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs;

public class UserDTO
{
    public string UserName { get; set; }
    public string Email { get; set; }
    public bool IsActived { get; set; }
}
