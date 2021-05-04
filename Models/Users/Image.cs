using Models.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Models.Users
{
    public class Image : HIDC
    {
        [Required]
        public string File { get; set; }
    }
}
