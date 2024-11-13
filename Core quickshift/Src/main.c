/* USER CODE BEGIN Header */
/**
 ******************************************************************************
 * @file           : main.c
 * @brief          : Main program body
 ******************************************************************************
 * @attention
 *
 * Copyright (c) 2022 STMicroelectronics.
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
ADC_HandleTypeDef hadc1;

CAN_HandleTypeDef hcan;

UART_HandleTypeDef huart1;

/* USER CODE BEGIN PV */

/* USER CODE END PV */

/* Private function prototypes -----------------------------------------------*/
void SystemClock_Config(void);
static void MX_GPIO_Init(void);
static void MX_USART1_UART_Init(void);
static void MX_ADC1_Init(void);
static void MX_CAN_Init(void);
/* USER CODE BEGIN PFP */

/* USER CODE END PFP */

/* Private user code ---------------------------------------------------------*/
/* USER CODE BEGIN 0 */

uint16_t gear_lever_pos = 0;
uint8_t WS, WS_1, RPM, RPM_1, automate_pos = 0, change_gear = 0,neutral_upshift_time=5, upshift_button;
uint8_t neutral_time[]={8.5,10,10,10,10,10,10,};
int gear = 0, WS_2, RPM_2;

CAN_TxHeaderTypeDef TxHeader;
CAN_RxHeaderTypeDef RxHeader;

uint32_t TxMailbox;

uint8_t TxData[8];
uint8_t RxData[8];

uint32_t timed, prev_time, prev_time1;
uint8_t upshift_button_debounce=0,a = 0, previous1 = 0, previous2 = 0, paddleUP_state = 0, paddleDown_state = 0, can_change_up = 1, can_change_down = 1, changed_up = 1, changed_down = 1, test;
char msg[100] = { '\0' };

uint8_t debounce(GPIO_TypeDef *GPIOx, uint16_t GPIO_Pin) {
	if (HAL_GPIO_ReadPin(GPIOx, GPIO_Pin) == 0 && a == 0) {
		a = 1;
		prev_time = HAL_GetTick();
		return 1;
	}
	if (HAL_GPIO_ReadPin(GPIOx, GPIO_Pin) == 1 && a == 0) {
		return 0;
	}
	if (a == 1) {
		if (HAL_GetTick() - prev_time > 30)
			a = 0;
	}

	return -1;
}


void upshift() {
	if (gear < 4)
		gear++;
	else
		gear = 4;
	paddleUP_state = 1;
	HAL_GPIO_WritePin(ign_cut_GPIO_Port, ign_cut_Pin, 1);
	HAL_Delay(20);
	HAL_GPIO_WritePin(emvolo_up_GPIO_Port, emvolo_up_Pin, 1);
	HAL_GPIO_WritePin(debug_led_GPIO_Port, debug_led_Pin, 1);
	while (HAL_GPIO_ReadPin(emvolo_up_GPIO_Port, emvolo_up_Pin) == 1) {
		if (HAL_GetTick() - timed < 800) {
			if (HAL_GPIO_ReadPin(fb_up_GPIO_Port, fb_up_Pin) == 1) {
				HAL_Delay(15);
				HAL_GPIO_WritePin(emvolo_up_GPIO_Port, emvolo_up_Pin, 0);
				HAL_GPIO_WritePin(ign_cut_GPIO_Port, ign_cut_Pin, 0);
				HAL_GPIO_WritePin(debug_led_GPIO_Port, debug_led_Pin, 0);
				changed_up = 1;
			}
		} else {
			HAL_GPIO_WritePin(emvolo_up_GPIO_Port, emvolo_up_Pin, 0);
			HAL_GPIO_WritePin(ign_cut_GPIO_Port, ign_cut_Pin, 0);
			changed_up = 1;

		}

	}
}
void open_upshift() {
	if (gear < 4)
		gear++;
	else
		gear = 4;
	paddleUP_state = 1;
	HAL_GPIO_WritePin(ign_cut_GPIO_Port, ign_cut_Pin, 1);
	HAL_Delay(25);
	HAL_GPIO_WritePin(ign_cut_GPIO_Port, ign_cut_Pin, 0);
	HAL_GPIO_WritePin(emvolo_up_GPIO_Port, emvolo_up_Pin, 1);
	HAL_GPIO_WritePin(debug_led_GPIO_Port, debug_led_Pin, 1);
	while (HAL_GPIO_ReadPin(emvolo_up_GPIO_Port, emvolo_up_Pin) == 1) {
				HAL_Delay(250);
				HAL_GPIO_WritePin(emvolo_up_GPIO_Port, emvolo_up_Pin, 0);
				HAL_GPIO_WritePin(debug_led_GPIO_Port, debug_led_Pin, 0);
				changed_up = 1;
	}
}

