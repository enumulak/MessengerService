﻿using Models.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Models.Messengers
{
    public class Member : HIDC
    {
        public int PoolID { get; set; }
        [IgnoreDataMember]
        public Pool Pool { get; set; }
        [Required]
        public string AuthID { get; set; }
    }
}
