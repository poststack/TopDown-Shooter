using System.Collections.Generic;
using UnityEngine;
using System.Linq;


    public class WeaponSystem : MonoBehaviour
    {
	    public List<Weapon> _weapons;
        
	    public Transform _weaponsHolder;


	    // Start is called on the frame when a script is enabled just before any of the Update methods is called the first time.
	    protected void Start()
	    {

	    }
	    
	    public void ReinstallWeapons()
	    {
		    _weaponsHolder = gameObject.transform.Find("Weapons");

	    	_weapons.Clear();
		    foreach (Transform child in _weaponsHolder)
		    {		
		    	//Debug.Log($"child {child}");
			    if (child.TryGetComponent<Weapon>(out Weapon _thisWeapon))
			    {
			    	//Debug.Log($"_thisWeapon {_thisWeapon}");
				    _weapons.Add(_thisWeapon);
			    }
		    }
		    Init(UnitBattleIdentity.Ally);
	    }

        public void Init(UnitBattleIdentity battleIdentity)
	    {

		    
            _weapons.ForEach(w => w.Init(battleIdentity));
            object obj = new object();
        }

        public void TriggerFire()
        {
            _weapons.ForEach(w => w.TriggerFire());
        }


        public void AllChangeCooldown(float multiplyer)
        {
            _weapons.ForEach(w => w.ChangeCooldown(multiplyer));
        }
    }

