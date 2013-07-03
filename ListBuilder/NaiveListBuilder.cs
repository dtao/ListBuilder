using System;
using System.Collections.Generic;

namespace ListBuilder
{
    public class NaiveListBuilder<T> : IListBuilder<T>
    {
        public IList<T> Build(IList<Op<T>> operations)
        {
            var list = new List<T>();
            foreach (Op<T> operation in operations)
            {
                operation.Apply(list);
            }
            return list;
        }
    }
}
