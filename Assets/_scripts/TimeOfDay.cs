using UnityEngine;
using System.Collections;

public class TimeOfDay : MonoBehaviour {

	public float _currentTime = 0.0f;
	public float timeScale = 2.0f;
	public GameObject timeTarget;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		_currentTime += Time.deltaTime * timeScale;
		if (_currentTime > 1440.0f) {
			_currentTime -= 1440.0f;
		}

		timeTarget.renderer.material.SetFloat ("_CurrentTime", _currentTime);
	}
}