void neutral_upshift() {
	HAL_GPIO_WritePin(emvolo_up_GPIO_Port, emvolo_up_Pin, 1);
	HAL_GPIO_WritePin(debug_led_GPIO_Port, debug_led_Pin, 1);
	while (HAL_GPIO_ReadPin(emvolo_up_GPIO_Port, emvolo_up_Pin) == 1) {
		HAL_Delay(neutral_upshift_time);
		HAL_GPIO_WritePin(emvolo_up_GPIO_Port, emvolo_up_Pin, 0);
		HAL_GPIO_WritePin(debug_led_GPIO_Port, debug_led_Pin, 0);
		changed_up = 1;
	}

}

void downshift() {
	if (gear > 0)
		gear--;
	else
		gear = 0;
	HAL_GPIO_WritePin(debug_led_GPIO_Port, debug_led_Pin, 1);
	//HAL_GPIO_WritePin(clutch_GPIO_Port, clutch_Pin, 1);
	//HAL_Delay(100);
	HAL_GPIO_WritePin(emvolo_down_GPIO_Port, emvolo_down_Pin, 1);
	while (HAL_GPIO_ReadPin(emvolo_down_GPIO_Port, emvolo_down_Pin) == 1) {
		if (HAL_GetTick() - timed < 800) {
			if (HAL_GPIO_ReadPin(fb_down_GPIO_Port, fb_down_Pin) == 1) {
				HAL_Delay(40);
				//HAL_GPIO_WritePin(clutch_GPIO_Port, clutch_Pin, 0);
				//HAL_Delay(20);
				HAL_GPIO_WritePin(emvolo_down_GPIO_Port, emvolo_down_Pin, 0);
				HAL_GPIO_WritePin(debug_led_GPIO_Port, debug_led_Pin, 0);
				changed_down = 1;

			}
		} else {
//			HAL_GPIO_WritePin(clutch_GPIO_Port, clutch_Pin, 0);
//			HAL_Delay(100);
			HAL_GPIO_WritePin(emvolo_down_GPIO_Port, emvolo_down_Pin, 0);
			HAL_GPIO_WritePin(debug_led_GPIO_Port, debug_led_Pin, 0);
			changed_down = 1;
		}

	}
//	HAL_Delay(300);
}

void downshift_with_upper_magnet() {//downshift me to magnhtaki tou upshift giati vghke to allo gia na mpei sthn kainouria kalwdiwsh
	if (gear > 0)
		gear--;
	else
		gear = 0;
	HAL_GPIO_WritePin(debug_led_GPIO_Port, debug_led_Pin, 1);
	//HAL_GPIO_WritePin(clutch_GPIO_Port, clutch_Pin, 1);
	//HAL_Delay(100);
	HAL_GPIO_WritePin(emvolo_down_GPIO_Port, emvolo_down_Pin, 1);
	while (HAL_GPIO_ReadPin(emvolo_down_GPIO_Port, emvolo_down_Pin) == 1) {
		if (HAL_GetTick() - timed < 800) {
			if (HAL_GPIO_ReadPin(fb_up_GPIO_Port, fb_up_Pin) == 1) {
				HAL_Delay(100);
				//HAL_GPIO_WritePin(clutch_GPIO_Port, clutch_Pin, 0);
				//HAL_Delay(20);
				HAL_GPIO_WritePin(emvolo_down_GPIO_Port, emvolo_down_Pin, 0);
				HAL_GPIO_WritePin(debug_led_GPIO_Port, debug_led_Pin, 0);
				changed_down = 1;
			}
		} else {
//			HAL_GPIO_WritePin(clutch_GPIO_Port, clutch_Pin, 0);
//			HAL_Delay(100);
			HAL_GPIO_WritePin(emvolo_down_GPIO_Port, emvolo_down_Pin, 0);
			HAL_GPIO_WritePin(debug_led_GPIO_Port, debug_led_Pin, 0);
			changed_down = 1;
		}

	}
//	HAL_Delay(300);
}
void open_downshift() {
	HAL_GPIO_WritePin(debug_led_GPIO_Port, debug_led_Pin, 1);
	HAL_GPIO_WritePin(emvolo_down_GPIO_Port, emvolo_down_Pin, 1);
	while (HAL_GPIO_ReadPin(emvolo_down_GPIO_Port, emvolo_down_Pin) == 1) {
				HAL_Delay(400);
				HAL_GPIO_WritePin(emvolo_down_GPIO_Port, emvolo_down_Pin, 0);
				HAL_GPIO_WritePin(debug_led_GPIO_Port, debug_led_Pin, 0);
				changed_down = 1;
	}
	HAL_Delay(80);
}


