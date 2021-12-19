

#ifndef QUEUE_TRANSFER_H
#define QUEUE_TRANSFER_H

#define RX_QUEUE_LENGTH 255
#define TX_QUEUE_LENGTH 1024


typedef struct {
	uint8_t *pui8Buffer;
	uint16_t ui16Capacity;
	uint16_t ui16Size;
	uint16_t ui16Tail;
	uint16_t ui16Head;
} Queue_t;




// "static initialization"
//#define dInitStaticQueue(PQUEUE,CAPACITY) Queue_t PQUEUE = {.pui8Buffer= (uint8_t[]){[0 ... CAPACITY-1]=0x00}, .ui16Capacity=CAPACITY, .ui16Tail=0, .ui16Head=0};
//dInitStaticQueue(queuetx,TX_QUEUE_LENGTH);
//dInitStaticQueue(queuerx,TX_QUEUE_LENGTH);

// Code based init
#define dInitQueue(queue, buffer, capacity) {queue.pui8Buffer=buffer; queue.ui16Capacity = capacity; queue.ui16Tail = 0; queue.ui16Head = 0; queue.ui16Size=0;}

// Queue Operations
#define dPutByteIntoQueue(queue, byte){  dAssert(queue.ui16Size<queue.ui16Capacity); queue.pui8Buffer[queue.ui16Head] = byte; queue.ui16Head = (queue.ui16Head +1)&(queue.ui16Capacity-1); NVIC_DisableIRQ(TIMx_BLOCK_IRQ); ++queue.ui16Size;NVIC_EnableIRQ(TIMx_BLOCK_IRQ);}
#define dPutBufferIntoQueue(queue, buffer,bytecount){ dAssert(queue.ui16Size+bytecount<=queue.ui16Capacity);\
													  for(uint16_t j=queue.ui16Head,i = 0;i<bytecount;i++,j=(j+1)&(queue.ui16Capacity-1) ){\
														  *(queue.pui8Buffer+j) = buffer[i];   }\
													  queue.ui16Head = (queue.ui16Head + bytecount)&(queue.ui16Capacity-1); NVIC_DisableIRQ(TIMx_BLOCK_IRQ);queue.ui16Size +=bytecount;NVIC_EnableIRQ(TIMx_BLOCK_IRQ); }

#define dPeekFirstByte(queue, byte){ byte = *(queue.pui8Buffer+queue.ui16Tail);}
#define dRemoveByteFromQueue(queue,byte)	{dAssert(queue.ui16Size>0); byte = *(queue.pui8Buffer+queue.ui16Tail); queue.ui16Size -=1; queue.ui16Tail = (queue.ui16Tail+1)&(queue.ui16Capacity-1);}

// Queue fill
#define dGetQueueSize(queue) (queue.ui16Size)

// Remove from queue
#define dRemoveFromQueue(queue, buffer, bufferoffset, bytecount) {      dAssert(queue.ui16Size>=bytecount); \
																		for(uint16_t i=0,j=queue.ui16Tail;i<bytecount;i++,j=(j+1)&(queue.ui16Capacity-1)){\
																		buffer[i+bufferoffset] = *(queue.pui8Buffer+j);}\
																		queue.ui16Tail =(queue.ui16Tail + bytecount)&(queue.ui16Capacity-1); \
																		NVIC_DisableIRQ(USARTx_BLOCK_IRQ); 	queue.ui16Size-=bytecount; NVIC_EnableIRQ(USARTx_BLOCK_IRQ); }

#define dClearQueue(queue) { NVIC_DisableIRQ(USARTx_BLOCK_IRQ); queue.ui16Tail = (queue.ui16Tail+queue.ui16Size)&(queue.ui16Capacity-1); queue.ui16Size = 0; NVIC_EnableIRQ(USARTx_BLOCK_IRQ);}


extern Queue_t stcQueueRx;
extern Queue_t stcQueueTx;

/* Exported functions*/
void vInitQueues(void);

#endif
