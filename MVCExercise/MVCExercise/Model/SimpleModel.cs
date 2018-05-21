using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCExercise.Model
{
    /// <summary>
    /// 绑定View上数据，验证对Controller和Action的解析机制
    /// </summary>
    public class SimpleModel
    {
        public string Controller { get; set; }
        public string Action { get; set; }

        public string Foo { get; set; }
        public int Bar { get; set; }

        public double Baz { get; set; }
    }
}