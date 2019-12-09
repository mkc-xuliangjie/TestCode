using com.gexin.rp.sdk.dto;
using com.igetui.api.openservice.igetui;
using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace com.igetui.api.openservice
{
    public class BatchImpl : IBatch
    {
        private string batchId;

        private List<SingleBatchItem> innerMsgList = new List<SingleBatchItem>();

        private int seqId;

        private string APPKEY;

        private IGtPush push;

        private Dictionary<string, object> lastPostData;

        public BatchImpl(string appKey, IGtPush push)
        {
            this.batchId = Guid.NewGuid().ToString();
            this.APPKEY = appKey;
            this.push = push;
        }

        public void setApiUrl(string url)
        {
        }

        public string getBatchId()
        {
            return this.batchId;
        }

        public string add(SingleMessage message, com.igetui.api.openservice.igetui.Target target)
        {
            if (this.seqId >= 5000)
            {
                throw new Exception("Can not add over 5000 message once! Please call submit() first.");
            }
            string data = this.createPostParams(message, target);
            SingleBatchItem item = SingleBatchItem.CreateBuilder().SetSeqId(this.seqId).SetData(data).Build();
            this.innerMsgList.Add(item);
            this.seqId++;
            return string.Concat(this.seqId);
        }

        public string createPostParams(SingleMessage message, com.igetui.api.openservice.igetui.Target target)
        {
            Dictionary<string, object> dictionary = new Dictionary<string, object>();
            dictionary.Add("action", "pushMessageToSingleAction");
            dictionary.Add("appkey", this.APPKEY);
            dictionary.Add("clientData", Convert.ToBase64String(message.Data.getTransparent().ToByteArray()));
            dictionary.Add("transmissionContent", message.Data.getTransmissionContent());
            dictionary.Add("isOffline", message.IsOffline);
            dictionary.Add("offlineExpireTime", message.OfflineExpireTime);
            dictionary.Add("appId", target.appId);
            dictionary.Add("clientId", target.clientId);
            dictionary.Add("type", 2);
            dictionary.Add("pushType", message.Data.getPushType());
            dictionary.Add("version", "3.0.0.0");
            return JsonConvert.SerializeObject(dictionary);
        }

        public string submit()
        {
            string value = Guid.NewGuid().ToString();
            this.seqId = 0;
            Dictionary<string, object> dictionary = new Dictionary<string, object>();
            dictionary.Add("requestId", value);
            dictionary.Add("appkey", this.APPKEY);
            dictionary.Add("action", "pushMessageToSingleBatchAction");
            dictionary.Add("serialize", "pb");
            dictionary.Add("async", GtConfig.isPushSingleBatchAsync());
            SingleBatchRequest singleBatchRequest = SingleBatchRequest.CreateBuilder().SetBatchId(this.batchId).AddRangeBatchItem(this.innerMsgList).Build();
            dictionary.Add("singleDatas", Convert.ToBase64String(singleBatchRequest.ToByteArray()));
            this.lastPostData = dictionary;
            this.innerMsgList.Clear();
            return this.push.httpPostJSON(this.push.host, dictionary, true);
        }

        public string retry()
        {
            if (this.lastPostData != null)
            {
                return this.push.httpPostJSON(this.push.host, this.lastPostData, true);
            }
            return null;
        }
    }
}
