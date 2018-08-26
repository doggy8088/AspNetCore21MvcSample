using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCore21Mvc.Models
{
    public class AppSettings : IAppSettings, IAppSettingsScoped, IAppSettingsSingleton
    {
        public AppSettings()
        {
            this.Name = Guid.NewGuid().ToString();
        }

        public int Id { get; set; }
        public string Name { get; set; }
    }
}
