using System.Collections.Generic;
using Abp.Application.Services.Dto;
using NewTech.ProjectsNG.Editions.Dto;

namespace NewTech.ProjectsNG.Web.Areas.App.Models.Common
{
    public interface IFeatureEditViewModel
    {
        List<NameValueDto> FeatureValues { get; set; }

        List<FlatFeatureDto> Features { get; set; }
    }
}