using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CmsShop.Models.Data
{
    public class Db : DbContext
    {
        public DbSet<PageDTO> Pages { get; set; }

        public System.Data.Entity.DbSet<CmsShop.Models.ViewModels.Pages.PageVM> PageVMs { get; set; }
    }

}