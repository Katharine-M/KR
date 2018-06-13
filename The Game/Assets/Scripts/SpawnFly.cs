using System.Collections;
using UnityEngine;

public class SpawnFly : MonoBehaviour {

	public GameObject fly;

	void Start () {
		StartCoroutine (Spawn ());	
	}

	IEnumerator Spawn () {
		while (!Player1.lose) {
			Instantiate (fly, new Vector2 (Random.Range (-2.6f, 2.6f), 5.55f), Quaternion.identity);
			yield return new WaitForSeconds (0.9f);
		}
	}

}
