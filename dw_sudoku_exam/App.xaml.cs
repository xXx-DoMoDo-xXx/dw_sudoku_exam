using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using dw_sudoku_exam;

namespace Dw_Sudoku_Exam
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();


            ISudoku sudoku = null;

            MainPage = new MainPage(new MainPageViewModel(sudoku));
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
