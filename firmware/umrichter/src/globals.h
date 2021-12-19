/*
 * globals.h
 *
 *  Created on: Jan 29, 2020
 *      Author: am
 */

#ifndef GLOBALS_H_
#define GLOBALS_H_


#include <math.h>
#include "system.h"


#include "transfer-queue.h"
#include "signals.h"




// Code will stop if the condition is not met, and disable all interrupts


/* Konstanten*/
#define TRUE 1
#define FALSE 0

/* Makros*/
#define dReceivedCommand(bufferptr)  *((uint16_t*) (bufferptr+1))
#define dReceivedLength(bufferptr)  *bufferptr

#define SET(data, bit_mask) (data|=bit_mask)
#define RES(data, bit_mask)	(data&=(~bit_mask))




#endif /* GLOBALS_H_ */
