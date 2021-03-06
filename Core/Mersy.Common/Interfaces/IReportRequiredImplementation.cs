﻿using System;
using Mersy.Common.Entities;

namespace Mersy.Common.Interfaces
{
    public interface IReportRequiredImplementation
    {
        public string Name { get; set; }

        public string Rnc { get; set; }

        public string Code { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string WebAddress { get; set; }

        public string Address { get; set; }

        public string Imagen { get; set; }

        public string Tel { get; set; }
          
        public string Header1 { get; set; }

        public string Header2 { get; set; }

        public string Header3 { get; set; }

        public string Footer1 { get; set; }

        public string Footer2 { get; set; }

        public string Footer3 { get; set; }
           
        public bool UserNameInReport { get; set; }

        public string FullName
        {
            get
            {
                return $"{Name} {LastName}";
            }
        }

    }
}
