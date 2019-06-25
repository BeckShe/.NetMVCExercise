using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MiniMVC
{
    public class RouteData
    {
        public IDictionary<string,object> Values { get; private set; }
        public IDictionary<string,object> DataTokens { get; private set; }

        public IRouteHandler RouteHandler { get; set; }
        /// <summary>
        /// 表示当前路由表中与当前请求匹配的路由对象
        /// </summary>
        public RouteBase Route { get; set; }

        public RouteData()
        {
            //请求地址解析出的变量
            //表示Controller和Action名称的同名属性直接从Values字典中提取，对应的Key分别为controller和action。
            this.Values=new Dictionary<string, object>();
            //其他类型的变量
            //属性Namespaces表示辅助Controller类型的解析而设置的命名空间列表，该属性值从DataTokens字典中提取，对应的Key为namespaces。
            this.DataTokens = new Dictionary<string, object>();
            this.DataTokens.Add("namespaces",new List<string>());
        }

        public string Controller
        {
            get
            {
                object controllerName = string.Empty;
                this.Values.TryGetValue("controller", out controllerName);
                return controllerName.ToString();
            }
        }
        public string ActionName
        {
            get
            {
                object actionName = string.Empty;
                this.Values.TryGetValue("action", out actionName);
                return actionName.ToString();
            }
        }

        public IEnumerable<string> Namespaces
        {
            get { return (IEnumerable<string>) this.DataTokens["namespaces"]; }
        }
    }
}
