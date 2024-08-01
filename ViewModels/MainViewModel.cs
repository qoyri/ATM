using System.ComponentModel;
using System.Threading.Tasks;

namespace ATMProjet.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private int _progress;
        public int Progress
        {
            get { return _progress; }
            set
            {
                if (_progress != value)
                {
                    _progress = value;
                    OnPropertyChanged(nameof(Progress));
                }
            }
        }

        public async Task StartLoading()
        {
            for (int i = 0; i <= 100; i++)
            {
                Progress = i;
                await Task.Delay(30);
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}