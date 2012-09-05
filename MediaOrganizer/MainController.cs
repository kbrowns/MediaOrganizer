using System;

namespace MediaOrganizer
{
    public class MainController
    {
        public MainModel Model { get; private set; }

        public MainController(MainModel model)
        {
            Model = model;

            IMainViewUserEvents events = Model.Start();

            events.ScreenCloseInitiated += ViewOnScreenCloseInitiated;
        }

        private void ViewOnScreenCloseInitiated(object sender, EventArgs eventArgs)
        {
            Model.Close();
        }
    }
}
