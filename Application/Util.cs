using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public static class Util
    {
        public static object SqlValue<T>(this T item)
        {
            if (item is SqlParameter)
            {
                if ((item as SqlParameter).Value == DBNull.Value)
                    return null;
                else
                    return (item as SqlParameter).Value;
            }
            else
            {
                if (item == null)
                    return DBNull.Value;
                else
                    return item;
            }
        }
    }
}
