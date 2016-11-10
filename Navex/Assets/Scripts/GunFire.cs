using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GunFire : MonoBehaviour {
	public GameObject ray_direct_obj;
	public GameObject flash;
	public GameObject[] explosion;
	public AudioClip shoot, blast;
	int no_of_enemies;
	AudioSource audioSource;
	Ray ray;
	RaycastHit hit;
	ParticleSystem explosionSys;

	void Start()
	{
		audioSource = GetComponent<AudioSource> ();

		no_of_enemies = 5;
	}

	void FixedUpdate()
	{
		
		if (Input.GetMouseButtonDown (0)) 
		{	
			flash.GetComponent<ParticleSystem> ().Play ();

			ray = new Ray (transform.position, ray_direct_obj.transform.forward);
			if (Physics.Raycast (ray, out hit, 100000)) 
			{
				if (hit.collider.tag == "Enemy") 
				{
//					explosionSys = explosion[no_of_enemies - 1].GetComponent<ParticleSystem> ();
					Destroy (hit.collider.gameObject);
					explosion[no_of_enemies-1].transform.position = hit.transform.position;
					explosion[no_of_enemies-1].SetActive(true);
//					explosionSys.Stop ();
//					explosionSys.Play ();
//					explosionSys.startLifetime = explosionSys.startLifetime;
					no_of_enemies--;

					audioSource.Play ();

					audioSource.enabled = true;

					Debug.Log (no_of_enemies);
//					explosion[no_of_enemies-1].SetActive(false);
				}
			}

		}
		if (no_of_enemies <= 0) {
			SceneManager.LoadScene ("Menu", LoadSceneMode.Single);
		}
	}
}


