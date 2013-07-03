using System;
using System.Collections.Generic;

namespace ListBuilder
{
    public struct Op<T>
    {
        public OpType Type;
        public int Index;
        public T Value;
    }

    public static class Op
    {
        public static void Apply<T>(this Op<T> op, IList<T> list)
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

        public static Op<T> Insert<T>(int index, T value)
        {
            return new Op<T>
            {
                Type = OpType.Insert,
                Index = index,
                Value = value
            };
        }

        public static Op<T> Remove<T>(int index)
        {
            return new Op<T>
            {
                Type = OpType.Remove,
                Index = index
            };
        }
    }
}
