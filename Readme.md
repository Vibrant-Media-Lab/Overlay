# VML/Overlay
## Purpose
This was created as a final project for Pitt's ```ENGLIT/ENGFLM/ENGCMP 0712``` Critical Making course.  

## About
VML/Overlay is an immersive Augmented Reality (AR) experience for the Vibrant Media Lab.  Posters and pictures around the 
room can be scanned to be used as AR targets, allowing the room to be transformed in a virtual manner limited only by your 
imagination!

## Technologies
VML/Overlay is a Unity project developed for mobile devices.  
  
Vuforia is used to handle all of the AR overhead.  The trackable images are loaded into a ```Device``` database in the Vuforia Developer Portal.  

As this is an AR venture, there is support for a Cardboard-like VR experience provided the headset of choice gives the camera an
unobstructed view.

#### Supported devices
Refer to Vuforia's [Supported Devices](https://library.vuforia.com/content/vuforia-library/en/articles/Solution/Vuforia-Supported-Versions.html) list for 
up to date requirements.  The Unity project currently targets and has been tested on Android devices with 6.0 Marshmallow or higher.


### Gamepad mappings
##### VRBOX Controller:
in `@+B` mode:

* Joystick1Button0: B
* Joystick1Button1: D
* Joystick1Button2: C
* Joystick1Button3: A
* Joystick1Button4: Trigger
* Joystick1Button5: Bumper
* Joystick1Button11: `@`
* Joystick1Button10: Power
* `Vertical` Axis (-1,1): left-right in single-handed operation
* `Horizontal` Axis (-1,1): up-down in single-handed operation
