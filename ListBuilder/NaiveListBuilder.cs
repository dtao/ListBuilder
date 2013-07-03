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
                Apply(operation, list);
            }
            return list;
        }
        
        static void Apply(Op<T> op, IList<T> list)
        {
            switch (op.Type)
            {
            case OpType.Insert:
                list.Insert(op.Index, op.Value);
                break;
            case OpType.Remove:
                list.RemoveAt(op.Index);
                break;
            default:
                throw new ArgumentException(string.Format("Invalid operation: {0}", op.Type));
            }
        }
    }
}
