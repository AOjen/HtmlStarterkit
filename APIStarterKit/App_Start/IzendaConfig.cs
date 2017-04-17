using Izenda.BI.Framework.Models.UserManagement;
using Izenda.BI.Logic.CustomConfiguration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APIStarterKit.App_Start
{
    public static class IzendaConfig
    {
        public static void Init()
        {
            UserIntegrationConfig.GetAccessToken = (args) => "IMPERSONATED_ADMIN_TOKEN";
            
            UserIntegrationConfig.ValidateToken = (ValidateTokenArgs args) =>
            {
                /* Always return IzendaAdmin user regardless passing token
                 */
                return new ValidateTokenResult
                {
                    UserName = "IzendaAdmin",
                    TenantUniqueName = ""
                };
            };
        }
    }
}