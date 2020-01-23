using dw_sudoku_exam;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dw_Sudoku_Exam
{
  
    class MainPageViewModelTest
    {
        private readonly MainPageViewModel testee;

        public MainPageViewModelTest()
        {
            testee = new MainPageViewModel(null);
        }

        [Test]
        public void ValidatedInput10IsFalse()
        {
            Assert.AreEqual(testee.validateInput("10"), false);
        }

        [Test]
        public void ValidatedInput0IsFalse()
        {
            Assert.AreEqual(testee.validateInput("10"), false);
        }

        [Test]
        public void ValidatedInput1IsTrue()
        {
            Assert.AreEqual(testee.validateInput("4"), true);
        }

        [Test]
        public void ValidatedInput5IsTrue()
        {
            Assert.AreEqual(testee.validateInput("4"), true);
        }

        [Test]
        public void ValidatedInput9IsTrue()
        {
            Assert.AreEqual(testee.validateInput("4"), true);
        }
    }
}
