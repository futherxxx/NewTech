using System.Collections.Generic;
using Abp.Application.Services.Dto;
using NewTech.ProjectsNG.Editions.Dto;

namespace NewTech.ProjectsNG.MultiTenancy.Dto
{
    public class GetTenantFeaturesEditOutput
    {
        public List<NameValueDto> FeatureValues { get; set; }

        public List<FlatFeatureDto> Features { get; set; }
    }
}