﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class BillProvider: IEntityBase
    {
        public int Id { get; set; }
        public string ProviderName { get; set; }
    }
}
