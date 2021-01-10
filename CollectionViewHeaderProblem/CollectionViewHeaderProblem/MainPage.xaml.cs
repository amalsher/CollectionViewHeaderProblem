using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace CollectionViewHeaderProblem
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            Items = new ObservableCollection<SomeModel>
            {
                new SomeModel {SomeValue = "1"},
                new SomeModel {SomeValue = "2"},
                new SomeModel {SomeValue = "3"},
                new SomeModel {SomeValue = "4"},
                new SomeModel {SomeValue = "5"},
                new SomeModel {SomeValue = "6"},
                new SomeModel {SomeValue = "7"},
                new SomeModel {SomeValue = "8"},
                new SomeModel {SomeValue = "9"},
                new SomeModel {SomeValue = "10"}
            };

            BindingContext = this;
        }

        public ObservableCollection<SomeModel> Items { get; }
    }
}
