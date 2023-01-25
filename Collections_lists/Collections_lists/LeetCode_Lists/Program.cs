using System.Collections;

Queue values1 = new();
Queue values2 = new();

Stack stack = new Stack();
values1.Enqueue(2);
values2.Enqueue(values1.Dequeue());