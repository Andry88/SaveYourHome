﻿using System.Collections.Generic;

namespace SaveMyHome.Models
{

    public class Problem
    {
        #region Properties
        public int Id { get; set; }
        public string Name { get; set; }
        #endregion

        #region NavigationProperties
        public virtual ICollection<Event> Events { get; set; }
        #endregion
    }
}