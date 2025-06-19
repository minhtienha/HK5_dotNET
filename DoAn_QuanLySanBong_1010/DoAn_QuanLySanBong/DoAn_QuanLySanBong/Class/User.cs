using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_QuanLySanBong.Class
{
    class User
    {
        public string user { get; set; }
        public string pws { get; set; }
        public User() { }
        public User(string user, string pws)
        {
            this.user = user;
            this.pws = pws;
        }
    }
}
