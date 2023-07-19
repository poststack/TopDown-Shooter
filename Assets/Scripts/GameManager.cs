﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;



    public class GameManager : MonoBehaviour
    {
        [SerializeField] private PointsView _pointsView;

	    [SerializeField] private HealthUI _healthUI;

        [SerializeField] private FireRateUI[] _weaponsUI;

        [SerializeField] private Spawner[] spawners;

        [SerializeField] private WeaponsUI weaponsUI;

        [SerializeField] private BonusSpawner bonusSpawner;

        [SerializeField] private float bonusDropChance = 0.1f;

	    [SerializeField] private PlayerWeapon playerWeapon;
	    [SerializeField] private PlayerHealth playerHealth;

        public static GameManager Instance;

        private void Awake()
        {
            if (Instance == null)
                Instance = this;
            else
                Destroy(gameObject);
        }
        
        private void Start()
        {
            PlayerSetup();

            EnableSpawners();
        }

        private void PlayerSetup()
        {
            foreach (Weapon weapon in playerWeapon.GetWeaponsCooldown())
            {
                weaponsUI.AddNewFireRateUI(weapon.name, weapon.Cooldown);
            }

            playerHealth.OnDie += PlayerDeath;
            playerHealth.OnChangeHealth += _healthUI.UpdateText;
            playerWeapon.OnChangeCooldown += weaponsUI.UpdateFireRate;

            playerHealth.ApplyHealth(0);
            UpdatePoints(0);
        }

        private void EnableSpawners()
        {
            foreach (Spawner spawner in spawners)
            {
                spawner.StartSpawn();
            }
        }


	    public void EnemyDeath(int addingPoints, Transform enemyTransform)
        {
            UpdatePoints(addingPoints);
            if(Random.Range(0f,1f) <= bonusDropChance)
                bonusSpawner?.SpawnRandomBonus(enemyTransform);
        }


	    public void UpdatePoints(int addingPoints)
	    {
		    //
            playerHealth.gameObject.GetComponent<ShipData>().Points += addingPoints;
            _pointsView.UpdateText(playerHealth.gameObject.GetComponent<ShipData>().Points);
        }



	    public void PlayerDeath(float points, Transform playerTranstorm)
        {
            weaponsUI.ClearAllWeapons();

            foreach (Spawner spawner in spawners)
            {
                spawner.StopSpawn();
            }
        }

    }

