﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Core.CrossCuttingConcerns.Logging
{

    public class LogDetailWithException : LogDetail
    {
        public string ExceptionMessage { get; set; }
    }
}
