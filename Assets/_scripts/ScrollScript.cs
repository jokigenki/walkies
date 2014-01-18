using UnityEngine;
using System.Collections;

public class ScrollScript : MonoBehaviour {

	public float speed = 0;

	public GameObject updater = null;

	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (updater != null) {
			ParallaxUpdater updateScript = updater.GetComponent("ParallaxUpdater") as ParallaxUpdater;
			renderer.material.mainTextureOffset = new Vector2 (updateScript.offset * speed, 0f);
		}
	}
}
