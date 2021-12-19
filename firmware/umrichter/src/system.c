/*
 * init.c
 *
 *  Created on: Jan 29, 2020
 *      Author: am
 */

#include "globals.h"


#if !defined  (HSE_VALUE)
  #define HSE_VALUE    ((uint32_t)25000000) /*!< Default value of the External oscillator in Hz */
#endif /* HSE_VALUE */

#if !defined  (HSI_VALUE)
  #define HSI_VALUE    ((uint32_t)16000000) /*!< Value of the Internal oscillator in Hz*/
#endif /* HSI_VALUE */

#ifdef DATA_IN_ExtSRAM
  static void SystemInit_ExtMemCtl(void);
#endif /* DATA_IN_ExtSRAM */



RCC_ClocksTypeDef stcClockFrequencies;	// Structure temporary holds clock configuration


uint32_t SystemCoreClock = 16000000;
const uint8_t AHBPrescTable[16] = {0, 0, 0, 0, 0, 0, 0, 0, 1, 2, 3, 4, 6, 7, 8, 9};
const uint8_t APBPrescTable[8]  = {0, 0, 0, 0, 1, 2, 3, 4};
#define VECT_TAB_OFFSET  0x00 /*!< Vector Table base offset field.
                                   This value must be a multiple of 0x200. */


void SystemCoreClockUpdate(void)
{
  uint32_t tmp = 0, pllvco = 0, pllp = 2, pllsource = 0, pllm = 2;

  /* Get SYSCLK source -------------------------------------------------------*/
  tmp = RCC->CFGR & RCC_CFGR_SWS;

  switch (tmp)
  {
    case 0x00:  /* HSI used as system clock source */
      SystemCoreClock = HSI_VALUE;
      break;
    case 0x04:  /* HSE used as system clock source */
      SystemCoreClock = HSE_VALUE;
      break;
    case 0x08:  /* PLL used as system clock source */

      /* PLL_VCO = (HSE_VALUE or HSI_VALUE / PLL_M) * PLL_N
         SYSCLK = PLL_VCO / PLL_P
         */
      pllsource = (RCC->PLLCFGR & RCC_PLLCFGR_PLLSRC) >> 22;
      pllm = RCC->PLLCFGR & RCC_PLLCFGR_PLLM;

      if (pllsource != 0)
      {
        /* HSE used as PLL clock source */
        pllvco = (HSE_VALUE / pllm) * ((RCC->PLLCFGR & RCC_PLLCFGR_PLLN) >> 6);
      }
      else
      {
        /* HSI used as PLL clock source */
        pllvco = (HSI_VALUE / pllm) * ((RCC->PLLCFGR & RCC_PLLCFGR_PLLN) >> 6);
      }

      pllp = (((RCC->PLLCFGR & RCC_PLLCFGR_PLLP) >>16) + 1 ) *2;
      SystemCoreClock = pllvco/pllp;
      break;
    default:
      SystemCoreClock = HSI_VALUE;
      break;
  }
  /* Compute HCLK frequency --------------------------------------------------*/
  /* Get HCLK prescaler */
  tmp = AHBPrescTable[((RCC->CFGR & RCC_CFGR_HPRE) >> 4)];
  /* HCLK frequency */
  SystemCoreClock >>= tmp;
}

#ifdef DATA_IN_ExtSRAM
/**
  * @brief  Setup the external memory controller.
  *         Called in startup_stm32f2xx.s before jump to main.
  *         This function configures the external SRAM mounted on STM322xG_EVAL board
  *         This SRAM will be used as program data memory (including heap and stack).
  * @param  None
  * @retval None
  */
