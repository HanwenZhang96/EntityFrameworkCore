using System;
using System.Collections.Generic;
using System.Text;

namespace AspEFCore.Domain
{
    public class Mayor
    {
        public int CityId { get; set; }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public Gender Gender { get; set; }
        // 导航属性
        public City City { get; set; }
    }

}
