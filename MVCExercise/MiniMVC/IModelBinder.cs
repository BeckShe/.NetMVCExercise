using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MiniMVC
{
    public interface IModelBinder
    {
        /// <summary>
        /// 绑定方法需要的参数实体
        /// </summary>
        /// <param name="controllerContext"></param>
        /// <param name="modelName"></param>
        /// <param name="modelType"></param>
        /// <returns></returns>

        object BindModel(ControllerContext controllerContext, string modelName, Type modelType);

    }
}
