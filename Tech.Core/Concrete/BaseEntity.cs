﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tech.Core.Concrete
{
    public abstract class BaseEntity
    {


        public DateTime CreateDate { get; set; }

        public DateTime? UpdatedDate { get; set; }
    }
}
