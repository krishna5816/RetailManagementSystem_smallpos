﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetailManagementSystem.Models
{
   partial class customer
    {
        public override string ToString()
        {
            return name + "(" + phone + ")";
        }
    }
}
