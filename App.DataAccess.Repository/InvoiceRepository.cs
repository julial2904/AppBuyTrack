﻿using App.DataAccess.Interfaces;
using App.Entities.Base;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.DataAccess.Repository
{
    public class InvoiceRepository :
        GenericRepository<Invoice>, IInvoiceRepository
    {
        public InvoiceRepository(DbContext context) : base(context)
        {
        }
    }
}
