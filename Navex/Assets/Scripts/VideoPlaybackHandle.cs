using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class VideoPlaybackHandle : MonoBehaviour {

	public static string video_url;
	public static List<string> recommendations;

	void Start()
	{
		recommendations = new List<string> ();
	}

	public void nextScene(string goToScene)
	{
		recommendations.Clear ();
		switch (goToScene) 
		{
		case "operations":
			video_url = "ihack-int.mp4";
			recommendations.Add ("Navy SEALS");
			recommendations.Add ("Navy Diver");
			recommendations.Add ("Aviation Rescue Swimmer"); 
			break;
		case "humanitarian":
			video_url = "ihack-human.mp4";
			recommendations.Add ("Medicine");
			recommendations.Add ("Dentistry");
			recommendations.Add ("Health Care Services"); 
			recommendations.Add ("Medical Support");
			break;
		case "logistics":
			video_url = "ihack-logis.mp4";
			recommendations.Add ("Supply Chain Management");
			recommendations.Add ("Logistics Speacilist");
			recommendations.Add ("Supply Corps"); 
			break;
		case "health-sciences":
			video_url = "med.mp4";
			recommendations.Add ("Medicine");
			recommendations.Add ("Dentistry");
			recommendations.Add ("Health Care Services"); 
			recommendations.Add ("Medical Support");
			break;
		}
		SceneManager.LoadScene ("Recommendations", LoadSceneMode.Single);
	}

	public void playGame()
	{
		SceneManager.LoadScene ("Game", LoadSceneMode.Single);
	}
}
