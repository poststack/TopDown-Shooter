
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
	private GameObject ExplosionEffectrefab;
	[SerializeField]
	private float timeToDestroy;
	
	protected void Start()
	{
		currentDamageColor = DamageEffectObject.GetComponent<ParticleSystem>().startColor;
	}
	
	public void TurnDamageEffect(bool isOn, float remainingHealthRatio)
	{
		if (isOn)
		{
			if (DamageEffectObject == null)
			{
				DamageEffectObject = Instantiate(DamageEffectPrefab, gameObject.transform);
			}
			currentDamageColor.a = 1 - remainingHealthRatio;
			DamageEffectObject.GetComponent<ParticleSystem>().startColor = currentDamageColor;
		}
		
	}
	
	public void Death()
	{
		GameObject obj = Instantiate(ExplosionEffectrefab, gameObject.transform);
		Destroy(obj,timeToDestroy);
		obj.transform.Rotate(
			new Vector3(
			UnityEngine.Random.Range(0,360),
			0,
			0));
	}
}
