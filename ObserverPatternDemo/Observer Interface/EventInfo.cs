﻿using System;

namespace ObserverPatternDemo.Observer_Interface
{
    /// <summary>
    ///     Represents the base class for classes that contain event data,
    ///     and provides a value to use for events that do not include event data.
    /// </summary>
    [Serializable]
    public class EventInfo
    {
        /// <summary>
        ///     Provides a value to use with events that do not have event data.
        /// </summary>
        public static readonly EventInfo Empty;

        static EventInfo()
        {
            Empty = new EventInfo();
        }
    }
}