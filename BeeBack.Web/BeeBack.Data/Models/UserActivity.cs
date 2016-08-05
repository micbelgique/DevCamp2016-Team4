﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeeBack.Data.Models
{
    public class UserActivity
    {
        public Guid ID { get; set; }

        public Guid UserID{ get; set; }
        [ForeignKey("UserID")]
        public User User { get; set; }

        public Guid ActivityID { get; set; }
        [ForeignKey("ActivityID")]
        public Activity Activity { get; set; }
    }
}
