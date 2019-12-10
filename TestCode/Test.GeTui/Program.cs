using com.igetui.api.openservice;
using com.igetui.api.openservice.igetui;
using com.igetui.api.openservice.igetui.template;
using System;
using System.Collections.Generic;
using System.Text;

namespace Test.GeTui
{
    class Program
    {
        //参数设置 <-----参数需要重新设置----->
        //http的域名
        private static String HOST = "http://sdk.open.api.igexin.com/apiex.htm";

        //https的域名
        //private static String HOST = "https://api.getui.com/apiex.htm";

        //定义常量, appId、appKey、masterSecret 采用本文档 "第二步 获取访问凭证 "中获得的应用配置
        private static String APPID = "BAIKH6zbA6AdOXB1BSTCV3";
        private static String APPKEY = "GZxjI9jjXP8rfNnYW1Foa1";
        private static String MASTERSECRET = "62VdzpYd5n8HJPzELkwjn1";


        //您获取的clientID
        private static String CLIENTID = "2126f584bb30f2b88eda617e88010510";

        //别名推送方式
        //private static String ALIAS = "";

        static void Main(string[] args)
        {
            //toList接口每个用户状态返回是否开启，可选
            //Console.OutputEncoding = Encoding.GetEncoding(936);
            //Environment.SetEnvironmentVariable("gexin_pushList_needDetails", "true");
            // pushMessageToApp();

            //PushMessageToSingle();

            //PushMessageToList();

            getPushResult();

            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }

        //pushMessageToApp接口测试代码
        private static void pushMessageToApp()
        {
            IGtPush push = new IGtPush(HOST, APPKEY, MASTERSECRET);
            // 定义"AppMessage"类型消息对象，设置消息内容模板、发送的目标App列表、是否支持离线发送、以及离线消息有效期(单位毫秒)
            AppMessage message = new AppMessage();

            TransmissionTemplate template = TransmissionTemplateDemo();

            message.IsOffline = true;                         // 用户当前不在线时，是否离线存储,可选
            message.OfflineExpireTime = 1000 * 3600 * 12;     // 离线有效时间，单位为毫秒，可选
            message.Data = template;
            //判断是否客户端是否wifi环境下推送，2:4G/3G/2G,1为在WIFI环境下，0为无限制环境
            //message.PushNetWorkType = 0; 
            //message.Speed = 1000;

            List<String> appIdList = new List<string>();
            appIdList.Add(APPID);

            List<String> phoneTypeList = new List<string>();   //通知接收者的手机操作系统类型
            phoneTypeList.Add("ANDROID");
            //phoneTypeList.Add("IOS");

            List<String> provinceList = new List<string>();    //通知接收者所在省份
            //provinceList.Add("浙江");
            //provinceList.Add("上海");
            //provinceList.Add("北京");

            List<String> tagList = new List<string>();
            //tagList.Add("中文");

            message.AppIdList = appIdList;
            message.PhoneTypeList = phoneTypeList;
            message.ProvinceList = provinceList;
            message.TagList = tagList;


            String pushResult = push.pushMessageToApp(message);
            System.Console.WriteLine("-----------------------------------------------");
            System.Console.WriteLine("服务端返回结果：" + pushResult);
        }


        //pushMessageToApp接口测试代码--此方法无用
        private static void pushMessageToAppT1()
        {
            // 推送主类（方式1，不可与方式2共存）
            IGtPush push = new IGtPush(HOST, APPKEY, MASTERSECRET);
            // 推送主类（方式2，不可与方式1共存）此方式可通过获取服务端地址列表判断最快域名后进行消息推送，每10分钟检查一次最快域名
            //IGtPush push = new IGtPush("",APPKEY,MASTERSECRET);

            AppMessage message = new AppMessage();

            // 设置群推接口的推送速度，单位为条/秒，仅对pushMessageToApp（对指定应用群推接口）有效
            message.Speed = 100;

            TransmissionTemplate template = TransmissionTemplateDemo();

            // 用户当前不在线时，是否离线存储,可选
            message.IsOffline = false;
            // 离线有效时间，单位为毫秒，可选  
            message.OfflineExpireTime = 1000 * 3600 * 12;
            message.Data = template;
            //message.PushNetWorkType = 0;        //判断是否客户端是否wifi环境下推送，1为在WIFI环境下，0为不限制网络环境。
            List<String> appIdList = new List<string>();
            appIdList.Add(APPID);

            //通知接收者的手机操作系统类型
            List<String> phoneTypeList = new List<string>();
            phoneTypeList.Add("ANDROID");
            phoneTypeList.Add("IOS");
            //通知接收者所在省份
            List<String> provinceList = new List<string>();
            provinceList.Add("浙江");
            provinceList.Add("上海");
            provinceList.Add("北京");

            List<String> tagList = new List<string>();
            tagList.Add("开心");

            message.AppIdList = appIdList;
            message.PhoneTypeList = phoneTypeList;
            message.ProvinceList = provinceList;
            message.TagList = tagList;


            String pushResult = push.pushMessageToApp(message);
            System.Console.WriteLine("-----------------------------------------------");
            System.Console.WriteLine("服务端返回结果：" + pushResult);
        }