void SystemInit_ExtMemCtl(void)
{
  __IO uint32_t tmp = 0x00;

/*-- GPIOs Configuration -----------------------------------------------------*/
   /* Enable GPIOD, GPIOE, GPIOF and GPIOG interface clock */
  RCC->AHB1ENR   |= 0x00000078;
  /* Delay after an RCC peripheral clock enabling */
  tmp = READ_BIT(RCC->AHB1ENR, RCC_AHB1ENR_GPIODEN);
  (void)(tmp);

  /* Connect PDx pins to FSMC Alternate function */
  GPIOD->AFR[0]  = 0x00CCC0CC;
  GPIOD->AFR[1]  = 0xCCCCCCCC;
  /* Configure PDx pins in Alternate function mode */
  GPIOD->MODER   = 0xAAAA0A8A;
  /* Configure PDx pins speed to 100 MHz */
  GPIOD->OSPEEDR = 0xFFFF0FCF;
  /* Configure PDx pins Output type to push-pull */
  GPIOD->OTYPER  = 0x00000000;
  /* No pull-up, pull-down for PDx pins */
  GPIOD->PUPDR   = 0x00000000;

  /* Connect PEx pins to FSMC Alternate function */
  GPIOE->AFR[0]  = 0xC00CC0CC;
  GPIOE->AFR[1]  = 0xCCCCCCCC;
  /* Configure PEx pins in Alternate function mode */
  GPIOE->MODER   = 0xAAAA828A;
  /* Configure PEx pins speed to 100 MHz */
  GPIOE->OSPEEDR = 0xFFFFC3CF;
  /* Configure PEx pins Output type to push-pull */
  GPIOE->OTYPER  = 0x00000000;
  /* No pull-up, pull-down for PEx pins */
  GPIOE->PUPDR   = 0x00000000;

  /* Connect PFx pins to FSMC Alternate function */
  GPIOF->AFR[0]  = 0x00CCCCCC;
  GPIOF->AFR[1]  = 0xCCCC0000;
  /* Configure PFx pins in Alternate function mode */
  GPIOF->MODER   = 0xAA000AAA;
  /* Configure PFx pins speed to 100 MHz */
  GPIOF->OSPEEDR = 0xFF000FFF;
  /* Configure PFx pins Output type to push-pull */
  GPIOF->OTYPER  = 0x00000000;
  /* No pull-up, pull-down for PFx pins */
  GPIOF->PUPDR   = 0x00000000;

  /* Connect PGx pins to FSMC Alternate function */
  GPIOG->AFR[0]  = 0x00CCCCCC;
  GPIOG->AFR[1]  = 0x000000C0;
  /* Configure PGx pins in Alternate function mode */
  GPIOG->MODER   = 0x00085AAA;
  /* Configure PGx pins speed to 100 MHz */
  GPIOG->OSPEEDR = 0x000CAFFF;
  /* Configure PGx pins Output type to push-pull */
  GPIOG->OTYPER  = 0x00000000;
  /* No pull-up, pull-down for PGx pins */
  GPIOG->PUPDR   = 0x00000000;

/*--FSMC Configuration -------------------------------------------------------*/
  /* Enable the FSMC interface clock */
  RCC->AHB3ENR         |= 0x00000001;

  /* Configure and enable Bank1_SRAM2 */
  FSMC_Bank1->BTCR[2]  = 0x00001011;
  FSMC_Bank1->BTCR[3]  = 0x00000201;
  FSMC_Bank1E->BWTR[2] = 0x0FFFFFFF;
}
#endif /* DATA_IN_ExtSRAM */


void SystemInit(void)
{
  /* Reset the RCC clock configuration to the default reset state ------------*/
  /* Set HSION bit */
  RCC->CR |= (uint32_t)0x00000001;

  /* Reset CFGR register */
  RCC->CFGR = 0x00000000;

  /* Reset HSEON, CSSON and PLLON bits */
  RCC->CR &= (uint32_t)0xFEF6FFFF;

  /* Reset PLLCFGR register */
  RCC->PLLCFGR = 0x24003010;

  /* Reset HSEBYP bit */
  RCC->CR &= (uint32_t)0xFFFBFFFF;

  /* Disable all interrupts */
  RCC->CIR = 0x00000000;

#ifdef DATA_IN_ExtSRAM
  SystemInit_ExtMemCtl();
#endif /* DATA_IN_ExtSRAM */

  /* Configure the Vector Table location add offset address ------------------*/
#ifdef VECT_TAB_SRAM
  SCB->VTOR = SRAM_BASE | VECT_TAB_OFFSET; /* Vector Table Relocation in Internal SRAM */
#else
  SCB->VTOR = FLASH_BASE | VECT_TAB_OFFSET; /* Vector Table Relocation in Internal FLASH */
#endif
}






