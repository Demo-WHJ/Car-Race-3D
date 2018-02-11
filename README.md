.# Race it 1.0 – Unity 3D game  
Description :-  
A car racing game designed on Unity 3D engine that allows player to race 
with his/her car against many other cars that are run by the computer.  

Design (Images and FBX models) :- 
    • A height map 
    • 3D world using the height map 
    • A Race track using unity assets 
    • Small 360 hollow tube racing arena in different places 
    • Player’s car model with floating camera, and interactive audio 
    • Rival’s car model with AI automation following the path assigned 
    • Main menu UI for the game 
    • Mini map / radar seen during runtime 
    • Audience crowd with animation 
    • Game finishing UI displaying positions of all the cars

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ 

Height Maps 
In computer graphics, a heightmap or heightfield is a raster image used to store values, 
such as surface elevation data, for display in 3D computer graphics 

A heightmap contains a distance of displacement or “height” from the “floor” of a surface and is in grayscale image,
with black representing minimum height and white representing maximum height.
When the map is rendered, the designer can specify the amount of displacement for each unit of the height channel,
which corresponds to the “contrast” of the image. Directional light (SUN) 

A directional light typically simulates sunlight and a single light can illuminate the whole of a scene.
This means that the shadow map will often cover a large portion of the scene at once and this makes the shadows susceptible
to a problem called perspective aliasing. Perspective aliasing means that shadow map pixels seen close to the camera look
enlarged and chunky compared to those farther away.

Clouded Sky box
Skyboxes are a wrapper around your entire scene that shows what the world looks like beyond your geometry.

Reflective water surface
Unity includes several water Prefabs (including the necessary Shaders, scripts and art Assets) within the Standard Assets packages.
Separate daylight and nighttime water Prefabs are provided. 

![Sun] (Sun.png)

Race spectators
Very low poly audience animated cheering and applausing to use in sports games, tv show games, car games.
with 7 different skins to combine.

Animations available: Idle, Applause fast, Applause Slow, Celebration with one arm, Celebration with both arms, celebration one arm moving hole body.
These animations are looped randomly and attached to each body using C# scripts.

![Crowd] (Crown.png)

Our Car
The car model is a prefab designed either within the Unity engine or in any other designing application software like 3DS max.
This prefab can be imported within the unity engine software using a .fbx file format of the 3d model.
 We have attached special CaController C# scripts that listens to user’s input for arrow keys and makes the car run accordingly
 We have added audio C# scripts to the car wheels that emit sound of the car acceleration and gear changing
 Camera that shows in game player’s view is an advanced floating camera that lags behind while car steering to
increase realism of the car movement. It also turns back when going reverse mode.

Opponent cars
 The opponents car model has attached to it special C# script for AI automation of the car that follows the path that we have
assigned using a pathScript
 We can assign different torque values and top speeds to different rival cars to make them run differently and to make the game
more realistic.

Start Menu

![Start] (Start.png)

Runtime player’s view

![Runtime] (Runtime.png)

Finish

![Finish] (Finish.png)
