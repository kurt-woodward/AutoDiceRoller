# AutoDiceRoller
In this project I intend to explore the Software Development Lifecycle through building a small, RaspberyyPi-controlled device to automatically roll dice, recognize the displayed face, and calculate the fairness of the device over repeated trials.  
  
The backend was developed using C#, T-SQL, and Python, with Postman for API development, while the frontend used Visual Studio scaffolding for HTML/CSS via Bootstrap. There is still a lot of room to explore and incrementally improve both the hardware and software as I gain proficiency with each of the components.  

## Table of Contents  
#### 1. [Model Classes](#1-model-classes)  
#### 2. [Database](#2-database)  
#### 3. [Sprints](#3-sprints)  
#### 4. [User Interface](#4-user-interface)  
#### 5. [API](#5-api)  
#### 6. [Software Testing](#6-software-testing)  
#### 7. [Hardware Setup and Configuration](#7-hardware-setup-and-configuration)  
#### 8. [Challenges, Lessons Learned, Lucky Moments](#8-challenges-lessons-learned-lucky-moments)  
#### 9. [Special Thanks and Inspiration](#9-special-thanks-and-inspiration)  

### 1. [Model Classes](#1-model-classes)  
[Model Classes](https://github.com/kurt-woodward/AutoDiceRoller/tree/main/AutoDiceRoller/Models)  
#### 1a.  DiceRollerDBContext.cs
> This is the scaffolded class generated from the DiceRoller database.
#### 1a.  ErrorViewModel.cs  
> This is the default scaffolded error handler.
#### 1a.  OcrResult.cs  
> This model underlies a scaffolded form where entries can be made and modified manually. Eventually, I would like to make this accessible only via API or a future admin login. 
### 2. [Database](#2-database)  
[Database](https://github.com/kurt-woodward/AutoDiceRoller/tree/main/Diagrams/README.md)  
![Initial Entity Relationship Diagram](https://raw.githubusercontent.com/kurt-woodward/AutoDiceRoller/main/Diagrams/AutoDiceRoller_ERD.jpg)
#### 2a. Initial Entity Relationship Diagram. The app currently only implements some of these features.
![Current SSMS Database Diagram](https://raw.githubusercontent.com/kurt-woodward/AutoDiceRoller/main/Diagrams/Database_Diagram.JPG)
#### 2b. Current SSMS Database Diagram
### 3. [Sprints](#3-sprints)  
[Sprints](https://github.com/kurt-woodward/AutoDiceRoller/tree/main/Sprints)  
#### 3a. Sprint 1:  
> This week was spent brushing up on Linux, learning to compile Python libraries, and systematically tracking down the many dependencies of dependencies required to get the OpenCV and SciKit Image libraries up and running.  
#### 3b. Sprint 2:  
![Sprint 2](https://raw.githubusercontent.com/kurt-woodward/AutoDiceRoller/main/Sprints/Week%202/Sprint_Week_2_Burndown_Chart.JPG)  
> This week was spent trying unsuccesfully to implement the MVC web app design pattern. Progress was hindered by information overload, and too many, often conflicting, potential starting points.  
#### 3c. Sprint 3:  
> Breakthrough this week when my instructor, Dan S., asked my classmates Jonathan R. and Brenden W. to help me get a handle on MVC apps. They did so by walking me through a bare-essentials, database-first toy model. Where I was getting lost in a forest of detail, they pointed me to landmarks in the underlying software geography.  
#### 3d. Sprint 4:  
> Implemented logic to allow the app to handle HTTP POST and GET requests from an API. The Python Requests library will be very useful here. Affixed the roller box to a servo motor and mounted the assembly to a ring stand (a.k.a. retort stand), as the camera had a fixed optimum focal distance. Temporarily used a spare Raspberry Pi 3B+ to calibrate the servo motor and script some controls in Python while the RPi 4 was in use working to improve character recognition rates. Switched from a d10 to a d6, since sometimes the OCR algorithm would pick up the wrong face. 
### 4. [User Interface](#4-user-interface)  
> Screenshots  
![Placeholder](https://placeholder)  
### 5. [API](#5-api)  
![Placeholder](https://placeholder) Postman screenshot  
![Placeholder](https://placeholder) Sending from RaspberryPi  
### 6. [Software Testing](#6-software-testing)  

#### 6a. Requirements Table  

#### 6b. Test Chart  

### 7. [Hardware Setup and Configuration](#7-hardware-setup-and-configuration)  
[Hardware Setup and Configuration](https://github.com/kurt-woodward/AutoDiceRoller/blob/main/Device%20Build/README.md)  
#### 
#### 7a. Installing Ubuntu Server 20.04
> This was surprisingly simple. Ubuntu has an application that allows you to select from a number of images appropriate for various RaspberryPi models and purposes and automatically formats your installation drive. 
#### 7b. Installing required Python libraries
### 8. [Challenges, Lessons Learned, Lucky Moments](#8-challenges-lessons-learned-lucky-moments)
### 9. [Special Thanks & Inspiration](#9-special-thanks-and-inspiration)

