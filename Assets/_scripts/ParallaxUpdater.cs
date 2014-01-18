using UnityEngine;
using System.Collections;

public class ParallaxUpdater : MonoBehaviour {
	
	public float offset = 0;
	public GameObject target;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		WalkController controller = target.GetComponent ("WalkController") as WalkController;
		offset += controller.velocity;
	}
}
