

using UnityEngine;
using DamageNumbersPro;


public class ObjectCreatorOnMousePosition : MonoBehaviour
{
	public GameObject objectPrefab;
	public Transform objectPrefabToFollow;


	// Start is called on the frame when a script is enabled just before any of the Update methods is called the first time.
	protected void Start()
	{


		GameObject obj = Instantiate(objectPrefab, objectPrefabToFollow.position, Quaternion.identity);
	}
	void Update()
	{
		if (Input.GetMouseButtonDown(0)) // Check for left mouse button click
		{
			Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			mousePosition.z = 0f; // Set the z-coordinate to 0 to ensure the object is created at the same plane as the 2D scene

			GameObject obj = Instantiate(objectPrefab, mousePosition, Quaternion.identity);
			
			//obj.GetComponent<DamageNumberMesh>().SetFollowedTarget(objectPrefabToFollow);

			
			//DamageNumber damageNumber = objectPrefab.Spawn(Vector3 position, Transform followedTransform);

			
		}
	}
}