﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Archery.Models
{
    public class Info
    {
        public static object ProtectedData { get; private set; }

        public string DevName { get; set; }

        public DateTime CreatedDate { get; set; }

        public string ContactMail { get; set; }        
        
        
        //!!!liesont entre le view et ceux modeles - binding
    }
}