/*
 * main.c
 *
 *  Created on: Oct 16, 2020
 *      Author: am
 */


#include "globals.h"


Queue_t stcQueueRx;
Queue_t stcQueueTx;


// Should be 2^x
static uint8_t arrui8QueueBufferRx[RX_QUEUE_LENGTH];
static uint8_t arrui8QueueBufferTx[TX_QUEUE_LENGTH];


void vInitQueues(){
	dInitQueue(stcQueueRx, arrui8QueueBufferRx, sizeof(arrui8QueueBufferRx));	// Queues
	dInitQueue(stcQueueTx, arrui8QueueBufferTx, sizeof(arrui8QueueBufferTx));
}
