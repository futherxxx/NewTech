using System;
using System.Threading.Tasks;
using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;
using NewTech.ProjectsNG.Configuration;
using NewTech.ProjectsNG.UiCustomization;
using NewTech.ProjectsNG.UiCustomization.Dto;
using NewTech.ProjectsNG.Web.Areas.App.Views.Shared.Themes;

namespace NewTech.ProjectsNG.Web.Views
{
    public abstract class ProjectsNGRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject] public IAbpSession AbpSession { get; set; }

        [RazorInject] public IUiThemeCustomizerFactory UiThemeCustomizerFactory { get; set; }

        protected ProjectsNGRazorPage()
        {
            LocalizationSourceName = ProjectsNGConsts.LocalizationSourceName;
        }

        public async Task<UiCustomizationSettingsDto> GetTheme()
        {
            var themeCustomizer = await UiThemeCustomizerFactory.GetCurrentUiCustomizer();
            var settings = await themeCustomizer.GetUiSettings();
            return settings;
        }

        public async Task<string> GetContainerClass()
        {
            var theme = await GetTheme();
            return theme.BaseSettings.Layout.LayoutType == "fluid" ? "container-fluid" : "container";
        }
    }
}
