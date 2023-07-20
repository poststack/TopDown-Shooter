using UnityEngine;
using System.Collections;



public class BonusSpawner : MonoBehaviour
{
    [SerializeField]
	public Bonus[] bonusPrefabs 
	{
		get
		{
			return this.bonusPrefabs;
		}
		set
		{
			
		}
	}



    public void SpawnRandomBonus(Transform transform)
    {
        int index = Random.Range(0, bonusPrefabs.Length);
        Instantiate(bonusPrefabs[index], transform.position, transform.rotation);
    }
}
