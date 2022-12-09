# ObjectManipulator

A Unity Project that allows the use of manipulating an object in an empty scene with simulated gimbal controls. The specifications are to address the criteria listed below.

![image](https://user-images.githubusercontent.com/10134730/206636361-bad6c284-a141-4d2a-a91a-3adec1133ae4.png)

Implement object manipulation per the above spec, meeting the following requirements:

- Translation, rotation, and scaling of object on x, y, z axes via gimbal controls and mouse click
    - Note - your build does not need to work in XR
- Any mesh is acceptable i.e. the standard Unity cube is fine
- The gimbal handles do not need to aesthetically match the above spec. Colors / materials are irrelevant and placeholder meshes are fine
- The purpose of this exercise is to demonstrate your ability to code functionality - not aesthetics or animations - in a polished manner as well as document your work effectively

Instructions for build player
The provided build will start the demo in windowed mode.

Rotation

![image](https://user-images.githubusercontent.com/10134730/206637469-031bcfec-f5f2-45b0-80a0-571334068d67.png)

The rings represent rotation gimbal controls. With the primary mouse button, click and hold any one of the three ring game object to begin the rotation function. With the innermost ring, moving the mouse up or down will cause the cube gameobject to rotate along its X-axis. In the centermost ring, moving the mouse left or right will cause the cube to rotate along its Y-axis. With the outermost ring, moving the mouse left or right will cause the cube to rotate along its Z-Axis.

Translation

![image](https://user-images.githubusercontent.com/10134730/206637964-5adc2442-52f0-4346-ae2f-61c8681a7b38.png)

The triangle gameobjects represent controls to translate the object with mouse controls. With the primary mouse button, click and hold on any of the three triangle game objects. Moving left to right with the mouse while performing a hold click on the left most triangle will move the object left to right. Moving up to down with the mouse while performing a hold click on the top most triangle will move the object up and down. Moving up to down with the mouse while performing a hold click on the bottom most triangle will move the object forward to back. 

Scale

![image](https://user-images.githubusercontent.com/10134730/206638246-aa7681a9-fb18-47d5-8f56-daed9bc3bebf.png)

The sphere game objects represent controls to scale the object with mouse controls. With the primary mouse button, click and hold on any of the three triangle game objects. The manipulatable scale of the cube object itself goes from a range of 0 to 1.5. Moving left to right with the mouse while performing a hold click on the left most sphere will scale the object along the X-axis. Moving up to down with the mouse while performing a hold click on the top most sphere will scale the object up and down. Moving up to down with the mouse while performing a hold click on the bottom most sphere will scale the object forward to back. 

Reset

![image](https://user-images.githubusercontent.com/10134730/206638336-8a30cb9b-992d-4aeb-a182-60e552f6f383.png)

If at anytime you would like to reset the manipulatable object to zero, press the reset button on the bottom right. It will reset the scene
