using System;
using System.Net;

namespace com.igetui.api.openservice
{
    internal class HttpProxy
    {
        private IGtHttpProxy proxy;

        private bool isProxy;

        private bool isProxyAuth;

        public HttpProxy(IGtHttpProxy p)
        {
            if (!string.IsNullOrWhiteSpace(p.Host) && p.Host.Length > 0)
            {
                this.isProxy = true;
            }
            else
            {
                this.isProxy = false;
            }
            if (p.User == null)
            {
                p.User = "";
            }
            if (p.Password == null)
            {
                p.Password = "";
            }
            if (!string.IsNullOrWhiteSpace(p.User) || !string.IsNullOrWhiteSpace(p.Password))
            {
                this.isProxyAuth = true;
            }
            else
            {
                this.isProxyAuth = false;
            }
            this.proxy = p;
        }

        public WebProxy getWebProxy()
        {
            WebProxy webProxy = null;
            if (this.isProxy)
            {
                webProxy = new WebProxy();
                if (!this.proxy.Host.ToLower().StartsWith("http"))
                {
                    this.proxy.Host = "http://" + this.proxy.Host;
                }
                webProxy.Address = new Uri(this.proxy.Host + ":" + this.proxy.Port);
                if (this.isProxyAuth)
                {
                    webProxy.Credentials = new NetworkCredential(this.proxy.User, this.proxy.Password);
                }
            }
            return webProxy;
        }
    }
}
