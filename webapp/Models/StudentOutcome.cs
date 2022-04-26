using System;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webapp.Models
{
    public class StudentOutcome{
        public int StudentOutcomeId{ get; set; }
        public string Description{ get; set; }
    }
}