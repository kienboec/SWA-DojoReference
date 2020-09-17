using GalaSoft.MvvmLight.Messaging;
using MessageBar.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageBar.Interfaces
{
    public interface IMessagebar
    {
        void RegisterOnMessenger(Messenger messanger, string token);
        void SetDisplayTime(int time);
        void ShowInfo(Message msg);
    }

  
}
