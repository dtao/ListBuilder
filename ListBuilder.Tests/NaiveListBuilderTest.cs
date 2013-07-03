using NUnit.Framework;

namespace ListBuilder.Tests
{
    [TestFixture]
    public class NaiveListBuilderTest : ListBuilderTest<NaiveListBuilder<int>>
    {
        protected override NaiveListBuilder<int> CreateBuilder()
        {
            return new NaiveListBuilder<int>();
        }
    }
}
