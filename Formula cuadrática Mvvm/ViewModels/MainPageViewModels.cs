using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Formula_cuadrática_Mvvm.Models;

namespace Formula_cuadrática_Mvvm.ViewModels
{
    internal partial class MainPageViewModels : ObservableObject
    {
        [ObservableProperty]
        private double _numero1;

        [ObservableProperty]
        private double _numero2;

        [ObservableProperty]
        private double _numero3;

        [ObservableProperty]
        private double _resultado;

        [RelayCommand]
        private void Calcular()
        {
            try
            {
                FormulaCuadratica r = new FormulaCuadratica();
                r.Numero1 = Numero1;
                r.Numero2 = Numero2;
                r.Numero3 = Numero3;

                Resultado = r.Calcular();
            }
            catch (Exception ex) {
                MainThread.BeginInvokeOnMainThread(async () => await App.Current!.MainPage!.DisplayAlert("ERROR", ex.Message, "Aceptar"));
            }
        }

        [RelayCommand]
        private void Limpiar()
        {
            Numero1 = 0;
            Numero2 = 0;
            Numero3 = 0;
            Resultado = 0;
        }

        [ObservableProperty]
        private int count;

        [RelayCommand]
        public void Incrementar()
        {
            count++;
        }
    }
}
