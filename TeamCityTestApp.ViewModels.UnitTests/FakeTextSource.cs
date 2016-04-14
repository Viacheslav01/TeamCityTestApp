namespace TeamCityTestApp.ViewModels.UnitTests
{
	internal class FakeTextSource
		: ITextSource
	{
		public FakeTextSource(string helloWorld)
		{
			HelloWorld = helloWorld;
		}

		public string HelloWorld { get; }
	}
}