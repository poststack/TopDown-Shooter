using UnityEngine;
using System.Collections;


    public class PlayerData : MonoBehaviour
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
	        set 
		    { 
			    _health = value; 
			    if (_health > _maxHealth)
				    _health =_maxHealth;

	        }
        }
        
	    public float MaxHealth
	    {
		    get { return _maxHealth; }
		    set { }
	    }
    }

