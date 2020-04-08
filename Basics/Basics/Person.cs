﻿using System;

namespace Basics
{
    public class Person
        {

        public DateTime Birthday { get; set; }
        public int Age {
            get {
                var timeSpan = DateTime.Today - Birthday;
                var years = timeSpan.Days / 365;
                return years;
             }
        }
}
}
