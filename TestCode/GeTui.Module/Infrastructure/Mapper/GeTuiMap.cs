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
            //const string sql =
            //    "insert dbo.GeTui(DBID,PushType,Title,ClientId,IsPush,CreateTime,PushTime,PushContent,JsonContent) VALUES (@Dbid,@type,@title,@cid,@isPush,@createTime,@pushTime,@pushContent,@jsonContent)";
            //isSave = false;
            //try
            //{
            //    var conn = new SqlConnection(Keys.ConnectionString);
            //    conn.Open();
            //    if (conn.State == ConnectionState.Open)
            //    {
            //        var parameters = new[]
            //        {
            //            new SqlParameter("@Dbid", geTui.DBID),
            //            new SqlParameter("@type", geTui.PushType.ToString()),
            //            new SqlParameter("@title", geTui.Title),
            //            new SqlParameter("@cid", geTui.ClientId),
            //            new SqlParameter("@isPush", geTui.IsPush),
            //            new SqlParameter("@createTime", geTui.CreateTime),
            //            new SqlParameter("@pushTime", geTui.PushTime),
            //            new SqlParameter("@pushContent", geTui.PushContent),
            //            new SqlParameter("@jsonContent", geTui.JsonContent)
            //        };
            //        var cmd = new SqlCommand(sql, conn);
            //        cmd.Parameters.AddRange(parameters);
            //        if (cmd.ExecuteNonQuery() > 0)
            //        {
            //            isSave = true;
            //            return $"{geTui.Title}个推实体入库成功!";
            //        }
            //    }

            //    return $"{geTui.Title}个推实体入库失败!";
            //}
            //catch (Exception e)
            //{
            //    return $"发生异常，{geTui.Title}个推实体入库失败!\t{e.Message}\t{e.StackTrace}";
            //}

            isSave = true;
            return string.Empty;
        }

        public static string Update(Domain.GeTui geTui)
        {
            //var sql = $"update dbo.GeTui set IsPush = 1, PushTime = '{DateTime.Now}' where DBID = '{geTui.DBID}'";
            //try
            //{
            //    var conn = new SqlConnection(Keys.ConnectionString);
            //    conn.Open();
            //    if (conn.State != ConnectionState.Open) return "更新数据库失败!";
            //    return new SqlCommand(sql, conn).ExecuteNonQuery() > 0 
            //        ? "更新数据库成功!" 
            //        : "更新数据库失败!";
            //}
            //catch (Exception e)
            //{
            //    return $"发生异常，更新数据库失败!\t{e.Message}\t{e.StackTrace}";
            //}

            return "更新数据库成功!";
        }
    }
}