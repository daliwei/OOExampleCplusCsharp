#include "StdAfx.h"
#include "Radio.h"
#include <iostream>

using namespace std;

Radio::Radio(void): // some value that storable needs 
   Transmitter()
{
}


Radio::~Radio(void)
{

}


void Radio::read()
{
	std::cout<<"read from radio";
}


