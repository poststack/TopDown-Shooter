using UnityEngine;
using System.Collections;


/// <summary>
/// Класс который будет спавнить бонусы на позициях умерших врагов
/// </summary>
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
