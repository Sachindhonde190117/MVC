using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC.Models
{
    public class StudentModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string FirstName { get; set; }= string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; }   
    }
}