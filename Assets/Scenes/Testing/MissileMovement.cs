using UnityEngine;

public class MissileMovement : MonoBehaviour
{
	public float speed = 5f;
	public float amplitude = 1f;
	public float frequency = 1f;

	private Vector3 startPos;

	private void Start()
	{
		startPos = transform.position;
	}

	private void Update()
	{
		// Move the missile forward
		transform.Translate(Vector3.up * Time.deltaTime * speed);

		// Calculate the new position using a sine wave
		float xPos = startPos.x + Mathf.Sin(Time.time * frequency) * amplitude;
		float yPos = transform.position.y;

		// Update the missile's position
		transform.position = new Vector3(xPos, yPos, transform.position.z);
	}
}
