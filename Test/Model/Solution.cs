using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Model;

namespace Test
{
    public class Solution : Equation
    {

        private double x { get; set; }
        public double X
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
                OnPropertyChanged();
            }
        }

        private double y { get; set; }
        public double Y
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
                OnPropertyChanged();
            }
        }

        private double f_x_y { get; set; }

        public double F_X_Y
        {
            get
            {
                return f_x_y;
            }
            set
            {
                f_x_y = value;
                OnPropertyChanged();
                //OnPropertyChanged("F_X_Y");
            }
        }
    }
}
