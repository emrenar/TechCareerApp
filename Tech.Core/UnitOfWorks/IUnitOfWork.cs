﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tech.Core.UnitOfWorks
{
    public interface IUnitOfWork
    {
        Task CommitAsync();

        void Commit();
    }
}
