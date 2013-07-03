using System;
using System.Collections.Generic;

namespace ListBuilder
{
    public class EfficientListBuilder<T> : IListBuilder<T>
    {
        public IList<T> Build(IList<Op<T>> operations)
        {
            throw new NotImplementedException();
        }
    }
}
