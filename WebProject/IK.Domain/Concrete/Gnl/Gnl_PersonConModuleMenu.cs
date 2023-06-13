﻿using IK.Domain.Abstract;
using IK.Domain.Concrete.Sys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IK.Domain.Concrete.Gnl
{
    public class Gnl_PersonConModuleMenu : BaseEntity
    {
        public int PersonID { get; set; }
        public Sys_Person Person { get; set; }
        public int SysModuleMenuID { get; set; }
        public Sys_ModuleMenu SysModuleMenu { get; set; }
    }
}