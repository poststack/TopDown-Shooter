using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System.Collections;


    /// <summary>
    /// Класс отображения здоровья корабля
    /// </summary>
    public class HealthUI : MonoBehaviour
    {
	    [SerializeField] private TMP_Text _healthText;
	    [SerializeField] private Image _FilledImageOnPlayer;

	    public void UpdateText(float health, float maxHealth )
	    {
	    	_healthText.text = $"Health:{health}";
	    	_FilledImageOnPlayer.fillAmount = health/maxHealth;
	    }
        
    }

