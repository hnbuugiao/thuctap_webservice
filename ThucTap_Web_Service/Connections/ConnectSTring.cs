using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ThucTap_Web_Service.Connections
{
    public class ConnectString
    {
        public string connectionstring { get; set; }
        public ConnectString()
        {
            this.connectionstring = "Server=127.0.0.1;Port=5432;User Id=postgres;Password=123456;Database=svthuctap;";
        }

        public ConnectString(string link)
        {
            this.connectionstring = link;
        }
    }
}