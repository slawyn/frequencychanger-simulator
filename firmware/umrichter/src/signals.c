/*
 * signals.c
 *
 *  Created on: Jan 29, 2020
 *      Author: am
 */
#include "globals.h"

Configuration_t stcGlobalConfiguration;
RuntimeData_t stcGlobalRuntimeData;

void vSetShifts(uint32_t ui32SignalShiftU, uint32_t ui32SignalShiftV, uint32_t ui32SignalShiftW) {
	Configuration_t *pconfiguration = &stcGlobalConfiguration;

	pconfiguration->ui16SignalShiftU = ui32SignalShiftU;
	pconfiguration->ui16SignalShiftV = ui32SignalShiftV;
	pconfiguration->ui16SignalShiftW = ui32SignalShiftW;

	pconfiguration->ui8Update |= UPDATE_SHIFT;
}

/* Set Mode */
void vSetMode(uint8_t ui8Mode) {
	Configuration_t *pconfiguration = &stcGlobalConfiguration;

	if (ui8Mode != pconfiguration->ui8SignalMode) {
		pconfiguration->ui8SignalMode = ui8Mode;
		pconfiguration->ui8Update |= UPDATE_ALL;
	}
}

/* Set Frequency*/
void vSetFrequencies(uint32_t ui32SignalFrequencyMaster, uint8_t ui8SignalStateU, uint8_t ui8SignalStateV, uint8_t ui8SignalStateW) {
	Configuration_t *pconfiguration = &stcGlobalConfiguration;

	pconfiguration->ui32SignalFrequencyMaster = ui32SignalFrequencyMaster;
	pconfiguration->ui8SignalStateU = ui8SignalStateU;
	pconfiguration->ui8SignalStateV = ui8SignalStateV;
	pconfiguration->ui8SignalStateW = ui8SignalStateW;

	pconfiguration->ui8Update |= UPDATE_FREQ;
}

/* Set amplitudes and offsets */
void vSetAmplitudesAndOffsets(uint16_t ui16SignalAmplitudeU, uint16_t ui16SignalAmplitudeV, uint16_t ui16SignalAmplitudeW, uint16_t ui16SignalOffsetU, uint16_t ui16SignalOffsetV,
		uint16_t ui16SignalOffsetW) {
	Configuration_t *pconfiguration = &stcGlobalConfiguration;

	pconfiguration->ui16SignalOffsetU = ui16SignalOffsetU;
	pconfiguration->ui16SignalOffsetV = ui16SignalOffsetV;
	pconfiguration->ui16SignalOffsetW = ui16SignalOffsetW;

	pconfiguration->ui16SignalAmplitudeU = ui16SignalAmplitudeU;
	pconfiguration->ui16SignalAmplitudeV = ui16SignalAmplitudeV;
	pconfiguration->ui16SignalAmplitudeW = ui16SignalAmplitudeW;

	pconfiguration->ui8Update |= UPDATE_AMPOFF;

}

