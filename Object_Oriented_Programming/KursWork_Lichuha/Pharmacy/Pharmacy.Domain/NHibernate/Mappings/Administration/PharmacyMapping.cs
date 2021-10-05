﻿using Pharmacy.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.Domain.NHibernate.Mappings.Administration
{
    public class PharmacyMapping : BaseEntityMapping<PharmacyModel>
    {
        public PharmacyMapping()
        {
            Table("Pharmacy");
            Map(x => x.Address).Column("Address");
        }
    }
}
