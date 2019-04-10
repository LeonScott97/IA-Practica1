﻿using UnityEngine;

public class MouseFollow : MonoBehaviour
{
	void Update()
	{
		Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		mousePosition.z = 0;
		transform.position = mousePosition;
	}
}
