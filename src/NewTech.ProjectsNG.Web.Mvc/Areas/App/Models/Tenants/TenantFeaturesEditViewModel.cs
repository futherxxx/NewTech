using Abp.AutoMapper;
using NewTech.ProjectsNG.MultiTenancy;
using NewTech.ProjectsNG.MultiTenancy.Dto;
using NewTech.ProjectsNG.Web.Areas.App.Models.Common;

namespace NewTech.ProjectsNG.Web.Areas.App.Models.Tenants
{
    [AutoMapFrom(typeof (GetTenantFeaturesEditOutput))]
    public class TenantFeaturesEditViewModel : GetTenantFeaturesEditOutput, IFeatureEditViewModel
    {
        public Tenant Tenant { get; set; }
    }
}