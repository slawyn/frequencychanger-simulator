################################################################################
# Automatically-generated file. Do not edit!
# Toolchain: GNU Tools for STM32 (9-2020-q2-update)
################################################################################

# Add inputs and outputs from these tool invocations to the build variables 
S_SRCS += \
../src/startup_stm32f2xx.s 

C_SRCS += \
../src/heap.c \
../src/main.c \
../src/signals.c \
../src/stm32f2xx_it.c \
../src/system.c \
../src/transfer-queue.c 

OBJS += \
./src/heap.o \
./src/main.o \
./src/signals.o \
./src/startup_stm32f2xx.o \
./src/stm32f2xx_it.o \
./src/system.o \
./src/transfer-queue.o 

S_DEPS += \
./src/startup_stm32f2xx.d 

C_DEPS += \
./src/heap.d \
./src/main.d \
./src/signals.d \
./src/stm32f2xx_it.d \
./src/system.d \
./src/transfer-queue.d 


# Each subdirectory must supply rules for building sources it contributes
src/heap.o: ../src/heap.c src/subdir.mk
	arm-none-eabi-gcc "$<" -mcpu=cortex-m3 -std=gnu11 -g3 -DSTM32F2XX -DUSE_STDPERIPH_DRIVER '-DHSE_VALUE  =8000000' -c -I../src -I../Libraries/STM32F2xx_StdPeriph_Driver/inc -I../Libraries/CMSIS/Include -I../Libraries/CMSIS/Device/ST/STM32F2xx/Include -O0 -ffunction-sections -fdata-sections -Wall -fstack-usage -MMD -MP -MF"src/heap.d" -MT"$@" --specs=nano.specs -mfloat-abi=soft -mthumb -o "$@"
src/main.o: ../src/main.c src/subdir.mk
	arm-none-eabi-gcc "$<" -mcpu=cortex-m3 -std=gnu11 -g3 -DSTM32F2XX -DUSE_STDPERIPH_DRIVER '-DHSE_VALUE  =8000000' -c -I../src -I../Libraries/STM32F2xx_StdPeriph_Driver/inc -I../Libraries/CMSIS/Include -I../Libraries/CMSIS/Device/ST/STM32F2xx/Include -O0 -ffunction-sections -fdata-sections -Wall -fstack-usage -MMD -MP -MF"src/main.d" -MT"$@" --specs=nano.specs -mfloat-abi=soft -mthumb -o "$@"
src/signals.o: ../src/signals.c src/subdir.mk
	arm-none-eabi-gcc "$<" -mcpu=cortex-m3 -std=gnu11 -g3 -DSTM32F2XX -DUSE_STDPERIPH_DRIVER '-DHSE_VALUE  =8000000' -c -I../src -I../Libraries/STM32F2xx_StdPeriph_Driver/inc -I../Libraries/CMSIS/Include -I../Libraries/CMSIS/Device/ST/STM32F2xx/Include -O0 -ffunction-sections -fdata-sections -Wall -fstack-usage -MMD -MP -MF"src/signals.d" -MT"$@" --specs=nano.specs -mfloat-abi=soft -mthumb -o "$@"
src/startup_stm32f2xx.o: ../src/startup_stm32f2xx.s src/subdir.mk
	arm-none-eabi-gcc -mcpu=cortex-m3 -g3 -DSTM32F2XX -DUSE_STDPERIPH_DRIVER -c -I../src -I../Libraries/STM32F2xx_StdPeriph_Driver/inc -I../Libraries/CMSIS/Include -I../Libraries/CMSIS/Device/ST/STM32F2xx/Include -x assembler-with-cpp -MMD -MP -MF"src/startup_stm32f2xx.d" -MT"$@" --specs=nano.specs -mfloat-abi=soft -mthumb -o "$@" "$<"
src/stm32f2xx_it.o: ../src/stm32f2xx_it.c src/subdir.mk
	arm-none-eabi-gcc "$<" -mcpu=cortex-m3 -std=gnu11 -g3 -DSTM32F2XX -DUSE_STDPERIPH_DRIVER '-DHSE_VALUE  =8000000' -c -I../src -I../Libraries/STM32F2xx_StdPeriph_Driver/inc -I../Libraries/CMSIS/Include -I../Libraries/CMSIS/Device/ST/STM32F2xx/Include -O0 -ffunction-sections -fdata-sections -Wall -fstack-usage -MMD -MP -MF"src/stm32f2xx_it.d" -MT"$@" --specs=nano.specs -mfloat-abi=soft -mthumb -o "$@"
src/system.o: ../src/system.c src/subdir.mk
	arm-none-eabi-gcc "$<" -mcpu=cortex-m3 -std=gnu11 -g3 -DSTM32F2XX -DUSE_STDPERIPH_DRIVER '-DHSE_VALUE  =8000000' -c -I../src -I../Libraries/STM32F2xx_StdPeriph_Driver/inc -I../Libraries/CMSIS/Include -I../Libraries/CMSIS/Device/ST/STM32F2xx/Include -O0 -ffunction-sections -fdata-sections -Wall -fstack-usage -MMD -MP -MF"src/system.d" -MT"$@" --specs=nano.specs -mfloat-abi=soft -mthumb -o "$@"
src/transfer-queue.o: ../src/transfer-queue.c src/subdir.mk
	arm-none-eabi-gcc "$<" -mcpu=cortex-m3 -std=gnu11 -g3 -DSTM32F2XX -DUSE_STDPERIPH_DRIVER '-DHSE_VALUE  =8000000' -c -I../src -I../Libraries/STM32F2xx_StdPeriph_Driver/inc -I../Libraries/CMSIS/Include -I../Libraries/CMSIS/Device/ST/STM32F2xx/Include -O0 -ffunction-sections -fdata-sections -Wall -fstack-usage -MMD -MP -MF"src/transfer-queue.d" -MT"$@" --specs=nano.specs -mfloat-abi=soft -mthumb -o "$@"

