using System;

namespace MediaOrganizer
{
    public interface IMainViewUserEvents
    {
        event EventHandler ScreenCloseInitiated;
        event EventHandler ScreenClosing;
        event EventHandler ScreenClosed;
    }
}