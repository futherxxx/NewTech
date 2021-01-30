using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using NewTech.ProjectsNG.MultiTenancy.HostDashboard.Dto;

namespace NewTech.ProjectsNG.MultiTenancy.HostDashboard
{
    public interface IIncomeStatisticsService
    {
        Task<List<IncomeStastistic>> GetIncomeStatisticsData(DateTime startDate, DateTime endDate,
            ChartDateInterval dateInterval);
    }
}