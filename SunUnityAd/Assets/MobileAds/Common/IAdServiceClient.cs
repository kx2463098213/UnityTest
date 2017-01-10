using UnityEngine;
using System.Collections;

namespace MobileAds.Common
{
    internal interface IAdServiceClient
    {
        void init(string publisherId , string appKey , string appId);
        void setDebug(bool debug);
        void setLocationEnable(bool enable);
    }
}


