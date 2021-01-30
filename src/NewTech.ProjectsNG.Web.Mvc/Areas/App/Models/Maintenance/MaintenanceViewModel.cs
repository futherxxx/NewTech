using System.Collections.Generic;
using NewTech.ProjectsNG.Caching.Dto;

namespace NewTech.ProjectsNG.Web.Areas.App.Models.Maintenance
{
    public class MaintenanceViewModel
    {
        public IReadOnlyList<CacheDto> Caches { get; set; }
    }
}