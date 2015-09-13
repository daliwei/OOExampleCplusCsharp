# OO Concepts Examples in C++ and C Sharp

. Virtual Function Demonstration Example

Quote an explanation from stackoverflow:
http://stackoverflow.com/questions/2391679/why-do-we-need-virtual-methods-in-c

"

Without "virtual" you get "early binding". Which implementation of the method is used gets decided at compile time based on the type of the pointer that you call through.
With "virtual" you get "late binding". Which implementation of the method is used gets decided at run time based on the type of the pointed-to object - what it was originally constructed as. This is not necessarily what you'd think based on the type of the pointer that points to that object.

"

. New and override examples

Quote stackoverflow:
http://stackoverflow.com/questions/1399127/c-new-versus-override

The override modifier may be used on virtual methods and must be used on abstract methods. This indicates for the compiler to use the last defined implementation of a method. Even if the method is called on a reference to the base class it will use the implementation overriding it.

The new modifier instructs the compiler to use your child class implementation instead of the parent class implementation. Any code that is not referencing your class but the parent class will use the parent class implementation.
