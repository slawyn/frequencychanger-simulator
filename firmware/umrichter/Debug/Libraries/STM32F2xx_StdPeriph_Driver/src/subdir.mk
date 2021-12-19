################################################################################
# Automatically-generated file. Do not edit!
# Toolchain: GNU Tools for STM32 (9-2020-q2-update)
################################################################################

# Add inputs and outputs from these tool invocations to the build variables 
C_SRCS += \
../Libraries/STM32F2xx_StdPeriph_Driver/src/misc.c \
../Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_adc.c \
../Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_can.c \
../Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_crc.c \
../Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_cryp.c \
../Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_cryp_aes.c \
../Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_cryp_des.c \
../Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_cryp_tdes.c \
../Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_dac.c \
../Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_dbgmcu.c \
../Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_dcmi.c \
../Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_dma.c \
../Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_exti.c \
../Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_flash.c \
../Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_fsmc.c \
../Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_gpio.c \
../Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_hash.c \
../Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_hash_md5.c \
../Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_hash_sha1.c \
../Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_i2c.c \
../Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_iwdg.c \
../Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_pwr.c \
../Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_rcc.c \
../Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_rng.c \
../Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_rtc.c \
../Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_sdio.c \
../Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_spi.c \
../Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_syscfg.c \
../Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_tim.c \
../Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_usart.c \
../Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_wwdg.c 

OBJS += \
./Libraries/STM32F2xx_StdPeriph_Driver/src/misc.o \
./Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_adc.o \
./Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_can.o \
./Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_crc.o \
./Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_cryp.o \
./Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_cryp_aes.o \
./Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_cryp_des.o \
./Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_cryp_tdes.o \
./Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_dac.o \
./Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_dbgmcu.o \
./Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_dcmi.o \
./Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_dma.o \
./Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_exti.o \
./Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_flash.o \
./Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_fsmc.o \
./Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_gpio.o \
./Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_hash.o \
./Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_hash_md5.o \
./Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_hash_sha1.o \
./Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_i2c.o \
./Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_iwdg.o \
./Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_pwr.o \
./Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_rcc.o \
./Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_rng.o \
./Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_rtc.o \
./Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_sdio.o \
./Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_spi.o \
./Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_syscfg.o \
./Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_tim.o \
./Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_usart.o \
./Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_wwdg.o 

C_DEPS += \
./Libraries/STM32F2xx_StdPeriph_Driver/src/misc.d \
./Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_adc.d \
./Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_can.d \
./Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_crc.d \
./Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_cryp.d \
./Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_cryp_aes.d \
./Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_cryp_des.d \
./Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_cryp_tdes.d \
./Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_dac.d \
./Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_dbgmcu.d \
./Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_dcmi.d \
./Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_dma.d \
./Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_exti.d \
./Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_flash.d \
./Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_fsmc.d \
./Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_gpio.d \
./Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_hash.d \
./Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_hash_md5.d \
./Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_hash_sha1.d \
./Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_i2c.d \
./Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_iwdg.d \
./Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_pwr.d \
./Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_rcc.d \
./Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_rng.d \
./Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_rtc.d \
./Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_sdio.d \
./Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_spi.d \
./Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_syscfg.d \
./Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_tim.d \
./Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_usart.d \
./Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_wwdg.d 


