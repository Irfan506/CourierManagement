﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierManagement.Common.Utilities
{
    public class DateTimeUtility : IDateTimeUtility
    {
        public DateTime Now
        {
            get
            {
                return DateTime.Now;
            }
        }
    }
}
