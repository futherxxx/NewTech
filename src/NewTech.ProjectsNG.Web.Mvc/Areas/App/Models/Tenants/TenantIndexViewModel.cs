using System.Collections.Generic;
using NewTech.ProjectsNG.Editions.Dto;

namespace NewTech.ProjectsNG.Web.Areas.App.Models.Tenants
{
    public class TenantIndexViewModel
    {
        public List<SubscribableEditionComboboxItemDto> EditionItems { get; set; }
    }
}