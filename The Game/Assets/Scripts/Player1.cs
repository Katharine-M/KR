using UnityEngine;

public class Player1 : MonoBehaviour {

	public static bool lose = false;

	void OnTriggerEnter2D (Collider2D other) {
		if (other.gameObject.tag == "Fly")
			lose = true;

	}
}