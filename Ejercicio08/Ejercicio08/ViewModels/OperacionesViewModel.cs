
using Ejercicio08.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Ejercicio08.ViewModels
{
    public class OperacionesViewModel : ViewModelBase
    {

        #region Propiedades
        int valor1;
        public int Valor1
        {
            get { return valor1; }
            set
            {
                if (valor1 != value)
                {
                    valor1 = value;
                    OnPropertyChanged();
                }
            }
        }

        int valor2;
        public int Valor2
        {
            get { return valor2; }
            set
            {
                if (valor2 != value)
                {
                    valor2 = value;
                    OnPropertyChanged();
                }
            }
        }

        int suma;
        public int Suma
        {
            get { return suma; }
            set
            {
                if (suma != value)
                {
                    suma = value;
                    OnPropertyChanged();
                }
            }
        }

        int resta;
        public int Resta
        {
            get { return resta; }
            set
            {
                if (resta != value)
                {
                    resta = value;
                    OnPropertyChanged();
                }
            }
        }
        #endregion

        int multiplica;
        public int Multiplica
        {
            get { return multiplica; }
            set
            {
                if (multiplica != value)
                {
                    multiplica = value;
                    OnPropertyChanged();
                }
            }
        }


        int divide;
        public int Divide
        {
            get { return divide; }
            set
            {
                if (divide != value)
                {
                    divide = value;
                    OnPropertyChanged();
                }
            }
        }


        #region Comandos 
        public ICommand Sumar { protected set; get; }

        public ICommand Restar { protected set; get; }

        public ICommand Multiplicar { protected set; get; }

        public ICommand Dividir { protected set; get; }
        #endregion

        #region Constructor

        public OperacionesViewModel()
        {

            Sumar = new Command(() =>
            {
                Suma = Valor1 + Valor2;
            });

            Restar = new Command(() =>
            {
                Resta = Valor1 - Valor2;
            });

            Multiplicar = new Command(() =>
            {
                Multiplica = Valor1 * Valor2;
            });

            Dividir = new Command(() =>
            {
                Divide = Valor1 / Valor2;
            });
        }
        #endregion

    }
}
