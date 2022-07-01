using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateSaw : MonoBehaviour
{
    public float RotateSpeed;

	void FixedUpdate()
        
    {
	float angle = transform.eulerAngles.z;
	transform.Rotate(0,0, RotateSpeed * 1f * Time.deltaTime);
        
    }
}
