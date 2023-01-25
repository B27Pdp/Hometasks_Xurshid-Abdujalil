using System;
using System.Collections;
using System.Collections.Generic;


    public class MyStack
    { 
        public MyStack()
        {

        }
        private Queue queue2 = new();
        private  Queue queue1 = new();

        public void Push(int x)
        {
        queue1.Enqueue(x);
        if(queue1.EnsureCapacity())

        }

        public int Pop()
        {

        }

        public int Top()
        {

        }

        public bool Empty()
        {
        
        }
    }

