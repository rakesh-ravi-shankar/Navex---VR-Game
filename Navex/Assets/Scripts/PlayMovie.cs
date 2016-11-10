using UnityEngine;
using System.Collections;

public class PlayMovie : MonoBehaviour {
	public string url;

	// Use this for initialization
	void Start () {
		//((MovieTexture)GetComponent<Renderer> ().material.mainTexture).Play ();
		Handheld.PlayFullScreenMovie (url, Color.black, FullScreenMovieControlMode.CancelOnInput);
	}
	
	// Update is called once per frame
	void Update () {
//		if (Input.GetMouseButtonDown(0))
//			Handheld.PlayFullScreenMovie ("Pinmap30.mp4", Color.black, FullScreenMovieControlMode.CancelOnInput);
	}
}
