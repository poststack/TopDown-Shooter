using UnityEngine;

public class Missile : Projectile
{
	public float speed = 5f;
	public float amplitude = 3f;
	public float frequency = 0.4f;

	private Vector3 startPos;

	private void Start()
	{
		startPos = transform.position;
		//speed += (float)UnityEngine.Random.Range(-0.5,0.5);
		//frequency += (float)UnityEngine.Random.Range(-0.5,0.5);
		float randomValue = Random.Range(0f, 5f);
		amplitude += randomValue;

	}

	protected override void Move(float speed)
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
