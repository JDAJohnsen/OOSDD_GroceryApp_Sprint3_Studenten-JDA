using CommunityToolkit.Mvvm.ComponentModel;

namespace Grocery.Core.Models
{
    public partial class Model : ObservableObject
    {
        [ObservableProperty]
        private int id;

        [ObservableProperty]
        private string name;

        public Model(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
