using System;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;

namespace TeamCityTestApp.ViewModels.UnitTests
{
    [TestClass]
    public class MainPageViewModelUnitTests
    {
	    private const string cHelloWorld = "Hello World!";

        [TestMethod]
        public void MainPageViewModelCtor_NullTextSource_ThrowsException()
        {
			// assert

	        Assert.ThrowsException<ArgumentNullException>(() => new MainPageViewModel(null));
        }

	    [TestMethod]
	    public void MainPageViewModelHellowWorld_ReturnsQuestionMark()
	    {
		    // arrange
			var textSource = new FakeTextSource(cHelloWorld);
			var viewModel = new MainPageViewModel(textSource);

			// act
		    var text = viewModel.Text;

		    // assert
			Assert.AreEqual("?", text);
	    }

		[TestMethod]
		public void MainPageViewModelHellowWorld_AfterExecuteCommand_ReturnsHelloWorld()
		{
			// arrange
			var textSource = new FakeTextSource(cHelloWorld);
			var viewModel = new MainPageViewModel(textSource);

			// act
			viewModel.SayHelloCommand.Execute(null);
			var text = viewModel.Text;

			// assert
			Assert.AreEqual(cHelloWorld, text);
		}
	}
}
