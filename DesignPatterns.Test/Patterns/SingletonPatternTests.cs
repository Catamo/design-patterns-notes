using DesignPatterns.Patterns.SingletonPattern;
using DesignPatterns.Test.TestUtilities;
using NUnit.Framework;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace DesignPatterns.Test.Patterns
{
    public class SingletonPatternTests
    {
        [Test]
        public void Singleton_GettingNewInstancesDoesntChangeObject_IsCorrect()
        {
            Singleton instanceOne = Singleton.GetInstance();
            Singleton instanceTwo = Singleton.GetInstance();

            int hashCodeOne = RuntimeHelpers.GetHashCode(instanceOne);
            int hashCodeTwo = RuntimeHelpers.GetHashCode(instanceTwo);

            Assert.AreEqual(hashCodeOne, hashCodeTwo);
        }

        [Test]
        public void Singleton_GetTilesWorks_IsCorrect()
        {
            Singleton instanceOne = Singleton.GetInstance();

            IList<string> lettersListOne = instanceOne.GetLetterList();
            int lettersListOneSize = lettersListOne.Count;

            instanceOne.GetTiles(7);

            Assert.AreEqual(lettersListOneSize - 7, lettersListOne.Count);
        }

        [Test]
        public void Singleton_GetTilesWorksAccrossInstances_IsCorrect()
        {
            Singleton instanceOne = Singleton.GetInstance();
            Singleton instanceTwo = Singleton.GetInstance();

            IList<string> lettersListOne = instanceOne.GetLetterList();
            int lettersListOneSize = lettersListOne.Count;

            instanceOne.GetTiles(7);

            Assert.AreEqual(lettersListOneSize - 7, instanceTwo.GetLetterList().Count);
        }
    }
}
