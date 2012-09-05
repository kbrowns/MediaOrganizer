using System;
using System.Windows.Forms;

namespace MediaOrganizer
{
    public partial class MainView : Form, IMainViewUserEvents
    {
        public event EventHandler ScreenCloseInitiated = delegate { };
        public event EventHandler ScreenClosing = delegate { };
        public event EventHandler ScreenClosed = delegate { };

        public MainView()
        {
            InitializeComponent();

            this.Model = new MainModel(this);
        }

        public MainModel Model { get; private set; }

        private void OnExitMenuItemClick(object sender, EventArgs e)
        {
            this.ScreenCloseInitiated(sender, e);
        }

        private void OnFormClosing(object sender, FormClosingEventArgs e)
        {
            this.ScreenClosing(sender, e);
        }

        private void OnFormClosed(object sender, FormClosedEventArgs e)
        {
            this.ScreenClosed(sender, e);
        }
    }
}
