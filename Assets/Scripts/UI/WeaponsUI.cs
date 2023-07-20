using System.Collections;
using System.Collections.Generic;
using UnityEngine;



    public class WeaponsUI : MonoBehaviour
    {
        [SerializeField] private FireRateUI prefab;

        [SerializeField] private Transform prefabsParent;

        private List<FireRateUI> fireRateUIs = new List<FireRateUI>();


        public void AddNewFireRateUI(string weaponName, float cooldown)
        {
            FireRateUI fireRateUI = Instantiate(prefab, prefabsParent);
            fireRateUI.UpdateText(cooldown, weaponName);
            fireRateUIs.Add(fireRateUI);
        }


        public void UpdateFireRate(List<Weapon> weapons)
        {
            int i = 0;
            foreach (var weapon in weapons)
            {
                fireRateUIs[i].UpdateText(weapon.Cooldown, weapon.name);
                ++i;
            }
        }

        public void ClearAllWeapons()
        {
            for (int i = 0; i < fireRateUIs.Count; i++)
            {
                Destroy(fireRateUIs[i].gameObject);
            }
            fireRateUIs.Clear();
        }
    }