        //根据clientId,对单个用户推送消息
        private static void PushMessageToSingle()
        {

            IGtPush push = new IGtPush(HOST, APPKEY, MASTERSECRET);

            //消息模版：TransmissionTemplate:透传模板

            TransmissionTemplate template = TransmissionTemplateDemo();


            // 单推消息模型
            SingleMessage message = new SingleMessage();
            message.IsOffline = true;                         // 用户当前不在线时，是否离线存储,可选
            message.OfflineExpireTime = 1000 * 3600 * 12;            // 离线有效时间，单位为毫秒，可选
            message.Data = template;
            //判断是否客户端是否wifi环境下推送，2为4G/3G/2G，1为在WIFI环境下，0为不限制环境
            //message.PushNetWorkType = 1;  

            com.igetui.api.openservice.igetui.Target target = new com.igetui.api.openservice.igetui.Target();
            target.appId = APPID;
            target.clientId = CLIENTID;
            //target.alias = ALIAS;
            try
            {
                String pushResult = push.pushMessageToSingle(message, target);

                System.Console.WriteLine("-----------------------------------------------");
                System.Console.WriteLine("-----------------------------------------------");
                System.Console.WriteLine("----------------服务端返回结果：" + pushResult);
            }
            catch (RequestException e)
            {
                String requestId = e.RequestId;
                //发送失败后的重发
                String pushResult = push.pushMessageToSingle(message, target, requestId);
                System.Console.WriteLine("-----------------------------------------------");
                System.Console.WriteLine("-----------------------------------------------");
                System.Console.WriteLine("----------------服务端返回结果：" + pushResult);
            }
        }


        //PushMessageToList接口测试代码
        private static void PushMessageToList()
        {
            // 推送主类（方式1，不可与方式2共存）
            IGtPush push = new IGtPush(HOST, APPKEY, MASTERSECRET);
            // 推送主类（方式2，不可与方式1共存）此方式可通过获取服务端地址列表判断最快域名后进行消息推送，每10分钟检查一次最快域名
            //IGtPush push = new IGtPush("",APPKEY,MASTERSECRET);
            ListMessage message = new ListMessage();

            NotificationTemplate template = NotificationTemplateDemo();
            // 用户当前不在线时，是否离线存储,可选
            message.IsOffline = true;
            // 离线有效时间，单位为毫秒，可选
            message.OfflineExpireTime = 1000 * 3600 * 12;
            message.Data = template;
            //message.PushNetWorkType = 0;        //判断是否客户端是否wifi环境下推送，1为在WIFI环境下，0为不限制网络环境。
            //设置接收者
            List<Target> targetList = new List<Target>();
           Target target1 = new Target();
            target1.appId = APPID;
            target1.clientId = CLIENTID;
            //target1.alias = ALIAS1;

            // 如需要，可以设置多个接收者
            //Target target2 = new Target();
            //target2.appId = APPID;
            //target2.clientId = CLIENTID2;
            //target2.alias = ALIAS2;

            targetList.Add(target1);
           // targetList.Add(target2);

            String contentId = push.getContentId(message);
            String pushResult = push.pushMessageToList(contentId, targetList);
            System.Console.WriteLine("-----------------------------------------------");
            System.Console.WriteLine("服务端返回结果:" + pushResult);
        }



