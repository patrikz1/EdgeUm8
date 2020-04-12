using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EdgeUm8
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterMaster : ContentPage
    {
        public ListView ListView;

        public MasterMaster()
        {
            InitializeComponent();

            BindingContext = new MasterMasterViewModel();
            ListView = MenuItemsListView;


           
        }

        class MasterMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<MasterMasterMenuItem> MenuItems { get; set; }

            public MasterMasterViewModel()
            {
                MenuItems = new ObservableCollection<MasterMasterMenuItem>(new[]
                {
                    new MasterMasterMenuItem { Id = 0, Title = "Profile", TargetType=typeof(Profile)},
                    new MasterMasterMenuItem { Id = 1, Title = "Reservations", TargetType=typeof(Reservations)},
                    new MasterMasterMenuItem { Id = 2, Title = "Free Times", TargetType=typeof(FreeTimes)},
                    new MasterMasterMenuItem { Id = 3, Title = "Adv.Free Times", TargetType=typeof(AdvFreeTimes)},
                    new MasterMasterMenuItem { Id = 4, Title = "Main Page", TargetType=typeof(MainPage)},
                });
            }

            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}