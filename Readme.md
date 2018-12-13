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

# Development

## Basics
First, you need to have your targets as defined in Vuforia's Developer portal.  Upload images there and download the database for Unity.  Open it and Unity will import everything for you.

#### Creating a trackable
Place an empty `GameObject` in the scene.  This is the container that the trackable will live in.  

Then, under this container, place a Vuforia `Image` object.  In the `Image Target Behaviour` script, select the target you wish to use.

Place an `ARObjectManager` on this object.  This will enable and disable the tracked object contents so interaction does not affect this while it is inactive.

Place an empty `GameObject` under the Image target object.  This will hold all of the tracked object contents.  Make sure you drag this container into the `Disable Object` field of the `ARObjectManager`.

Place whatever trackable contents you want in here! You can make minigames, text elements, image views, you name it.  Take a look at the sections below to learn what tools are available out of the box.

## Interactors

The main way in which input is handled generically is through `Interactor`.  `Interactor` is an abstract class which can be extended to implement different means of interaction.
Interactors must be polled with `<interactor>.IsInteracting()`, which has the same functionality as if you are polling a button directly.

There are pre-made Interactors which can be used without modification:

* ```GamepadButton```: takes a KeyCode as the button to check
* ```GamepadJoystick```: uses an axis name and a threshold in which the axis must cross. Direction signifies if it should check in the negative direction.
* ```KeyboardButton```: Uses a button's string name
* ```KeyboardKey```: Uses a buttons KeyCode type
* ```MultiInputInteractor```: Takes a list of interactors and can be set to interact if either **ALL** or **ANY** interactor is interacting.

## Interactables

If you want to have a manager handle inputs and interactions, then you may use `Interactable` on the object which you want to make do something.
`Interactable` objects may be told to do its thing on call of `<interactable>.Interact()`.  `Interactable` must be extended to define a specific implementation.

There are pre-made Interactables which can be used without modification:

* ```Hyperlink```: Open the specific url in the system's default browser

## AR Generics
Within the `ARInteractables` folder there is a `Generics` collection.  Any feature that is generic enough to be shared across different Interactables can be placed here.

### Scroll Views
Scroll views can handle any observable media (images, text) that will overflow outside of the viewing area.  There are prefabs here that support horizontal, vertical, or bidirectional scrolling.

To use, just drag the type of scroll view you want under a canvas within a Vuforia trackable.  Within that prefab is `Viewport/Content`.  Replace the `Image` or `Text` attached to this object with whatever content you want to scroll.  

### Hyperlink
There is a hyperlink object controlled by a UI button. You can play around with the button's texture to make it look more appealing, but the functionality is there. 
The UI button (under `Button`) interacts with a `Hyperlink` Interactable.  

Drag the `Hyperlink` prefab under a canvas under a Vuforia trackable. Just update the link and you are good to go.    

## Example implementation
The `Environmental Humanities Poster` has all of the Overlay-specific features required to make a minigame, provided you know how to make a game in Unity.

Under the Vuforia target you can place your minigame.  It should contain a game manager/controller that handles input and controls.  The manager should use 
Interactors as described above.  The example given uses 2 axes to move a ball around, and a few buttons to do some color swapping.

#
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
