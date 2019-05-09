using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyTimeOut : MonoBehaviour {
	public float timer = 15.0f;
	void Start () {
		Destroy (gameObject, timer);
	}
}
