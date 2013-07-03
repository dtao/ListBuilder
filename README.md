The ListBuilder Challenge
=========================

Here's a fun challenge I've never quite been able to figure out. (Disclaimer to
spare myself potential embarrassment: I haven't tried all that hard. Mostly
I've just *thought* about it. So if you figure it out easily, don't judge me!)

The challenge is this: given an array of **list operations**, consisting of
inserts and removals, construct a list representing the end result of running
all of those operations in order.

For example, take the following input:

- Insert(0, 'foo')
- Insert(1, 'bar')
- Insert(1, 'baz')
- Remove(2)

The result of combining the above operations is:

- 'foo'
- 'baz'

A naive O(N<sup>2</sup>) approach is obvious: start with an empty `List<T>` or
equivalent, then read every operation and call either `Insert` or `RemoveAt`
with the appropriate argument(s). Really the challenge is to come up with an
approach that's *better* than O(N<sup>2</sup>)... presumably one that's O(N).

This repo contains all of the necessary setup code in C#. Finish implementing
the `EfficientListBuilder<T>` class, run the tests, and see if you can get them
to pass.

**TODO**: Add more tests, including tests estimating algorithmic complexity.

