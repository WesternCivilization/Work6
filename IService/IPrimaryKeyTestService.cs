using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IService
{
    /// <summary>
    /// Author : 谭振
    /// DateTime : 2017/3/20 10:48:17
    /// Mail : tanz01@haid.com.cn
    /// Description : 
    /// </summary>
    public interface IPrimaryKeyTestService
    {
        int InsertTable(string FiledsName, object arrayList);
    }
}
