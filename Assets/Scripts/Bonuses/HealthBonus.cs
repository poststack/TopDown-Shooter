using UnityEngine;
using System.Collections;

    public class HealthBonus : Bonus
    {
        [SerializeField]
        private int addingHealth = 1;

	    protected override void Apply(PlayerBonusHandler player)
        {
            player.HealthBonus(addingHealth);
        }
    }

