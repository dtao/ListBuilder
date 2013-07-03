using System;
using System.Collections.Generic;

namespace ListBuilder
{
    public interface IListBuilder<T>
    {
        IList<T> Build(IList<Op<T>> operations);
    }
}
