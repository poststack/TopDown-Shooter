using System.Collections;
using UnityEngine;

public class ShipEffects : MonoBehaviour
{
	[SerializeField]
	private GameObject DamageEffectPrefab;
	[SerializeField]
	private GameObject DamageEffectObject;
	[SerializeField]
	private Color currentDamageColor;

	
	
	[SerializeField]
	private GameObject ExplosionEffectPrefab;
	[SerializeField]
	private float timeToDestroy;
	
	protected void Start()
	{
		DamageEffectPrefab = EffectManager.Instance.DamagedShipPrefab;
		ExplosionEffectPrefab = EffectManager.Instance.explosionPrefab;
		currentDamageColor = DamageEffectPrefab.GetComponent<ParticleSystem>().main .startColor.color;
	}
	
	public void TurnDamageEffectOn (float remainingHealthRatio)
	{
		//if (isOn)
		//{
			if (DamageEffectObject == null)
			{
				DamageEffectObject = Instantiate(DamageEffectPrefab, gameObject.transform);
			}
			currentDamageColor.a = 1 - remainingHealthRatio;
		//DamageEffectObject.GetComponent<ParticleSystem>().main.startColor.color = currentDamageColor;
		DamageEffectObject.transform.Rotate
		(new Vector3(
			UnityEngine.Random.Range(0,360),
			0,
			0));
	}
	
	public void TurnDamageEffectOff ()
	{
		Destroy(DamageEffectObject);
	}

	
	
	public void Death()
	{
		GameObject obj = Instantiate(ExplosionEffectPrefab, gameObject.transform);
		Destroy(obj,timeToDestroy);
		obj.transform.Rotate(
			new Vector3(
			UnityEngine.Random.Range(0,360),
			0,
			0));
	}
}
