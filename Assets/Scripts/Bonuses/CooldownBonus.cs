using UnityEngine;
using System.Collections;


    public class CooldownBonus : Bonus
    {
        [SerializeField]
        private float multiplyer = 1f;
        [SerializeField]
        private float time = 5f;


        protected override void Apply(PlayerBonusHandler player)
        {
            player.StartFireRateBonus(multiplyer, time);
        }
    }

