using System;

using NUnit.Framework;

namespace ListBuilder.Tests
{
    [TestFixture]
    public class EfficientListBuilderTest : ListBuilderTest<EfficientListBuilder<int>>
    {
        protected override EfficientListBuilder<int> CreateBuilder()
        {
            return new EfficientListBuilder<int>();
        }
    }
}
