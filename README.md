# Mario-SJ
CSIT302: Final Project 

DO THIS BEFORE EACH CHANGE
For pulling - use 'git pull' on cmd via root folder to pull the changes made

For file upload:
First commit -> push onto child branch -> pull req from main -> pull from private machines

Git Basics for Us
---
- There is a local repository and a remote repository  
- You pull the remote repository branch onto your local repository branch  
- Work on your local repo branch (not main) until you are ready  
- Keep commiting your changes to the local repo branch  
- Once somewhat ready, push the collective changees to the remote repo branch  
- The collective changes then can be merged into the main remote branch using a pull request  

You have to reset your branch using the main branch as multiple pull requests might cause a merge conflict causing your branch to be out of sync from main  

Next Steps:
-   Setting up clean movements (left and right with the sprite changing face direction).
-   Setting up clean jump movement as well (need to decide if we want to give Mario double jump or not).
-   Setting up proper backgrounds.

How we figured it out:
-   For rigid bodies always make sure the Rigidbody 2D component has:
    collision detector: continuous
    interpolate - interpolate
    this allows fluid movement in the sprites.
-   The rest is code written as comments on the movement script itself.

Decisions:
-   Due to the fact tilemaps can be buggy with their colliders, we are not going to use staircase-like 
    platforms, we will stick with flat platforms and high platforms.
    UPDATE: lol nvm I fixed that.

Background

Tilemapping:
-   The background is fairly easy to do, it is done by using tiles, we installed the tiles via an image on
    the internet and use the inbuilt
    tilemap function in unity to draw each tile per pixel on the screen. (note that the pixels on the parent image needs to match the tilemap
    pixel size)
-   Important thing to do for tilemapping:
    tick pre-released packages in advanced project settings -> go to all packages and navigate to 2D tilemap extras and unlock it.
    now you have more options when creating tilemaps from 2D empty objects.
-   We can create new Tilemap GameObjects so that the interaction between player and objects are different,
    for example, non interactable and interactable objects can be 2 different objects - one having
    rigidbody2d and one not. 

Scripting tiles:
-   Although it might be a slow process, we are creating different tilemaps so that we can deal with the
    interaction between the player and objects easier, like grass will have a different tilemapping to 
    that of water.
-   I tried assigning private scripts per tilemap but it doesnt work since the function is ScriptableObject
    and not MonoBehavior.
-   I finally figured it out, using the tillmap collider 2D component, we can set triggers, using that we
    can go forward and work on scripting each tilemap respectively (note the usage of tiles).

Animations:
-   Every animation of the sprite (idle, running, jumping, etc) or for world objects (flowers, tree wind
    interaction), we need a series of image (.png) files so add into the animation tab in Unity.
-   We need to create different clips per animation (Mario_IDLE, Mario_RUNNING).
-   Using the Animator, we can control which animation is linked to the other. We need to set a parameter
    which will act as a base that will influence the entry and exit of each of the animations we have created.
-   For the text box, add the text you want to put in in the TextMeshPro component, to make sure its fitting
    properly you will need to adjust the size and font accordingly. Everything that needs to be edited is through
    the Unity component itself.
