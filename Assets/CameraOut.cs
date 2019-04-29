using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraOut : MonoBehaviour {

	private GameObject target;

	void Start (){
		target = GameObject.Find("unitychan");
	}
	void Update()
	{
		float targetPos = target.transform.position.z;
		if (this.gameObject.transform.position.z < targetPos -8)
			Destroy(this.gameObject);
	}
}
