using UnityEngine;
using System.Collections;

    public class HealthBonus : Bonus
    {
        [SerializeField]
        private int addingHealth = 1;
        /// <summary>
        /// Добавим жизни кораблю
        /// </summary>
        /// <param name="player"></param>
	    protected override void Apply(PlayerBonusHandler player)
        {
            player.HealthBonus(addingHealth);
        }
    }

