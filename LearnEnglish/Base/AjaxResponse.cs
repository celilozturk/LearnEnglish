﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearnEnglish.Base
{
    public class AjaxResponse
    {
        public bool Sonuc { get; set; }
        public object Data { get; set; }
        public string Message { get; set; }
        public string DetailMessage { get; set; }
    }
}