        public static void singleBatchDemo()
        {
            IGtPush push = new IGtPush(HOST, APPKEY, MASTERSECRET);
            IBatch batch = new BatchImpl(APPKEY, push);
            //消息模版：TransmissionTemplate:透传模板
            TransmissionTemplate templateTrans = TransmissionTemplateDemo();

            // 单推消息模型
            SingleMessage messageTrans = new SingleMessage();
            messageTrans.IsOffline = true;                         // 用户当前不在线时，是否离线存储,可选
            messageTrans.OfflineExpireTime = 1000 * 3600 * 12;            // 离线有效时间，单位为毫秒，可选
            messageTrans.Data = templateTrans;
            //判断是否客户端是否wifi环境下推送，2为4G/3G/2G，1为在WIFI环境下，0为不限制环境
            //messageTrans.PushNetWorkType = 1;  

            com.igetui.api.openservice.igetui.Target targetTrans = new com.igetui.api.openservice.igetui.Target();
            targetTrans.appId = APPID;
            targetTrans.clientId = CLIENTID;
            batch.add(messageTrans, targetTrans);

            NotificationTemplate templateNoti = NotificationTemplateDemo();

            // 单推消息模型
            SingleMessage messageNoti = new SingleMessage();
            messageNoti.IsOffline = true;                         // 用户当前不在线时，是否离线存储,可选
            messageNoti.OfflineExpireTime = 1000 * 3600 * 12;            // 离线有效时间，单位为毫秒，可选
            messageNoti.Data = templateNoti;
            //判断是否客户端是否wifi环境下推送，2为4G/3G/2G，1为在WIFI环境下，0为不限制环境
            //messageNoti.PushNetWorkType = 1;  

            //com.igetui.api.openservice.igetui.Target targetNoti = new com.igetui.api.openservice.igetui.Target();
            //targetNoti.appId = APPID;
            //targetNoti.clientId = CLIENTID2;
            //batch.add(messageNoti, targetNoti);
            try
            {
                batch.submit();
            }
            catch (Exception e)
            {
                batch.retry();
            }
        }

        //根据taskId查询推送是否成功
        public static void getPushResult()
        {
            IGtPush push = new IGtPush(HOST, APPKEY, MASTERSECRET);

            //taskId

            String ret = push.getPushResult("OSS-1210_466df321b736b36e287f21b0e5d719ee");
            System.Console.WriteLine(ret);

        }

        //. 批量获取推送结果
        private static void getPushResultByTaskidListDemo()
        {
            IGtPush push = new IGtPush(HOST, APPKEY, MASTERSECRET);
            List<string> taskIdList = new List<string>();
            taskIdList.Add("OSS-1210_466df321b736b36e287f21b0e5d719ee");
            //taskIdList.Add(TASKID1);
            //taskIdList.Add(TASKID2);
            string res = push.getPushResultByTaskidList(taskIdList);
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine(res);
        }


        //透传模板动作内容
        public static TransmissionTemplate TransmissionTemplateDemo()
        {
            TransmissionTemplate template = new TransmissionTemplate();
            template.AppId = APPID;
            template.AppKey = APPKEY;
            //应用启动类型，1：强制应用启动 2：等待应用启动
            template.TransmissionType = 1;
            //透传内容  
            template.TransmissionContent = "测试1111";
            //设置通知定时展示时间，结束时间与开始时间相差需大于6分钟，消息推送后，客户端将在指定时间差内展示消息（误差6分钟）
            //String begin = "2015-03-06 14:36:10";
            //String end = "2015-03-06 14:46:20";

            string begin = DateTime.Now.AddMinutes(-1).ToString("yyyy-MM-dd HH:mm:ss");

            string end = DateTime.Now.AddMinutes(2).ToString("yyyy-MM-dd HH:mm:ss");
            template.setDuration(begin, end);

            return template;
        }


        //通知透传模板动作内容
        public static NotificationTemplate NotificationTemplateDemo()
        {
            NotificationTemplate template = new NotificationTemplate();
            template.AppId = APPID;
            template.AppKey = APPKEY;
            //通知栏标题
            template.Title = "请填写通知标题";
            //通知栏内容     
            template.Text = "请填写通知内容";
            //通知栏显示本地图片
            template.Logo = "";
            //通知栏显示网络图标
            template.LogoURL = "";
            //应用启动类型，1：强制应用启动  2：等待应用启动
            template.TransmissionType = 1;
            //透传内容  
            template.TransmissionContent = "请填写透传内容";
            //接收到消息是否响铃，true：响铃 false：不响铃   
            template.IsRing = true;
            //接收到消息是否震动，true：震动 false：不震动   
            template.IsVibrate = true;
            //接收到消息是否可清除，true：可清除 false：不可清除    
            template.IsClearable = true;
            //设置通知定时展示时间，结束时间与开始时间相差需大于6分钟，消息推送后，客户端将在指定时间差内展示消息（误差6分钟）
            string begin = DateTime.Now.AddMinutes(-1).ToString("yyyy-MM-dd HH:mm:ss");

            string end = DateTime.Now.AddMinutes(2).ToString("yyyy-MM-dd HH:mm:ss");

            template.setDuration(begin, end);

            return template;
        }
    }
}
