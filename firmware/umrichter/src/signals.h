/*
 * signals.h
 *
 *  Created on: 26.11.2020
 *      Author: am
 */

#ifndef SIGNALS_H_
#define SIGNALS_H_

enum SIGNAL_STATE {
	SIGNAL_STATE_OFF = 0, SIGNAL_STATE_ON = 1, SIGNAL_STATE_FREQ = 2
};
enum MODES {
	MODE_HTL = 0, MODE_PWM16Khz = 1, MODE_PWM8Khz = 2, MODE_STOEBER = 3, MODE_PWM4Khz = 4, MODE_PWM2Khz = 8
};

enum UPDATE {
	UPDATE_NONE = 0,
	UPDATE_AMPOFF = 1,
	UPDATE_FREQ = 2,
	UPDATE_SHIFT = 4,
	UPDATE_ALL = 0x07

};

/*Configuration struct */
typedef struct {
	uint32_t ui32SignalFrequencyMaster;

	uint16_t ui16SignalAmplitudeU;
	uint16_t ui16SignalAmplitudeV;
	uint16_t ui16SignalAmplitudeW;

	uint16_t ui16SignalOffsetU;
	uint16_t ui16SignalOffsetV;
	uint16_t ui16SignalOffsetW;

	uint16_t ui16SignalShiftU;
	uint16_t ui16SignalShiftV;
	uint16_t ui16SignalShiftW;

	uint8_t ui8SignalStateU;
	uint8_t ui8SignalStateV;
	uint8_t ui8SignalStateW;

	uint8_t ui8SignalMode;
	uint8_t ui8Update;
} Configuration_t;

/*Runtime data used for */
typedef struct {
	uint16_t ui16ShiftU;
	uint16_t ui16ShiftV;
	uint16_t ui16ShiftW;

	uint16_t ui16BottomOffsetU;
	uint16_t ui16BottomOffsetV;
	uint16_t ui16BottomOffsetW;

	uint16_t ui16TableIndex;
	uint8_t ui8Mode;
	uint8_t ui8Duant;

} RuntimeData_t;

/* Exported functions*/
void vSetMode(uint8_t ui8Mode);
void vSetShifts(uint32_t ui32SignalShiftU, uint32_t ui32SignalShiftV,
		uint32_t ui32SignalShiftW);
void vSetFrequencies(uint32_t ui32SignalFrequencyMaster,
		uint8_t ui8SignalStateU, uint8_t ui8SignalStateV,
		uint8_t ui8SignalStateW);

void vSetAmplitudesAndOffsets(uint16_t ui16SignalAmplitudeU,
		uint16_t ui16SignalAmplitudeV, uint16_t ui16SignalAmplitudeW,
		uint16_t ui16SignalOffsetU, uint16_t ui16SignalOffsetV,
		uint16_t ui16SignalOffsetW);




#endif /* SIGNALS_H_ */
