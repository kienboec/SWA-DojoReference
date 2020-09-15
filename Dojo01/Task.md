# Task

Build a Stack in C\# without using Collections or the existing Stack class. 
The Stack should work with several types and have to be type safe. 
The Stack should contain a **“Push” “Pop” and a “Peek” method** which allows 

* add and 
* remove functionality as well as a possibility to 
* read the current value.

## Hints

A Stack is a LIFO Buffer. 
That means Last In First Out. 
The Push Method adds a new object to the stack, 
the Pop Method removes an object from the stack. 
The Peek method returns the object from the top of the stack.
You have to know which object is on top. 
If you remove this object you have to take care, to set the “pointer” to the next object. 
Think about special Cases (e.g. last, first element in the stack).
