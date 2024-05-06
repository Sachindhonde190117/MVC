using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml.Linq;

namespace MVC.Models
{
    public class StudentModel
    {
        
        [DataType( DataType.Text)]
        public int Id { get; set; }

        [DataType(DataType.Text)]
        
        [Display(Name="Student Full Name")]
        [Required(ErrorMessage = "Please Enter Name")]
        public string Name { get; set; }

        [DataType(DataType.Text)]
        [StringLength(500,ErrorMessage ="Please enter less than 500 char")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Please Enter FirstName")]
        public string FirstName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please Enter LastName")]
        public string LastName { get; set; } = string.Empty;

        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Please Enter Email")]
        public string Email { get; set; }   

        public string Hobbie { get; set; }
        public List<string> Hobbies { get; set; }
        public SubjectModel subject { get; set; }

        [Range(18, 100, ErrorMessage ="Please enter Age above 18 & below 100")]
        public int Age { get; set; }    
    }

    public class SubjectModel
    {
        string Name { get; set; }
        public int Id { get; set; }
    }
}