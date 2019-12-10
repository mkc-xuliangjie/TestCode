namespace GeTui.Module.Application.Dto
{
    internal class ResultDto
    {
        /// <summary>
        /// 正确为ok
        /// </summary>
        public string result { get; set; }
        /// <summary>
        /// contentId	任务ID（当result值为ok时，有此字段），
        /// </summary>
        public string contentId { get; set; }

        /// <summary>
        /// 任务Id,PushMessageToSingle,返回此字段
        /// </summary>
        public string taskId { get; set; }

        /// <summary>
        /// successed_online,用户在线，消息在线下发,successed_offline,用户离线,消息存入离线系统
        /// </summary>
        public string status { get; set; }
    }
}