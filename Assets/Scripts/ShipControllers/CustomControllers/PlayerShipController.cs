using UnityEngine;


    public class PlayerShipController : ShipController
    {
    	
    	public bool autoFire = true;
    	
    	
        protected override void ProcessHandling(MovementSystem movementSystem)
        {
            movementSystem.LateralMovement(Input.GetAxis("Horizontal") * Time.deltaTime);
        }

        protected override void ProcessFire(WeaponSystem fireSystem)
        {
	        //if (Input.GetKey(KeyCode.Space))
	        if (autoFire)
            {
                fireSystem.TriggerFire();
            }
        }
    }

