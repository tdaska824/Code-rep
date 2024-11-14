/* USER CODE BEGIN Header */
/**
  ******************************************************************************
  * @file           : main.c
  * @brief          : Main program body
  ******************************************************************************
  * @attention
  *
  * Copyright (c) 2024 STMicroelectronics.
  * All rights reserved.
  *
  * This software is licensed under terms that can be found in the LICENSE file
  * in the root directory of this software component.
  * If no LICENSE file comes with this software, it is provided AS-IS.
  *
  ******************************************************************************
  */
/* USER CODE END Header */
/* Includes ------------------------------------------------------------------*/
#include "main.h"

/* Private includes ----------------------------------------------------------*/
/* USER CODE BEGIN Includes */
#include "string.h"
#include "stdio.h"
#include <stdlib.h>

/* USER CODE END Includes */

/* Private typedef -----------------------------------------------------------*/
/* USER CODE BEGIN PTD */

/* USER CODE END PTD */

/* Private define ------------------------------------------------------------*/
/* USER CODE BEGIN PD */
/* USER CODE END PD */

/* Private macro -------------------------------------------------------------*/
/* USER CODE BEGIN PM */

/* USER CODE END PM */

/* Private variables ---------------------------------------------------------*/
CAN_HandleTypeDef hcan1;
CAN_HandleTypeDef hcan2;

UART_HandleTypeDef huart1;

/* USER CODE BEGIN PV */

/* USER CODE END PV */

/* Private function prototypes -----------------------------------------------*/
void SystemClock_Config(void);
static void MX_GPIO_Init(void);
static void MX_CAN1_Init(void);
static void MX_CAN2_Init(void);
static void MX_USART1_UART_Init(void);
/* USER CODE BEGIN PFP */

/* USER CODE END PFP */

/* Private user code ---------------------------------------------------------*/
/* USER CODE BEGIN 0 */
CAN_TxHeaderTypeDef TxHeader;
CAN_RxHeaderTypeDef RxHeader;

uint8_t TxData[8];
uint8_t RxData[8];

uint32_t TxMailbox;

#define ET_THRESHOLD 125;
#define CHASSIS_TEMP_THRESHOLD 75;
#define OP_THRESHOLD 200;


uint8_t TPS, TPS1, RPM, RPM1, MAP, MAP1, IAT, IAT1, FP, FP1, IGT, IGT1, IGT2, OP, OP1, ET, OT, Lambda, Gear, LapTime, LapTime1, FU, FU1,FrontBrakePress, FrontBrakePress1, RearBrakePress, RearBrakePress1;
int RearBrakePress2, FrontBrakePress2, TPS2, OP2, RPM2, BatV, MAP2, IAT2, FP2, Speed, LapTime2, FU2,InnerFLIR,InnerFRIR,InnerRRIR,InnerRLIR,CenterFRIR,CenterRRIR,CenterFLIR,CenterRLIR,OuterFRIR,OuterRRIR,OuterFLIR,OuterRLIR,CHASSIS_TEMP;
//char msg[] = "~,Time/1000,RPM,EngineTemp,OilTemp,OilPress/10,Batt/10,MAP/10,Fuel Press/10,Lambda/10,TPS/10,ChassisTemp,Gear,FrontBrakePress,RearBrakePress,`";

char msg[] = "~,Time/1000,RPM,OilPress/10,Batt/10,MAP/10,TPS/10,Fuel Press/10,Lambda/100,Speed,Gear,`";
char msg2[] = "$,Time/1000,EngineTemp,OilTemp,AirTemp/10,ChassisTemp,InnerFRIR,CenterFRIR,OuterFRIR,InnerFLIR,CenterFLIR,OuterFLIR,InnerRRIR,CenterRRIR,OuterRRIR,InnerRLIR,CenterRLIR,OuterRLIR,FuelUsed,#";
char text[256],text2[256];
char data[1] = "";
long previousMillis;
int interval =100;

int datacheck = 0,secondmessagesent=1;

