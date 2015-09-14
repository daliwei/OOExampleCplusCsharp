#pragma once
#include "storable.h"
class Transmitter :
	public virtual Storable
{
public:
	Transmitter(void);
	~Transmitter(void);
	void read();
};