/* Timer Clock is 100 Mhz:
 * For PWM we need 8kHz */
void vSystemConfigureGenerator() {

	GPIO_InitTypeDef init_pwm_pins_portE = { .GPIO_Mode = GPIO_Mode_AF, .GPIO_Speed = GPIO_Speed_50MHz, .GPIO_OType = GPIO_OType_PP, .GPIO_PuPd = GPIO_PuPd_NOPULL, .GPIO_Pin = GPIO_Pin_13
			| GPIO_Pin_12 | GPIO_Pin_11 | GPIO_Pin_10 | GPIO_Pin_9 | GPIO_Pin_8 };

	RCC_APB2PeriphClockCmd(RCC_APB2ENR_TIM1EN, ENABLE);
	RCC_AHB1PeriphClockCmd(RCC_AHB1ENR_GPIOEEN, ENABLE);

	// Ports initializieren
	GPIO_Init(GPIOE, &init_pwm_pins_portE);

	GPIO_PinAFConfig(GPIOE, GPIO_PinSource9, GPIO_AF_TIM1);	// 	   pwm 1	U
	GPIO_PinAFConfig(GPIOE, GPIO_PinSource8, GPIO_AF_TIM1); // inv pwm 1

	GPIO_PinAFConfig(GPIOE, GPIO_PinSource11, GPIO_AF_TIM1); //	    pwm 2	V
	GPIO_PinAFConfig(GPIOE, GPIO_PinSource10, GPIO_AF_TIM1); // inv pwm 2

	// pwm pins
	GPIO_PinAFConfig(GPIOE, GPIO_PinSource13, GPIO_AF_TIM1); // 	pwm 3	W
	GPIO_PinAFConfig(GPIOE, GPIO_PinSource12, GPIO_AF_TIM1); // inv pwm 3

	// Beispiele auf http://diller-technologies.de/stm32.html#timer_pwm
	TIM_TimeBaseInitTypeDef TIM_TimeBase_InitStructure;

	TIM_TimeBase_InitStructure.TIM_ClockDivision = TIM_CKD_DIV1;		//
	TIM_TimeBase_InitStructure.TIM_CounterMode = TIM_CounterMode_Up;
	TIM_TimeBase_InitStructure.TIM_Period = 0;
	TIM_TimeBase_InitStructure.TIM_Prescaler = 0;
	TIM_TimeBaseInit(TIM1, &TIM_TimeBase_InitStructure);

	// Set Signal Polarities
	TIM1->CCMR1 = 0;		// Output Mode: Frozen
	TIM1->CCMR2 = 0;

	TIM1->CCMR1 |= TIM_CCMR1_OC1PE|TIM_CCMR1_OC2PE;		// Synchronize preloading CCR  on the update event
	TIM1->CCMR2 |= TIM_CCMR2_OC3PE;

	TIM1->CCER = 0;

	//TIM1->CR2 |= TIM_CR2_OIS1|TIM_CR2_OIS2|TIM_CR2_OIS3;
	//TIM1->CCER |=TIM_CCER_CC1P|TIM_CCER_CC2P|TIM_CCER_CC3P;		// Default High:
	//TIM1->CCER |=((TIM_CCER_CC1NP|TIM_CCER_CC2NP|TIM_CCER_CC3NP));


	/* Der Treiber hat einen Bug und setzt die OutputNState nicht,
	 weil Im Treibercode die Bit-Position von NState gleich der Position von OCNPolarity ist! Dieser Bug kann gef�hrlich auswirken! Platinen schon verreckt) */

	// Die invertierten Signale manuell freischalten.
	TIM1->CCER |=TIM_CCER_CC1E| TIM_CCER_CC2E|TIM_CCER_CC3E|TIM_CCER_CC1NE | TIM_CCER_CC2NE | TIM_CCER_CC3NE;

	/* Pwm einschalten */
	TIM_CtrlPWMOutputs(TIM1, ENABLE);

	TIM_ClearITPendingBit(TIM1, TIM_IT_Update);

	// PWM arbeitet genauer mit Update Interrupt als mit CC, CC braucht anderen Ansatz!
	TIM_ITConfig(TIM1, TIM_IT_Update, ENABLE);

	// TIM 1 update interrupt tritt auf wenn Z�hler durchgez�hlt ist, aber die Ausf�hrung in main zu haben reichts aus.
	NVIC_InitTypeDef NVIC_InitStruct;/**/
	NVIC_InitStruct.NVIC_IRQChannel = TIM1_UP_TIM10_IRQn;
	NVIC_InitStruct.NVIC_IRQChannelCmd = ENABLE;
	NVIC_InitStruct.NVIC_IRQChannelPreemptionPriority = 0;
	NVIC_InitStruct.NVIC_IRQChannelSubPriority = 1;
	NVIC_Init(&NVIC_InitStruct);

	//TIM_ITConfig(TIM1, TIM_IT_CC1, ENABLE);
	// TIM 1 compare interrupt tritt am Compare auf, es ist m�glich aber viel komplizierter pwm mit diesem interrupt nachzubauen.
	//NVIC_InitStruct.NVIC_IRQChannel = TIM1_CC_IRQn;
	//NVIC_InitStruct.NVIC_IRQChannelCmd = ENABLE;
	//NVIC_InitStruct.NVIC_IRQChannelPreemptionPriority = 0;
	//NVIC_InitStruct.NVIC_IRQChannelSubPriority = 1;
	//NVIC_Init(&NVIC_InitStruct);
}

