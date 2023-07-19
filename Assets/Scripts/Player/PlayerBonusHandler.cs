using System;
using System.Collections;
using System.Collections.Generic;
using Utility;
using UnityEngine;

public class PlayerBonusHandler : MonoBehaviour
{
	
	[SerializeField]
	protected PlayerHealth playerHealth;
	



	public void StartFireRateBonus(float multiplyer, float time)
	{
		Debug.Log($"StartFireRateBonus(float {multiplyer}, float {time})");
		//StartCoroutine(FireRateBonus(multiplyer, time));
	}



	
	
	public void HealthBonus(int addingHealth)
	{
		playerHealth.ApplyHealth(addingHealth);
	}
}
