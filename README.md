# VirtualFunctionExample

Virtual Function Demonstration Example

Quote an explanation from stackoverflow:
http://stackoverflow.com/questions/2391679/why-do-we-need-virtual-methods-in-c

"

Without "virtual" you get "early binding". Which implementation of the method is used gets decided at compile time based on the type of the pointer that you call through.
With "virtual" you get "late binding". Which implementation of the method is used gets decided at run time based on the type of the pointed-to object - what it was originally constructed as. This is not necessarily what you'd think based on the type of the pointer that points to that object.

"
