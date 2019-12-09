namespace GeTui.Module.Domain
{
    internal enum PushType
    {
        PushMessageToSingle, //对单个用户的推送
        PushMessageToList, //对指定列表用户推送
        PushMessageToApp, //对指定应用群推送
        SingleBatch //批量单推
    }
}