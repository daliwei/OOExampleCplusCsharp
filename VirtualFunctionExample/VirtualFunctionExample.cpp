// VirtualFunctionExample.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include "Animal.h"
#include "Cat.h"
#include <iostream>
using namespace std;

int _tmain(int argc, _TCHAR* argv[])
{

	//with virtual function enabling the late-binding
	//the output from cat is "I eat rat".
	//without virtual declaration, the output is still "I eat generic food"

	Animal *animal = new Animal();
	animal->eat();

	Animal *cat = new Cat();
	cat->eat();
	
	int x=0;
	std::cin>>x;
	
	return 0;
}

