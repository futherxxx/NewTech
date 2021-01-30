using System.Collections.ObjectModel;

namespace NewTech.ProjectsNG.Editions.Dto
{
	//Mapped in CustomDtoMapper
	public class LocalizableComboboxItemSourceDto
	{
		public Collection<LocalizableComboboxItemDto> Items { get; set; }
	}
}