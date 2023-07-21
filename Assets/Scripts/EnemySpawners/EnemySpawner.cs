using System;
using System.Collections;
using UnityEngine;
using Random = UnityEngine.Random;


    public class EnemySpawner : MonoBehaviour
    {

        [SerializeField]
        private GameObject _object;
        
        [SerializeField]
        private Transform _parent;
        
        [SerializeField]
        private Vector2 _spawnPeriodRange;
        
        [SerializeField]
        private Vector2 _spawnDelayRange;

        [SerializeField]
        private bool _autoStart = true;


        private void Start()
        {
            if (_autoStart)
                StartSpawn();
        }


        public void StartSpawn()
        {
            StartCoroutine(Spawn());
        }

        public void StopSpawn()
        {
            StopAllCoroutines();
        }


        private IEnumerator Spawn()
        {
            yield return new WaitForSeconds(Random.Range(_spawnDelayRange.x, _spawnDelayRange.y));
            
            while (true)
            {
                GameObject spawnShip = Instantiate(_object, transform.position, transform.rotation, _parent);

	            spawnShip.GetComponent<Ship>().OnDie += GameManager.Instance.EnemyDeath;
                yield return new WaitForSeconds(Random.Range(_spawnPeriodRange.x, _spawnPeriodRange.y));
            }
        }
    }

