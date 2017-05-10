using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Testing;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CreateDictionary_CheckLetterCount()
        {
            var dictionary = Services.CreateDictionary();

            Assert.AreEqual(26, dictionary.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void CompareSentenceToDictionary_NullStringInput()
        {
            var dictionary = Services.CreateDictionary();
            var checkedDictionary = Services.CompareSentenceToDictionary(dictionary, null);
        }

        [TestMethod]
        public void CompareSentenceToDictionary_EmptyStringInput()
        {
            var dictionary = Services.CreateDictionary();
            var checkedDictionary = Services.CompareSentenceToDictionary(dictionary, "");
            Assert.AreEqual(dictionary, checkedDictionary);
        }

        [TestMethod]
        public void CompareSentenceToDictionary_NonLetterCharacters()
        {
            var dictionary = Services.CreateDictionary();
            var checkedDictionary = Services.CompareSentenceToDictionary(dictionary, "!*&");
            Assert.AreEqual(dictionary, checkedDictionary);
        }

        [TestMethod]
        public void CheckNumberOfLettersUsed_CorrectIntOutput()
        {
            var dictionary = Services.CreateDictionary();
            var checkedDictionary = Services.CompareSentenceToDictionary(dictionary, "abc");
            var lettersUsed = Services.CheckNumberOfLettersUsed(checkedDictionary);

            Assert.AreEqual(3, lettersUsed);
        }

        [TestMethod]
        public void DeterminePangramStatus_CorrectStringOutput()
        {
            var dictionary = Services.CreateDictionary();
            var checkedDictionary = Services.CompareSentenceToDictionary(dictionary, "abc");
            var lettersUsed = Services.CheckNumberOfLettersUsed(checkedDictionary);
            var pangramStatus = Services.DeterminePangramStatus(lettersUsed);

            Assert.AreEqual("not pangram", pangramStatus);
        }

        [TestMethod]
        public void WomboCombo_CorrectNotPangramResult()
        {
            var sentence = "abc";
            var result = Services.WomboCombo(sentence);

            Assert.AreEqual("not pangram", result);
        }

        [TestMethod]
        public void WomboCombo_CorrectPangramResult()
        {
            var sentence = "We promptly judged antique ivory buckles for the next prize";
            var result = Services.WomboCombo(sentence);

            Assert.AreEqual("pangram", result);
        }
    }
}
