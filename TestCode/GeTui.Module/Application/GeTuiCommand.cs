using System.Linq;
using GeTui.Module.Domain;

namespace GeTui.Module.Application
{
    internal class GeTuiCommand
    {
        public GeTuiCommand(Domain.GeTui entity)
        {
            Entity = entity;
        }

        public Domain.GeTui Entity { get; set; }

        public GeTuiCommand PushContent(string pushContent)
        {
            Entity.PushContent = pushContent;
            return this;
        }

        public GeTuiCommand Title(string title)
        {
            Entity.Title = title;
            return this;
        }

        public GeTuiCommand ClientId(string[] cids)
        {
            Entity.ClientId = cids.Aggregate((f, n) => $"{f}-{n}");
            if (cids.Length == 1)
            {
                Entity.PushType = PushType.PushMessageToSingle;
            }
            else if (cids.Length < 20)
            {
                Entity.PushType = PushType.SingleBatch;
            }
            else
            {
                Entity.PushType = PushType.PushMessageToList;
            }

            return this;
        }

        public GeTuiCommand JsonConetnt(string transmissionContent)
        {
            Entity.TransmissionContent = transmissionContent;
            return this;
        }
    }
}