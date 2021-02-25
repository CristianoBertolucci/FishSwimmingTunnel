#include <TimerOne.h>

#include <Adafruit_MAX31865.h>  //pt100 sensor
// Use software SPI: CS, DI, DO, CLK
Adafruit_MAX31865 max = Adafruit_MAX31865(10, 11, 12, 13);
// The value of the Rref resistor. Use 430.0 for PT100 and 4300.0 for PT1000
#define RREF      430.0
// The 'nominal' 0-degrees-C resistance of the sensor
// 100.0 for PT100, 1000.0 for PT1000
#define RNOMINAL  100.0
//------------------------------------------------------------------------
//constants and variables for PWM control --> 0-10V 
#define PIN_PWM 9 // PWM pin for 0-10V
int duty = 256; //this is 25%
//------------------------------------------------------------------------
//constants and variables for  ph sensor
#define SensorPin A0      //pH meter Analog output to Arduino Analog Input 0
//#define Offset 0.00     //deviation compensate
#define Offset 0.15       
//#define LED 13
#define samplingInterval 20
#define printInterval 1000
#define ArrayLenth  40    //times of collection
int pHArray[ArrayLenth];  //Store the average value of the sensor feedback
int pHArrayIndex=0;
//------------------------------------------------------------------------

String stringa, comando, par;

void setup(void)
{
  max.begin(MAX31865_2WIRE);  // set to 2WIRE or 4WIRE as necessary
  pinMode(PIN_PWM, OUTPUT);
  Timer1.initialize(5000);//in microseconds. Period of wave, 5000 = 200 Hz *** 1000 = 1kHz *** 500 = 2kHz
  Serial.begin(115200);
  Timer1.pwm(PIN_PWM, duty);//Configure one of the timer's PWM pins. "duty" is from 0 to 1023, where 0 makes the pin always LOW and 1023 makes the pin always HIGH.
  //Timer1.setPwmDuty(pin, duty);//Set a new PWM, without reconfiguring the pin. This is slightly faster than pwm(), but pwm() must be used at least once to configure the pin.
  //Timer1.disablePwm(pin); //Stop using PWM on a pin. The pin reverts to being controlled by digitalWrite().
  Serial.println("Alive");
}


void loop(void)
{ 
  static unsigned long samplingTime = millis();
  static unsigned long printTime = millis();
  static float pHValue,voltage;
  
  //board for PH conversion
  if(millis()-samplingTime > samplingInterval)
  {
      pHArray[pHArrayIndex++]=analogRead(SensorPin);
      if(pHArrayIndex==ArrayLenth)pHArrayIndex=0;
      voltage = avergearray(pHArray, ArrayLenth)*5.0/1024;
      pHValue = 3.5*voltage+Offset;
      samplingTime=millis();
  }
  
  //board for Pt100 conversion
  uint16_t rtd = max.readRTD();
  //Serial.print("RTD value: "); Serial.println(rtd);
  float ratio = rtd;
  ratio /= 32768;
  //Serial.print("Ratio = "); Serial.println(ratio,8);
  //Serial.print("Resistance = "); Serial.println(RREF*ratio,8);

  //writing temperature and ph
  if(millis() - printTime > printInterval)   //Every 800 milliseconds, print a numerical, convert the state of the LED indicator
  {
    //Serial.print("T="); 
    Serial.print(max.temperature(RNOMINAL, RREF));
    Serial.print("*");
    //Serial.print("PH=");
    Serial.println(pHValue,2);
  }
    
  while (Serial.available() > 0) 
      {
        //parsing
        stringa = Serial.readString();
        comando = stringa.substring(0, 3); 
        Serial.print("ric:");    
        Serial.print(comando);    
        if (comando == "dut")
          {
            par =  stringa.substring(3,stringa.length());
            duty = par.toInt();
            Serial.print(duty);
            Serial.print("\n\r");
            if ((1024 - duty) > 0)
              duty = 1024 - duty;
            //duty 200 --> 20%
            //duty 500 --> 50%
            //duty 1000 --> 98%
            Timer1.setPwmDuty(PIN_PWM, duty);//Set a new PWM, without reconfiguring the pin. This is slightly faster than pwm(), but pwm() must be used at least once to configure the pin.
          }
      }
}


//function for avarage calculation
double avergearray(int* arr, int number){
  int i;
  int max,min;
  double avg;
  long amount=0;
  if(number<=0){
    Serial.println("Error number for the array to avraging!/n");
    return 0;
  }
  if(number<5){   //less than 5, calculated directly statistics
    for(i=0;i<number;i++){
      amount+=arr[i];
    }
    avg = amount/number;
    return avg;
  }else{
    if(arr[0]<arr[1]){
      min = arr[0];max=arr[1];
    }
    else{
      min=arr[1];max=arr[0];
    }
    for(i=2;i<number;i++){
      if(arr[i]<min){
        amount+=min;        //arr<min
        min=arr[i];
      }else {
        if(arr[i]>max){
          amount+=max;    //arr>max
          max=arr[i];
        }else{
          amount+=arr[i]; //min<=arr<=max
        }
      }//if
    }//for
    avg = (double)amount/(number-2);
  }//if
  return avg;
}