/* Old code
void vGenerateHtl(uint32_t ui32tick, uint8_t ui32subtype) {


	 // f�r Rechteck
	 static uint32_t ui32systick = 0;
	 static uint32_t ui32systick2 = 0;
	 static uint32_t ui32systick3 = 0;
	 static uint16_t ui16portstate = 0;
	 static uint32_t ui32cntold = 0;
	 static uint32_t ui32cnt = 0;
	 static uint32_t ui32t1 = 0;
	 static uint32_t ui32t2 = 0;
	 static uint32_t ui32phase_off2 = 0;
	 static uint32_t ui32phase_off3 = 0;
	 static uint32_t ui32temp = 0;

	 // 3 Phasen
	 if (ui32subtype == 0) {
	 // Frequenz wurde umgestellt
	 if (ui32PreviousFrequency != ui32ConfiguredFrequency) {
	 ui32cnt = (uint32_t) (dSquareSampleFrequency / ui32ConfiguredFrequency);	// Anzahl der ben�tigten Ticks
	 ui32t1 = 0;	// phase 1 einschalten
	 ui32t2 = ui32cnt / 2;
	 ui32phase_off2 = ui32cnt / 3;
	 ui32phase_off3 = ui32cnt * 2 / 3;

	 //GPIO_ResetBits(GPIOE,GPIO_Pin_8 | GPIO_Pin_9 | GPIO_Pin_10 | GPIO_Pin_11 | GPIO_Pin_12 | GPIO_Pin_13);
	 }

	 ui32PreviousFrequency = ui32ConfiguredFrequency;
	 ui32temp = ui32tick % (ui32cnt);

	 // Variante wo Rechtecke von den 3 Phasen jeweils um 120 zu einander versetzt sind
	 // zu dem jeweiligen Zeitpunkt nur ein mal �berpr�fen
	 if (ui32temp != ui32systick) {
	 ui32systick = ui32temp;

	 // Phase 1
	 if (ui32systick == ui32t1) {
	 SET(ui16portstate, GPIO_Pin_9);
	 RES(ui16portstate, GPIO_Pin_8);			// Phase 1 setzen

	 dWrtiePort(GPIOE, ui16portstate);
	 } else if (ui32systick == ui32t2) {
	 SET(ui16portstate, GPIO_Pin_8);		// Phase 1 zur�cksetzen
	 RES(ui16portstate, GPIO_Pin_9);
	 dWrtiePort(GPIOE, ui16portstate);
	 }

	 // Phase 2
	 ui32systick2 = (ui32systick + ui32phase_off2) % ui32cnt;	//offset
	 if (ui32systick2 == ui32t1) {
	 SET(ui16portstate, GPIO_Pin_11);		// Phase 2 setzen
	 RES(ui16portstate, GPIO_Pin_10);
	 dWrtiePort(GPIOE, ui16portstate);

	 } else if (ui32systick2 == ui32t2) {
	 SET(ui16portstate, GPIO_Pin_10);	// Phase 2 zur�cksetzen
	 RES(ui16portstate, GPIO_Pin_11);
	 dWrtiePort(GPIOE, ui16portstate);
	 }

	 // Phase 3
	 ui32systick3 = (ui32systick + ui32phase_off3) % ui32cnt;	//offset
	 if (ui32systick3 == ui32t1) {
	 SET(ui16portstate, GPIO_Pin_13);		// Phase 3 setzen
	 RES(ui16portstate, GPIO_Pin_12);
	 dWrtiePort(GPIOE, ui16portstate);

	 } else if (ui32systick3 == ui32t2) {
	 SET(ui16portstate, GPIO_Pin_12);	// Phase 3 zur�cksetzen
	 RES(ui16portstate, GPIO_Pin_13);
	 dWrtiePort(GPIOE, ui16portstate);

	 }

	 }

	 } else if (ui32subtype == 1) {
	 // Frequenz wurde umgestellt
	 if (ui32PreviousFrequency != ui32ConfiguredFrequency) {
	 ui32cnt = (uint32_t) (dSquareSampleFrequency / ui32ConfiguredFrequency);	// Anzahl der ben�tigten Ticks
	 ui32t1 = 0;	// phase 1 einschalten
	 ui32t2 = ui32cnt / 2;

	 //GPIO_ResetBits(GPIOE,GPIO_Pin_8 | GPIO_Pin_9 | GPIO_Pin_10 | GPIO_Pin_11 | GPIO_Pin_12 | GPIO_Pin_13);
	 }

	 ui32temp = ui32tick % (ui32cnt);

	 // Variante wo 2  Signale in gleicher Phase sind und L2 invertiert verl�uft.
	 // zu dem jeweiligen Zeitpunkt nur ein mal �berpr�fen
	 if (ui32temp != ui32systick) {
	 ui32systick = ui32temp;

	 // Phase 1
	 if (ui32systick == ui32t1) {
	 RES(ui16portstate, GPIO_Pin_8);							// Phase 1 setzen(L2)
	 SET(ui16portstate, GPIO_Pin_9);

	 SET(ui16portstate, GPIO_Pin_10);							// Phase 2 zur�cksetzen
	 RES(ui16portstate, GPIO_Pin_11);

	 SET(ui16portstate, GPIO_Pin_12);							// Phase 3 zur�cksetzen
	 RES(ui16portstate, GPIO_Pin_13);

	 dWrtiePort(GPIOE, ui16portstate);
	 } else if (ui32systick == ui32t2) {
	 SET(ui16portstate, GPIO_Pin_8);							// Phase 1 zur�cksetzen(L2)
	 RES(ui16portstate, GPIO_Pin_9);

	 SET(ui16portstate, GPIO_Pin_11);							// Phase 2 setzen
	 RES(ui16portstate, GPIO_Pin_10);

	 SET(ui16portstate, GPIO_Pin_13);							// Phase 3 setzen
	 RES(ui16portstate, GPIO_Pin_12);

	 dWrtiePort(GPIOE, ui16portstate);
	 }
	 }
	 }

}*/

