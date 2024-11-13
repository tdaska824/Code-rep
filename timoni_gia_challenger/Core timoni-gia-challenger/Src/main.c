/* USER CODE BEGIN Header */
/**
  ******************************************************************************
  * @file           : main.c
  * @brief          : Main program body
  ******************************************************************************
  * @attention
  *
  * Copyright (c) 2023 STMicroelectronics.
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
#include "math.h"
#include "stdio.h"
#include "string.h"

/* USER CODE END Includes */

/* Private variables ---------------------------------------------------------*/
ADC_HandleTypeDef hadc1;

CAN_HandleTypeDef hcan;

TIM_HandleTypeDef htim1;
TIM_HandleTypeDef htim2;
TIM_HandleTypeDef htim3;
DMA_HandleTypeDef hdma_tim2_ch3;

UART_HandleTypeDef huart3;


/* Private function prototypes -----------------------------------------------*/
void SystemClock_Config(void);
static void MX_GPIO_Init(void);
static void MX_DMA_Init(void);
static void MX_TIM2_Init(void);
static void MX_ADC1_Init(void);
static void MX_USART3_UART_Init(void);
static void MX_CAN_Init(void);
static void MX_TIM3_Init(void);
static void MX_TIM1_Init(void);
/* USER CODE BEGIN PFP */

/* USER CODE END PFP */

/* Private user code ---------------------------------------------------------*/
/* USER CODE BEGIN 0 */

CAN_TxHeaderTypeDef TxHeader;
CAN_RxHeaderTypeDef RxHeader;

uint32_t TxMailbox, prevTime;

uint8_t TxData[8];
uint8_t RxData[8];

uint8_t TransmitData[10]={0x5A, 0xA5, 0x07, 0x82, 0x00, 0x84, 0x5A, 0x01, 0x00,0x05};//Addresses for screen 
//uint8_t TransmitData2[8]={0x5A, 0xA5, 0x05, 0x82, 0x51, 0x00, 0x00, 0x10};


#define MAX_LED 16
#define USE_BRIGHTNESS 1

uint8_t LED_Data[MAX_LED][4];
uint8_t LED_Mod[MAX_LED][4]; //for brightness
uint16_t  effStep;
uint8_t cmd_end[3] = {0xFF, 0xFF, 0xFF}; //Command end sequence


int RearBrakePress2, FrontBrakePress2, CHASSIS_TEMP, brake_bias=0,Lambda,Lambda1,Lambda2, cnt=0,cnt2=0,datasentflag=0,datacheck=0,launch_sw,launch, ecu_map, old_ecu_map, old_launch, launch_changed, launch_pos;
long launchTime;
uint8_t page_changed=1,a,changed_up=0,changed_down=0, test=0, TPS, TPS1, RPM, RPM1, MAP, MAP1, IAT, IAT1, FP, FP1, IGT, IGT1, IGT2, OP, OP1, Gear, Gear1, Gear2, LapTime, LapTime1, FU, FU1, FRWS, FRWS1, FLWS, FLWS1, RRWS, RRWS1, RLWS, RLWS1, FrontBrakePress, FrontBrakePress1, RearBrakePress, RearBrakePress1;
int Neutral,lastGear, Gear_icon, RPM_BAR, page = 0,TPS2, OP2, RPM2, BatV, MAP2, IAT2, FP2, LapTime2, FU2, ratio1, RRWS2, RLWS2, FLWS2, FRWS2, RearSPEED, SPEED, RearSPEEDRPM, numReadings=40,idx,readings[40],total, ET, OT;
float ratio,average_RearSPEEDRPM,error_btn=0;
uint32_t counter=0,counter2=0,prevNeutralTimeChange=0;
int16_t count=0,count2=0,position=0,position2=0,lastPosition;
char *pagea[]={"page2","page1","page3"};
uint8_t neutral_upshift=0,neutral_upshift_time=10,neutral_time_changed=0;


