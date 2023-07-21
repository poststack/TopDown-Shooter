using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System.Collections;



    public class HealthUI : MonoBehaviour
    {
	    [SerializeField] private TMP_Text _healthText;
	    [SerializeField] private Image _FilledImageOnPlayer;
	    
	    
	    [SerializeField] private SpriteRenderer _HealthSignalSprite;
	    [SerializeField] private Color _HealthSignalSpriteFull = Color.blue;
	    [SerializeField] private Color _HealthSignalSpriteEmpty = Color.red;


	    void Start()
	    {
	    	//Debug.Log (gameObject.name);
	    }
	    public void UpdateText(float health, float maxHealth )
	    {
	    	_healthText.text = $"Health:{health}";
	    	_FilledImageOnPlayer.fillAmount = health/maxHealth;
	    //	_HealthSignalSprite.color = Color.Lerp(
		//    	_HealthSignalSpriteEmpty,
		//    	_HealthSignalSpriteFull,
	    //		health/maxHealth);
	    }
        
    }

