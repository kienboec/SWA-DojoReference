using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Messaging;
using MessageBar.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace MultiVm.ViewModel
{
    public class OverviewVm : ViewModelBase
    {
        private Messenger messenger = SimpleIoc.Default.GetInstance<Messenger>();

        private ItemVm currentItem;

        public ObservableCollection<ItemVm> Items { get; set; }
     
        private RelayCommand<ItemVm> buyBtnClickedCmd;

        public ItemVm CurrentItem
        {
            get { return currentItem; }
            set
            {
                currentItem = value;
                RaisePropertyChanged();


            }
        }

        public RelayCommand<ItemVm> BuyBtnClickedCmd
        {
            get
            {
                return buyBtnClickedCmd;
            }

            set
            {
                buyBtnClickedCmd = value; RaisePropertyChanged();
            }
        }

        public OverviewVm()
        {
            BuyBtnClickedCmd = new RelayCommand<ItemVm>((p) =>
            {
                messenger.Send<PropertyChangedMessage<ItemVm>>(new PropertyChangedMessage<ItemVm>(null, p, "AddNew"), "Write");
                
                //send info to message bar
                messenger.Send<PropertyChangedMessage<Message>>(new PropertyChangedMessage<Message>(null, new Message("New Entry Added", MessageState.Info), ""), "@Message");
                
            }, (p) => { return true; });
            Items = new ObservableCollection<ItemVm>();
            GenerateDemoData();

        }



        private void GenerateDemoData()
        {

            Items.Add(new ItemVm("Lego", new BitmapImage(new Uri("../Images/lego1.jpg", UriKind.Relative)), "-"));
            Items.Add(new ItemVm("Playmobil", new BitmapImage(new Uri("../Images/playmobil1.jpg", UriKind.Relative)), "-"));
            Items[Items.Count - 1].AddItem(
                new ItemVm("Playmobil 2", new BitmapImage(new Uri("../Images/playmobil2.jpg", UriKind.Relative)), "5+"));
            Items[Items.Count - 1].AddItem(
                new ItemVm("Playmobil 3", new BitmapImage(new Uri("../Images/playmobil3.jpg", UriKind.Relative)), "10+"));
            Items[Items.Count - 1].AddItem(
               new ItemVm("Playmobil 2", new BitmapImage(new Uri("../Images/playmobil2.jpg", UriKind.Relative)), "5+"));
            Items[Items.Count - 1].AddItem(
                new ItemVm("Playmobil 3", new BitmapImage(new Uri("../Images/playmobil3.jpg", UriKind.Relative)), "10+"));
            Items[Items.Count - 1].AddItem(
               new ItemVm("Playmobil 2", new BitmapImage(new Uri("../Images/playmobil2.jpg", UriKind.Relative)), "5+"));
            Items[Items.Count - 1].AddItem(
                new ItemVm("Playmobil 3", new BitmapImage(new Uri("../Images/playmobil3.jpg", UriKind.Relative)), "10+"));
            Items[Items.Count - 1].AddItem(
               new ItemVm("Playmobil 2", new BitmapImage(new Uri("../Images/playmobil2.jpg", UriKind.Relative)), "5+"));
            Items[Items.Count - 1].AddItem(
                new ItemVm("Playmobil 3", new BitmapImage(new Uri("../Images/playmobil3.jpg", UriKind.Relative)), "10+"));
            Items[Items.Count - 1].AddItem(
               new ItemVm("Playmobil 2", new BitmapImage(new Uri("../Images/playmobil2.jpg", UriKind.Relative)), "5+"));
            Items[Items.Count - 1].AddItem(
                new ItemVm("Playmobil 3", new BitmapImage(new Uri("../Images/playmobil3.jpg", UriKind.Relative)), "10+"));
        }

    }
}
