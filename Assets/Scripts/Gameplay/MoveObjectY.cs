using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObjectY : MonoBehaviour
{
	[SerializeField] private float speedY;
	[SerializeField] private float Range;
	[SerializeField] private int Delay;
	 private float wait = 0;
	 private Vector2 targetUp;
	private Vector2 targetDown;

	private void Start()
    {
	targetUp = new Vector2(transform.position.x, transform.position.y + Range);
	targetDown = new Vector2(transform.position.x, transform.position.y);
        
    }

	void FixedUpdate()
    {
        wait += Time.deltaTime;
	if ((int)wait >= 1f * Delay && (int)wait < 3f * Delay)
	{
		transform.position = Vector2.MoveTowards(transform.position, targetUp, speedY * Time.deltaTime);
	}
	if ((int)wait >= 3f * Delay && (int)wait < 4f * Delay)
	{
		transform.position = Vector2.MoveTowards(transform.position, targetDown, speedY * Time.deltaTime);
	}
	if ((int)wait >= 4f * Delay) wait = 0;
    }
}
