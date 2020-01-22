using dw_sudoku_exam;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dw_Sudoku_Exam
{
    public class MainPageViewModel : ViewModelBase
    {
        private readonly ISudoku sudoku;

        private string result = string.Empty;
        public string Result
        {
            get
            {
                return result;
            }
            private set
            {
                if (result != value)
                {
                    result = value;
                    Notify(nameof(Result));
                }
            }
        }

        public MainPageViewModel(ISudoku calculator)
        {
            this.sudoku = calculator;
        }

        private void SudokuCommand(string args)
        {
           
        }

        private void UpdateResult(string value)
        {
            Result += value;
        }

        private void SetResult(string value)
        {
            Result = value;
        }

        private void ResetResult()
        {
            Result = string.Empty;
        }
    }
}
