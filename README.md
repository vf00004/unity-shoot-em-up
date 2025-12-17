# Shoot ’Em Up

A Unity-based 2D shoot ’em up focused on clean gameplay architecture, input handling, and enemy wave systems.

![forGit](https://github.com/user-attachments/assets/3d89aaf8-d9f8-497b-8b5d-346bcd399636)

## Gameplay Mechanics
* Horizontal player movement with screen-bounded constraints
* Projectile-based combat with collision-driven damage
* Multiple enemy types with distinct movement and firing patterns
* Lives-based failure system with visual indicators

## Controls
* Move: A / D  
* Shoot: Right Control

## Architecture & Implementation
* Component-based design using Unity MonoBehaviours
* Clear separation of concerns between input, movement, combat, and UI systems
* Player input handled via Unity Input Actions
* Enemy behaviors implemented through reusable, configurable scripts
* Centralized game state management for player lives and game-over conditions

## Enemies and Combat
* Three distinct enemy types
* Enemies move side-to-side and remain on screen
* Enemies can fire bullets and missiles at the player
* Collision-based destruction for both player and enemies

## Lives System
* Player starts with three lives
* Lives are lost on collisions with enemies or enemy projectiles
* Game ends when all lives are depleted
* Remaining lives are displayed using sprite-based indicators

## Level Design
* Vertical-scrolling level
* Automatic top-down camera movement
* Enemies appear throughout the entire scroll
* Player can move freely left and right during scrolling

## Visual Feedback
* Fully covered 2D background
* Original, hand-drawn sprite art
* Explosion effects when:
  * Enemies are destroyed
  * The player loses a life or is destroyed

## Technical Details
* Engine: Unity 6 (6000.0.37f1)
* Template: 2D (Built-in Render Pipeline)
* Language: C#
* Input: Unity Input Actions
* Assets: Original sprites created for this project

## Running the Project
1. Open the project in Unity 6 (6000.0.37f1)
2. Load the main scene
3. Press Play to begin

## Learning Outcomes
* Implementing core game loops and combat systems
* Structuring Unity projects for clarity and maintainability
* Working with event-driven input and collision systems
* Debugging and iterating on real-time gameplay mechanics
* Designing and balancing arcade-style gameplay

## Future Improvements
* Additional enemy patterns and AI
* Score system and UI
* Audio effects and background music
* Difficulty scaling over time

> This project originated as a course assignment and was expanded independently to improve code structure, gameplay systems, and overall polish.
