﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRUDUsingADO.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int Rating { get; set; }
    }
}