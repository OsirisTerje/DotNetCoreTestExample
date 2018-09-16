using NUnit.Framework;
using WhateverInStandard;

namespace WhateverCoreTests
{
    public class WhateverTests
    {

        [Test]
        public void CheckTheAnswer()
        {
            var sut = new Whatever();

            var result = sut.Answer;

            Assert.That(result,Is.EqualTo(42));
        }

    }
}
