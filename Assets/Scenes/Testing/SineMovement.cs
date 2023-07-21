using UnityEngine;

public class SineMovement : MonoBehaviour
{
	public float amplitude = 1f;
	public float frequency = 1f;

	private Vector3 originalPosition;

	void Start()
	{
		originalPosition = transform.position;
	}

	void Update()
	{
		float time = Time.time;
		float sinValue = Mathf.Sin(time * frequency);
		float yPos = originalPosition.y + sinValue * amplitude;

		transform.position = new Vector3(transform.position.x, yPos, transform.position.z);
	}
}