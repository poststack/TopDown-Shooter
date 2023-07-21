using UnityEngine;
using System.Collections;


    public class RocketWeaponBonus : Bonus
    {
        [SerializeField]
	    private float multiplier = 5f;
        [SerializeField]
	    private float time = 5f;
	    //[SerializeField]
	    //public float _dropChance = 0.4f;


        protected override void Apply(PlayerBonusHandler player)
        {
	        player.StartFireRateBonus(multiplier , time);
        }
    }