long BitShiftCombine(uint8_t xhigh, uint8_t xlow)//16-bit combination
 {
	long combined;
	combined = xhigh;
	combined = combined << 8;
	combined |= xlow;
	return combined;
}
uint8_t highByte(int number)//first 8-bit
{
	uint8_t high_byte = (number >> 8) & 0xff ;
	return high_byte;
}

uint8_t lowbyte(int number)//last 8-bit
{
	uint8_t low_byte = number & 0xff ;
	return low_byte;
}



void HAL_TIM_IC_CaptureCallback(TIM_HandleTypeDef *htim)
{
	if (htim->Instance==TIM1){
		counter = __HAL_TIM_GetCounter(htim);
		count = (int16_t)counter;
		position = count/4;
	}
	if (htim->Instance==TIM3){
			counter2 = __HAL_TIM_GetCounter(htim);
			count2 = (int16_t)counter2;
			position2 = count2/4;
	}
}



void HAL_CAN_RxFifo0MsgPendingCallback(CAN_HandleTypeDef *hcan)
 {
	HAL_CAN_GetRxMessage(hcan, CAN_RX_FIFO0, &RxHeader, RxData);
		if (RxHeader.StdId == 1600) {
			RPM = RxData[0];
			RPM1 = RxData[1];
			RPM2 = BitShiftCombine(RPM, RPM1);
			MAP = RxData[2];
			MAP1 = RxData[3];
			MAP2 = BitShiftCombine(MAP, MAP1)/10;
			IAT = RxData[4];
			IAT1 = RxData[5];
			IAT2 = BitShiftCombine(IAT, IAT1);
			TPS = RxData[6];
			TPS1 = RxData[7];
			TPS2 = BitShiftCombine(TPS, TPS1)/10;
		}
		if (RxHeader.StdId == 1601) // η τιμή π�?οέ�?χεται από το εγκέφαλο
				{
			FP = RxData[4];
			FP1 = RxData[5];
			FP2 = BitShiftCombine(FP, FP1);  //FUEL PRESS
		}

		if (RxHeader.StdId == 1604) // η τιμή π�?οέ�?χεται από το εγκέφαλο
				{
			OP = RxData[6];
			OP1 = RxData[7];
			OP2 = BitShiftCombine(OP, OP1);    //OIL PRESS
		}

		if (RxHeader.StdId == 1609) // η τιμή π�?οέ�?χεται από το εγκέφαλο
				{
			BatV = RxData[5];
			OT = RxData[1] - 40; //OIL TEMP , offset 40, π�?οκ�?πτει από τον motec
			ET = RxData[0] - 40; //COOLANT TEMP
		}
		if (RxHeader.StdId == 1617) // η τιμή π�?οέ�?χεται από το εγκέφαλο
				{
			Lambda = RxData[0]; // LAMBDA, measure the amount of air and fuel on the car exhaust
		}
		if (RxHeader.StdId == 105) // η τιμή π�?οέ�?χεται από το εγκέφαλο
					{
			FU = RxData[0];
			FU1 = RxData[1];
			FU2 = BitShiftCombine(FU, FU1);
		}
		if( RxHeader.StdId == 1381 ){
			Gear = RxData[0];
			Neutral = RxData[1];
		}
		if (RxHeader.StdId == 17) // από logger
				{
			LapTime = RxData[4];
			LapTime1 = RxData[5];
			LapTime2 = BitShiftCombine(LapTime, LapTime1);    //Lap time
		}

		if (RxHeader.StdId == 1608) // η τιμή π�?οέ�?χεται από το εγκέφαλο
					{
			FLWS= RxData[0];
			FLWS1 = RxData[1];
			FLWS2 = BitShiftCombine(FLWS, FLWS1);
			FRWS= RxData[2];
			FRWS1 = RxData[3];
			FRWS2 = BitShiftCombine(FRWS, FRWS1);
			RLWS= RxData[4];
			RLWS1 = RxData[5];
			RLWS2 = BitShiftCombine(RLWS, RLWS1);
			RRWS= RxData[6];
			RRWS1 = RxData[7];
			RRWS2 = BitShiftCombine(RRWS, RRWS1);
			SPEED = (FRWS2+FLWS2)/2;
			RearSPEED = (RRWS2+RLWS2)/2;

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

			brake_bias=100*FrontBrakePress2/(FrontBrakePress2+RearBrakePress2);

		}
}

