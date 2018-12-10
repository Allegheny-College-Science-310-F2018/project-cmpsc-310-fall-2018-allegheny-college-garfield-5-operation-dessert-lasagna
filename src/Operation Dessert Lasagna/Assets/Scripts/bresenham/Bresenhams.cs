using UnityEngine;
using System.Collections;

// resources used thus far:
// https://youtu.be/cJj7-Sy03HQ
// (temp info to be deleted before final version)
public class Bresenhams : MonoBehaviour{

  public Transform sightStart, sightEnd;
  public bool spotted = false;

  public void Update(){
    Raycasting();
  }

  public void Raycasting(){
    Debug.DrawLine(sightStart.position, sightEnd.position, Color.blue);
    spotted = Physics2D.Linecast(sightStart.position, sightEnd.position, 1 << LayerMask.NameToLayer("Players"));
  }

  // actual algorithm, may end up being abandoned
  /*public void line(int x,int y,int x2, int y2, int color) {
    int w = x2 - x ;
    int h = y2 - y ;
    int dx1 = 0, dy1 = 0, dx2 = 0, dy2 = 0 ;
    if (w<0) dx1 = -1 ; else if (w>0) dx1 = 1 ;
    if (h<0) dy1 = -1 ; else if (h>0) dy1 = 1 ;
    if (w<0) dx2 = -1 ; else if (w>0) dx2 = 1 ;
    int longest = Math.Abs(w) ;
    int shortest = Math.Abs(h) ;
    if (!(longest>shortest)) {
        longest = Math.Abs(h) ;
        shortest = Math.Abs(w) ;
        if (h<0) dy2 = -1 ; else if (h>0) dy2 = 1 ;
        dx2 = 0 ;
    }
    int numerator = longest >> 1 ;
    for (int i=0;i<=longest;i++) {
        putpixel(x,y,color) ;
        numerator += shortest ;
        if (!(numerator<longest)) {
            numerator -= longest ;
            x += dx1 ;
            y += dy1 ;
        } else {
            x += dx2 ;
            y += dy2 ;
        }
    }
  }*/

  // method below should somehow check to see if there is any obstacle blocking the line of sight by being caught with the line
  //public void obstacleInLine {
    //todo
  //}

}
