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

    // Helper class with convenient methods for creating Op<T> values
    public static class Op
    {
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
