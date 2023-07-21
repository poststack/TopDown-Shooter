using UnityEngine;

public class EffectManager : MonoBehaviour
{
	// Singleton instance
	private static EffectManager _instance;
	public static EffectManager Instance { get { return _instance; } }

	private void Awake()
	{
		if (_instance != null && _instance != this)
		{
			Destroy(this.gameObject);
		}
		else
		{
			_instance = this;
			DontDestroyOnLoad(this.gameObject);
		}
	}
	public GameObject DamagedShipPrefab;
	public GameObject explosionPrefab;
	public GameObject pointGainPrefab;
	public GameObject smokePrefab;
	public GameObject muzzleFlashPrefab;
    
}
