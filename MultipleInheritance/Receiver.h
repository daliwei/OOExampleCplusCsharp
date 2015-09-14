#pragma once
#include "storable.h"
class Receiver :
	public  Storable
{
public:
	Receiver(void);
	~Receiver(void);

	void read();
};

