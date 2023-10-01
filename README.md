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

How we figured it out:
-   For rigid bodies always make sure the Rigidbody 2D component has:
    collision detector: continuous
    interpolate - interpolate
    this allows fluid movement in the sprites.
-   