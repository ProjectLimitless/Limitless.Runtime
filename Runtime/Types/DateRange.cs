/** 
* This file is part of Project Limitless.
* Copyright © 2017 Donovan Solms.
* Project Limitless
* https://www.projectlimitless.io
* 
* Project Limitless is free software: you can redistribute it and/or modify
* it under the terms of the Apache License Version 2.0.
* 
* You should have received a copy of the Apache License Version 2.0 with
* Project Limitless. If not, see http://www.apache.org/licenses/LICENSE-2.0.
*/

using System;

namespace Limitless.Runtime.Types
{
    /// <summary>
    /// Holds a range with a start and end date. 
    /// If only one date is given, start and end will return the same value.
    /// If both are null, returns Now.
    /// </summary>
    public class DateRange
    {
        private DateTime _start;
        private DateTime _end;

        /// <summary>
        /// Gets and sets the start date.
        /// If only one date is given, start and end will return the same value.
        /// If both are null, returns Now.
        /// </summary>
        public DateTime Start
        {
            get
            {
                return _start;
            }
            set
            {
                if (value == null)
                {
                    throw new NullReferenceException("You cannot set a null start date in a DateRange");
                }
                _start = value;
            }
        }

        /// <summary>
        /// Gets and sets the end date.
        /// If only one date is given, start and end will return the same value.
        /// If both are null, returns Now.
        /// </summary>
        public DateTime End
        {
            get
            {
                return _end == null ? _start : _end;
            }
            set
            {
                if (value == null)
                {
                    throw new NullReferenceException("You cannot set a null end date in a DateRange");
                }
                _end = value;
            }
        }

        /// <summary>
        /// Creates a new instance of <see cref="DateRange"/> 
        /// setting the Start data to DateTime.Now.
        /// </summary>
        public DateRange()
        {
            Start = DateTime.Now;
        }

        /// <summary>
        /// Creates a new instance of <see cref="DateRange"/> 
        /// setting the start date.
        /// </summary>
        /// <param name="start">The start date</param>
        public DateRange(DateTime start)
        {
            Start = start;
        }

        /// <summary>
        /// Creates a new instance of <see cref="DateRange"/> 
        /// setting the start and end dates.
        /// </summary>
        /// <param name="start">The start date</param>
        /// <param name="end">The end date</param>
        public DateRange(DateTime start, DateTime end)
        {
            Start = start;
            End = end;
        }
    }
}
