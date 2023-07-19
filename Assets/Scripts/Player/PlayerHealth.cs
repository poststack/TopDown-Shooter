using System;
using System.Collections;
using System.Collections.Generic;
using Utility;

using UnityEngine;

public class PlayerHealth : MonoBehaviour, ISpaceship, IDamagable
    {
        [SerializeField]
        private ShipController _shipController;
    
        [SerializeField]
        private MovementSystem _movementSystem;
    
        [SerializeField]
        private WeaponSystem _weaponSystem;

        [SerializeField]
        private ShipData _shipData;

        [SerializeField]
        private UnitBattleIdentity _battleIdentity;

        public MovementSystem MovementSystem => _movementSystem;
        public WeaponSystem WeaponSystem => _weaponSystem;

        public UnitBattleIdentity BattleIdentity => _battleIdentity;


	    public event Action<float, Transform> OnDie;
	    public event Action<float> OnChangeHealth;

        private void Start()
        {
            _shipController.Init(this);
            _weaponSystem.Init(_battleIdentity);
        }

        public void ApplyDamage(IDamageDealer damageDealer)
        {
	        ApplyHealth(-(float)damageDealer.Damage);

            if (_shipData.Health <= 0)
            {
                OnDie?.Invoke(_shipData.Points, transform);
                Destroy(gameObject);
            }
        }

	    public void ApplyHealth(float addingHealth)
        {
            _shipData.Health += addingHealth;
            OnChangeHealth?.Invoke(_shipData.Health);
        }


	    
	    

    }

