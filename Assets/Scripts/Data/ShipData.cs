using UnityEngine;
using System.Collections;


    /// <summary>
    /// Хранит данные корабля, незнаю стоит ли сюда прокидывать cooldown орудий
    /// </summary>
    public class ShipData : MonoBehaviour
    {
        [SerializeField]
        private int _points;

        public int Points
        {
            get { return _points; }
            set { _points = value; }
        }

        [SerializeField]
	    private float _health;
	    
	    [SerializeField]
	    private float _maxHealth;

	    public float Health
        {
            get { return _health; }
            set { _health = value; }
        }
        
	    public float MaxHealth
	    {
		    get { return _maxHealth; }
		    set { }
	    }
    }

