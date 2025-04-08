using System;
using System.Collections.Generic;

namespace Kursovaya
{
    public class MainViewModel
    {
        public HashSet<DateTime> HighlightedDatesSet { get; set; }

        public MainViewModel()
        {
            HighlightedDatesSet = new HashSet<DateTime>();
        }
    }
}