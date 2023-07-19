﻿using UnityEngine;
using System.Collections;

    public abstract class Bonus : MonoBehaviour
    {
        [SerializeField]
	    protected MovementSystem _movementSystem;


        public void Update()
        {
            _movementSystem.LongitudinalMovement(Time.deltaTime);
        }

	    protected virtual void Apply(PlayerBonusHandler player) { }
        

        protected void OnCollisionEnter2D(Collision2D other)
        {
            var damagableObject = other.gameObject.GetComponent<IDamagable>();

            if (damagableObject != null && damagableObject.BattleIdentity == UnitBattleIdentity.Ally)
            {
                if (other.gameObject.GetComponent<PlayerBonusHandler>() != null)
                    Apply(other.gameObject.GetComponent<PlayerBonusHandler>());
                Destroy(gameObject);
            }
        }
    }
