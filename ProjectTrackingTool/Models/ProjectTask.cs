﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace ProjectTrackingTool.Models
{
    public class ProjectTask
    {
        [Key]
        public int Task_Id { get; set; }

        public string Task_Title { get; set; }

        public DateTime Start_Date { get; set; }

        public DateTime Target_End_Date { get; set; }

        public DateTime End_Date { get; set; }

        public APriority Priority { get; set; }

        public AStatus Status { get; set; }

        public string Task_Desc { get; set; }


    }
}
