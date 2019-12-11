using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlueCat.Core
{
    /// <summary>
    /// Class RequestModel.
    /// </summary>
    /// <remarks>
    /// <para>作者    :xulj</para>	
    /// <para>创建时间:2019-12-09</para>
    /// <para>最后更新:xulj</para>	
    /// <para>更新时间:2019-12-09</para>
    /// </remarks>
    public class RequestModel
    {
        /// <summary>
        /// 请求的应用名称
        /// </summary>
        [Required]
        public string Application { get; set; }

        /// <summary>
        /// 请求的数据
        /// </summary>
        [Required]
        public string Data { get; set; }

        /// <summary>
        /// 当前用户（若有验证）
        /// </summary>
        public string Account { get; set; }
    }

    public class RequestModel<T> : RequestModel where T : class, new()
    {
        /// <summary>
        /// 业务数据，将 <see cref="RequestModel.Data"/> 反序列化为指定的对象 <typeparamref name="T"/>, 若不能反序列化，将设置为 <code>default(T)</code>
        /// </summary>
        public T BusinessData { get; set; }
    }
}