long BitShiftCombine(uint8_t xhigh, uint8_t xlow) {
	long combined;
	combined = xhigh;
	combined = combined << 8;
	combined |= xlow;
	return combined;
}

void HAL_CAN_RxFifo0MsgPendingCallback(CAN_HandleTypeDef *hcan){
	HAL_CAN_GetRxMessage(hcan, CAN_RX_FIFO0, &RxHeader, RxData);
		if (RxHeader.StdId == 1600) {
			RPM = RxData[0];
			RPM1 = RxData[1];
			RPM2 = BitShiftCombine(RPM, RPM1);
			MAP = RxData[2];
			MAP1 = RxData[3];
			MAP2 = BitShiftCombine(MAP, MAP1);
			IAT = RxData[4];
			IAT1 = RxData[5];
			IAT2 = BitShiftCombine(IAT, IAT1);
			TPS = RxData[6];
			TPS1 = RxData[7];
			TPS2 = BitShiftCombine(TPS, TPS1);
		}
		if (RxHeader.StdId == 1601) // η τιμή π�?οέ�?χεται από το εγκέφαλο
				{
			FP = RxData[4];
			FP1 = RxData[5];
			FP2 = BitShiftCombine(FP, FP1);  //FUEL PRESS
		}
		if (RxHeader.StdId == 1602) // η τιμή π�?οέ�?χεται από το εγκέφαλο
				{
			IGT = RxData[4];
			IGT1 = RxData[5];
			IGT2 = BitShiftCombine(IGT, IGT1);  //IGNITION TIMING

		}
		if (RxHeader.StdId == 1604) // η τιμή π�?οέ�?χεται από το εγκέφαλο
				{
			OP = RxData[6];
			OP1 = RxData[7];
			OP2 = BitShiftCombine(OP, OP1);    //OIL PRESS
		}
//		if (RxHeader.StdId == 1608) // η τιμή π�?οέ�?χεται από το εγκέφαλο
//				{
//			FU = RxData[6];
//			FU1 = RxData[7];
//			FU2 = BitShiftCombine(FU, FU1);    //OIL PRESS
//		}

		if (RxHeader.StdId == 1609) // η τιμή π�?οέ�?χεται από το εγκέφαλο
				{
			BatV = RxData[5];
			OT = RxData[1] - 40; //OIL TEMP , offset 40, π�?οκ�?πτει από τον motec
			ET = RxData[0] - 40; //COOLANT TEMP

			FU = RxData[6];
			FU1 = RxData[7];
			FU2 = BitShiftCombine(FU, FU1);    //Fuel Used

		}
		if (RxHeader.StdId == 1617) // η τιμή π�?οέ�?χεται από το εγκέφαλο
				{
			Lambda = RxData[0]; // LAMBDA, measure the amount of air and fuel on the car exhaust
		}
		if (RxHeader.StdId == 1888) // το ID π�?οκ�?πτει από την πλακέτα του quick shift
				{
			 // κιβώτιο ταχυτήτων
		}
		if (RxHeader.StdId == 17) // από logger
				{
			LapTime = RxData[4];
			LapTime1 = RxData[5];
			LapTime2 = BitShiftCombine(LapTime, LapTime1);    //Lap time
		}
		if( RxHeader.StdId == 1381 ){
			Gear = RxData[0];
		}
		if(RxHeader.StdId ==1929){
			InnerFRIR = RxData[0];
			CenterFRIR = RxData[1];
			OuterFRIR = RxData[2];
		}
		if(RxHeader.StdId ==1936){
			InnerFLIR = RxData[0];
			CenterFLIR = RxData[1];
			OuterFLIR = RxData[2];
		}
		if(RxHeader.StdId ==1937){
			InnerRRIR = RxData[0];
			CenterRRIR = RxData[1];
			OuterRRIR = RxData[2];
		}
		if(RxHeader.StdId ==1938){
			InnerRLIR = RxData[0];
			CenterRLIR = RxData[1];
			OuterRLIR = RxData[2];
		}
		if (RxHeader.StdId == 1889) // η τιμή π�?οέ�?χεται από το εγκέφαλο
				{
			CHASSIS_TEMP=RxData[0];
		}
		if (RxHeader.StdId == 1874) // η τιμή π�?οέ�?χεται από το εγκέφαλο
				{
			FrontBrakePress=RxData[0];
			FrontBrakePress1=RxData[1];
			FrontBrakePress2=BitShiftCombine(FrontBrakePress, FrontBrakePress1);

			RearBrakePress=RxData[2];
			RearBrakePress1=RxData[3];
			RearBrakePress2=BitShiftCombine(RearBrakePress, RearBrakePress1);

		}

 }

