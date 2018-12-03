# Progress report
# Group members: Jordan Durci, Noah Stape, and Alex Yarkosky

## Introduction

We've been building our platformer at a decent pace.  We've fleshed out the main player characters quite well, being Lloyd (bound arms, blue spike) and Armin (bound legs, yellow spike).  That said, we're still a few player mechanics from done, and need to do more work on the NPCs where the AI truly lies.  On the upside, most of the visuals are fully sprited out, and many animations are done.  Our main areas in need of work are the implementations of our algorithms and pathfinding techniques that will come with the rest of worked needed for the AIs.  We have made at least some progress in all of the areas required for the full completion of the project we outlined in our proposal.

## Graphics

The pixel art graphics are all made by Jordan, all of them having no more than 15 colors and a transparent layer, or no more than 16 colors.  The images are then upscaled to four times their real size for crisper pixels.  The idea was to make the game vibrant and colorful, with a sense of scale presented from being miniature characters in a big world.  Most of our graphics are done, though we still have a few more assets we could use to make the world feel a little more fleshed out than it is at the moment.  We still have to implement the NPC animations, a couple spawn sprites, and the boss room, if we have time to assemble a unique room for that.  As for the levels themselves, it is highly likely at this point that the game will take place within only one level, which right now is in its most basic form as we test the game.

## Physics

Unity's 2D physics engine has been our main tool in making the physics work.  It leads to a great sense of weight in the jumps of the characters, as well as the ability to use extremely detailed collision maps.  We'd like to work to lock the fall speed of Lloyd, though, as his constant moving needs to be made less detrimental to his platforming capabilities. Overall, the physics could be improved in most aspects but they are at a useable status as of right now and may not get all to much more time dedicated to improving them.

## Pathfinding

After doing some research on A* pathfinding algorithms in C#, we came across a project called the "A* Pathfinding Project." This project has an extensive amount of Unity assets with various amounts of different implementations. The project, designed by Aron Granberg, has an extensive forum for troubleshooting and for different implementations of many aspects of the project. We have downloaded this package, and we have explored many of the assets of the project. This project has given us some difficulty in its implementation, but we have confidence in our ability to plug it into our project. We intend to use this on enemy AI, and potentially a variation of it for our final boss. The project is very flexible, so we should be able to implement it in any way that we wish.

## Image Recognition

The "A* Pathfinding Project" has a method that can be used to detect objects in our world. This will allow the AI to avoid obstacles around the world, while finding the quickest path. If we use this method, we will only use it once, as our world only has one layout. There will be no need to constantly update the AI's interpretation of the world. This may be difficult for a platformer, and we will need to modify the method for it to work with our game. Due to the method's design, it works best with top down 2D games, or 3D world. This should not be too difficult after we initially get it working in our system.

## Line of Sight

For the line of sight, we have settled upon using Brensenham's line algorithm as the way we will implement this technique. It was only fairly recently that this was deceided upon and therefore no progress has been made in coding this into the game in any way yet. Some of the resources that we had found and helped us settle on using this algorithm may be useful when it comes to implementing it as well. While not concretely deceided upon, it is likely that our flying enemy will implement this as its AI in the game. Our goal is still to implement this technique into the game in this or similar fashion. If need be, we realize that with only one week left to finish this project that this feature may have to be abandoned and excluded from the final delivery of the project simply due to this time constraint.

## Conclusion

While we have not made the most progress possible with the coding of the crucial elements of our project, we believe that the work have accomplished thus far gives us a great enough foundation to build off of with the final implementations of the proposed techniques. Along the way, we have thus far learned more about the process for making a 2D game in specific in Unity and how it differs from our experience with making a 3D game in Unity. Our challenges so far have mainly revolved around working with Unity and the C# language due to our collective inexperience with both. Specifically with Unity, it has created some trouble for us pushing into the repository since we are not using the proper GitHub workflow with branches from the slightest of changes that Unity produces when working on the project within it. The `.gitignore` file has been updated to include Unity and all other subsequent derived files that may be encountered with the help of gitignore.io for generating the new additions to the file. It also probably took us longer than it should have to find resources and settle upon the algorithms we intend to use for the implementation of the various AI techniques. Nonetheless, it has been quite the learning experience for all of us so far and besides fulfilling the requirements of the project, that is all that we can ever hope to get out of efforts like these.
