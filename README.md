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

Background

Tilemapping:
-   The background is fairly easy to do, it is done by using tiles, we installed the tiles via an image on
    the internet and use the inbuilt
    tilemap function in unity to draw each tile per pixel on the screen. (note that the pixels on the parent image needs to match the tilemap
    pixel size)
-   Important thing to do for tilemapping:
    tick pre-released packages in advanced project settings -> go to all packages and navigate to 2D tilemap extras and unlock it.
    now you have more options when creating tilemaps from 2D empty objects.

Scripting tiles:
-   Although it might be a slow process, we are creating different tilemaps so that we can deal with the
    interaction between the player and objects easier, like grass will have a different tilemapping to 
    that of water.
-   I tried assigning private scripts per tilemap but it doesnt work since the function is ScriptableObject
    and not MonoBehavior.