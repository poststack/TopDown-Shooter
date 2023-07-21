using System;
using System.Collections;
using System.Collections.Generic;
using Utility;
using UnityEngine;

public class PlayerBonusHandler : MonoBehaviour
{
	
	[SerializeField]
	protected Ship playerHealth;
	[SerializeField]
	protected PlayerWeapon playerWeapon;	



	public void StartFireRateBonus(float multiplier , float time)
	{
		Debug.Log($"StartFireRateBonus(float {multiplier}, float {time})");
		StartCoroutine(playerWeapon.FireRateBonus(multiplier, time));
	}



	
	
	public void HealthBonus(int addingHealth)
	{
		playerHealth.ApplyHealth(addingHealth);
	}
}
