﻿using Models.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Models.Users
{
    public class Contact : HIDC
    {
        public int UserID { get; set; }
        [IgnoreDataMember]
        public User User { get; set; }
        [Required]
        public string Link { get; set; }
        [Required]
        public string Type { get; set; }
    }
}
