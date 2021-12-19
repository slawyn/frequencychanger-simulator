/*
 * prototypes.h
 *
 *  Created on: Jan 29, 2020
 *      Author: am
 */

#ifndef SYSTEM_H_
#define SYSTEM_H_

#include <stm32f2xx.h>

#include <stddef.h>
#include <stdint.h>

#include <stdlib.h>
#include <string.h>



/* TIM Counter Clock 100 Mhz
 * 16Khz<- 6250 Counter
 * 8Khz <- 12500 Counter
 * 4Khz <- 25000 Counter
 *
 * or use clock divider + 16Khz as base
 *
 * */


// Pwm
#define TIM_PERIOD_PWM 		6250
/*
#define PWM_100MHz_4KHz		25000
#define PWM_100MHz_8KHz		12500
#define PWM_100MHz_16KHz	6250
#define TIM_PERIOD_PWM 		PWM_100MHz_8KHz*/

// Htl Config
#define TIM_PRESCALER_HTL 62500
#define TIM_PERIOD_HTL 800


// Ticker
#define SYSTICK_10HZ 10
#define TIMEOUT_2SECONDS 20


/* Functional Entities: defines used by other files */
#define USARTx_BLOCK USART3
#define TIMx_BLOCK	TIM2

#define USARTx_BLOCK_IRQ USART3_IRQn
#define TIMx_BLOCK_IRQ  TIM2_IRQn

// Hardware Access defines
#define dCriticalSection(code) NVIC_DisableIRQ(TIM1_UP_TIM10_IRQn); code; NVIC_EnableIRQ(TIM1_UP_TIM10_IRQn);
#define dAssert(condition) if(!(condition)){__disable_irq(); while(1){}};
#define dWrtiePort(port, state) GPIO_Write(GPIOE, state);
#define dWrite(x)  USARTx_BLOCK->DR = x;

#define dSystemGeneratorPrescaler(prescaler) TIM1->PSC = (prescaler-1);
#define dSystemGeneratorPeriod(Period){TIM1->ARR = Period;}
#define dSystemGeneratorEnable(state){TIM_ClearITPendingBit(TIM1, TIM_IT_Update);TIM_Cmd(TIM1, state);}		// ENABLE, DISABLE
#define dSystemGeneratorFrequencies(freq1, freq2, freq3){ TIM1->CCR1= freq1; TIM1->CCR2=freq2; TIM1->CCR3=freq3;};

#define dSystemGeneratorEnableInterrupt(state){ if(state){ NVIC_EnableIRQ(TIMx_BLOCK_IRQ);}else{ NVIC_DisableIRQ(TIMx_BLOCK_IRQ);}}



/* Exported System Functions*/
void vSystemConfigureGpio();
void vSystemConfigureGenerator();
void vSystemSetTicktime(uint32_t ui32freq);
void vSystemConfigureMisc();
void vSystemConfigureClocks();
void vSystemConfigureUart();

#endif /* SYSTEM_H_ */
