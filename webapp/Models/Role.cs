using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace webapp.Models
{
    public class Role{
        public int RoleID{get; set;} // primary key
        public string RoleName {get; set;}
    }
}