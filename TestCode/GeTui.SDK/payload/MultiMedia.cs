using System;
using System.Collections.Generic;
using System.Text;

namespace GetuiServerApiSDK_Core.payload
{
    public class MultiMedia
    {
        public enum MediaType
        {
            pic = 1,
            audio,
            video
        }

        private string resId;

        private string resUrl;

        private MultiMedia.MediaType resType;

        private int isOnlyWifi;

        public string rid
        {
            get
            {
                return this.resId;
            }
            set
            {
                this.resId = value;
            }
        }

        public string url
        {
            get
            {
                return this.resUrl;
            }
            set
            {
                this.resUrl = value;
            }
        }

        public int onlywifi
        {
            get
            {
                return this.isOnlyWifi;
            }
        }

        public MultiMedia.MediaType type
        {
            get
            {
                return this.resType;
            }
            set
            {
                this.resType = value;
            }
        }

        public void setIsOnlyWifi(bool value)
        {
            this.isOnlyWifi = (value ? 1 : 0);
        }
    }
}
