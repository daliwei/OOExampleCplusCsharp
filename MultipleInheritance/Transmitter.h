#pragma once
#include "storable.h"
class Transmitter :
	public Storable
{
public:
	Transmitter(void);
	~Transmitter(void);
	void read();
};

