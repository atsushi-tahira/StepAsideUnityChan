using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeGenerator : MonoBehaviour {

	public GameObject red;
	public GameObject blue;
	public GameObject green;
	private int offsetX = 10;
	// Use this for initialization
	void Start () {
		for (int i = -75; i <= 135; i += 15) {
			Debug.Log ("in f");
			for (int j = -2; j <= 2; j++) {
				int item = Random.Range (1, 11);
				Debug.Log ("0 in");
				if (item >= 1 && item <= 4) {
					Debug.Log ("1 in");
					GameObject redclo = Instantiate (red, new Vector3 (j * offsetX, this.red.transform.position.y, i), Quaternion.identity);
				} else if (item >= 5 && item <= 7) {
					Debug.Log ("2 in");
					GameObject blueclo = Instantiate (blue, new Vector3 (j * offsetX, this.red.transform.position.y, i), Quaternion.identity);
				} else if (item >= 8 && item <= 9) {
					Debug.Log ("3 in");
					GameObject greenclo = Instantiate (green, new Vector3 (j * offsetX, this.red.transform.position.y, i), Quaternion.identity);
				}
			}
		}
		Debug.Log ("end");
	}

	// Update is called once per frame
	void Update () {

	}
}
