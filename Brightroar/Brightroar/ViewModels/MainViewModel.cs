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

        private int _pressCount;

        public MainViewModel()
        {
            Message = "Hello World";
            _pressCount = 0;
        }

        public void ChangeMessage()
        {
            _pressCount++;

            Message = "Presses = " + _pressCount;
        }
    }
}
