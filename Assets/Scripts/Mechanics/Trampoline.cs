using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampoline : MonoBehaviour
{
  public float springForce = 1000;

  void OnCollisionEnter2D(Collision2D coll)
  {
    coll.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, springForce));
  }
}
