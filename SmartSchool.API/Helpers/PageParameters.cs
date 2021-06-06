using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartSchool.API.Helpers
{
    public class PageParameters
    {
        public const int MaxPageSize = 100;

        private int pageSize = 10;
        public int PageNumber { get; set; }
        public int PageSize 
        {
            get { return pageSize; }
            set { pageSize = (value > MaxPageSize) ? MaxPageSize : value; } 
        }

        public int? StudentEnrollment { get; set; } = null;
        public string Name { get; set; } = string.Empty;
        public int? Active { get; set; } = null;

    }
}
