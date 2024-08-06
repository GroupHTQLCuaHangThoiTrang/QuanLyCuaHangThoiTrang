using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class HoadonBLL
    {
        WebsiteBanQuanAoDataContext ql = new WebsiteBanQuanAoDataContext();
        public HoadonBLL() { }

        public List<Order> load_Order()
        {
            return ql.Orders.Select(o => o).ToList();
        }
    }
}
