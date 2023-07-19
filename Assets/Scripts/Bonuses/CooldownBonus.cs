using UnityEngine;
using System.Collections;


    public class CooldownBonus : Bonus
    {
        [SerializeField]
        private float multiplyer = 1f;
        [SerializeField]
        private float time = 5f;
        /// <summary>
        /// Запустим изменения скорости перезарядки у корабля
        /// </summary>
        /// <param name="player"></param>
        protected override void Apply(PlayerBonusHandler player)
        {
            player.StartFireRateBonus(multiplyer, time);
        }
    }