/* Rechteck */
void vSystemConfigureGpio() {

	GPIO_InitTypeDef init_gpio_pins_portE = { .GPIO_Mode = GPIO_Mode_OUT, .GPIO_Speed = GPIO_Speed_50MHz, .GPIO_OType = GPIO_OType_PP, .GPIO_PuPd = GPIO_PuPd_NOPULL, .GPIO_Pin = GPIO_Pin_13
			| GPIO_Pin_12 | GPIO_Pin_11 | GPIO_Pin_10 | GPIO_Pin_9 | GPIO_Pin_8 };

	/* PWM Ausschalten */
	RCC_APB2PeriphClockCmd(RCC_APB2ENR_TIM1EN, DISABLE);

	/* Pins umkonfigurieren zu GPIO*/
	RCC_AHB1PeriphClockCmd(RCC_AHB1ENR_GPIOEEN, ENABLE);
	GPIO_Init(GPIOE, &init_gpio_pins_portE);

	GPIO_ResetBits(GPIOE, GPIO_Pin_9 | GPIO_Pin_11 | GPIO_Pin_13);
	GPIO_SetBits(GPIOE, GPIO_Pin_8 | GPIO_Pin_10 | GPIO_Pin_12);
}

void vSystemConfigureUart() {

	/* UART */
	GPIO_InitTypeDef uart_pins;

	/* Tx Rx */
	uart_pins.GPIO_Pin = GPIO_Pin_8 | GPIO_Pin_9;
	uart_pins.GPIO_Speed = GPIO_Speed_100MHz;
	uart_pins.GPIO_Mode = GPIO_Mode_AF;
	uart_pins.GPIO_PuPd = GPIO_PuPd_UP;
	uart_pins.GPIO_OType = GPIO_OType_OD;

	RCC_AHB1PeriphClockCmd(RCC_AHB1ENR_GPIODEN, ENABLE);
	RCC_APB1PeriphClockCmd(RCC_APB1Periph_USART3, ENABLE);

	GPIO_Init(GPIOD, &uart_pins);

	RCC_AHB1PeriphClockCmd(RCC_AHB1ENR_GPIOGEN, ENABLE);

	/* Die Pins auf UART umschalten*/
	GPIO_PinAFConfig(GPIOD, GPIO_PinSource8, GPIO_AF_USART3);
	GPIO_PinAFConfig(GPIOD, GPIO_PinSource9, GPIO_AF_USART3);

	USART_InitTypeDef usart2_init_struct;
	usart2_init_struct.USART_BaudRate = 115200;					// 115200
	usart2_init_struct.USART_WordLength = USART_WordLength_8b;
	usart2_init_struct.USART_StopBits = USART_StopBits_1;
	usart2_init_struct.USART_Parity = USART_Parity_No;
	usart2_init_struct.USART_Mode = USART_Mode_Rx | USART_Mode_Tx;
	usart2_init_struct.USART_HardwareFlowControl =
	USART_HardwareFlowControl_None;

	// UART freischalten
	USART_Cmd(USART3, ENABLE);
	USART_Init(USART3, &usart2_init_struct);

	// RXNE Interrupt erlauben
	USART_ITConfig(USART3, USART_IT_RXNE, ENABLE);

	// UART interrupt, damit vom PC aus die Frequenz verstellt werden kann
	NVIC_InitTypeDef NVIC_InitStruct;
	NVIC_InitStruct.NVIC_IRQChannel = USART3_IRQn;
	NVIC_InitStruct.NVIC_IRQChannelCmd = ENABLE;
	NVIC_InitStruct.NVIC_IRQChannelPreemptionPriority = 0;
	NVIC_InitStruct.NVIC_IRQChannelSubPriority = 1;
	NVIC_Init(&NVIC_InitStruct);
}

