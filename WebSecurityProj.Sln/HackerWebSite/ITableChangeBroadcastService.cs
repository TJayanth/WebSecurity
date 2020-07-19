using HackerWebSite.Data;
using System;
using System.Collections.Generic;

namespace HackerWebSite
{
    public delegate void HackedLoginChangeDelegate(object sender, HackedLoginChangeEventArgs args);

    public class HackedLoginChangeEventArgs : EventArgs
    {
        public LoginDTO NewValue { get; }
        public LoginDTO OldValue { get; }

        public HackedLoginChangeEventArgs(LoginDTO newValue, LoginDTO oldValue)
        {
            this.NewValue = newValue;
            this.OldValue = oldValue;
        }
    }

    public interface ITableChangeBroadcastService
    {
        event HackedLoginChangeDelegate OnHackedLoginChanged;
        IList<LoginDTO> GetCurrentValues();
    }
}