void Dwin_SendNumber(uint8_t ID, int number){
	uint8_t TransmitData2[8]={0x5A, 0xA5, 0x05, 0x82, ID, 0x00, highByte(number), lowbyte(number)};
	HAL_UART_Transmit(&huart3, TransmitData2, 8,0xFFFF);
}
void Dwin_SendFloat(uint8_t ID, float number){
	unsigned char *byte_ptr = (unsigned char *)&number;
	unsigned char hex[4];
	    // Copy the bytes to the array, ensuring consistent endianness
	    for (int i = 0; i < 4; i++) {
	        hex[i] = byte_ptr[i];  // Little-endian
	    }
	uint8_t TransmitData2[10]={0x5A, 0xA5, 0x07, 0x82, ID, 0x00, hex[3], hex[2], hex[1], hex[0]};
	HAL_UART_Transmit(&huart3, TransmitData2, 10,0xFFFF);
}
void Dwin_SendPage(int number){
	uint8_t TransmitData2[10]={0x5A, 0xA5, 0x07, 0x82, 0x00, 0x84, 0x5A, 0x01, highByte(number), lowbyte(number)};
	HAL_UART_Transmit(&huart3, TransmitData2, 10,0xFFFF);
}


void HAL_GPIO_EXTI_Callback(uint16_t GPIO_Pin){

	if(GPIO_Pin == right_upper_button_Pin || GPIO_Pin == left_upper_button_Pin )//changes screen
  {
  		if (page==16){
  			Dwin_SendPage(17);
  			page=17;
  		}
  		else if (page==17){
  			Dwin_SendPage(16);
  			page=16;
  		}
  		changed_up=1;
	}
}
void HAL_TIM_PWM_PulseFinishedCallback(TIM_HandleTypeDef *htim)
{
	HAL_TIM_PWM_Stop_DMA(&htim2, TIM_CHANNEL_3);
	datasentflag=1;
}

void Set_LED (int LEDnum, int Red, int Green, int Blue)
{
	LED_Data[LEDnum][0] = LEDnum;
	LED_Data[LEDnum][1] = Green;
	LED_Data[LEDnum][2] = Red;
	LED_Data[LEDnum][3] = Blue;
}

#define PI 3.14159265

void Set_Brightness (int brightness) //0-45
{
#if USE_BRIGHTNESS

	if(brightness > 45) brightness = 45;
	for (int i=0; i<MAX_LED; i++)
	{
		LED_Mod[i][0] = LED_Data[i][0];
		for(int j=1; j<4; j++)
		{
			float angle = 90 - brightness; //in degrees
			angle = angle*PI / 180; //in rad
			LED_Mod[i][j] = (LED_Data[i][j])/(tan(angle));

		}
	}

#endif
}

uint16_t pwmData[(24*MAX_LED)+ 50];

