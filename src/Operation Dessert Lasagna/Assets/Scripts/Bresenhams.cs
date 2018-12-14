using UnityEngine;
using System.Collections;

public class Bresenhams : MonoBehaviour{

  public Transform sightStart, sightEnd;
  public bool spotted = false;
  public bool clearLineOfSAight = true;

  public void Start(){
    Physics2D.queriesStartInColliders = false;
  }

  public void Update(){
    Raycasting();
  }

  public void Raycasting(){
    if (clearLineOfSAight) {
      Debug.DrawLine(sightStart.position, sightEnd.position, Color.blue);
    }
    else {
      Debug.DrawLine(sightStart.position, sightEnd.position, Color.red);
    }
    spotted = Physics2D.Linecast(sightStart.position, sightEnd.position, 1 << LayerMask.NameToLayer("Players"));
    clearLineOfSAight = !(Physics2D.Linecast(sightStart.position, sightEnd.position, 1 << LayerMask.NameToLayer("TransparentFX")));
  }

}
