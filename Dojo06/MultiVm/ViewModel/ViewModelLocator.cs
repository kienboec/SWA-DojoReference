/*
  In App.xaml:
  <Application.Resources>
      <vm:ViewModelLocator xmlns:vm="clr-namespace:MultiVm"
                           x:Key="Locator" />
  </Application.Resources>
  
  In the View:
  DataContext="{Binding Source={StaticResource Locator}, Path=ViewModelName}"

  You can also use Blend to do all this with the tool's support.
  See http://www.galasoft.ch/mvvm
*/

using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Messaging;
using MessageBar.ViewModel;
using Microsoft.Practices.ServiceLocation;
using System;

namespace MultiVm.ViewModel
{
    
    public class ViewModelLocator
    {
        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            //TODO: REgister MEssagingSystem
            SimpleIoc.Default.Register<Messenger>();

            SimpleIoc.Default.Register<MainViewModel>();
            //TODO: Register new ViewModels here 
            SimpleIoc.Default.Register<OverviewVm>(true);
            SimpleIoc.Default.Register<MyToysVm>(true);

            //TODO: Register NavigationService Here
            SimpleIoc.Default.Register<NavigationService>();

            //Register MEssagebar:
            SimpleIoc.Default.Register<MessageBarVm>();

        }

        public MainViewModel Main
        {
            get
            {
                return ServiceLocator.Current.GetInstance<MainViewModel>();
            }
        }
        //TODO: Create new properties for VMs

        public OverviewVm Overview
        {
            get
            {
                return ServiceLocator.Current.GetInstance<OverviewVm>();
            }
        }

        public MyToysVm MyToys
        {
            get
            {
                return ServiceLocator.Current.GetInstance<MyToysVm>();
            }
        }

        public MessageBarVm MessageBar
        {
            get
            {
                return ServiceLocator.Current.GetInstance<MessageBarVm>();
            }
        }

        public static void Cleanup()
        {
            // TODO Clear the ViewModels
        }
    }
}