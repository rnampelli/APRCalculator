﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanProducts {
    public enum ScheduleType {
        Weekly,
        BiWeekly,
        SemiMonthly,
        SemiMonthlyLastDay,
        Monthly,
        MonthlyLastDay,
        FixedDays,
        Manual
    }

    public enum FeesType {
        Regular,
        Discounted,
        Fixed
    }

    public enum InterestType {
        Simple,
        Compound
    }
}
