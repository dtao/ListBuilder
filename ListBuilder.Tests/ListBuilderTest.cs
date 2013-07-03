using System;
using System.Collections.Generic;

using NUnit.Framework;

namespace ListBuilder.Tests
{
    [TestFixture]
    public abstract class ListBuilderTest<TListBuilder> where TListBuilder : IListBuilder<int>
    {
        IListBuilder<int> builder;
        IList<Op<int>> operations;
        IList<int> result;

        [SetUp]
        public void SetUp()
        {
            this.builder = CreateBuilder();
            this.operations = new Op<int>[0];
        }

        [Test]
        public void CreatesEmptyListByDefault()
        {
            Populate();
            Assert.That(this.result, Is.Empty);
        }

        [Test]
        public void AddsElementsInTheCorrectOrder()
        {
            Populate(
                Op.Insert(0, 1),
                Op.Insert(1, 2)
            );
            Verify(1, 2);
        }

        [Test]
        public void RemovesElementsFromTheCorrectPositions()
        {
            Populate(
                Op.Insert(0, 1),
                Op.Insert(1, 2),
                Op.Insert(2, 3),
                Op.Remove<int>(1)
            );
            Verify(1, 3);
        }

        [Test]
        public void InsertsElementsCorrectly()
        {
            Populate(
                Op.Insert(0, 1),
                Op.Insert(0, 2),
                Op.Insert(1, 3),
                Op.Insert(1, 4)
            );
            Verify(2, 4, 3, 1);
        }

        protected void Populate(params Op<int>[] ops)
        {
            this.operations = ops;
            this.result = this.builder.Build(this.operations);
        }

        protected void Verify(params int[] expected)
        {
            Assert.That(this.result, Is.EquivalentTo(expected));
        }

        protected abstract TListBuilder CreateBuilder();
    }
}
