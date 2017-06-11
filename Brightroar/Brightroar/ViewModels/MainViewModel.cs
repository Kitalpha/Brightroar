using Caliburn.Micro;

namespace Brightroar.ViewModels
{
    public class MainViewModel : PropertyChangedBase
    {
        private string _message;

        public string Message
        {
            get { return _message; }
            set
            {
                _message = value;
                NotifyOfPropertyChange(() => Message);
            }
        }

        public MainViewModel()
        {
            Message = "Hello World";
        }
    }
}
