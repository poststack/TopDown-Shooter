/* 
    ------------------- Code Monkey -------------------

    Thank you for downloading this package
    I hope you find it useful in your projects
    If you have any questions let me know
    Cheers!

               unitycodemonkey.com
    --------------------------------------------------
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ItemSlot : MonoBehaviour, IDropHandler {
	
	[SerializeField]
	private WeaponSystem _weaponSystem;
	
	
	public ItemScript carriedObject;
	public Transform ConnectedWeaponHolder;
	public GameObject installedWeapon;

    public void OnDrop(PointerEventData eventData) {
        Debug.Log("OnDrop");
        if (eventData.pointerDrag != null) {
	        eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = 
		        GetComponent<RectTransform>().anchoredPosition;
	        InstallItem(eventData.pointerDrag);
	        Debug.Log($"Installed {eventData.pointerDrag.name} to {gameObject.name}");
        }
    }
    
	private void InstallItem(GameObject item)
	{
		item.GetComponent<ItemScript>().occupidedSlot = gameObject.GetComponent<ItemSlot>();
		carriedObject = item.GetComponent<ItemScript>();
		
		GameObject weapon = Instantiate(
			item.gameObject.transform.GetChild(1).gameObject,
			ConnectedWeaponHolder.position,
			ConnectedWeaponHolder.rotation);	
		weapon.transform.parent = ConnectedWeaponHolder.parent;
		installedWeapon = weapon;
		_weaponSystem.ReinstallWeapons();
	}
	
	public void UninstallItem()
	{
		carriedObject = null;
		Destroy(installedWeapon);
	}

}
