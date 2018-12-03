# Progress report
# Group members: Jordan Durci, Noah Stape, and Alex Yarkosky

## Introduction

We've been building our platformer at a decent pace.  We've fleshed out the main player characters quite well, being Lloyd (bound arms, blue spike) and Armin (bound legs, yellow spike).  That said, we're still a few player mechanics from done, and need to do more work on the NPCs where the AI truly lies.  On the upside, most of the visuals are fully sprited out, and many animations are done.  Our main areas in need of work are the implementations of our algorithms and pathfinding techniques.

## Graphics

The pixel art graphics are all made by Jordan, all of them having no more than 15 colors and a transparent layer, or no more than 16 colors.  The images are then upscaled to four times their real size for crisper pixels.  The idea was to make the game vibrant and colorful, with a sense of scale presented from being miniature characters in a big world.  Most of our graphics are done, though we still have a few more assets we could use to make the world feel a little more fleshed out than it is at the moment.  We still have to implement the NPC animations, a couple spawn sprites, and the boss room, if we have time to assemble a unique room for that.

## Physics

Unity's 2D physics engine has been our main tool in making the physics work.  It leads to a great sense of weight in the jumps of the characters, as well as the ability to use extremely detailed collision maps.  I'd like to work to lock the fall speed of Lloyd, though, as his constant moving needs to be made less detrimental to his platforming capabilities.

## Pathfinding

## Image Recognition

## Line of Sight

For the line of sight, we have settled upon using Brensenham's line algorithm as the way we will implement this technique. It was only fairly recently that this was deceided upon and therefore no progress has been made in coding this into the game in any way yet. While not concretely deceided upon, it is likely that our flying enemy will implement this as its AI in the game. Our goal is still to implement this technique into the game in this or similar fashion.

## Conclusion

While we have not made the most progress possible with the coding of the crucial elements of our project, we believe that the work have accomplished thus far gives us a great enough foundation to build off of with the final implementations of the proposed techniques. Along the way, we have thus far learned more about the process for making a 2D game in specific in Unity and how it differs from our experience with making a 3D game in Unity. Our challenges so far have mainly revolved around working with Unity and the C# language due to our collective inexperience with both. It also probably took us longer than it should have to find resources and settle upon the algorithms we intend to use for the implementation of the various AI techniques. Nonetheless, it has been quite the learning experience for all of us so far and besides fulfilling the requirements of the project, that is all that we can ever hope to get out of efforts like these.
