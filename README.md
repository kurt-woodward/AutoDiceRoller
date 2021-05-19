# AutoDiceRoller
In this project I intend to explore the Software Development Life Cycle through building a small, RaspberyyPi-controlled device to automatically roll dice, recognize the displayed face, and calculate the fairness of the device over repeated trials.  
  
The backend was developed using C#, T-SQL, and Python, with Postman for API development, while the frontend used Visual Studio scaffolding for HTML/CSS via Bootstrap. There is still a lot of room to explore and incrementally improve both the hardware and software as I gain proficiency with each of the components.  

## Table of Contents  
#### 1. [Model Classes](#model-classes)  
#### 2. [Database](#database)  
#### 3. [Sprints](#sprints)  
#### 4. [User Interface](#user-interface)  
#### 5. [API](#api)  
#### 6. [Software Testing](#software-testing)  
#### 7. [Hardware Setup and Configuration](#hardware-setup-and-configuration)  
#### 8. [Challenges, Lessons Learned, Lucky Moments](#challenges-lessons-learned-lucky-moments)  
#### 9. [Special Thanks and Inspiration](#special-thanks-and-inspiration)  

### [Model Classes](#1-model-classes)  
[Models](https://github.com/kurt-woodward/AutoDiceRoller/tree/main/AutoDiceRoller/Models)  
####  DiceRollerDBContext.cs
> This is the scaffolded class generated from the DiceRoller database.
####  ErrorViewModel.cs  
> This is the default scaffolded error handler.
####  OcrResult.cs  
> This model underlies a scaffolded form where entries can be made and modified manually. Eventually, I would like to make this accessible only via API or a future admin login. 
### [Database](#2-database)  
#### [Database Integration](https://github.com/kurt-woodward/AutoDiceRoller/blob/main/Diagrams/README.md#database-integration--crud-operations-from-web-app-and-api)
![Initial Entity Relationship Diagram](https://raw.githubusercontent.com/kurt-woodward/AutoDiceRoller/main/Diagrams/AutoDiceRoller_ERD.jpg)
#### Initial Entity Relationship Diagram. The app currently only implements some of these features.
![Current SSMS Database Diagram](https://raw.githubusercontent.com/kurt-woodward/AutoDiceRoller/main/Diagrams/Database_Diagram.JPG)
#### Current SSMS Database Diagram
### [Sprints](#3-sprints)  
#### Sprint 1:  
> This week was spent brushing up on Linux, learning to compile Python libraries, and systematically tracking down the many dependencies of dependencies required to get the OpenCV and SciKit Image libraries up and running.  
#### Sprint 2:  
![Sprint 2](https://raw.githubusercontent.com/kurt-woodward/AutoDiceRoller/main/Sprints/Week%202/Sprint_Week_2_Burndown_Chart.JPG)  
> This week was spent trying unsuccesfully to implement the MVC web app design pattern. Progress was hindered by information overload, and too many, often conflicting, potential starting points.  
#### Sprint 3:  
> Breakthrough this week when my instructor, Dan S., asked my classmates Jonathan R. and Brenden W. to help me get a handle on MVC apps. They did so by walking me through a bare-essentials, database-first toy model. Where I was getting lost in a forest of detail, they pointed me to landmarks in the underlying software geography.  
#### Sprint 4:  
> Implemented logic to allow the app to handle HTTP POST and GET requests from an API. The Python Requests library will be very useful here. Affixed the roller box to a servo motor and mounted the assembly to a ring stand (a.k.a. retort stand), as the camera had a fixed optimum focal distance. Temporarily used a spare Raspberry Pi 3B+ to calibrate the servo motor and script some controls in Python while the RPi 4 was in use working to improve character recognition rates. Switched from a d10 to a d6, since sometimes the OCR algorithm would pick up the wrong face. 
### [User Interface](#4-user-interface)  
> Screenshots  
![Placeholder](https://placeholder)  
### [API](#5-api)  
![Placeholder](https://placeholder) Postman screenshot  
![Placeholder](https://placeholder) Sending from RaspberryPi  
### [Software Testing](#6-software-testing)  

#### Requirements Table  
##### TODO  
#### Test Chart  
##### TODO  

### [Hardware Setup and Configuration](#7-hardware-setup-and-configuration)  
[Hardware Setup README](https://github.com/kurt-woodward/AutoDiceRoller/blob/main/Device%20Build/README.md)  
#### Installing Ubuntu Server 20.04
> This was surprisingly simple. Canonical has an [application](https://ubuntu.com/tutorials/how-to-install-ubuntu-on-your-raspberry-pi#1-overview) that allows you to select from a number of Rasperry Pi OS or Ubuntu images appropriate for various RaspberryPi models and purposes, and automatically formats and writes to your chosen installation media. Network access for downloading updates, packages, and libraries can be configured by editing a (OS-specific) .txt file on the installation media.
#### Installing required Python libraries
> This was something of a headache. I learned that best practice when starting a new Python project is to set up a 'virtual environment', so that dependencies from one project don't conflict with those from another. I believe this is similar in purpose to Visual Studio's 'solutions'. Then I followed installation tutorials for each library. Some were simple using Pip or Apt Install commands, but SciKit Image and OpenCV had to be compiled from source. Apparently, it has something to do with the Pi CPU's architecture (ARM).
> Libraries used include: 
> -OpenCV (optical character recognition)
> -NumPy
> -SciKit
> -PyTorch
> -RPi.GPIO (Control servo motor via RPi's General Purpose Input-Output pins)
### [Challenges, Lessons Learned, Lucky Moments](#8-challenges-lessons-learned-lucky-moments)  
> Challenges:  
  
> --Getting an MVC app up and running outside of the textbook assignments. I still have to figure out how to dress it all up without it getting hopelessly complicated.  
> --Quirky Linux/RPi/Python/Library interactions. I originally wanted to use the RPi camera module since it doesn't have to compete with USB devices for bandwidth, but it's nearly impossible to do on Ubuntu. Conversely, installing/compiling the required libraries on Raspberry Pi OS would have even more time and labor intensive than it was.  
> --Documenting my process and efforts has been a struggle. I know it's worth it and makes for better software, so I will continue to work on this area.  

> -Lessons Learned:  
> --Start smaller when learning a new skill. This was my second project for this course. The first one, codenamed [ViridianKrypton](), was too broad in scope to implement effectively (and securely) at my current skill level.  
> --Time management while working from home. It took many weeks to discover (what my wife is all-too familiar with) that the only way I would get uninterrupted study time was to shift my sleep schedule as much as possible to daylight hours, and work late into the night.  
  
> -Lucky Moments:  
> --Listening to a podcast on a long drive, I heard an interview with author Adrian Rosebrock, PhD. In the interview Dr. Rosebrock described the tools needed to accomplish the computer vision piece. Additionally, he hosts a number of excellent tutorials on the [PyImageSearch website](https://www.pyimagesearch.com/) which I relied on heavily while configuring the Python virtual environment and compiling OpenCV.  
> --Learning to follow & debug C# applications translated surprisingly well to tinkering with parametric CAD files in [OpenSCAD](https://openscad.org/index.html). This allowed me to add windows to an n-sided box model from [Thingiverse](https://www.thingiverse.com/thing:27716) and 3d print it without much fuss.  
> -- My wife thought of mounting the dice box and camera on a ring stand, which saved me the time of designing and building a mount out of plywood. She wanted one anyway, so it was win-win.  
### [Special Thanks & Inspiration](#9-special-thanks-and-inspiration)  
> My gratitude goes out to:  
> -My family for putting up with me during these past 19 weeks in MSSA.  
> -Our instructor, Dan S., for his time and patience.  
> -My many classmates for their empathy & encouragement while still keeping things real.  
> -In particular, Melanie M. and Johnathan S. for general life and career advice, and Brenden W. and Jonathan R. for helping me through my mental block on MVC apps.  
  
> This project was inspired by a dice rolling machine seen in this [YouTube video](https://youtu.be/UxT8COXu6zE?t=429) by DM Rybonator. He was reviewing a set of Bluetooth-enabled dice [(see Kickstarter)](https://www.kickstarter.com/projects/pixels-dice/pixels-the-electronic-dice) that could report the results of rolls through a mobile phone speaker for vision-impaired players, or through platforms like Discord to enhance geographically-dispersed Table-Top RPGs.  
