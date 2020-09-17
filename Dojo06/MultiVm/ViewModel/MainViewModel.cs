using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Messaging;

namespace MultiVm.ViewModel
{
   
    public class MainViewModel : ViewModelBase
    {
        private ViewModelBase currentDetailView;
        private NavigationService navService = SimpleIoc.Default.GetInstance<NavigationService>();
     
        public ViewModelBase CurrentDetailView
        {
            get
            {
                return currentDetailView;
            }

            set
            {
                currentDetailView = value;
                RaisePropertyChanged();
            }
        }
        public RelayCommand SwitchToOverviewBtnClickedCmd { get; set; }
        public RelayCommand SwitchToMyToysBtnClickedCmd { get; set; }

        public MainViewModel()
        {

            SwitchToOverviewBtnClickedCmd = new RelayCommand(
                ()=> { CurrentDetailView = navService.NavigateTo("Overview"); });
            SwitchToMyToysBtnClickedCmd = new RelayCommand(
                () => { CurrentDetailView = navService.NavigateTo("MyToys"); });

            //display default view:
            CurrentDetailView = navService.NavigateTo("Overview");

            //init Msgbar by geting the ViewModelLocator via the App Resources
            (App.Current.Resources["Locator"] as ViewModelLocator).MessageBar.RegisterOnMessenger(SimpleIoc.Default.GetInstance<Messenger>(), "@Message");
            //after that messages sent via messanger at @Message are displayed in the bar
            

        }

       
    }
}