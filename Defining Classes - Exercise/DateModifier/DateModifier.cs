﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DateModifier
{
    public class DateModifier
    {
        public int GetDaysDifference(string startDateAsString, string endDateAsString)
        {
            //year month day
            DateTime startDate = DateTime.Parse(startDateAsString);
            DateTime endDate = DateTime.Parse(endDateAsString);

            int totalDays = (int)Math.Abs((startDate - endDate).TotalDays);

            return totalDays;
        }
    }
}
