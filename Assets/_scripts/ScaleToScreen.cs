using UnityEngine;
using System.Collections;

public class ScaleToScreen : MonoBehaviour {

	public Camera mainCam;

	void Start () {

		float height = (float)(mainCam.orthographicSize * 0.2);
		float width = (float)(height * Screen.width / Screen.height);
		transform.localScale = new Vector3(width, 0.1f, height);
	}
}
