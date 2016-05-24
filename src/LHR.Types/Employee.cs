﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LHR.Types
{
    public class Employee: TypeBase
    {
        public string FullName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int OrgUnitId { get; set; }
        public int JobRoleId { get; set; }
        public int CountryId { get; set; }
        public int LocationId { get; set; }
    }
}
