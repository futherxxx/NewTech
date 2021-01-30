using System.Collections.Generic;
using NewTech.ProjectsNG.Auditing.Dto;
using NewTech.ProjectsNG.Dto;

namespace NewTech.ProjectsNG.Auditing.Exporting
{
    public interface IAuditLogListExcelExporter
    {
        FileDto ExportToFile(List<AuditLogListDto> auditLogListDtos);

        FileDto ExportToFile(List<EntityChangeListDto> entityChangeListDtos);
    }
}
