# VR_Basic

## Overview
VR_Basic is a virtual reality project designed to provide a foundational framework for VR interactions using Unity and Oculus Integration. This project includes basic interaction mechanics, terrain generation, and customizable assets to create immersive VR experiences.

## Hierarchy
- **VR_Basic**: The root game object.
- **Sun Light**: Provides the lighting for the scene.
- **Knife_01**: A basic object for interaction.
- **Attach TransformPoint**: Allows the object to be interacted with by the VR hands.
- **XR Origin (XR Rig)**: Represents the player's position in VR space.
- **Camera Offset**: Adjusts the position of the main camera relative to the player.
- **Main Camera**: Renders the scene.
- **Left Controller**: The left VR hand controller.
- **Right Controller**: The right VR hand controller.
- **XR Interaction Manager**: Manages interactions between the VR hands and objects.
- **XROriginSpawner**: Spawns the player at the origin.
- **StandGround**: A basic ground plane.
- **Terrain**: Creates a complex terrain mesh.
- **SampleCube**: A simple cube for testing purposes.
- **Attach TransformPoint**: Allows the cube to be interacted with by the VR hands.

## Scripts
- **AnimateHandOnInput**: Controls animations of the VR hand based on pinch and grip input.
- **FireBulletOnActivate**: Allows an object to fire bullets when activated.
- **GrabObject**: Enables objects to be grabbed by the VR hand.
- **SplashRed**: Handles the visuals of the red splash effect.
- **SplashTrans**: Manages the visuals of the translucent splash effect.
- **XROriginSpawner**: Spawns the player at the origin.

## Assets
- **TerrainAutoUpgrade**: Automatically upgrades terrain.
- **Fantasy Skybox FREE**: A free skybox asset.
- **GrassFlowers**: Prefab for grass and flowers.
- **LowPoly Weapons_LITE**: Low-poly weapon assets.
- **Oculus**: Oculus VR platform assets.
- **Oculus Hands**: Prefabs for Oculus VR hands.
- **Plugins**: Various plugins used in the project.
- **Proxy Games**: Assets related to the Proxy Games team.
- **Resources**: Various project resources.
- **Samples**: Sample scenes and assets.
- **Skybox**: Skybox asset.
- **Standard Assets**: Standard Unity assets.
- **Terrain**: Assets related to terrain generation.
- **Textures**: Various project textures.
- **Unity**: Unity-related assets.
- **VR**: Assets related to VR functionality.
- **Water**: Assets related to water effects.

## Features
- **VR Interactions**: Interact with objects in the scene using VR hands.
- **Terrain Generation**: Generate complex terrain meshes.
- **Lighting**: Adjust lighting settings for the scene.
- **Animations**: Control hand animations based on input.

## Requirements
- **Unity 2020.3.20f1**: The project is built using Unity 2020.3.20f1.
- **Oculus Integration**: The project uses Oculus Integration for VR functionality.
- **VR Hardware**: A VR headset and controllers are required to experience the project.

## Setup
1. Clone the repository to your local machine.
2. Open the project in Unity 2020.3.20f1.
3. Ensure Oculus Integration is installed and configured.
4. Connect your VR hardware and launch the project.

## Contributing
Contributions are welcome! If you'd like to contribute to the project, please fork the repository and submit a pull request.
