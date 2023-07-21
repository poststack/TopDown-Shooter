using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;


public class BonusSpawner : MonoBehaviour
{
	[SerializeField]
	private Bonus[] _bonusPrefabs;

	public Bonus[] BonusPrefabs
	{
		get
		{
			return _bonusPrefabs;
		}
		set
		{
			_bonusPrefabs = value;
		}
	}


	public void Start()
	{
		ArrayCleanup();
	}


    
	private void ArrayCleanup()
	{
		
		_bonusPrefabs = _bonusPrefabs.Where(c => c != null).ToArray();

		//List<GameObject> gameObjectList = new List<GameObject>(_bonusPrefabs);

		//// Iterate over the list and remove null elements
		//gameObjectList.RemoveAll(item => item == null);

		//// Convert the list back to an array
		//_bonusPrefabs = gameObjectList.ToArray();
	}
	
	public void SpawnRandomBonus(Transform transform)
	{
		int index = Random.Range(0, _bonusPrefabs.Length);
		Instantiate(_bonusPrefabs[index], transform.position, transform.rotation);
	}
}
