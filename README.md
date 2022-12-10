# ObjectManipulator

A Unity Project that allows the use of manipulating an object in an empty scene with simulated gimbal controls. The specifications are to address the criteria listed below.

![image](https://user-images.githubusercontent.com/10134730/206636361-bad6c284-a141-4d2a-a91a-3adec1133ae4.png)

Implement object manipulation per the above spec, meeting the following requirements:

- Translation, rotation, and scaling of object on x, y, z axes via gimbal controls and mouse click
    - Note - your build does not need to work in XR
- Any mesh is acceptable i.e. the standard Unity cube is fine
- The gimbal handles do not need to aesthetically match the above spec. Colors / materials are irrelevant and placeholder meshes are fine
- The purpose of this exercise is to demonstrate your ability to code functionality - not aesthetics or animations - in a polished manner as well as document your work effectively

## Instructions for build player
The provided build will start the demo in windowed mode.

### Rotation

![image](https://user-images.githubusercontent.com/10134730/206874346-affa474b-31e9-4ce4-abdd-e8935a599edb.png)

The rings represent rotation gimbal controls. With the primary mouse button, click and hold any one of the three ring game object to begin the rotation function. With the innermost ring, moving the mouse up or down will cause the cube gameobject to rotate along its X-axis. In the centermost ring, moving the mouse left or right will cause the cube to rotate along its Y-axis. With the outermost ring, moving the mouse left or right will cause the cube to rotate along its Z-Axis.

### Translation

![image](https://user-images.githubusercontent.com/10134730/206874391-f22d80e0-4551-4fb3-9413-9b59c1f019b4.png)

The triangle gameobjects represent controls to translate the object with mouse controls. With the primary mouse button, click and hold on any of the three triangle game objects. Moving left to right with the mouse while performing a hold click on the left most triangle will move the object left to right. Moving up to down with the mouse while performing a hold click on the top most triangle will move the object up and down. Moving up to down with the mouse while performing a hold click on the bottom most triangle will move the object forward to back. 

### Scale

![image](https://user-images.githubusercontent.com/10134730/206874420-04a4f240-a036-4ae7-ba12-6b3ab831cc5b.png)

The sphere game objects represent controls to scale the object with mouse controls. With the primary mouse button, click and hold on any of the three triangle game objects. The manipulatable scale of the cube object itself goes from a range of 0 to 1.5. Moving left to right with the mouse while performing a hold click on the left most sphere will scale the object along the X-axis. Moving up to down with the mouse while performing a hold click on the top most sphere will scale the object up and down. Moving up to down with the mouse while performing a hold click on the bottom most sphere will scale the object forward to back. 

### Reset

![image](https://user-images.githubusercontent.com/10134730/206638336-8a30cb9b-992d-4aeb-a182-60e552f6f383.png)

If at anytime you would like to reset the manipulatable object to zero, press the reset button on the bottom right. It will reset the scene

## Instructions for Unity Project

If you would like to examine the contents of the project and scene itself. Ensure you are opening the project with 2020.3.42f1. Inside the scenes folder you will find the main scene SampleScene.

The main game object is ObjectManipulator and attached to it is a Controller script. The Controller script has public references to the target mesh, in this case the cube, and the different triangle, sphere, and rings used for the gimbal controls or prism, sphere, and rotate respectively. The Controller script has functions that it uses to serve the rotation, translation, and scale manipulation by subscribing them to events that come from the MouseMoveX and MouseMoveY scripts.

MouseMoveX and MouseMoveY
Each control game object has a MouseMoveX or MouseMoveY script attached to them, depending on the interaction. Each of these scripts create an event and call them when the OnMouseDrag method is raised. The scripts will then communicate the event out to the Controller script.

To create a build of your own, Go to File, Build Settings. Ensure Scenes/SampleScene is included in the Scenes in Build and click Build to a folder directory of your choosing
