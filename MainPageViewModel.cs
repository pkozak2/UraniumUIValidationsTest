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

        private string _password = string.Empty;

        [Required]
        public string Password
        {
            get => _password;
            set { SetProperty(ref _password, value); }
            }
        }
    }
