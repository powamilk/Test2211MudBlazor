﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestBUS.ViewModel.Email
{
    public class EmailCreateVM
    {
        public int UserId { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public int Priority { get; set; } = 2;
        public int AttachmentCount { get; set; } = 0;
        public string Status { get; set; } = "draft"; 
    }
}
