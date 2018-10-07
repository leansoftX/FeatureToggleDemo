using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LeansoftX_FeatureToggle.Models.FeatureToggles;

namespace LeansoftX_FeatureToggle.Models
{
    public class HomeIndexViewModel
    {
        public WechatNotifyFeature WechatNotifyFeature
        {
            get
            {
                return new WechatNotifyFeature();
            }
        }

        public SMSNotifyFeature SMSNotifyFeature
        {
            get
            {
                return new SMSNotifyFeature();
            }
        }

    }
}
