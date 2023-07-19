using System;
using System.Collections;
using System.Collections.Generic;
using Utility;
using UnityEngine;

public class PlayerWeapon : MonoBehaviour
{


	[SerializeField]
	private WeaponSystem _weaponSystem;
	
	[SerializeField]
	protected PlayerHealth playerHealth;
	
	public event Action<List<Weapon>> OnChangeCooldown;

	public List<Weapon> GetWeaponsCooldown()
	{
		return _weaponSystem._weapons;
	}
	
	public IEnumerator FireRateBonus(float multiplyer, float time)
	{
		_weaponSystem.AllChangeCooldown(multiplyer);
		OnChangeCooldown?.Invoke(GetWeaponsCooldown());
		yield return new WaitForSeconds(time);
		_weaponSystem.AllChangeCooldown(1f / multiplyer);
		OnChangeCooldown?.Invoke(GetWeaponsCooldown());
	}

}
