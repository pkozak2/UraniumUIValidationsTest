using CommunityToolkit.Mvvm.ComponentModel;

namespace UraniumUITestValidations
{
    public abstract partial class BaseViewModel : ObservableValidator, IQueryAttributable
    {
        public virtual void ApplyQueryAttributes(IDictionary<string, object> query)
        {
        }
    }
}
