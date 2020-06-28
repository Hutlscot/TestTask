using System;
using System.Collections.ObjectModel;
using System.Management.Instrumentation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Test;
using Test.Model;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void PositiveCalculationTest()
        {
            var viewModel = new AppViewModel();

            ObservableCollection<Solution> solutions = new ObservableCollection<Solution>();
            Solution solution = new Solution { X = 2, Y = 3 };
            var equztion_lines = new Equation { name = "Линейная", Multiplier = 1, Solution = solutions, A=1,B=2,C=3 };
            var equation_4_degree = new Equation { name = "4-ой степени", Multiplier = 4, Solution = solutions, A = 1, B = 2, C = 3000 };
            Assert.IsTrue(viewModel.Calculation(equztion_lines, solution)==7);
            Assert.IsTrue(viewModel.Calculation(equation_4_degree, solution) == 3070);
        }

        [TestMethod]
        public void NegativeCalculationTest()
        {
            var viewModel = new AppViewModel();

            ObservableCollection<Solution> solutions = new ObservableCollection<Solution>();
            Solution solution = new Solution { X = 2, Y = 3 };
            var equztion_lines = new Equation { name = "Линейная", Multiplier = 1, Solution = solutions, A = 1, B = 2, C = 3 };
            var equation_4_degree = new Equation { name = "4-ой степени", Multiplier = 4, Solution = solutions, A = 1, B = 2, C = 3000 };
            Assert.IsTrue(viewModel.Calculation(equztion_lines, solution) != 8);
            Assert.IsTrue(viewModel.Calculation(equation_4_degree, solution) != 3071);
        }
    }
}
