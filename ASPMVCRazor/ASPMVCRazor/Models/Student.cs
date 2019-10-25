using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace ASPMVCRazor.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        //thêm thuộc tính tên hiển thị
        //Ngoài file index home kia chưa khai báo thuộc tính
        //À phải có thư viện DataAnnotations mới có thuộc tính
        [Display(Name="Name")]
        public String StudentName { get; set; }
        public int Age { get; set; }

        public string Description { get; set; }

        public bool isNewlyEnrolled { get; set; }

        public string Password { get; set; }

        public DateTime DoB { get; set; }



        public Gender StudentGender { get; set; }
        public enum Gender
        {
            Male,
            Female
        }
    }
}