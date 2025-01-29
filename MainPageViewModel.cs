using CommunityToolkit.Mvvm.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace UraniumUITestValidations
{
    public partial class MainPageViewModel : BaseViewModel
    {
        [ObservableProperty]
        [Required]
        [EmailAddress]
        private string email = string.Empty;
    }
}
