# Bluetooth Slide Presentation Controller 

Slide Presentation Controller is a remote controller that allows you to manage your slides in a presentation. It helps you to navigate through your presentation and control the flow of information that you are presenting. You can use it to move forward or backward through your slides, jump to specific slides, or even pause your presentation if you need to take a break or answer questions from your audience.


# Note

> This project can be used as a reference for controlling a computer or communcate with arduino via bluetooth 

# How is Work 

The "Bluetooth Slide Presentation Controller" project is a device that allows users to control their presentation slides wirelessly using an Arduino Nano and a Bluetooth module (HC-05). The project is divided into two parts - a client software and a remote controller.

The client software is built using VB.NET and is responsible for receiving commands from the remote controller and executing them. The remote controller is created using an Arduino Nano and a Bluetooth module and features two buttons - one for moving to the next slide and one for going back.

The principle of how this project works is quite simple. When the user clicks on either of the buttons on the remote controller, the remote sends information to the client software to move to the next slide or go back. The Bluetooth module allows for wireless communication between the two parts of the project, making it easy and convenient for users to control their presentation slides without the need to be close to their computer.

# Software 

This project is a small program developed in VB.NET that can be used as a client  ( written in less than 😸 15 minutes and demonstrates the simplicity and efficiency of VB.NET ) in a computer to remotely control a presentation. 
The program can receive commands from a remote control and use the "next/back" key to change the pages of the presentation in the Windows environment.

### Setup 

1. Pair HC-05 Module with PC 
1. Open App 
1. Select Port 
1. Connect
1. Open your presentation and enjoy  😎

![alt text](https://github.com/Bsm-B/Slide_Control/blob/master/client.png?raw=true)

# Hardware  

Remote control device consisting of a battery, two buttons, and an Arduino Nano microcontroller unit (MCU). The device uses an HC-05 Bluetooth module to communicate with a PC. The remote 
control can be used to send simple commands to a computer, and the Arduino Nano MCU provides the necessary processing power to handle the inputs from the buttons and the Bluetooth module

## Schematic

![alt text](https://github.com/Bsm-B/Slide_Control/blob/master/Schema.png?raw=true)


## Pinout 


| Device    |     MCU      |
|---------- |:-------------:|
| Button 01  |       D2     |
| Button 02  |       D3     |
| HC-05 (RX) |       TX     |


