using System.Collections;
using UnityEngine;


    public class Weapon : MonoBehaviour
    {

        [SerializeField]
        private Projectile _projectile;

        [SerializeField]
        private Transform _barrel;

        [SerializeField]
        private float _cooldown;


        private bool _readyToFire = true;
        private UnitBattleIdentity _battleIdentity;

        public float Cooldown
            => _cooldown;
        
        public void Init(UnitBattleIdentity battleIdentity)
        {
            _battleIdentity = battleIdentity;
        }
        
        public void TriggerFire()
        {
            if (!_readyToFire)
                return;
            
	        var proj = Instantiate(_projectile, _barrel.position, _barrel.rotation);
        	Instantiate(
	        	EffectManager.Instance.muzzleFlashPrefab,
	        	_barrel.position, _barrel.rotation)
	        	.transform.parent = 
	        	gameObject.transform;
            proj.Init(_battleIdentity);
            StartCoroutine(Reload(_cooldown));
        }


        private IEnumerator Reload(float cooldown)
        {
            _readyToFire = false;
            yield return new WaitForSeconds(cooldown);
            _readyToFire = true;
        }


        public void ChangeCooldown(float multiplyer)
            => _cooldown *= multiplyer;
    }

