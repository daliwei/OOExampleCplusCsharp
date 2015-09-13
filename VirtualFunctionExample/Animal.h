#pragma once

class Animal
{
public:
	Animal(void);
	~Animal(void);
	virtual void eat();
	
	//when you add this line
	//then the instantiation has error
	//virtual void play()=0;
};
