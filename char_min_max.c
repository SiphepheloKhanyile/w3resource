#include <limits.h>
#include <stdio.h>
#include <stdlib.h>
/**
  * main - get 'char' min to max value
  * Return: void
  */
void main(void)
{
	char c;
	c = CHAR_MIN;
	while (c != CHAR_MAX)
	{
		printf("%d\n", c);
		c++;
	}
}
