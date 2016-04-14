using TeamCityTestApp.ViewModels;

namespace TeamCityTestApp.Services
{
	internal class TextSource
		: ITextSource
	{
		public string HelloWorld => Resources.ru_RU.Resources.HellowWorld;
	}
}
