﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Model
{
    public class BaseResponse
    {
        public ResponseStatus Status { get; set; }
        public string EndUserMessage { get; set; }
    }
}
