using dw_sudoku_exam;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dw_Sudoku_Exam
{
    public class MainPageViewModel : ViewModelBase
    {
        private readonly ISudoku sudoku;

        private string _field3 = string.Empty;
        private string _field5 = string.Empty;
        private string _field9 = string.Empty;

        public string Field3
        {
            get
            {
                return _field3;
            }
            set
            {
                if (_field3 != value)
                {
                    if (validateInput(value))
                    {
                        _field3 = value;
                    }
                    else {
                        _field3 = "";
                    }
                    Notify(nameof(Field3));

                }
            }
        }

        public string field5
        {
            get
            {
                return _field5;
            }
            set
            {
                if (_field5 != value)
                {
                    if (validateInput(value))
                    {
                        _field5 = value;
                    }
                    else
                    {
                        _field5 = "";
                    }
                    Notify(nameof(field5));

                }
            }
        }

        public string Field9
        {
            get
            {
                return _field9;
            }
            set
            {
                if (_field9 != value)
                {
                    if (validateInput(value))
                    {
                        _field9 = value;
                    }
                    else
                    {
                        _field9 = "";
                    }
                    Notify(nameof(Field9));

                }
            }
        }

        public MainPageViewModel(ISudoku Sudoku)
        {
            this.sudoku = Sudoku;
        }


        private void SudokuCommand(string args)
        {

        }

        public bool validateInput(string value) {

            int val;

            try
            {
                val = Int32.Parse(value);
            }
            catch (Exception e) {
                return false;
            }


            if (val < 1 || val > 9) {
                return false;
            }

            return true;
        }

    }
}