using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace u24989003_INF272_Prac_2.Models
{
    public class PeopleModel
    {
        [Display(Name = "Student Number")]
        public string StudentNum { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Email")]
        public string Email { get; set; }

        [Display(Name = "Info On Each Member")]
        public string myLink { get; set; }
    }
}