using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using TeamCityTestApp.ViewModels.Annotations;

namespace TeamCityTestApp.ViewModels
{
    public class MainPageViewModel
		: INotifyPropertyChanged
    {
	    public MainPageViewModel(ITextSource textSource)
	    {
			if (textSource == null)
			{
				throw new ArgumentNullException(nameof(textSource));
			}

		    Text = "?";
			SayHelloCommand = new SimpleCommand(() => Text = textSource.HelloWorld);
	    }

	    private string _text;
	    public string Text
	    {
			get { return _text; }
		    private set
		    {
			    if (string.Equals(_text, value, StringComparison.CurrentCulture))
			    {
				    return;
			    }

			    _text = value;

				OnPropertyChanged();
		    }
	    }

		public ICommand SayHelloCommand { get; }

	    public event PropertyChangedEventHandler PropertyChanged;

	    [NotifyPropertyChangedInvocator]
	    protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
	    {
		    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
	    }
    }
}
