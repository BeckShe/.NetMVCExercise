using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MiniMVC
{
   public  class ControllerBuilder
   {
       private Func<IControllerFactory> factoryThunk;
        /// <summary>
        /// 表示当前ControllerBuilder
        /// </summary>
       public static ControllerBuilder Current { get;  }
        /// <summary>
        /// 默认命名空间列表
        /// </summary>
       public HashSet<string> DefaultNamespaces { get; }
      
       static ControllerBuilder()
       {
           Current=new ControllerBuilder();
       }
       public ControllerBuilder()
       {
           this.DefaultNamespaces=new HashSet<string>();
       }
        /// <summary>
        /// ContorllerFactory获取
        /// </summary>
        /// <returns></returns>
       public IControllerFactory GetControllerFactory()
       {
           return factoryThunk();
       }
        /// <summary>
        /// ContorllerFactory注册
        /// </summary>
        /// <param name="controllerFactory"></param>
       public void SetControllerFactory(IControllerFactory controllerFactory)
       {
           factoryThunk = () => controllerFactory;
       }
    }
}
