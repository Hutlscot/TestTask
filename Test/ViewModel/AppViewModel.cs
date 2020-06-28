using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using Test.Model;

namespace Test
{
    public class AppViewModel : INotifyPropertyChanged
    {
        

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }

        private Equation selectedEquation;

       
        public ObservableCollection<Equation> equations { get; set; }
        //выбранное уравнение
        public Equation SelectedEquation
        {
            get
            {
                return selectedEquation;
            }
            set
            {
                selectedEquation = value;
                OnPropertyChanged();
            }
        }
        public AppViewModel()
        {
            ObservableCollection<Solution> solutions = new ObservableCollection<Solution>();
            Solution solution = new Solution {X=1,Y=1 };
            solutions.Add(solution);
            equations = new ObservableCollection<Equation>();
            equations.Add(new Equation { name = "Линейная", Multiplier = 1, Solution = solutions});
            equations.Add(new Equation { name = "Квадратичная", Multiplier = 2, Solution = solutions });
            equations.Add(new Equation { name = "Кубическая", Multiplier = 3, Solution = solutions });
            equations.Add(new Equation { name = "4-ой степени", Multiplier = 4, Solution = solutions });
            equations.Add(new Equation { name = "5-ой степени", Multiplier = 5, Solution = solutions });
        }
        public ICommand Click
        {
            get
            {
                return new DelegateCommand((obj) =>
                {
                    if (selectedEquation == null)
                    {
                        MessageBox.Show("Выберите сперва уравнение","Ошибка",MessageBoxButton.OK,MessageBoxImage.Error);
                        return;
                    }
                    foreach (Solution sol in selectedEquation.Solution)
                    {
                        sol.F_X_Y = Calculation(selectedEquation, sol);
                    }
                    //вывод количества решений
                    //MessageBox.Show(selectedEquation.Solution.Count.ToString());
                });
            }
        }
        //функция определения f(x,y)
        public double Calculation(Equation selEq, Solution sol)
        {
            return selEq.A * Math.Pow(sol.X, selEq.Multiplier) + selEq.B * Math.Pow(sol.Y, selEq.Multiplier - 1) + selEq.C;
        }
    }
}
