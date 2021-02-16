# GrapplingHook
A grappling hook mechanic for Level Design


Note that this uses the first person drifter, but should work so long as you use the 'character controller' component. 

## What Can The Grappling Hook Do?

Click to 'shoot' the hook at possible objects. 


Press R to retract the hook. 

If the hook is attached to an object, the object will come to you! 

If the hook is attached to a wall, the hook will detach and return.

If you are fishing, reel in your fish!


When you have hooked a wall, press F to pull yourself to the location!

To release, press space.

*enemy how do here*

## How to use this asset

The aiming reticle canvas is just to know the point you are aiming at, and is recommended, but not necessary. 

'Grappling Hook Gun', 'Grappling Hook Hook', and 'FishingHook' should all be separate children of your player character.

Objects you want the player to be able to pull towards themself should be tagged with the tag 'HookableObjects'. 

Objects you want the player to grapple towards should be tagged with the tag 'StableObjects'.

All objects (grabbable and grapple walls) should be kinematic to avoid physics collision causing problems. :)


*JUDE PLEASE INSERT HOW TO SET UP FISHING AND ENEMY USE HERE*