int BitShiftCombine(uint8_t high, uint8_t low) {
	int combined;
	combined = high;
	combined = combined << 8;
	combined |= low;
	return combined;
}

void HAL_CAN_RxFifo0MsgPendingCallback(CAN_HandleTypeDef *hcan) {
	HAL_CAN_GetRxMessage(hcan, CAN_RX_FIFO0, &RxHeader, RxData);
	if (RxHeader.StdId == 16) // η τιμή π�?οέ�?χεται από το εγκέφαλο
			{
		automate_pos = RxData[1];  //OIL PRESS
	}
	if (RxHeader.StdId == 1608) {
		WS = RxData[0];
		WS_1 = RxData[1];
		WS_2 = BitShiftCombine(WS, WS_1);
	}
	if (RxHeader.StdId == 1600) {
		RPM = RxData[0];
		RPM_1 = RxData[1];
		RPM_2 = BitShiftCombine(RPM, RPM_1);
	}
	if (RxHeader.StdId == 1945) {
		neutral_upshift_time=RxData[0];
		upshift_button=RxData[1];
	}
	if (RxHeader.StdId==1793){
		test = RxData[0];
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
  MX_USART1_UART_Init();
  MX_ADC1_Init();
  MX_CAN_Init();
  /* USER CODE BEGIN 2 */

	HAL_ADCEx_Calibration_Start(&hadc1);

	HAL_CAN_Start(&hcan);
	HAL_CAN_ActivateNotification(&hcan, CAN_IT_RX_FIFO0_MSG_PENDING);

	/*TxHeader.DLC = 1;
//	TxHeader.ExtId = 0x02;
	TxHeader1.IDE = CAN_ID_STD;
	TxHeader1.RTR = CAN_RTR_DATA;
	TxHeader1.StdId = 0x760;
	TxHeader1.TransmitGlobalTime = DISABLE;
	HAL_Delay(1000);
	*/

	TxHeader.DLC = 1;
	TxHeader.IDE = CAN_ID_STD;
	TxHeader.RTR = CAN_RTR_DATA;
	TxHeader.StdId = 0x530 ;
	TxHeader.TransmitGlobalTime = DISABLE;
	HAL_Delay(1000);

  /* USER CODE END 2 */

  /* Infinite loop */
  /* USER CODE BEGIN WHILE */
	while (1) {
		HAL_ADC_Start(&hadc1);
		HAL_ADC_PollForConversion(&hadc1, 100);
		gear_lever_pos = HAL_ADC_GetValue(&hadc1);
//		if (gear_analog > 300) {
//			gear = 0;
//		} else if (gear_analog > 300) {
//			gear = 1;
//		} else if (gear_analog > 220) {
//			gear = 2;
//		} else if (gear_analog > 150) {
//			gear = 3;
//		} else {
//			gear = 4;
//		}

//		gear = 1;
		//TxData1[0] = gear_lever_pos>>8;
		//TxData1[1] = gear_lever_pos;
		//HAL_CAN_AddTxMessage(&hcan, &TxHeader1, TxData1, &TxMailbox1);

//		if (HAL_GPIO_ReadPin(paddle_up_GPIO_Port, paddle_up_Pin) == 1) {
//			HAL_GPIO_WritePin(debug_led_GPIO_Port, debug_led_Pin, 1);
//		}
//		if (HAL_GPIO_ReadPin(paddle_up_GPIO_Port, paddle_up_Pin) == 0) {
//			HAL_GPIO_WritePin(debug_led_GPIO_Port, debug_led_Pin, 0);
//		}
//		if (HAL_GPIO_ReadPin(paddle_down_GPIO_Port, paddle_down_Pin) == 1) {
//			HAL_GPIO_WritePin(debug_led_GPIO_Port, debug_led_Pin, 1);
//		}
//		if (HAL_GPIO_ReadPin(paddle_down_GPIO_Port, paddle_down_Pin) == 0) {
//			HAL_GPIO_WritePin(debug_led_GPIO_Port, debug_led_Pin, 0);
//		}
//		if (HAL_GPIO_ReadPin(fb_up_GPIO_Port, fb_up_Pin) == 1) {
//			HAL_GPIO_WritePin(debug_led_GPIO_Port, debug_led_Pin, 1);
//		}
//		if (HAL_GPIO_ReadPin(fb_up_GPIO_Port, fb_up_Pin) == 0) {
//			HAL_GPIO_WritePin(debug_led_GPIO_Port, debug_led_Pin, 0);
//		}
//		if (HAL_GPIO_ReadPin(fb_down_GPIO_Port, fb_down_Pin) == 1) {
//			HAL_GPIO_WritePin(debug_led_GPIO_Port, debug_led_Pin, 1);
//		}
//		if (HAL_GPIO_ReadPin(fb_down_GPIO_Port, fb_down_Pin) == 0) {
//			HAL_GPIO_WritePin(debug_led_GPIO_Port, debug_led_Pin, 0);
//		}

//		if (automate_pos) {
//			if (WS_2 > 26 && RPM_2 > 11500 && gear == 1) {
//				change_gear++;
//				TxData[1] = change_gear;
//				HAL_CAN_AddTxMessage(&hcan, &TxHeader, TxData, &TxMailbox);
//			} else if (RPM_2 > 11500 && gear == 2) {
//				change_gear++;
//				TxData[1] = change_gear;
//				HAL_CAN_AddTxMessage(&hcan, &TxHeader, TxData, &TxMailbox);
//			} else if (RPM_2 > 11500 && gear == 3) {
//				change_gear++;
//				TxData[1] = change_gear;
//				HAL_CAN_AddTxMessage(&hcan, &TxHeader, TxData, &TxMailbox);
//			}
//		}

// UpShift
		if (HAL_GPIO_ReadPin(paddle_up_GPIO_Port, paddle_up_Pin) == 0) {
			previous1 = debounce(paddle_up_GPIO_Port, paddle_up_Pin);
			TxData[0]=0;
			changed_up = 0;
			can_change_up = 0;
			timed = HAL_GetTick();
			open_upshift();
		} else if (HAL_GPIO_ReadPin(paddle_up_GPIO_Port, paddle_up_Pin) == 1) {
			can_change_up = 1;
			previous1 = debounce(paddle_up_GPIO_Port, paddle_up_Pin);
			TxData[0]=1;
//			previous1 = 0;
            //

		}
		HAL_CAN_AddTxMessage(&hcan, &TxHeader2, TxData2, &TxMailbox2);

//
//		// DownShift
		if (HAL_GPIO_ReadPin(paddle_down_GPIO_Port, paddle_down_Pin) == 0) {
			previous2 = debounce(paddle_down_GPIO_Port, paddle_down_Pin);
			TxData[0]=0;
			changed_down = 0;
			can_change_down = 0;
			timed = HAL_GetTick();
			open_downshift();
		} else if (HAL_GPIO_ReadPin(paddle_down_GPIO_Port, paddle_down_Pin) == 1) {
			can_change_down = 1;
			TxData[0]=1;
			previous2 = debounce(paddle_down_GPIO_Port, paddle_down_Pin);

		}
		// Upshift Neutral
		if (upshift_button == 1 && upshift_button_debounce==0) {
			neutral_upshift();
			upshift_button_debounce=1;
		}
		if (upshift_button_debounce==1 && upshift_button==0){
			upshift_button_debounce=0;
		}

//		if(test==1){
//			HAL_GPIO_WritePin(debug_led_GPIO_Port, debug_led_Pin, 1);
//			HAL_Delay(100);
//			HAL_GPIO_WritePin(debug_led_GPIO_Port, debug_led_Pin, 0);
//			HAL_Delay(100);
//
//		}
//		else if (test==0){
//			HAL_GPIO_WritePin(debug_led_GPIO_Port, debug_led_Pin, 1);
//			HAL_Delay(1000);
//			HAL_GPIO_WritePin(debug_led_GPIO_Port, debug_led_Pin, 0);
//			HAL_Delay(1000);
//
//		}

		if (HAL_GetTick() - prev_time1 > 100) {
			paddleUP_state = 0;
			paddleDown_state = 0;
			prev_time1 = HAL_GetTick();
		}
    /* USER CODE END WHILE */

    /* USER CODE BEGIN 3 */
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
  RCC_PeriphCLKInitTypeDef PeriphClkInit = {0};

  /** Initializes the RCC Oscillators according to the specified parameters
  * in the RCC_OscInitTypeDef structure.
  */
  RCC_OscInitStruct.OscillatorType = RCC_OSCILLATORTYPE_HSE;
  RCC_OscInitStruct.HSEState = RCC_HSE_ON;
  RCC_OscInitStruct.HSEPredivValue = RCC_HSE_PREDIV_DIV1;
  RCC_OscInitStruct.HSIState = RCC_HSI_ON;
  RCC_OscInitStruct.PLL.PLLState = RCC_PLL_ON;
  RCC_OscInitStruct.PLL.PLLSource = RCC_PLLSOURCE_HSE;
  RCC_OscInitStruct.PLL.PLLMUL = RCC_PLL_MUL9;
  if (HAL_RCC_OscConfig(&RCC_OscInitStruct) != HAL_OK)
  {
    Error_Handler();
  }
  /** Initializes the CPU, AHB and APB buses clocks
  */
  RCC_ClkInitStruct.ClockType = RCC_CLOCKTYPE_HCLK|RCC_CLOCKTYPE_SYSCLK
                              |RCC_CLOCKTYPE_PCLK1|RCC_CLOCKTYPE_PCLK2;
  RCC_ClkInitStruct.SYSCLKSource = RCC_SYSCLKSOURCE_PLLCLK;
  RCC_ClkInitStruct.AHBCLKDivider = RCC_SYSCLK_DIV1;
  RCC_ClkInitStruct.APB1CLKDivider = RCC_HCLK_DIV2;
  RCC_ClkInitStruct.APB2CLKDivider = RCC_HCLK_DIV1;

  if (HAL_RCC_ClockConfig(&RCC_ClkInitStruct, FLASH_LATENCY_2) != HAL_OK)
  {
    Error_Handler();
  }
  PeriphClkInit.PeriphClockSelection = RCC_PERIPHCLK_ADC;
  PeriphClkInit.AdcClockSelection = RCC_ADCPCLK2_DIV6;
  if (HAL_RCCEx_PeriphCLKConfig(&PeriphClkInit) != HAL_OK)
  {
    Error_Handler();
  }
}

/**
  * @brief ADC1 Initialization Function
  * @param None
  * @retval None
  */
static void MX_ADC1_Init(void)
{

  /* USER CODE BEGIN ADC1_Init 0 */

  /* USER CODE END ADC1_Init 0 */

  ADC_ChannelConfTypeDef sConfig = {0};

  /* USER CODE BEGIN ADC1_Init 1 */

  /* USER CODE END ADC1_Init 1 */
  /** Common config
  */
  hadc1.Instance = ADC1;
  hadc1.Init.ScanConvMode = ADC_SCAN_DISABLE;
  hadc1.Init.ContinuousConvMode = DISABLE;
  hadc1.Init.DiscontinuousConvMode = DISABLE;
  hadc1.Init.ExternalTrigConv = ADC_SOFTWARE_START;
  hadc1.Init.DataAlign = ADC_DATAALIGN_RIGHT;
  hadc1.Init.NbrOfConversion = 1;
  if (HAL_ADC_Init(&hadc1) != HAL_OK)
  {
    Error_Handler();
  }
  /** Configure Regular Channel
  */
  sConfig.Channel = ADC_CHANNEL_0;
  sConfig.Rank = ADC_REGULAR_RANK_1;
  sConfig.SamplingTime = ADC_SAMPLETIME_1CYCLE_5;
  if (HAL_ADC_ConfigChannel(&hadc1, &sConfig) != HAL_OK)
  {
    Error_Handler();
  }
  /* USER CODE BEGIN ADC1_Init 2 */

  /* USER CODE END ADC1_Init 2 */

}

/**
  * @brief CAN Initialization Function
  * @param None
  * @retval None
  */
static void MX_CAN_Init(void)
{

  /* USER CODE BEGIN CAN_Init 0 */

  /* USER CODE END CAN_Init 0 */

  /* USER CODE BEGIN CAN_Init 1 */

  /* USER CODE END CAN_Init 1 */
  hcan.Instance = CAN1;
  hcan.Init.Prescaler = 18;
  hcan.Init.Mode = CAN_MODE_NORMAL;
  hcan.Init.SyncJumpWidth = CAN_SJW_1TQ;
  hcan.Init.TimeSeg1 = CAN_BS1_2TQ;
  hcan.Init.TimeSeg2 = CAN_BS2_1TQ;
  hcan.Init.TimeTriggeredMode = DISABLE;
  hcan.Init.AutoBusOff = DISABLE;
  hcan.Init.AutoWakeUp = DISABLE;
  hcan.Init.AutoRetransmission = DISABLE;
  hcan.Init.ReceiveFifoLocked = DISABLE;
  hcan.Init.TransmitFifoPriority = DISABLE;
  if (HAL_CAN_Init(&hcan) != HAL_OK)
  {
    Error_Handler();
  }
  /* USER CODE BEGIN CAN_Init 2 */
	CAN_FilterTypeDef canfilterconfig;

	canfilterconfig.FilterActivation = CAN_FILTER_ENABLE;
	canfilterconfig.FilterBank = 10;
	canfilterconfig.FilterFIFOAssignment = CAN_RX_FIFO0;
	canfilterconfig.FilterIdHigh = 0;
	canfilterconfig.FilterIdLow = 0x0000;
	canfilterconfig.FilterMaskIdHigh = 0;
	canfilterconfig.FilterMaskIdLow = 0x0000;
	canfilterconfig.FilterMode = CAN_FILTERMODE_IDMASK;
	canfilterconfig.FilterScale = CAN_FILTERSCALE_32BIT;
	canfilterconfig.SlaveStartFilterBank = 0;

	HAL_CAN_ConfigFilter(&hcan, &canfilterconfig);
  /* USER CODE END CAN_Init 2 */

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
  __HAL_RCC_GPIOD_CLK_ENABLE();
  __HAL_RCC_GPIOA_CLK_ENABLE();
  __HAL_RCC_GPIOB_CLK_ENABLE();

  /*Configure GPIO pin Output Level */
  HAL_GPIO_WritePin(GPIOB, emvolo_down_Pin|ign_cut_Pin|debug_led_Pin|emvolo_up_Pin
                          |clutch_Pin, GPIO_PIN_RESET);

  /*Configure GPIO pins : paddle_down_Pin paddle_up_Pin */
  GPIO_InitStruct.Pin = paddle_down_Pin|paddle_up_Pin;
  GPIO_InitStruct.Mode = GPIO_MODE_INPUT;
  GPIO_InitStruct.Pull = GPIO_PULLUP;
  HAL_GPIO_Init(GPIOA, &GPIO_InitStruct);

  /*Configure GPIO pins : emvolo_down_Pin ign_cut_Pin debug_led_Pin emvolo_up_Pin
                           clutch_Pin */
  GPIO_InitStruct.Pin = emvolo_down_Pin|ign_cut_Pin|debug_led_Pin|emvolo_up_Pin
                          |clutch_Pin;
  GPIO_InitStruct.Mode = GPIO_MODE_OUTPUT_PP;
  GPIO_InitStruct.Pull = GPIO_NOPULL;
  GPIO_InitStruct.Speed = GPIO_SPEED_FREQ_LOW;
  HAL_GPIO_Init(GPIOB, &GPIO_InitStruct);

  /*Configure GPIO pins : fb_up_Pin fb_down_Pin */
  GPIO_InitStruct.Pin = fb_up_Pin|fb_down_Pin;
  GPIO_InitStruct.Mode = GPIO_MODE_INPUT;
  GPIO_InitStruct.Pull = GPIO_PULLDOWN;
  HAL_GPIO_Init(GPIOB, &GPIO_InitStruct);

}

/* USER CODE BEGIN 4 */

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
	while (1) {
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