// MultipleInheritance.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include "Radio.h"
#include "Storable.h"
#include "Receiver.h"
#include <iostream>

using namespace std;


int _tmain(int argc, _TCHAR* argv[])
{
	Storable *radio = new Radio();
	radio->read();

	int x=0;
	std::cin>>x;
	return 0;
}

