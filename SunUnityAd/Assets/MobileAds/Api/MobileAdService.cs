using UnityEngine;
using MobileAds.Common;

namespace MobileAds.Api
{
    public class MobileAdService
    {
        private IAdServiceClient client;

        public MobileAdService() {
            client = MobileAdsClientFactory.BuildAdServiceClient();
        }

        public void init(string publisherId, string appkey, string appId)
        {
            client.init(publisherId,appkey,appId);
        }

        public void setDebug(bool debug) {
            client.setDebug(debug);
        }

        public void setLocationEnable(bool enable)
        {
            client.setLocationEnable(enable);
        }

    }
}


