using System;
using System.Data;
using System.Data.SqlClient;
using GeTui.Module.Domain;

namespace GeTui.Module.Infrastructure.Mapper
{
    internal static class GeTuiMap
    {
        public static string Save(Domain.GeTui geTui, out bool isSave)
        {
            isSave = true;
            return "个推实体入库成功";
        }

        public static string Update(Domain.GeTui geTui)
        {
            return "更新数据库成功!";
        }
    }
}