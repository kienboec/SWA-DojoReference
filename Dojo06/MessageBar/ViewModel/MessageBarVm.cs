using GalaSoft.MvvmLight;
using MessageBar.Interfaces;
using System.Windows.Media.Imaging;
using System.Windows.Threading;
using System;
using GalaSoft.MvvmLight.Messaging;
using GalaSoft.MvvmLight.Ioc;
using MessageBar.Model;
using System.Windows;

namespace MessageBar.ViewModel
{
   
    public class MessageBarVm : ViewModelBase, IMessagebar
    {
        private Messenger messenger = null;

        private string message;
        private BitmapImage symbol;
        private DispatcherTimer timer;
        private int displayTime = 2;
        private Visibility visible;
        public string Message
        {
            get
            {
                return message;
            }

            set
            {
                message = value;  RaisePropertyChanged();
            }
        }

        public BitmapImage Symbol
        {
            get
            {
                return symbol;
            }

            set
            {
                symbol = value; RaisePropertyChanged();
            }
        }

        public Visibility Visible
        {
            get
            {
                return visible;
            }

            set
            {
                visible = value; RaisePropertyChanged();
            }
        }

        public MessageBarVm()
        {
            timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(0, 0, displayTime);
            timer.Tick += Timer_Tick;
        }

   
        private void Timer_Tick(object sender, EventArgs e)
        {
            Symbol = null;
            Message = "";
            timer.Stop();
            Visible = Visibility.Hidden;
        }

        public void SetDisplayTime(int time)
        {
            displayTime = time;
        }

        public void ShowInfo(Message msg)
        {
            Visible = Visibility.Visible;
            switch (msg.State)
            {
                case MessageState.Warning:
                    Symbol = new BitmapImage(new Uri("../Images/state_Warning.png", UriKind.Relative));
                    break;
                case MessageState.Error:
                    Symbol = new BitmapImage(new Uri("../Images/state_Error.png", UriKind.Relative));
                    break;
                case MessageState.Info:
                    Symbol = new BitmapImage(new Uri("Images/state_Info.png", UriKind.Relative));
                    break;
                case MessageState.Ok:
                    Symbol = new BitmapImage(new Uri("../Images/state_Ok.png", UriKind.Relative));
                    break;
                default:
                    break;
            }
            Message = msg.Text;
            timer.Start();
        }

        //Register on Messenger
        public void RegisterOnMessenger(Messenger messanger, string token)
        {
            this.messenger = messanger;
            messenger.Register<PropertyChangedMessage<Message>>(this, token, showContent);
        }

        //Display Info
        private void showContent(PropertyChangedMessage<Message> obj)
        {
            ShowInfo(obj.NewValue);
        }
    }
}