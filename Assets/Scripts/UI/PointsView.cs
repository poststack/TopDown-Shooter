using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using DamageNumbersPro;



    public class PointsView : MonoBehaviour
    {
	    [SerializeField] private TMP_Text _pointsText;
	    
	    //DamageNumberPro prefab
	    [SerializeField] 
	    private GameObject NumberPrefab;  
	    [SerializeField] 
	    private Transform WhereToSpawnNumber;   
	    [SerializeField] 
	    private float scale = 1f;
	    

	    protected void Start()
	    {



	    }

	    public void UpdateText(int totalPoints, int addedPoints, Transform scoringSpot)
	    {
	    	Debug.Log ("UpdateText");
	    	
		    GameObject obj = Instantiate(NumberPrefab, scoringSpot.position, Quaternion.identity);
		    obj.name = "ScoreNumber";
		    obj.transform.localScale = Vector3.one*scale;
		    obj.transform.parent = WhereToSpawnNumber;

		    obj.GetComponent<DamageNumberMesh>().number = addedPoints;

	    	_pointsText.text = $"Points:{totalPoints}";	    	
	    }
	    
	    //on start
	    public void UpdateText(int totalPoints)
	    {
	    	_pointsText.text = $"Points:{totalPoints}";	    	
	    	
		    GameObject obj = Instantiate(NumberPrefab, WhereToSpawnNumber.position, Quaternion.identity);
		    obj.name = "ScoreNumber";
		    obj.transform.localScale = Vector3.one*scale;
		    obj.transform.parent = WhereToSpawnNumber;
		    obj.GetComponent<DamageNumberMesh>().number = totalPoints;
	    }
    }

