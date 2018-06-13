using UnityEngine;

public class MovePlayer : MonoBehaviour {

	public Transform Player;
	[SerializeField]
	private float speed =10f;

	void OnMouseDrag () {
		Vector3 mousePos = Camera.main.ScreenToViewportPoint (Input.mousePosition);
		mousePos.x = mousePos.x > 2.6f ? 2.6f : mousePos.x;
		mousePos.x = mousePos.x < -2.6f ? -2.6f : mousePos.x;
		Player.position = Vector2.MoveTowards(Player.position, 
			new Vector2 (mousePos.x, Player.position.y),
			speed * Time.deltaTime);
		
	}
}
