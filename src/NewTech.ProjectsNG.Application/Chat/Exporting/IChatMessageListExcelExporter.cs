using System.Collections.Generic;
using Abp;
using NewTech.ProjectsNG.Chat.Dto;
using NewTech.ProjectsNG.Dto;

namespace NewTech.ProjectsNG.Chat.Exporting
{
    public interface IChatMessageListExcelExporter
    {
        FileDto ExportToFile(UserIdentifier user, List<ChatMessageExportDto> messages);
    }
}
