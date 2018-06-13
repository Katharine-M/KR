using UnityEngine;

public class FallDown : MonoBehaviour {

	[SerializeField]
	private float fallspeed = 5f;

	void Update () {
		if (transform.position.y < -5.55f)
			Destroy (gameObject);
		transform.position -= new Vector3 (0, fallspeed * Time.deltaTime, 0);
	}
}
