/* USER CODE BEGIN Header */
/**
  ******************************************************************************
  * @file           : main.h
  * @brief          : Header for main.c file.
  *                   This file contains the common defines of the application.
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

/* Define to prevent recursive inclusion -------------------------------------*/
#ifndef __MAIN_H
#define __MAIN_H

#ifdef __cplusplus
extern "C" {
#endif

/* Includes ------------------------------------------------------------------*/
#include "stm32f1xx_hal.h"

/* Private includes ----------------------------------------------------------*/
/* USER CODE BEGIN Includes */

/* USER CODE END Includes */

/* Exported types ------------------------------------------------------------*/
/* USER CODE BEGIN ET */

/* USER CODE END ET */

/* Exported constants --------------------------------------------------------*/
/* USER CODE BEGIN EC */

/* USER CODE END EC */

/* Exported macro ------------------------------------------------------------*/
/* USER CODE BEGIN EM */

/* USER CODE END EM */

void HAL_TIM_MspPostInit(TIM_HandleTypeDef *htim);

/* Exported functions prototypes ---------------------------------------------*/
void Error_Handler(void);

/* USER CODE BEGIN EFP */

/* USER CODE END EFP */

/* Private defines -----------------------------------------------------------*/
#define debug_led_Pin GPIO_PIN_13
#define debug_led_GPIO_Port GPIOC
#define launch_button_Pin GPIO_PIN_0
#define launch_button_GPIO_Port GPIOA
#define left_down_rotary_button_Pin GPIO_PIN_4
#define left_down_rotary_button_GPIO_Port GPIOA
#define rotary_button_leds_Pin GPIO_PIN_0
#define rotary_button_leds_GPIO_Port GPIOB
#define left_button_leds_Pin GPIO_PIN_1
#define left_button_leds_GPIO_Port GPIOB
#define right_down_rotary_button_Pin GPIO_PIN_2
#define right_down_rotary_button_GPIO_Port GPIOB
#define DP_TX_Pin GPIO_PIN_10
#define DP_TX_GPIO_Port GPIOB
#define DP_RX_Pin GPIO_PIN_11
#define DP_RX_GPIO_Port GPIOB
#define right_button_leds_Pin GPIO_PIN_10
#define right_button_leds_GPIO_Port GPIOA
#define map_button_Pin GPIO_PIN_11
#define map_button_GPIO_Port GPIOA
#define right_down_button_Pin GPIO_PIN_15
#define right_down_button_GPIO_Port GPIOA
#define right_upper_button_Pin GPIO_PIN_3
#define right_upper_button_GPIO_Port GPIOB
#define right_upper_button_EXTI_IRQn EXTI3_IRQn
#define left_upper_button_Pin GPIO_PIN_5
#define left_upper_button_GPIO_Port GPIOB
#define left_upper_button_EXTI_IRQn EXTI9_5_IRQn
#define left_down_button_Pin GPIO_PIN_6
#define left_down_button_GPIO_Port GPIOB

/* USER CODE BEGIN Private defines */

/* USER CODE END Private defines */

#ifdef __cplusplus
}
#endif

#endif /* __MAIN_H */
