using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MiniMVC
{
    /// <summary>
    /// 路由表
    /// </summary>
    public class RouteTable
    {
        public static RouteDictionary Routes { get; private set; }

        static RouteTable()
        {
            Routes=new RouteDictionary();
        }
    }
}
