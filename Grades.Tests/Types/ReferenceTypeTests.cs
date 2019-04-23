using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades.Tests.Types
{   
    [TestClass]
    public class TypeTests
    {
        [TestMethod]
        public void ValueTypesPassByValue()
        {
            int x = 46;
            IncrementNumber(ref x);

            Assert.AreEqual(47, x);
        }

        private void IncrementNumber(ref int number)
        {
            number += 1;
        }

        [TestMethod]
        public void ReferenceTypesPassByValues()
        {
            GradeBook bookOne = new GradeBook();
            GradeBook bookTwo = bookOne;

            GiveBookName(ref bookTwo);
            Assert.AreEqual("A Gradebook", bookTwo.Name);
        }

        private void GiveBookName (ref GradeBook book)
        {
            book = new GradeBook();
            book.Name = "A Gradebook";
        }

        [TestMethod]
        public void StringComparison()
        {
            string nameOne = "David";
            string nameTwo = "David";

            bool result = String.Equals(nameOne, nameTwo, System.StringComparison.InvariantCultureIgnoreCase);
            Assert.IsTrue(result);
        
        }

        [TestMethod]
        public void IntVariablesHoldValue()
        {
            int x1 = 100;
            int x2 = x1;

            x1 = 4;
            Assert.AreNotEqual(x1, x2);
        }
        [TestMethod]
        public void VariblesHoldARefernce()
        {
            GradeBook gradeBookOne = new GradeBook();
            GradeBook gradeBookTwo = gradeBookOne;

            gradeBookOne = new GradeBook();
            gradeBookOne.Name = "David's Gradebook";
            Assert.AreNotEqual(gradeBookOne.Name, gradeBookTwo.Name);
        }
    }
}
