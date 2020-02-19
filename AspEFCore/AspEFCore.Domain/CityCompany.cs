using System;
using System.Collections.Generic;
using System.Text;

namespace AspEFCore.Domain
{
    public class CityCompany
    {
        public int CityId { get; set; }
        // 导航属性
        public City City { get; set; }

        public int CompanyId { get; set; }
        // 导航属性
        public Company Company { get; set; }
    }
}
