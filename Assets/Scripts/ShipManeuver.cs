using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipManeuver : MonoBehaviour
{
   
   private Rigidbody2D rb;
   
   float maxVelocity = 3;
   
    // Start is called before the first frame update
    private void Start()
    {
       rb = GetComponent<Rigidbody2D>();
    }
    
    // Update is called once per frame
    private void Update()
    {
        float yAxis = Input.GetAxis("Vertical");
        float xAxis = Input.GetAxis("Horizontal");
        ThrustSideways(xAxis); 
        ThrustForward(yAxis);       
     }
    
    #region Manuevering API
    
    private void ClampVelocity()
    {
    		float x = Mathf.Clamp(rb.velocity.x, -maxVelocity, maxVelocity);
    		float y = Mathf.Clamp(rb.velocity.y, -maxVelocity, maxVelocity);
    		
    		rb.velocity = new Vector2(x, y);
    }
    
    private void ThrustForward(float amount)
    {
    		Vector2 force = transform.up * amount;
    		rb.AddForce(force);
    }
    
     private void ThrustSideways(float amount)
    {
    		Vector2 force = transform.right * amount;
    		rb.AddForce(force);
    }
    
    #endregion
}
