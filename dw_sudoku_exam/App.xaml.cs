using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Dw_Sudoku_Exam.Services;
using Dw_Sudoku_Exam.Views;

namespace Dw_Sudoku_Exam
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new Views.MainPage();
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
