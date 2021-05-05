﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace OrderOverview.Entities
{
    public class Employee
    {
        [DisplayName("Name"), Required(ErrorMessage = "{0} ist erforderlich"), StringLength(60)]
        public string Name { get; set; }

        [DisplayName("Adress")]
        public string Adress { get; set; }

        [DisplayName("Phone"),StringLength(60)]
        public string Phone { get; set; }

        [DisplayName("E-mail"),StringLength(40)]
        public string Email { get; set; }


        public string Status { get; set; }
    }
}
