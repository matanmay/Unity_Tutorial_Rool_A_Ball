# VR Roll-a-Ball

## Overview

Welcome to the VR Roll-a-Ball project! This is a virtual reality adaptation of the classic Unity "Roll-a-Ball" tutorial. The game challenges you to navigate a virtual ball through a maze-like environment, collecting all the glowing cubes ("pickups") before time runs out. The key difference in this VR version is the intuitive, motion-based control scheme. Instead of using a keyboard or mouse, you control the ball by physically tilting a virtual plane using a VR controller.

## Features

- **Immersive VR Gameplay:** Experience the classic Roll-a-Ball game in an immersive, three-dimensional VR environment.
- **Intuitive Controls:** Tilt the game plane by physically moving your VR controller, providing a natural and engaging way to control the ball.
- **Dynamic Pickups:** Collect all the scattered pickups to complete the level.
- **Interactive UI:** A user interface in the VR space displays your score and a "Win" message upon completion.
- **Particle Effects:** Enjoy particle effects when you collect pickups, adding to the game's visual feedback.
- **Sound Effects:** Hear a satisfying sound effect each time a pickup is collected.

## Requirements

- A computer capable of running Unity and a VR application.
- A compatible VR headset (e.g., Oculus Rift, HTC Vive, Valve Index, etc.).
- A VR controller for your headset.
- Unity 6.0.53 or later.

## Getting Started

1.  **Clone or Download the Repository:**
    `git clone https://github.com/matanmay/Unity_Tutorial_Rool_A_Ball.git`

2.  **Open in Unity:**
    - Launch Unity Hub.
    - Click "Add" and navigate to the project folder you just cloned.
    - Select the folder and open the project.

3.  **Configure VR Settings:**
    - Go to `Edit > Project Settings > XR Plug-in Management`.
    - Ensure your VR provider (e.g., Oculus, OpenXR) is checked under the "Windows, Mac, Linux" tab.
    - For OpenXR, you may need to add the `XR Interaction Toolkit` from the Package Manager and configure the interaction profiles.

4.  **Explore the Scene:**
    - Open the `Assets/Scenes/MainScene.unity` file.
    - The scene is set up with all the necessary game objects, including the `Player`, `Pickups`, `Ground`, and `Walls`.
    - The `Player` object has a `Rigidbody` and a custom script for VR control.
    - The `Ground` object has a custom script that takes input from the VR controller and applies a rotation.

5.  **Running the Game:**
    - Make sure your VR headset is connected and your VR runtime is active.
    - In Unity, press the "Play" button.
    - Put on your headset, and you should be able to see the game world. Use your VR controller to tilt the plane and move the ball.

## How to Play

1.  Put on your VR headset and grab your VR controller.
2.  The game will start automatically.
3.  Your VR controller is linked to the tilting of the game plane. Move the controller to tilt the plane and roll the ball.
4.  Navigate the ball to collect all the glowing cubes.
5.  Each collected cube will disappear, and your score will increase.
6.  Once you collect all the cubes, a "You Win!" message will appear, and the game will end.

## Scripts

-   `PlayerController.cs`: This script handles the movement of the ball based on the tilt of the plane. It applies forces to the ball's Rigidbody. **Note:** In this VR version, this script is simplified or replaced by the `GroundController.cs` script which controls the tilt.
-   `GroundController.cs`: **(New for VR)** This is the core of the VR control. It gets the rotation of the VR controller and applies that rotation to the `Ground` object, effectively tilting the entire play area. This creates the intuitive rolling motion.
-   `PickupController.cs`: Manages the behavior of the pickup cubes, including their rotation and the logic for their destruction upon collision with the player.
-   `GameManager.cs`: Handles game state, scorekeeping, and victory conditions. It updates the UI and checks if all pickups have been collected.

## Customization

-   **Level Design:** Modify the `Ground` and `Walls` objects to create your own unique mazes and challenges.
-   **Add More Pickups:** Duplicate the `Pickup` prefab to add more collectibles to the scene.
-   **Change Materials:** Experiment with different materials and lighting to create a new aesthetic for your game.
-   **Modify Game Speed:** Adjust the `speed` variable in the `PlayerController.cs` (or `GroundController.cs`) to change how quickly the ball responds to your movements.
-   **Audio:** Replace the existing audio clips with your own to create a different feel.

## Troubleshooting

-   **VR Headset Not Working:** Check your XR Plug-in Management settings in Unity. Ensure your headset is properly connected to your computer.
-   **Controller Not Tilting the Plane:** Make sure your VR controller is active and properly tracked. Check the `GroundController.cs` script to ensure the correct controller input is being used.

## Acknowledgements

-   This project is a VR adaptation of the original Unity "Roll-a-Ball" tutorial.
-   The foundation of this project is built upon the excellent learning resources provided by Unity Technologies.
