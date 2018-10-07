using FeatureToggle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeansoftX_FeatureToggle.CustomToggles
{
    public class SpecificUsersFeatureToggle : IFeatureToggle
    {
        public bool FeatureEnabled {
            get {
                var user = new Models.Users().GetUser();
                if (user.Name == "jackyzhou" || user.Name == "leixu")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
