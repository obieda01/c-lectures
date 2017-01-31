using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestableClasses.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestableClasses.Classes.Tests
{
    [TestClass()]
    public class LoopsAndArrayExercisesTests
    {
        //CollectionAssert
        //.AllItemsAreNotNull() - Looks at each item in actual collection for not null
        //.AllItemsAreUnique() - Checks for uniqueness among actual collection
        //.AreEqual() - Checks to see if two collections are equal (same order and quantity)
        //.AreEquilavent() - Checks to see if two collections have same element in same quantity, any order
        //.AreNotEqual() - Opposite of AreEqual
        //.AreNotEquilavent() - Opposite or AreEqualivent
        //.Contains() - Checks to see if collection contains a value/object

        LoopsAndArrayExercises exercises = new LoopsAndArrayExercises();


        [TestMethod]
        public void testEndMin()
        {
            CollectionAssert.AreEqual(new int[] { 3, 3, 3 }, exercises.MaxEnd3(new int[] {1,2,3 }));


        }
        [TestMethod]
        public void testMiddle()
        {
            CollectionAssert.AreEqual(new int[] {1,4 },exercises.MiddleWay(new int[] {5,1,3 },new int[] {10,4,9 }));
        }
    }
}