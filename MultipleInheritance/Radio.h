#pragma once
#include "transmitter.h"
#include "Receiver.h"
class Radio :
	public Transmitter, public Receiver
{
public:
	Radio(void);
	~Radio(void);
	/*void read();*/
};

