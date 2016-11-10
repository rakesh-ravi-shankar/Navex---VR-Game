using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PopulateRecommendations : MonoBehaviour {

	public Text[] textFields;

	// Use this for initialization
	void Start () {
		Handheld.PlayFullScreenMovie (VideoPlaybackHandle.video_url, Color.black, FullScreenMovieControlMode.CancelOnInput);
		int i = 0;
		Debug.Log (VideoPlaybackHandle.recommendations[0]);
		if(VideoPlaybackHandle.recommendations.Count != 0)
			foreach (string r in VideoPlaybackHandle.recommendations)
			{
				textFields [i].text = r;
				i++;
			}
	}

	public void ReturnToMenu()
	{
		SceneManager.LoadScene ("Menu", LoadSceneMode.Single);
	}

	
	// Update is called once per frame
	void Update () {
	
	}
}