/* USER CODE END 0 */

/**
  * @brief  The application entry point.
  * @retval int
  */
int main(void)
{
  /* USER CODE BEGIN 1 */

  /* USER CODE END 1 */

  /* MCU Configuration--------------------------------------------------------*/

  /* Reset of all peripherals, Initializes the Flash interface and the Systick. */
  HAL_Init();

  /* USER CODE BEGIN Init */

  /* USER CODE END Init */

  /* Configure the system clock */
  SystemClock_Config();

  /* USER CODE BEGIN SysInit */

  /* USER CODE END SysInit */

  /* Initialize all configured peripherals */
  MX_GPIO_Init();
  MX_CAN1_Init();
  MX_CAN2_Init();
  MX_USART1_UART_Init();
  /* USER CODE BEGIN 2 */
  HAL_UART_Receive_IT(&huart1, (uint8_t*) data, 1);

  /* USER CODE END 2 */

  /* Infinite loop */
  /* USER CODE BEGIN WHILE */
  while (1)
  {
    /* USER CODE END WHILE */

    /* USER CODE BEGIN 3 */
//	  if(HAL_GetTick()-previousMillis>6000){
//		  previousMillis=HAL_GetTick();
//		  sprintf(text, "$,%lu,%d,%d,%d,%d,%d,%d,%d,%d,%d,%d,%d,%d,%d,%d,%d,%d,#",HAL_GetTick(),ET, OT, IAT2, CHASSIS_TEMP, InnerFRIR, CenterFRIR, OuterFRIR, InnerFLIR, CenterFLIR, OuterFLIR, InnerRRIR, CenterRRIR, OuterRRIR, InnerRLIR, CenterRLIR, OuterRLIR);
//		  secondmessagesent=0;
//	  }
//	  else if(secondmessagesent>=10){
//		  sprintf(text, "~,%lu,%d,%d,%d,%d,%d,%d,%d,%d,%d,`", HAL_GetTick(), RPM2, OP2, BatV, MAP2, TPS2, FP2, Lambda, Speed, Gear);
//	  }
    if (ET>ET_THRESHOLD){
      sprintf(text2, "$,%lu,"\033[0;31m%d\033[0m",%d,%d,%d,%d,%d,%d,%d,%d,%d,%d,%d,%d,%d,%d,%d,%d,#",HAL_GetTick(),ET, OT, IAT2, CHASSIS_TEMP, InnerFRIR, CenterFRIR, OuterFRIR, InnerFLIR, CenterFLIR, OuterFLIR, InnerRRIR, CenterRRIR, OuterRRIR, InnerRLIR, CenterRLIR, OuterRLIR, FU2);
	    sprintf(text, "~,%lu,%d,%d,%d,%d,%d,%d,%d,%d,%d,`", HAL_GetTick(), RPM2, OP2, BatV, MAP2, TPS2, FP2, Lambda, Speed, Gear);

    }
    if (OP<OP_THRESHOLD){
	  sprintf(text2, "$,%lu,%d,%d,%d,%d,%d,%d,%d,%d,%d,%d,%d,%d,%d,%d,%d,%d,%d,#",HAL_GetTick(),ET, OT, IAT2, CHASSIS_TEMP, InnerFRIR, CenterFRIR, OuterFRIR, InnerFLIR, CenterFLIR, OuterFLIR, InnerRRIR, CenterRRIR, OuterRRIR, InnerRLIR, CenterRLIR, OuterRLIR, FU2);
	  sprintf(text, "~,%lu,%d,"\033[0;31m%d\033[0m",%d,%d,%d,%d,%d,%d,%d,`", HAL_GetTick(), RPM2, OP2, BatV, MAP2, TPS2, FP2, Lambda, Speed, Gear);

    }

  if (CHASSIS_TEMP>CHASSIS_TEMP_THRESHOLD) {
    sprintf(text2, "$,%lu,%d,%d,%d,"\033[0;31m%d\033[0m",%d,%d,%d,%d,%d,%d,%d,%d,%d,%d,%d,%d,%d,#",HAL_GetTick(),ET, OT, IAT2, CHASSIS_TEMP, InnerFRIR, CenterFRIR, OuterFRIR, InnerFLIR, CenterFLIR, OuterFLIR, InnerRRIR, CenterRRIR, OuterRRIR, InnerRLIR, CenterRLIR, OuterRLIR, FU2);
	  sprintf(text, "~,%lu,%d,%d,%d,%d,%d,%d,%d,%d,%d,`", HAL_GetTick(), RPM2, OP2, BatV, MAP2, TPS2, FP2, Lambda, Speed, Gear);

  }
  if (ET<=ET_THRESHOLD &&  OP>=OP_THRESHOLD && CHASSIS_TEMP<=CHASSIS_TEMP_THRESHOLD)
  {


    sprintf(text2, "$,%lu,%d,%d,%d,%d,%d,%d,%d,%d,%d,%d,%d,%d,%d,%d,%d,%d,%d,#",HAL_GetTick(),ET, OT, IAT2, CHASSIS_TEMP, InnerFRIR, CenterFRIR, OuterFRIR, InnerFLIR, CenterFLIR, OuterFLIR, InnerRRIR, CenterRRIR, OuterRRIR, InnerRLIR, CenterRLIR, OuterRLIR, FU2);
	  sprintf(text, "~,%lu,%d,%d,%d,%d,%d,%d,%d,%d,%d,`", HAL_GetTick(), RPM2, OP2, BatV, MAP2, TPS2, FP2, Lambda, Speed, Gear);

  }


//	  sprintf(text, "~,%lu,%d,%d,%d,%d,%d,%d,%d,%d,%d,%d,%d,%d,%d,`", HAL_GetTick(), RPM2, ET, OT, OP2, BatV, MAP2, FP2, Lambda,TPS2,CHASSIS_TEMP,Gear,FrontBrakePress2,RearBrakePress2);


//	  sprintf(text, "~,%lu,%d,%d,%d,%d,%d,%d,%d,%d,%d,%d,%d,%d,`", HAL_GetTick(), RPM2, ET, OT, OP2, BatV, MAP2, FP2, Lambda,TPS2,CHASSIS_TEMP,Gear);
//	  sprintf(text, "~,%lu,%d,%d,%d,%d,%d,%d,%d,%d,%d,`", HAL_GetTick(), RPM2, OP2, BatV, MAP2, TPS2, FP2, Lambda, Speed, Gear);
//	  RPM2=1000;
//	  ET=rand()%100;
//	  OT=rand()%100;
//	  OP2=rand()%600;
//	  BatV=rand()%15;
//	  MAP2=rand()%100;
//	  FP2=rand()%450;
//	  Lambda=rand()%250;
//	  InnerFRIR=rand()%100;


	  if (datacheck){
  		  HAL_GPIO_TogglePin(GPIOA, GPIO_PIN_4);
	  	  HAL_Delay(100);
	  }
  }
  /* USER CODE END 3 */
}

/**
  * @brief System Clock Configuration
  * @retval None
  */
void SystemClock_Config(void)
{
  RCC_OscInitTypeDef RCC_OscInitStruct = {0};
  RCC_ClkInitTypeDef RCC_ClkInitStruct = {0};

  /** Configure the main internal regulator output voltage
  */
  __HAL_RCC_PWR_CLK_ENABLE();
  __HAL_PWR_VOLTAGESCALING_CONFIG(PWR_REGULATOR_VOLTAGE_SCALE1);

  /** Initializes the RCC Oscillators according to the specified parameters
  * in the RCC_OscInitTypeDef structure.
  */
  RCC_OscInitStruct.OscillatorType = RCC_OSCILLATORTYPE_HSI;
  RCC_OscInitStruct.HSIState = RCC_HSI_ON;
  RCC_OscInitStruct.HSICalibrationValue = RCC_HSICALIBRATION_DEFAULT;
  RCC_OscInitStruct.PLL.PLLState = RCC_PLL_ON;
  RCC_OscInitStruct.PLL.PLLSource = RCC_PLLSOURCE_HSI;
  RCC_OscInitStruct.PLL.PLLM = 8;
  RCC_OscInitStruct.PLL.PLLN = 180;
  RCC_OscInitStruct.PLL.PLLP = RCC_PLLP_DIV2;
  RCC_OscInitStruct.PLL.PLLQ = 2;
  RCC_OscInitStruct.PLL.PLLR = 2;
  if (HAL_RCC_OscConfig(&RCC_OscInitStruct) != HAL_OK)
  {
    Error_Handler();
  }

  /** Activate the Over-Drive mode
  */
  if (HAL_PWREx_EnableOverDrive() != HAL_OK)
  {
    Error_Handler();
  }

  /** Initializes the CPU, AHB and APB buses clocks
  */
  RCC_ClkInitStruct.ClockType = RCC_CLOCKTYPE_HCLK|RCC_CLOCKTYPE_SYSCLK
                              |RCC_CLOCKTYPE_PCLK1|RCC_CLOCKTYPE_PCLK2;
  RCC_ClkInitStruct.SYSCLKSource = RCC_SYSCLKSOURCE_PLLCLK;
  RCC_ClkInitStruct.AHBCLKDivider = RCC_SYSCLK_DIV1;
  RCC_ClkInitStruct.APB1CLKDivider = RCC_HCLK_DIV4;
  RCC_ClkInitStruct.APB2CLKDivider = RCC_HCLK_DIV2;

  if (HAL_RCC_ClockConfig(&RCC_ClkInitStruct, FLASH_LATENCY_5) != HAL_OK)
  {
    Error_Handler();
  }
}

/**
  * @brief CAN1 Initialization Function
  * @param None
  * @retval None
  */
static void MX_CAN1_Init(void)
{

  /* USER CODE BEGIN CAN1_Init 0 */
  CAN_FilterTypeDef  sFilterConfig;

  /* USER CODE END CAN1_Init 0 */

  /* USER CODE BEGIN CAN1_Init 1 */

  /* USER CODE END CAN1_Init 1 */
  hcan1.Instance = CAN1;
  hcan1.Init.Prescaler = 18;
  hcan1.Init.Mode = CAN_MODE_NORMAL;
  hcan1.Init.SyncJumpWidth = CAN_SJW_1TQ;
  hcan1.Init.TimeSeg1 = CAN_BS1_2TQ;
  hcan1.Init.TimeSeg2 = CAN_BS2_2TQ;
  hcan1.Init.TimeTriggeredMode = DISABLE;
  hcan1.Init.AutoBusOff = DISABLE;
  hcan1.Init.AutoWakeUp = DISABLE;
  hcan1.Init.AutoRetransmission = DISABLE;
  hcan1.Init.ReceiveFifoLocked = DISABLE;
  hcan1.Init.TransmitFifoPriority = DISABLE;
  if (HAL_CAN_Init(&hcan1) != HAL_OK)
  {
    Error_Handler();
  }
  /* USER CODE BEGIN CAN1_Init 2 */
  sFilterConfig.FilterBank = 0;
  sFilterConfig.FilterMode = CAN_FILTERMODE_IDMASK;
  sFilterConfig.FilterScale = CAN_FILTERSCALE_32BIT;
  sFilterConfig.FilterIdHigh = 0x0000;
  sFilterConfig.FilterIdLow = 0x0000;
  sFilterConfig.FilterMaskIdHigh = 0x0000;
  sFilterConfig.FilterMaskIdLow = 0x0000;
  sFilterConfig.FilterFIFOAssignment = CAN_RX_FIFO0;
  sFilterConfig.FilterActivation = ENABLE;
  sFilterConfig.SlaveStartFilterBank = 14;

  if (HAL_CAN_ConfigFilter(&hcan1, &sFilterConfig) != HAL_OK)
  {
    /* Filter configuration Error */
    Error_Handler();
  }

  HAL_CAN_Start(&hcan1);

  /*##-4- Activate CAN RX notification #######################################*/
  if (HAL_CAN_ActivateNotification(&hcan1, CAN_IT_RX_FIFO0_MSG_PENDING) != HAL_OK)
  {
    /* Notification Error */
    Error_Handler();
  }

  /* USER CODE END CAN1_Init 2 */

}

/**
  * @brief CAN2 Initialization Function
  * @param None
  * @retval None
  */
static void MX_CAN2_Init(void)
{

  /* USER CODE BEGIN CAN2_Init 0 */
  CAN_FilterTypeDef  sFilterConfig;

  /* USER CODE END CAN2_Init 0 */

  /* USER CODE BEGIN CAN2_Init 1 */

  /* USER CODE END CAN2_Init 1 */
  hcan2.Instance = CAN2;
  hcan2.Init.Prescaler = 18;
  hcan2.Init.Mode = CAN_MODE_NORMAL;
  hcan2.Init.SyncJumpWidth = CAN_SJW_1TQ;
  hcan2.Init.TimeSeg1 = CAN_BS1_2TQ;
  hcan2.Init.TimeSeg2 = CAN_BS2_2TQ;
  hcan2.Init.TimeTriggeredMode = DISABLE;
  hcan2.Init.AutoBusOff = DISABLE;
  hcan2.Init.AutoWakeUp = DISABLE;
  hcan2.Init.AutoRetransmission = DISABLE;
  hcan2.Init.ReceiveFifoLocked = DISABLE;
  hcan2.Init.TransmitFifoPriority = DISABLE;
  if (HAL_CAN_Init(&hcan2) != HAL_OK)
  {
    Error_Handler();
  }
  /* USER CODE BEGIN CAN2_Init 2 */
  sFilterConfig.FilterBank = 14;
  sFilterConfig.FilterMode = CAN_FILTERMODE_IDMASK;
  sFilterConfig.FilterScale = CAN_FILTERSCALE_32BIT;
  sFilterConfig.FilterIdHigh = 0x0000;
  sFilterConfig.FilterIdLow = 0x0000;
  sFilterConfig.FilterMaskIdHigh = 0x0000;
  sFilterConfig.FilterMaskIdLow = 0x0000;
  sFilterConfig.FilterFIFOAssignment = CAN_RX_FIFO0;
  sFilterConfig.FilterActivation = ENABLE;
  sFilterConfig.SlaveStartFilterBank = 14;

  if (HAL_CAN_ConfigFilter(&hcan2, &sFilterConfig) != HAL_OK)
  {
    /* Filter configuration Error */
    Error_Handler();
  }


  HAL_CAN_Start(&hcan2);

  /*##-4- Activate CAN RX notification #######################################*/
  if (HAL_CAN_ActivateNotification(&hcan2, CAN_IT_RX_FIFO0_MSG_PENDING) != HAL_OK)
  {
    /* Notification Error */
    Error_Handler();
  }
  /* USER CODE END CAN2_Init 2 */

}

/**
  * @brief USART1 Initialization Function
  * @param None
  * @retval None
  */
static void MX_USART1_UART_Init(void)
{

  /* USER CODE BEGIN USART1_Init 0 */

  /* USER CODE END USART1_Init 0 */

  /* USER CODE BEGIN USART1_Init 1 */

  /* USER CODE END USART1_Init 1 */
  huart1.Instance = USART1;
  huart1.Init.BaudRate = 115200;
  huart1.Init.WordLength = UART_WORDLENGTH_8B;
  huart1.Init.StopBits = UART_STOPBITS_1;
  huart1.Init.Parity = UART_PARITY_NONE;
  huart1.Init.Mode = UART_MODE_TX_RX;
  huart1.Init.HwFlowCtl = UART_HWCONTROL_NONE;
  huart1.Init.OverSampling = UART_OVERSAMPLING_16;
  if (HAL_UART_Init(&huart1) != HAL_OK)
  {
    Error_Handler();
  }
  /* USER CODE BEGIN USART1_Init 2 */

  /* USER CODE END USART1_Init 2 */

}

/**
  * @brief GPIO Initialization Function
  * @param None
  * @retval None
  */
static void MX_GPIO_Init(void)
{
  GPIO_InitTypeDef GPIO_InitStruct = {0};

  /* GPIO Ports Clock Enable */
  __HAL_RCC_GPIOC_CLK_ENABLE();
  __HAL_RCC_GPIOH_CLK_ENABLE();
  __HAL_RCC_GPIOA_CLK_ENABLE();
  __HAL_RCC_GPIOB_CLK_ENABLE();

  /*Configure GPIO pin Output Level */
  HAL_GPIO_WritePin(GPIOA, GPIO_PIN_4, GPIO_PIN_RESET);

  /*Configure GPIO pin : PA4 */
  GPIO_InitStruct.Pin = GPIO_PIN_4;
  GPIO_InitStruct.Mode = GPIO_MODE_OUTPUT_PP;
  GPIO_InitStruct.Pull = GPIO_NOPULL;
  GPIO_InitStruct.Speed = GPIO_SPEED_FREQ_LOW;
  HAL_GPIO_Init(GPIOA, &GPIO_InitStruct);

}

/* USER CODE BEGIN 4 */
void HAL_UART_RxCpltCallback(UART_HandleTypeDef *huart) {
	if (data[0] == 'l') {
		HAL_UART_Transmit_IT(huart, (uint8_t*) msg, strlen(msg));
		//HAL_UART_Transmit_IT(huart, (uint8_t*) msg, sizeof(msg));
	}
	if (data[0] == 'k') {
		HAL_UART_Transmit_IT(huart, (uint8_t*) text, strlen(text));
		//HAL_UART_Transmit_IT(huart, (uint8_t*) bufferTX, sizeof(bufferTX));
	}
	if (data[0] == 'm') {
		HAL_UART_Transmit_IT(huart, (uint8_t*) msg2, strlen(msg2));
		//HAL_UART_Transmit_IT(huart, (uint8_t*) bufferTX, sizeof(bufferTX));
	}
	if (data[0] == 'n') {
			HAL_UART_Transmit_IT(huart, (uint8_t*) text2, strlen(text2));
	}
	HAL_UART_Receive_IT(huart, (uint8_t*) data, 1);
}

/* USER CODE END 4 */

/**
  * @brief  This function is executed in case of error occurrence.
  * @retval None
  */
void Error_Handler(void)
{
  /* USER CODE BEGIN Error_Handler_Debug */
  /* User can add his own implementation to report the HAL error return state */
  __disable_irq();
  while (1)
  {
  }
  /* USER CODE END Error_Handler_Debug */
}

#ifdef  USE_FULL_ASSERT
/**
  * @brief  Reports the name of the source file and the source line number
  *         where the assert_param error has occurred.
  * @param  file: pointer to the source file name
  * @param  line: assert_param error line source number
  * @retval None
  */
void assert_failed(uint8_t *file, uint32_t line)
{
  /* USER CODE BEGIN 6 */
  /* User can add his own implementation to report the file name and line number,
     ex: printf("Wrong parameters value: file %s on line %d\r\n", file, line) */
  /* USER CODE END 6 */
}
#endif /* USE_FULL_ASSERT */