void WS2812_Send (void)
{
	uint32_t indx=0;
	uint32_t color;


	for (int i= 0; i<MAX_LED; i++)
	{
#if USE_BRIGHTNESS
		color = ((LED_Mod[i][1]<<16) | (LED_Mod[i][2]<<8) | (LED_Mod[i][3]));
#else
		color = ((LED_Data[i][1]<<16) | (LED_Data[i][2]<<8) | (LED_Data[i][3]));
#endif

		for (int i=23; i>=0; i--)
		{
			if (color&(1<<i))
			{
				pwmData[indx] = 61;  // 2/3 of 90
			}

			else pwmData[indx] = 29;  // 1/3 of 90

			indx++;
		}

	}

	for (int i=0; i<50; i++)
	{
		pwmData[indx] = 0;
		indx++;
	}

	HAL_TIM_PWM_Start_DMA(&htim2, TIM_CHANNEL_3, (uint32_t *)pwmData, indx);
	while (!datasentflag){};
	datasentflag = 0;
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
  MX_DMA_Init();
  MX_TIM2_Init();
  MX_ADC1_Init();
  MX_USART3_UART_Init();
  MX_CAN_Init();
  MX_TIM3_Init();
  MX_TIM1_Init();
  /* USER CODE BEGIN 2 */

  HAL_CAN_Start(&hcan);
  HAL_CAN_ActivateNotification(&hcan, CAN_IT_RX_FIFO0_MSG_PENDING);

  HAL_TIM_Encoder_Start_IT(&htim3, TIM_CHANNEL_ALL);
  HAL_TIM_Encoder_Start_IT(&htim1, TIM_CHANNEL_ALL);

  TxHeader.DLC = 8;//Initializes can bus
  TxHeader.ExtId = 0;//Extended(1) or standard(0)
  TxHeader.IDE = CAN_ID_STD;
  TxHeader.RTR = CAN_RTR_DATA;
  TxHeader.StdId = 0x7F0;	//0x7F0
  TxHeader.TransmitGlobalTime = DISABLE;//(dont care)

  HAL_GPIO_WritePin(GPIOB, rotary_button_leds_Pin|left_button_leds_Pin, GPIO_PIN_RESET);
  HAL_GPIO_WritePin(right_button_leds_GPIO_Port, right_button_leds_Pin, GPIO_PIN_RESET);

  for (int i=0;i<16;i++){
	  Set_LED (i, 0, 0, 255);
	  Set_Brightness(35);
	  WS2812_Send();
	  HAL_Delay(52);
  }
  for (int i=0;i<16;i++){
	  Set_LED (i, 0, 0, 0);
	  Set_Brightness(35);
	  WS2812_Send();
	  HAL_Delay(52);
  }
  for (int i=15;i>=0;i--){
  	  Set_LED (i, 0, 0, 255);
  	  Set_Brightness(35);
  	  WS2812_Send();
  	  HAL_Delay(52);
  }
  for (int i=15;i>=0;i--){
  	  Set_LED (i, 0, 0, 0);
  	  Set_Brightness(35);
  	  WS2812_Send();
  	  HAL_Delay(52);
  }
  Dwin_SendPage(17);
  page=17;


  while (1)
  {
    /*User Code Begin Here*/
    
	  if (position!=lastPosition){
		  neutral_upshift_time=position+10;
		  if (neutral_upshift_time<1)
			  neutral_upshift_time=1;
		  if (neutral_upshift_time>90)
			  neutral_upshift_time=90;
		  neutral_time_changed=1;
		  prevNeutralTimeChange=HAL_GetTick();
		  lastPosition=position;
	  }

	  //Set_Brightness(45);
	  TxHeader.StdId = 0x799;
	  TxData[0]=neutral_upshift_time;
	  TxData[1]=neutral_upshift;
	  TxData[2]=error_btn;
	  HAL_CAN_AddTxMessage(&hcan,&TxHeader,TxData,&TxMailbox); // Send Message

	  TxHeader.StdId = 0x7F0;
	  TxData[0] = ecu_map;
	  TxData[2] = launch;
	  HAL_CAN_AddTxMessage(&hcan,&TxHeader,TxData,&TxMailbox); // Send Message


	  cnt++;
	  if(cnt==10000)//experimental value for screen refresh
    {
		  cnt=0;
		  Dwin_SendNumber(0x10, RPM2);
		  Dwin_SendNumber(0x11, ET);
		  Dwin_SendNumber(0x12, OT);
		  Dwin_SendNumber(0x14, OP2/10);
		  Dwin_SendNumber(0x15, FP2/10);
		  Dwin_SendNumber(0x16, MAP2);
		  float Lambdafloat=Lambda/100.0;
		  Dwin_SendFloat(0x17, Lambdafloat);//---Lambda
		  float Batteryfloat=BatV/10.0;
		  Dwin_SendFloat(0x18, Batteryfloat);//Battery
		  Dwin_SendNumber(0x19, brake_bias);
		  Dwin_SendNumber(0x21, CHASSIS_TEMP);

		  if(HAL_GetTick()-prevNeutralTimeChange<2000){
			  Dwin_SendNumber(0x20, neutral_upshift_time);
		  }else
			  Dwin_SendNumber(0x20, TPS2);

		  if(Neutral==1){
			  Gear=0;
			  Dwin_SendNumber(0x30, 0);
		  }
		  else if (Gear<7 && Gear>0){
			  Dwin_SendNumber(0x30, Gear);
		  }
		  else
			  Dwin_SendNumber(0x30, 1);//shutdown circuit gear


		  for (int i=0;i<16;i++){
		 	  Set_LED (i, 0, 0, 0);
		  }
		  if (RPM2==0){
		  	Set_Brightness(0);
		  }
		  if (RPM2>2000){
		  	Set_LED (3, 0, 255, 0);
		  }
		  if (RPM2>6000){
		  	Set_LED (4, 0, 255, 0);
		  }
		  if (RPM2>7000){
		  	Set_LED (5, 255, 0, 0);
		  }
		  if (RPM2>8000){
		  	Set_LED (6, 255, 0, 0);
		  }
		  if (RPM2>9000){
		  	Set_LED (7, 255, 0, 0);
		  }
		  if (RPM2>10000){
		  	Set_LED (8, 255, 0, 0);
		  }
		  if (RPM2>11000){
		  	Set_LED (9, 0, 0, 255);
	  		Set_LED (10, 0, 0, 255);
		  	Set_LED (11, 0, 0, 255);
		  	Set_LED (12, 0, 0, 255);
		  }
		  if (RPM2>13500){
		  	for(int i=0;i<16;i++){
		  		Set_LED (i, 0, 0, 255);
		  	}
		  	 Set_Brightness(0);
		  	 WS2812_Send();
		  	 HAL_Delay(120);
		  	 Set_Brightness(35);


		  }

		  Set_Brightness(45);
		  WS2812_Send();

	  }


	  	if (HAL_GPIO_ReadPin(GPIOA, map_button_Pin)==GPIO_PIN_RESET)
	  		ecu_map = 0;
	  	else
	  		ecu_map = 1;
	  	if (ecu_map != old_ecu_map){
	  		old_ecu_map = ecu_map;

	  		if (ecu_map==0)
	  			Dwin_SendNumber(0x32, 0);
	  		else
	  			Dwin_SendNumber(0x32, 1);

	  	}

	    HAL_ADC_Start(&hadc1);
	    HAL_ADC_PollForConversion(&hadc1, HAL_MAX_DELAY);
	    launch_sw = HAL_ADC_GetValue(&hadc1);

	  	if (launch_sw > 3100 && launch_sw <= 3700)
	  	    launch = 0;
	    else if (launch_sw > 2700 && launch_sw <= 3100)
	  	    launch = 1;
	  	else if (launch_sw > 2200 && launch_sw <= 2700)
	  	    launch = 2;
	  	else if (launch_sw > 1700 && launch_sw <= 2200)
	  	    launch = 3;
	  	else if (launch_sw > 1300 && launch_sw <= 1700)
	  	    launch = 4;
	  	else if (launch_sw > 900 && launch_sw <= 1300)
	  	    launch = 5;

	  	if (launch != old_launch){
  			launch_changed=1;
  			old_launch = launch;
  			cnt2=0;
  			Dwin_SendNumber(0x31, launch);

	  	}

	  	if (ET>118)//Screen turns red for 1500 ms
      {
	  		Dwin_SendPage(18);
	  		HAL_Delay(1500);
	  		Dwin_SendPage(page);

	  	}


	  	if (HAL_GPIO_ReadPin(GPIOA, right_down_button_Pin)==GPIO_PIN_RESET)//magic button
      {
	  		error_btn = 1;
	  	}else error_btn=0;

	  	neutral_upshift=HAL_GPIO_ReadPin(GPIOB, left_down_button_Pin)==GPIO_PIN_RESET;//neutral button


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
  RCC_OscInitStruct.HSEPredivValue = RCC_HSE_PREDIV_DIV2;
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
  hcan.Init.AutoRetransmission = ENABLE;
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
  * @brief TIM1 Initialization Function
  * @param None
  * @retval None
  */
static void MX_TIM1_Init(void)
{

  /* USER CODE BEGIN TIM1_Init 0 */

  /* USER CODE END TIM1_Init 0 */

  TIM_Encoder_InitTypeDef sConfig = {0};
  TIM_MasterConfigTypeDef sMasterConfig = {0};

  /* USER CODE BEGIN TIM1_Init 1 */

  /* USER CODE END TIM1_Init 1 */
  htim1.Instance = TIM1;
  htim1.Init.Prescaler = 0;
  htim1.Init.CounterMode = TIM_COUNTERMODE_UP;
  htim1.Init.Period = 65535;
  htim1.Init.ClockDivision = TIM_CLOCKDIVISION_DIV1;
  htim1.Init.RepetitionCounter = 0;
  htim1.Init.AutoReloadPreload = TIM_AUTORELOAD_PRELOAD_DISABLE;
  sConfig.EncoderMode = TIM_ENCODERMODE_TI12;
  sConfig.IC1Polarity = TIM_ICPOLARITY_RISING;
  sConfig.IC1Selection = TIM_ICSELECTION_DIRECTTI;
  sConfig.IC1Prescaler = TIM_ICPSC_DIV1;
  sConfig.IC1Filter = 0;
  sConfig.IC2Polarity = TIM_ICPOLARITY_FALLING;
  sConfig.IC2Selection = TIM_ICSELECTION_DIRECTTI;
  sConfig.IC2Prescaler = TIM_ICPSC_DIV1;
  sConfig.IC2Filter = 0;
  if (HAL_TIM_Encoder_Init(&htim1, &sConfig) != HAL_OK)
  {
    Error_Handler();
  }
  sMasterConfig.MasterOutputTrigger = TIM_TRGO_RESET;
  sMasterConfig.MasterSlaveMode = TIM_MASTERSLAVEMODE_DISABLE;
  if (HAL_TIMEx_MasterConfigSynchronization(&htim1, &sMasterConfig) != HAL_OK)
  {
    Error_Handler();
  }
  /* USER CODE BEGIN TIM1_Init 2 */

  /* USER CODE END TIM1_Init 2 */

}

/**
  * @brief TIM2 Initialization Function
  * @param None
  * @retval None
  */
static void MX_TIM2_Init(void)
{

  /* USER CODE BEGIN TIM2_Init 0 */

  /* USER CODE END TIM2_Init 0 */

  TIM_MasterConfigTypeDef sMasterConfig = {0};
  TIM_OC_InitTypeDef sConfigOC = {0};

  /* USER CODE BEGIN TIM2_Init 1 */

  /* USER CODE END TIM2_Init 1 */
  htim2.Instance = TIM2;
  htim2.Init.Prescaler = 0;
  htim2.Init.CounterMode = TIM_COUNTERMODE_UP;
  htim2.Init.Period = 90-1;
  htim2.Init.ClockDivision = TIM_CLOCKDIVISION_DIV1;
  htim2.Init.AutoReloadPreload = TIM_AUTORELOAD_PRELOAD_DISABLE;
  if (HAL_TIM_PWM_Init(&htim2) != HAL_OK)
  {
    Error_Handler();
  }
  sMasterConfig.MasterOutputTrigger = TIM_TRGO_RESET;
  sMasterConfig.MasterSlaveMode = TIM_MASTERSLAVEMODE_DISABLE;
  if (HAL_TIMEx_MasterConfigSynchronization(&htim2, &sMasterConfig) != HAL_OK)
  {
    Error_Handler();
  }
  sConfigOC.OCMode = TIM_OCMODE_PWM1;
  sConfigOC.Pulse = 0;
  sConfigOC.OCPolarity = TIM_OCPOLARITY_HIGH;
  sConfigOC.OCFastMode = TIM_OCFAST_DISABLE;
  if (HAL_TIM_PWM_ConfigChannel(&htim2, &sConfigOC, TIM_CHANNEL_3) != HAL_OK)
  {
    Error_Handler();
  }
  /* USER CODE BEGIN TIM2_Init 2 */

  /* USER CODE END TIM2_Init 2 */
  HAL_TIM_MspPostInit(&htim2);

}

/**
  * @brief TIM3 Initialization Function
  * @param None
  * @retval None
  */
static void MX_TIM3_Init(void)
{

  /* USER CODE BEGIN TIM3_Init 0 */

  /* USER CODE END TIM3_Init 0 */

  TIM_Encoder_InitTypeDef sConfig = {0};
  TIM_MasterConfigTypeDef sMasterConfig = {0};

  /* USER CODE BEGIN TIM3_Init 1 */

  /* USER CODE END TIM3_Init 1 */
  htim3.Instance = TIM3;
  htim3.Init.Prescaler = 0;
  htim3.Init.CounterMode = TIM_COUNTERMODE_UP;
  htim3.Init.Period = 65535;
  htim3.Init.ClockDivision = TIM_CLOCKDIVISION_DIV1;
  htim3.Init.AutoReloadPreload = TIM_AUTORELOAD_PRELOAD_DISABLE;
  sConfig.EncoderMode = TIM_ENCODERMODE_TI12;
  sConfig.IC1Polarity = TIM_ICPOLARITY_RISING;
  sConfig.IC1Selection = TIM_ICSELECTION_DIRECTTI;
  sConfig.IC1Prescaler = TIM_ICPSC_DIV1;
  sConfig.IC1Filter = 0;
  sConfig.IC2Polarity = TIM_ICPOLARITY_FALLING;
  sConfig.IC2Selection = TIM_ICSELECTION_DIRECTTI;
  sConfig.IC2Prescaler = TIM_ICPSC_DIV1;
  sConfig.IC2Filter = 0;
  if (HAL_TIM_Encoder_Init(&htim3, &sConfig) != HAL_OK)
  {
    Error_Handler();
  }
  sMasterConfig.MasterOutputTrigger = TIM_TRGO_RESET;
  sMasterConfig.MasterSlaveMode = TIM_MASTERSLAVEMODE_DISABLE;
  if (HAL_TIMEx_MasterConfigSynchronization(&htim3, &sMasterConfig) != HAL_OK)
  {
    Error_Handler();
  }
  /* USER CODE BEGIN TIM3_Init 2 */

  /* USER CODE END TIM3_Init 2 */

}

/**
  * @brief USART3 Initialization Function
  * @param None
  * @retval None
  */
static void MX_USART3_UART_Init(void)
{

  /* USER CODE BEGIN USART3_Init 0 */

  /* USER CODE END USART3_Init 0 */

  /* USER CODE BEGIN USART3_Init 1 */

  /* USER CODE END USART3_Init 1 */
  huart3.Instance = USART3;
  huart3.Init.BaudRate = 115200;
  huart3.Init.WordLength = UART_WORDLENGTH_8B;
  huart3.Init.StopBits = UART_STOPBITS_1;
  huart3.Init.Parity = UART_PARITY_NONE;
  huart3.Init.Mode = UART_MODE_TX;
  huart3.Init.HwFlowCtl = UART_HWCONTROL_NONE;
  huart3.Init.OverSampling = UART_OVERSAMPLING_16;
  if (HAL_UART_Init(&huart3) != HAL_OK)
  {
    Error_Handler();
  }
  /* USER CODE BEGIN USART3_Init 2 */

  /* USER CODE END USART3_Init 2 */

}

/**
  * Enable DMA controller clock
  */
static void MX_DMA_Init(void)
{

  /* DMA controller clock enable */
  __HAL_RCC_DMA1_CLK_ENABLE();

  /* DMA interrupt init */
  /* DMA1_Channel1_IRQn interrupt configuration */
  HAL_NVIC_SetPriority(DMA1_Channel1_IRQn, 0, 0);
  HAL_NVIC_EnableIRQ(DMA1_Channel1_IRQn);

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
  HAL_GPIO_WritePin(debug_led_GPIO_Port, debug_led_Pin, GPIO_PIN_RESET);

  /*Configure GPIO pin Output Level */
  HAL_GPIO_WritePin(GPIOB, rotary_button_leds_Pin|left_button_leds_Pin, GPIO_PIN_RESET);

  /*Configure GPIO pin Output Level */
  HAL_GPIO_WritePin(right_button_leds_GPIO_Port, right_button_leds_Pin, GPIO_PIN_RESET);

  /*Configure GPIO pin : debug_led_Pin */
  GPIO_InitStruct.Pin = debug_led_Pin;
  GPIO_InitStruct.Mode = GPIO_MODE_OUTPUT_PP;
  GPIO_InitStruct.Pull = GPIO_NOPULL;
  GPIO_InitStruct.Speed = GPIO_SPEED_FREQ_LOW;
  HAL_GPIO_Init(debug_led_GPIO_Port, &GPIO_InitStruct);

  /*Configure GPIO pins : left_down_rotary_button_Pin map_button_Pin right_down_button_Pin */
  GPIO_InitStruct.Pin = left_down_rotary_button_Pin|map_button_Pin|right_down_button_Pin;
  GPIO_InitStruct.Mode = GPIO_MODE_INPUT;
  GPIO_InitStruct.Pull = GPIO_PULLUP;
  HAL_GPIO_Init(GPIOA, &GPIO_InitStruct);

  /*Configure GPIO pins : rotary_button_leds_Pin left_button_leds_Pin */
  GPIO_InitStruct.Pin = rotary_button_leds_Pin|left_button_leds_Pin;
  GPIO_InitStruct.Mode = GPIO_MODE_OUTPUT_PP;
  GPIO_InitStruct.Pull = GPIO_NOPULL;
  GPIO_InitStruct.Speed = GPIO_SPEED_FREQ_LOW;
  HAL_GPIO_Init(GPIOB, &GPIO_InitStruct);

  /*Configure GPIO pins : right_down_rotary_button_Pin left_down_button_Pin */
  GPIO_InitStruct.Pin = right_down_rotary_button_Pin|left_down_button_Pin;
  GPIO_InitStruct.Mode = GPIO_MODE_INPUT;
  GPIO_InitStruct.Pull = GPIO_PULLUP;
  HAL_GPIO_Init(GPIOB, &GPIO_InitStruct);

  /*Configure GPIO pin : right_button_leds_Pin */
  GPIO_InitStruct.Pin = right_button_leds_Pin;
  GPIO_InitStruct.Mode = GPIO_MODE_OUTPUT_PP;
  GPIO_InitStruct.Pull = GPIO_NOPULL;
  GPIO_InitStruct.Speed = GPIO_SPEED_FREQ_LOW;
  HAL_GPIO_Init(right_button_leds_GPIO_Port, &GPIO_InitStruct);

  /*Configure GPIO pins : right_upper_button_Pin left_upper_button_Pin */
  GPIO_InitStruct.Pin = right_upper_button_Pin|left_upper_button_Pin;
  GPIO_InitStruct.Mode = GPIO_MODE_IT_FALLING;
  GPIO_InitStruct.Pull = GPIO_PULLUP;
  HAL_GPIO_Init(GPIOB, &GPIO_InitStruct);

  /* EXTI interrupt init*/
  HAL_NVIC_SetPriority(EXTI3_IRQn, 0, 0);
  HAL_NVIC_EnableIRQ(EXTI3_IRQn);

  HAL_NVIC_SetPriority(EXTI9_5_IRQn, 0, 0);
  HAL_NVIC_EnableIRQ(EXTI9_5_IRQn);

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
