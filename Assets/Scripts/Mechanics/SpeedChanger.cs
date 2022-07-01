using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Platformer.Mechanics
{
  public class SpeedChanger : MonoBehaviour
  {
    public float delta = 1f;

    void OnCollisionEnter2D(Collision2D coll)
    {
      PlayerController player = coll.gameObject.GetComponent<PlayerController>();
      if (player != null)
      {
        player.ChangeMaxSpeed(delta);
      }
    }

    void OnCollisionExit2D(Collision2D coll)
    {
      PlayerController player = coll.gameObject.GetComponent<PlayerController>();
      if (player != null)
      {
        player.ResetMaxSpeed();
      }
    }
  }
}
