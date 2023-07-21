using System;
using System.Collections;
using System.Collections.Generic;
using Utility;

using UnityEngine;

public class Ship : MonoBehaviour, ISpaceship, IDamagable
    {
        [SerializeField]
        private ShipController _shipController;
    
        [SerializeField]
        private MovementSystem _movementSystem;
    
        [SerializeField]
	    private WeaponSystem _weaponSystem;
        
	    [SerializeField]
	    private ShipEffects _shipEffects;

        [SerializeField]
	    private PlayerData _playerData;
	    

        [SerializeField]
        private UnitBattleIdentity _battleIdentity;

        public MovementSystem MovementSystem => _movementSystem;
        public WeaponSystem WeaponSystem => _weaponSystem;

        public UnitBattleIdentity BattleIdentity => _battleIdentity;


	    public event Action<float, Transform> OnDie;
	    public event Action<float,float> OnChangeHealth;

        private void Start()
        {
            _shipController.Init(this);
            _weaponSystem.Init(_battleIdentity);
        }

	    public void GetHit (IDamageDealer HitDealer)
	    {
		    //Debug.Log($"GotHit by {HitDealer.BattleIdentity.ToString()}");
	        ApplyHealth(-(float)HitDealer.Damage);

            if (_playerData.Health <= 0)
            {
            	_shipEffects.Death();
	            OnDie?.Invoke(_playerData.Points, transform);
            	//GetComponent<Ship>().enabled = false;
            	Destroy(gameObject,0.01f);
            }
        }

	    public void ApplyHealth(float addingHealth)
	    {
		    
		    _playerData.Health += addingHealth;
		    OnChangeHealth?.Invoke(_playerData.Health, _playerData.MaxHealth);
		    Debug.Log($"ApplyHealth {addingHealth} " + Environment.NewLine + $"_playerData.Health {_playerData.Health}");
		    if (_playerData.Health < _playerData.MaxHealth)
		    {
		    	_shipEffects.TurnDamageEffectOn( _playerData.Health/_playerData.MaxHealth);
		    }
		    else
		    {
		    	_shipEffects.TurnDamageEffectOff();
		    }

	    }
        
	    public GameObject getGameObject() {
		    return gameObject;
     }


	    
	    

    }