void vSystemConfigureMisc() {
	DBGMCU->APB1FZ |= DBGMCU_APB1_FZ_DBG_IWDG_STOP;
}

void vSystemSetTicktime(uint32_t ui32freq) {
	RCC_GetClocksFreq(&stcClockFrequencies);
	SysTick_Config(stcClockFrequencies.HCLK_Frequency/ui32freq);
}

void vSystemConfigureClocks() {
	// Enable External Crystal
	RCC_HSEConfig(RCC_HSE_ON);
	while (RCC_GetFlagStatus(RCC_FLAG_HSERDY) == RESET) {
	}

	// 100 MHz mit 8Mhz Quarz
	// • f(VCO clock) = f(PLL clock input) × (PLLN / PLLM)
	// • f(PLL general clock output) = f(VCO clock) / PLLP
	RCC_PLLConfig(RCC_PLLCFGR_PLLSRC_HSE, 2, 50, 2, 2);	//###RCC_PLLConfig(RCC_PLLCFGR_PLLSRC_HSE, PLLM, PLLN, PLLP, PLLQ2)
	RCC_PLLCmd(ENABLE);
	while (RCC_GetFlagStatus(RCC_FLAG_PLLRDY) == RESET) {}

	// Flash Konfiguration und Clocks müssen von dem Umsteigen auf PLL erstellt werden
	FLASH_DataCacheCmd(ENABLE);
	FLASH_InstructionCacheCmd(ENABLE);
	FLASH_PrefetchBufferCmd(ENABLE);
	FLASH_SetLatency(FLASH_Latency_3);

	RCC_HCLKConfig(RCC_SYSCLK_Div1);	// 100 Mhz
	RCC_PCLK1Config(RCC_HCLK_Div4);		// 25 Mhz
	RCC_PCLK2Config(RCC_HCLK_Div2);		// 50 Mhz

	// Ab hier SYSCLK 100 MHz
	RCC_SYSCLKConfig(RCC_SYSCLKSource_PLLCLK);

	SysTick_CLKSourceConfig(SysTick_CLKSource_HCLK_Div8);
	/*
	 //### MCO Output
	 RCC_AHB1PeriphClockCmd(RCC_AHB1ENR_GPIOAEN, ENABLE);

	 GPIO_InitTypeDef GPIO_InitStructure;
	 GPIO_InitStructure.GPIO_Pin = GPIO_Pin_8;
	 GPIO_InitStructure.GPIO_PuPd = GPIO_PuPd_UP;
	 GPIO_InitStructure.GPIO_Mode = GPIO_Mode_AF;
	 GPIO_InitStructure.GPIO_OType = GPIO_OType_PP;
	 GPIO_InitStructure.GPIO_Speed = GPIO_Speed_100MHz;

	 GPIO_Init(GPIOA, &GPIO_InitStructure);

	 //RCC_MCO1Config(RCC_MCO1Source_HSI, RCC_MCO1Div_1);		// Internal Clock
	 RCC_MCO1Config(RCC_MCO1Source_PLLCLK, RCC_MCO1Div_1);		// External Clock HSE

	 */
}

