namespace Albinjose1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Diagnostics.Contracts;
    using System.Resources;


    [Serializable()]
    public partial class CONTACTUS 
    {
        public CONTACTUS()
        {
        }

        [Required(ErrorMessage = "*Please enter name")]
        public string NAME { get; set; }

        [Required(ErrorMessage = "*Please enter email")]
        [EmailAddress(ErrorMessage = "*Please Enter valid Email ID")]
        public string EMAIL { get; set; }

        [Required(ErrorMessage = "*Please enter phone number")]
        public string PHONE { get; set; }

        public string PLACE { get; set; }

        public string MESSAGE { get; set; }

        public IFormFile AttachmentCareer { get; set; }

    }

    [Serializable()]
    public partial class CAREERMOD
    {
        public CAREERMOD()
        {
        }


        public string NAME { get; set; }

        [Required(ErrorMessage = "*Please enter email")]
        [EmailAddress(ErrorMessage = "*Please Enter valid Email ID")]
        public string EMAIL { get; set; }

        [Required(ErrorMessage = "*Please enter phone number")]
        public string PHONE { get; set; }

        public string PLACE { get; set; }

        public string MESSAGE { get; set; }

        [Required(ErrorMessage = "*Please enter last name")]
        public string LASTNAME { get; set; }

        [Required(ErrorMessage = "*Please enter first name")]
        public string FIRSTNAME { get; set; }
        public string LOCATION { get; set; }
        public string POSITION { get; set; }
        public IFormFile AttachmentCareer { get; set; }

    }
}