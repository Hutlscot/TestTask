using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;

namespace Test.Model
{
    public class Equation : INotifyPropertyChanged
    {
       
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }

        public string name { get; set; }
        private int multiplier { get; set; }
        public int Multiplier
        {
            get
            {
                return multiplier;
            }
            set
            {
                multiplier = value;
                OnPropertyChanged();
            }
        }

        private double a { get; set; }

        public double A
        {
            get
            {
                return a;
            }
            set
            {
                a = value;
                OnPropertyChanged();
            }
        }

        private double b { get; set; }
        public double B
        {
            get
            {
                return b;
            }
            set
            {
                b = value;
                OnPropertyChanged();
            }
        }
        private int c { get; set; }
        public int C
        {
            get
            {
                return c;
            }
            set
            {
                c = value;
                OnPropertyChanged();
            }
        }
        //расчет допустимых значений с 
        //работает правильно
        private List<int> ls_c;
        public List<int> Ls_c
        {
            get
            {
                ls_c = new List<int>();
                for (int x = 1; x < 6; x++)
                {
                    double i = x * Math.Pow(10, multiplier - 1);
                    ls_c.Add(Convert.ToInt32(i));
                }
                return ls_c;
            }
            set
            {
                ls_c = value;
                OnPropertyChanged();
            }
        }
        //список решений
        private ObservableCollection<Solution> solution;

        public ObservableCollection<Solution> Solution
        {
            get
            {
                return solution;
            }
            set
            {
                solution = value;
                OnPropertyChanged();
            }
        }

    }
}