# Each subdirectory must supply rules for building sources it contributes
Libraries/STM32F2xx_StdPeriph_Driver/src/misc.o: ../Libraries/STM32F2xx_StdPeriph_Driver/src/misc.c Libraries/STM32F2xx_StdPeriph_Driver/src/subdir.mk
	arm-none-eabi-gcc "$<" -mcpu=cortex-m3 -std=gnu11 -g3 -DSTM32F2XX -DUSE_STDPERIPH_DRIVER '-DHSE_VALUE  =8000000' -c -I../src -I../Libraries/STM32F2xx_StdPeriph_Driver/inc -I../Libraries/CMSIS/Include -I../Libraries/CMSIS/Device/ST/STM32F2xx/Include -O0 -ffunction-sections -fdata-sections -Wall -fstack-usage -MMD -MP -MF"Libraries/STM32F2xx_StdPeriph_Driver/src/misc.d" -MT"$@" --specs=nano.specs -mfloat-abi=soft -mthumb -o "$@"
Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_adc.o: ../Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_adc.c Libraries/STM32F2xx_StdPeriph_Driver/src/subdir.mk
	arm-none-eabi-gcc "$<" -mcpu=cortex-m3 -std=gnu11 -g3 -DSTM32F2XX -DUSE_STDPERIPH_DRIVER '-DHSE_VALUE  =8000000' -c -I../src -I../Libraries/STM32F2xx_StdPeriph_Driver/inc -I../Libraries/CMSIS/Include -I../Libraries/CMSIS/Device/ST/STM32F2xx/Include -O0 -ffunction-sections -fdata-sections -Wall -fstack-usage -MMD -MP -MF"Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_adc.d" -MT"$@" --specs=nano.specs -mfloat-abi=soft -mthumb -o "$@"
Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_can.o: ../Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_can.c Libraries/STM32F2xx_StdPeriph_Driver/src/subdir.mk
	arm-none-eabi-gcc "$<" -mcpu=cortex-m3 -std=gnu11 -g3 -DSTM32F2XX -DUSE_STDPERIPH_DRIVER '-DHSE_VALUE  =8000000' -c -I../src -I../Libraries/STM32F2xx_StdPeriph_Driver/inc -I../Libraries/CMSIS/Include -I../Libraries/CMSIS/Device/ST/STM32F2xx/Include -O0 -ffunction-sections -fdata-sections -Wall -fstack-usage -MMD -MP -MF"Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_can.d" -MT"$@" --specs=nano.specs -mfloat-abi=soft -mthumb -o "$@"
Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_crc.o: ../Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_crc.c Libraries/STM32F2xx_StdPeriph_Driver/src/subdir.mk
	arm-none-eabi-gcc "$<" -mcpu=cortex-m3 -std=gnu11 -g3 -DSTM32F2XX -DUSE_STDPERIPH_DRIVER '-DHSE_VALUE  =8000000' -c -I../src -I../Libraries/STM32F2xx_StdPeriph_Driver/inc -I../Libraries/CMSIS/Include -I../Libraries/CMSIS/Device/ST/STM32F2xx/Include -O0 -ffunction-sections -fdata-sections -Wall -fstack-usage -MMD -MP -MF"Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_crc.d" -MT"$@" --specs=nano.specs -mfloat-abi=soft -mthumb -o "$@"
Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_cryp.o: ../Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_cryp.c Libraries/STM32F2xx_StdPeriph_Driver/src/subdir.mk
	arm-none-eabi-gcc "$<" -mcpu=cortex-m3 -std=gnu11 -g3 -DSTM32F2XX -DUSE_STDPERIPH_DRIVER '-DHSE_VALUE  =8000000' -c -I../src -I../Libraries/STM32F2xx_StdPeriph_Driver/inc -I../Libraries/CMSIS/Include -I../Libraries/CMSIS/Device/ST/STM32F2xx/Include -O0 -ffunction-sections -fdata-sections -Wall -fstack-usage -MMD -MP -MF"Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_cryp.d" -MT"$@" --specs=nano.specs -mfloat-abi=soft -mthumb -o "$@"
Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_cryp_aes.o: ../Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_cryp_aes.c Libraries/STM32F2xx_StdPeriph_Driver/src/subdir.mk
	arm-none-eabi-gcc "$<" -mcpu=cortex-m3 -std=gnu11 -g3 -DSTM32F2XX -DUSE_STDPERIPH_DRIVER '-DHSE_VALUE  =8000000' -c -I../src -I../Libraries/STM32F2xx_StdPeriph_Driver/inc -I../Libraries/CMSIS/Include -I../Libraries/CMSIS/Device/ST/STM32F2xx/Include -O0 -ffunction-sections -fdata-sections -Wall -fstack-usage -MMD -MP -MF"Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_cryp_aes.d" -MT"$@" --specs=nano.specs -mfloat-abi=soft -mthumb -o "$@"
Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_cryp_des.o: ../Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_cryp_des.c Libraries/STM32F2xx_StdPeriph_Driver/src/subdir.mk
	arm-none-eabi-gcc "$<" -mcpu=cortex-m3 -std=gnu11 -g3 -DSTM32F2XX -DUSE_STDPERIPH_DRIVER '-DHSE_VALUE  =8000000' -c -I../src -I../Libraries/STM32F2xx_StdPeriph_Driver/inc -I../Libraries/CMSIS/Include -I../Libraries/CMSIS/Device/ST/STM32F2xx/Include -O0 -ffunction-sections -fdata-sections -Wall -fstack-usage -MMD -MP -MF"Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_cryp_des.d" -MT"$@" --specs=nano.specs -mfloat-abi=soft -mthumb -o "$@"
Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_cryp_tdes.o: ../Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_cryp_tdes.c Libraries/STM32F2xx_StdPeriph_Driver/src/subdir.mk
	arm-none-eabi-gcc "$<" -mcpu=cortex-m3 -std=gnu11 -g3 -DSTM32F2XX -DUSE_STDPERIPH_DRIVER '-DHSE_VALUE  =8000000' -c -I../src -I../Libraries/STM32F2xx_StdPeriph_Driver/inc -I../Libraries/CMSIS/Include -I../Libraries/CMSIS/Device/ST/STM32F2xx/Include -O0 -ffunction-sections -fdata-sections -Wall -fstack-usage -MMD -MP -MF"Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_cryp_tdes.d" -MT"$@" --specs=nano.specs -mfloat-abi=soft -mthumb -o "$@"
Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_dac.o: ../Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_dac.c Libraries/STM32F2xx_StdPeriph_Driver/src/subdir.mk
	arm-none-eabi-gcc "$<" -mcpu=cortex-m3 -std=gnu11 -g3 -DSTM32F2XX -DUSE_STDPERIPH_DRIVER '-DHSE_VALUE  =8000000' -c -I../src -I../Libraries/STM32F2xx_StdPeriph_Driver/inc -I../Libraries/CMSIS/Include -I../Libraries/CMSIS/Device/ST/STM32F2xx/Include -O0 -ffunction-sections -fdata-sections -Wall -fstack-usage -MMD -MP -MF"Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_dac.d" -MT"$@" --specs=nano.specs -mfloat-abi=soft -mthumb -o "$@"
Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_dbgmcu.o: ../Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_dbgmcu.c Libraries/STM32F2xx_StdPeriph_Driver/src/subdir.mk
	arm-none-eabi-gcc "$<" -mcpu=cortex-m3 -std=gnu11 -g3 -DSTM32F2XX -DUSE_STDPERIPH_DRIVER '-DHSE_VALUE  =8000000' -c -I../src -I../Libraries/STM32F2xx_StdPeriph_Driver/inc -I../Libraries/CMSIS/Include -I../Libraries/CMSIS/Device/ST/STM32F2xx/Include -O0 -ffunction-sections -fdata-sections -Wall -fstack-usage -MMD -MP -MF"Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_dbgmcu.d" -MT"$@" --specs=nano.specs -mfloat-abi=soft -mthumb -o "$@"
Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_dcmi.o: ../Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_dcmi.c Libraries/STM32F2xx_StdPeriph_Driver/src/subdir.mk
	arm-none-eabi-gcc "$<" -mcpu=cortex-m3 -std=gnu11 -g3 -DSTM32F2XX -DUSE_STDPERIPH_DRIVER '-DHSE_VALUE  =8000000' -c -I../src -I../Libraries/STM32F2xx_StdPeriph_Driver/inc -I../Libraries/CMSIS/Include -I../Libraries/CMSIS/Device/ST/STM32F2xx/Include -O0 -ffunction-sections -fdata-sections -Wall -fstack-usage -MMD -MP -MF"Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_dcmi.d" -MT"$@" --specs=nano.specs -mfloat-abi=soft -mthumb -o "$@"
Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_dma.o: ../Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_dma.c Libraries/STM32F2xx_StdPeriph_Driver/src/subdir.mk
	arm-none-eabi-gcc "$<" -mcpu=cortex-m3 -std=gnu11 -g3 -DSTM32F2XX -DUSE_STDPERIPH_DRIVER '-DHSE_VALUE  =8000000' -c -I../src -I../Libraries/STM32F2xx_StdPeriph_Driver/inc -I../Libraries/CMSIS/Include -I../Libraries/CMSIS/Device/ST/STM32F2xx/Include -O0 -ffunction-sections -fdata-sections -Wall -fstack-usage -MMD -MP -MF"Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_dma.d" -MT"$@" --specs=nano.specs -mfloat-abi=soft -mthumb -o "$@"
Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_exti.o: ../Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_exti.c Libraries/STM32F2xx_StdPeriph_Driver/src/subdir.mk
	arm-none-eabi-gcc "$<" -mcpu=cortex-m3 -std=gnu11 -g3 -DSTM32F2XX -DUSE_STDPERIPH_DRIVER '-DHSE_VALUE  =8000000' -c -I../src -I../Libraries/STM32F2xx_StdPeriph_Driver/inc -I../Libraries/CMSIS/Include -I../Libraries/CMSIS/Device/ST/STM32F2xx/Include -O0 -ffunction-sections -fdata-sections -Wall -fstack-usage -MMD -MP -MF"Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_exti.d" -MT"$@" --specs=nano.specs -mfloat-abi=soft -mthumb -o "$@"
Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_flash.o: ../Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_flash.c Libraries/STM32F2xx_StdPeriph_Driver/src/subdir.mk
	arm-none-eabi-gcc "$<" -mcpu=cortex-m3 -std=gnu11 -g3 -DSTM32F2XX -DUSE_STDPERIPH_DRIVER '-DHSE_VALUE  =8000000' -c -I../src -I../Libraries/STM32F2xx_StdPeriph_Driver/inc -I../Libraries/CMSIS/Include -I../Libraries/CMSIS/Device/ST/STM32F2xx/Include -O0 -ffunction-sections -fdata-sections -Wall -fstack-usage -MMD -MP -MF"Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_flash.d" -MT"$@" --specs=nano.specs -mfloat-abi=soft -mthumb -o "$@"
Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_fsmc.o: ../Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_fsmc.c Libraries/STM32F2xx_StdPeriph_Driver/src/subdir.mk
	arm-none-eabi-gcc "$<" -mcpu=cortex-m3 -std=gnu11 -g3 -DSTM32F2XX -DUSE_STDPERIPH_DRIVER '-DHSE_VALUE  =8000000' -c -I../src -I../Libraries/STM32F2xx_StdPeriph_Driver/inc -I../Libraries/CMSIS/Include -I../Libraries/CMSIS/Device/ST/STM32F2xx/Include -O0 -ffunction-sections -fdata-sections -Wall -fstack-usage -MMD -MP -MF"Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_fsmc.d" -MT"$@" --specs=nano.specs -mfloat-abi=soft -mthumb -o "$@"
Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_gpio.o: ../Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_gpio.c Libraries/STM32F2xx_StdPeriph_Driver/src/subdir.mk
	arm-none-eabi-gcc "$<" -mcpu=cortex-m3 -std=gnu11 -g3 -DSTM32F2XX -DUSE_STDPERIPH_DRIVER '-DHSE_VALUE  =8000000' -c -I../src -I../Libraries/STM32F2xx_StdPeriph_Driver/inc -I../Libraries/CMSIS/Include -I../Libraries/CMSIS/Device/ST/STM32F2xx/Include -O0 -ffunction-sections -fdata-sections -Wall -fstack-usage -MMD -MP -MF"Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_gpio.d" -MT"$@" --specs=nano.specs -mfloat-abi=soft -mthumb -o "$@"
Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_hash.o: ../Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_hash.c Libraries/STM32F2xx_StdPeriph_Driver/src/subdir.mk
	arm-none-eabi-gcc "$<" -mcpu=cortex-m3 -std=gnu11 -g3 -DSTM32F2XX -DUSE_STDPERIPH_DRIVER '-DHSE_VALUE  =8000000' -c -I../src -I../Libraries/STM32F2xx_StdPeriph_Driver/inc -I../Libraries/CMSIS/Include -I../Libraries/CMSIS/Device/ST/STM32F2xx/Include -O0 -ffunction-sections -fdata-sections -Wall -fstack-usage -MMD -MP -MF"Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_hash.d" -MT"$@" --specs=nano.specs -mfloat-abi=soft -mthumb -o "$@"
Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_hash_md5.o: ../Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_hash_md5.c Libraries/STM32F2xx_StdPeriph_Driver/src/subdir.mk
	arm-none-eabi-gcc "$<" -mcpu=cortex-m3 -std=gnu11 -g3 -DSTM32F2XX -DUSE_STDPERIPH_DRIVER '-DHSE_VALUE  =8000000' -c -I../src -I../Libraries/STM32F2xx_StdPeriph_Driver/inc -I../Libraries/CMSIS/Include -I../Libraries/CMSIS/Device/ST/STM32F2xx/Include -O0 -ffunction-sections -fdata-sections -Wall -fstack-usage -MMD -MP -MF"Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_hash_md5.d" -MT"$@" --specs=nano.specs -mfloat-abi=soft -mthumb -o "$@"
Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_hash_sha1.o: ../Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_hash_sha1.c Libraries/STM32F2xx_StdPeriph_Driver/src/subdir.mk
	arm-none-eabi-gcc "$<" -mcpu=cortex-m3 -std=gnu11 -g3 -DSTM32F2XX -DUSE_STDPERIPH_DRIVER '-DHSE_VALUE  =8000000' -c -I../src -I../Libraries/STM32F2xx_StdPeriph_Driver/inc -I../Libraries/CMSIS/Include -I../Libraries/CMSIS/Device/ST/STM32F2xx/Include -O0 -ffunction-sections -fdata-sections -Wall -fstack-usage -MMD -MP -MF"Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_hash_sha1.d" -MT"$@" --specs=nano.specs -mfloat-abi=soft -mthumb -o "$@"
Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_i2c.o: ../Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_i2c.c Libraries/STM32F2xx_StdPeriph_Driver/src/subdir.mk
	arm-none-eabi-gcc "$<" -mcpu=cortex-m3 -std=gnu11 -g3 -DSTM32F2XX -DUSE_STDPERIPH_DRIVER '-DHSE_VALUE  =8000000' -c -I../src -I../Libraries/STM32F2xx_StdPeriph_Driver/inc -I../Libraries/CMSIS/Include -I../Libraries/CMSIS/Device/ST/STM32F2xx/Include -O0 -ffunction-sections -fdata-sections -Wall -fstack-usage -MMD -MP -MF"Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_i2c.d" -MT"$@" --specs=nano.specs -mfloat-abi=soft -mthumb -o "$@"
Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_iwdg.o: ../Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_iwdg.c Libraries/STM32F2xx_StdPeriph_Driver/src/subdir.mk
	arm-none-eabi-gcc "$<" -mcpu=cortex-m3 -std=gnu11 -g3 -DSTM32F2XX -DUSE_STDPERIPH_DRIVER '-DHSE_VALUE  =8000000' -c -I../src -I../Libraries/STM32F2xx_StdPeriph_Driver/inc -I../Libraries/CMSIS/Include -I../Libraries/CMSIS/Device/ST/STM32F2xx/Include -O0 -ffunction-sections -fdata-sections -Wall -fstack-usage -MMD -MP -MF"Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_iwdg.d" -MT"$@" --specs=nano.specs -mfloat-abi=soft -mthumb -o "$@"
Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_pwr.o: ../Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_pwr.c Libraries/STM32F2xx_StdPeriph_Driver/src/subdir.mk
	arm-none-eabi-gcc "$<" -mcpu=cortex-m3 -std=gnu11 -g3 -DSTM32F2XX -DUSE_STDPERIPH_DRIVER '-DHSE_VALUE  =8000000' -c -I../src -I../Libraries/STM32F2xx_StdPeriph_Driver/inc -I../Libraries/CMSIS/Include -I../Libraries/CMSIS/Device/ST/STM32F2xx/Include -O0 -ffunction-sections -fdata-sections -Wall -fstack-usage -MMD -MP -MF"Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_pwr.d" -MT"$@" --specs=nano.specs -mfloat-abi=soft -mthumb -o "$@"
Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_rcc.o: ../Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_rcc.c Libraries/STM32F2xx_StdPeriph_Driver/src/subdir.mk
	arm-none-eabi-gcc "$<" -mcpu=cortex-m3 -std=gnu11 -g3 -DSTM32F2XX -DUSE_STDPERIPH_DRIVER '-DHSE_VALUE  =8000000' -c -I../src -I../Libraries/STM32F2xx_StdPeriph_Driver/inc -I../Libraries/CMSIS/Include -I../Libraries/CMSIS/Device/ST/STM32F2xx/Include -O0 -ffunction-sections -fdata-sections -Wall -fstack-usage -MMD -MP -MF"Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_rcc.d" -MT"$@" --specs=nano.specs -mfloat-abi=soft -mthumb -o "$@"
Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_rng.o: ../Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_rng.c Libraries/STM32F2xx_StdPeriph_Driver/src/subdir.mk
	arm-none-eabi-gcc "$<" -mcpu=cortex-m3 -std=gnu11 -g3 -DSTM32F2XX -DUSE_STDPERIPH_DRIVER '-DHSE_VALUE  =8000000' -c -I../src -I../Libraries/STM32F2xx_StdPeriph_Driver/inc -I../Libraries/CMSIS/Include -I../Libraries/CMSIS/Device/ST/STM32F2xx/Include -O0 -ffunction-sections -fdata-sections -Wall -fstack-usage -MMD -MP -MF"Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_rng.d" -MT"$@" --specs=nano.specs -mfloat-abi=soft -mthumb -o "$@"
Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_rtc.o: ../Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_rtc.c Libraries/STM32F2xx_StdPeriph_Driver/src/subdir.mk
	arm-none-eabi-gcc "$<" -mcpu=cortex-m3 -std=gnu11 -g3 -DSTM32F2XX -DUSE_STDPERIPH_DRIVER '-DHSE_VALUE  =8000000' -c -I../src -I../Libraries/STM32F2xx_StdPeriph_Driver/inc -I../Libraries/CMSIS/Include -I../Libraries/CMSIS/Device/ST/STM32F2xx/Include -O0 -ffunction-sections -fdata-sections -Wall -fstack-usage -MMD -MP -MF"Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_rtc.d" -MT"$@" --specs=nano.specs -mfloat-abi=soft -mthumb -o "$@"
Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_sdio.o: ../Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_sdio.c Libraries/STM32F2xx_StdPeriph_Driver/src/subdir.mk
	arm-none-eabi-gcc "$<" -mcpu=cortex-m3 -std=gnu11 -g3 -DSTM32F2XX -DUSE_STDPERIPH_DRIVER '-DHSE_VALUE  =8000000' -c -I../src -I../Libraries/STM32F2xx_StdPeriph_Driver/inc -I../Libraries/CMSIS/Include -I../Libraries/CMSIS/Device/ST/STM32F2xx/Include -O0 -ffunction-sections -fdata-sections -Wall -fstack-usage -MMD -MP -MF"Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_sdio.d" -MT"$@" --specs=nano.specs -mfloat-abi=soft -mthumb -o "$@"
Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_spi.o: ../Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_spi.c Libraries/STM32F2xx_StdPeriph_Driver/src/subdir.mk
	arm-none-eabi-gcc "$<" -mcpu=cortex-m3 -std=gnu11 -g3 -DSTM32F2XX -DUSE_STDPERIPH_DRIVER '-DHSE_VALUE  =8000000' -c -I../src -I../Libraries/STM32F2xx_StdPeriph_Driver/inc -I../Libraries/CMSIS/Include -I../Libraries/CMSIS/Device/ST/STM32F2xx/Include -O0 -ffunction-sections -fdata-sections -Wall -fstack-usage -MMD -MP -MF"Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_spi.d" -MT"$@" --specs=nano.specs -mfloat-abi=soft -mthumb -o "$@"
Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_syscfg.o: ../Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_syscfg.c Libraries/STM32F2xx_StdPeriph_Driver/src/subdir.mk
	arm-none-eabi-gcc "$<" -mcpu=cortex-m3 -std=gnu11 -g3 -DSTM32F2XX -DUSE_STDPERIPH_DRIVER '-DHSE_VALUE  =8000000' -c -I../src -I../Libraries/STM32F2xx_StdPeriph_Driver/inc -I../Libraries/CMSIS/Include -I../Libraries/CMSIS/Device/ST/STM32F2xx/Include -O0 -ffunction-sections -fdata-sections -Wall -fstack-usage -MMD -MP -MF"Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_syscfg.d" -MT"$@" --specs=nano.specs -mfloat-abi=soft -mthumb -o "$@"
Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_tim.o: ../Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_tim.c Libraries/STM32F2xx_StdPeriph_Driver/src/subdir.mk
	arm-none-eabi-gcc "$<" -mcpu=cortex-m3 -std=gnu11 -g3 -DSTM32F2XX -DUSE_STDPERIPH_DRIVER '-DHSE_VALUE  =8000000' -c -I../src -I../Libraries/STM32F2xx_StdPeriph_Driver/inc -I../Libraries/CMSIS/Include -I../Libraries/CMSIS/Device/ST/STM32F2xx/Include -O0 -ffunction-sections -fdata-sections -Wall -fstack-usage -MMD -MP -MF"Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_tim.d" -MT"$@" --specs=nano.specs -mfloat-abi=soft -mthumb -o "$@"
Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_usart.o: ../Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_usart.c Libraries/STM32F2xx_StdPeriph_Driver/src/subdir.mk
	arm-none-eabi-gcc "$<" -mcpu=cortex-m3 -std=gnu11 -g3 -DSTM32F2XX -DUSE_STDPERIPH_DRIVER '-DHSE_VALUE  =8000000' -c -I../src -I../Libraries/STM32F2xx_StdPeriph_Driver/inc -I../Libraries/CMSIS/Include -I../Libraries/CMSIS/Device/ST/STM32F2xx/Include -O0 -ffunction-sections -fdata-sections -Wall -fstack-usage -MMD -MP -MF"Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_usart.d" -MT"$@" --specs=nano.specs -mfloat-abi=soft -mthumb -o "$@"
Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_wwdg.o: ../Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_wwdg.c Libraries/STM32F2xx_StdPeriph_Driver/src/subdir.mk
	arm-none-eabi-gcc "$<" -mcpu=cortex-m3 -std=gnu11 -g3 -DSTM32F2XX -DUSE_STDPERIPH_DRIVER '-DHSE_VALUE  =8000000' -c -I../src -I../Libraries/STM32F2xx_StdPeriph_Driver/inc -I../Libraries/CMSIS/Include -I../Libraries/CMSIS/Device/ST/STM32F2xx/Include -O0 -ffunction-sections -fdata-sections -Wall -fstack-usage -MMD -MP -MF"Libraries/STM32F2xx_StdPeriph_Driver/src/stm32f2xx_wwdg.d" -MT"$@" --specs=nano.specs -mfloat-abi=soft -mthumb -o "$@"

