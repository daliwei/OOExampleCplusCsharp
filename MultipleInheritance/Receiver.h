#pragma once
#include "storable.h"
class Receiver :
	public virtual Storable
{
public:
	Receiver(void);
	~Receiver(void);

	void read();
};

