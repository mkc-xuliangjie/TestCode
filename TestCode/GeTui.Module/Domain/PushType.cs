namespace GeTui.Module.Domain
{
    /// <summary>
    /// 推送方式
    /// </summary>
    internal enum PushType
    {
        /// <summary>
        /// 对单个用户的推送
        /// </summary>
        PushMessageToSingle,
        /// <summary>
        /// //对指定列表用户推送
        /// </summary>
        PushMessageToList, 
        /// <summary>
        /// //对指定应用群推送
        /// </summary>
        PushMessageToApp,
        /// <summary>
        /// 批量单推
        /// </summary>
        SingleBatch
    }


    public class TransmissionContentModel
    {
        public string payload { get; set; }

        public string tilte { get; set; }
        
        public string content { get; set; }
    }
}