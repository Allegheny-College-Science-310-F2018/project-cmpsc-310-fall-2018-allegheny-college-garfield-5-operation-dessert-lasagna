# Project Report
# Group members: Jordan Durci, Noah Stape, and Alex Yarkosky

## Motivation

Our motivation for doing this as our project first and foremost comes from our collective enjoyment of video games. We have also had those moments when we complained about the AI in a game not being good enough and with this project, we will surely get a better idea of the process of creating AI in a game and see if we really had much room to complain or if we actually might be able to make a better AI than the ones that we were disappointed by. Similar concerns can briefly be found in Amit's Game Programming Information below in the Resources section. Regardless of our experience, the video game industry is always looking to improve in all aspects with the games being released, and this is the beginning into the kind of work needed to make those advancements from game to game. Furthermore, the types of problems we hope to look into are able to be applied outside of video games in much more generic contexts and then reapplied to the specifics of another area of programming entirely. Our efforts in making this project will also lend to us having experience desirable nonetheless the path taking in getting those experiences.
We also specifically chose to make a game as it gave us the ability to work with multiple AI techniques and gain a more broader sense of experience. We also wanted to get more experience with Unity as felt we could be more familiar with it and this let us work with it in 2D as opposed to previous experience with it only in 3D. Ultimately, we decieded that this project would give us the kinds of experiences we would like to gain one way or another and hence it coincided well with the requirements of the project.

## Background

(What work already exists on topic? Refer back to paper mentioned in proposal.)

## Work Accomplished

(Should talk about algorithms, etc. that we used.)

## Results

(Should talk about what is actually in the game currently.)
We were able to achieve our basic goals of this project and provide the framework for most of the basis of the actual game.
Currently, the butterfly looking enemies, the grumperflies, both implement the pathfinding technique (green line in scene view) and the line of sight technique (blue line when spotted and red line when there is not a clear line of sight (i.e. terrain or obstacle crosses the line between the player character and the enemy) in the scene view). it should also be noted that each grumperfly either targets Armin or Lloyd for both the pathfinding and the line of sight. It should also be noted that the current implementation of the line of sight does not use or simulate Bresenham's algorithm as originally desired but instead just uses Unity to draw the lines. The entirety of the game exists with a test level of sorts with all of the assets being in it even if they are not fully implemented. It might be obvious, but it should still be said that it is indeed possible to move the characters around the test level with Armin only being able to move whilst in the air as he jumps and Lloyd continuing to move after he is first moved, continuing in one direction until changed by the user.

## Conclusion

(Overview, what was learned, challenges, rewards.)
