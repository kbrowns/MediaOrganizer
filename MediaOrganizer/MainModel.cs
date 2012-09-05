using System.Windows.Forms;

namespace MediaOrganizer
{
    public class MainModel
    {
        private readonly MainView _view;

        public MainModel(MainView view)
        {
            _view = view;
        }

        public void Close()
        {
            _view.Close();
        }

        public IMainViewUserEvents Start()
        {
            return _view;
        }

        public Form View { get { return _view; } }
    }
}