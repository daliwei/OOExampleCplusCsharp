#include "StdAfx.h"
#include "Animal.h"
#include <iostream>
using namespace std;

Animal::Animal(void)
{
}

Animal::~Animal(void)
{
}

void Animal::eat()
{
	std::cout<<"I eat generic food!";
}
