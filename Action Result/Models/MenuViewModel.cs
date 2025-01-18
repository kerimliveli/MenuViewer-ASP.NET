using Action_Result.Entities;
using System.Collections.Generic;

namespace Action_Result.Models
{
    public class MenuViewModel
    {

        public List<Drinks> Drinks { get; set; }
        public List<Hotmeals> Hotmeals { get; set; }
        public List<Fastfoods> Fastfoods{ get; set; }

    }
}
