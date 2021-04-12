using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserControl : MonoBehaviour
{

    public Camera cam;
    public LineRenderer lineRenderer;
    public Transform firePoint;
    public GameObject circle;

    // Start is called before the first frame update
    void Start()
    {
        DisableLaser();
    }

    // Update is called once per frame
    void Update()
    {

        
        UpdateLaser();
        // Debug.Log(firePoint.position);
        // Debug.Log(circle.transform.position);

        if(Input.GetButtonDown("Fire1"))
        {
            if (Physics2D.Raycast(firePoint.position, circle.transform.position, 15, 1)){
            EnableLaser();  
            
            }
          
        }
        

        if(Input.GetButton("Fire1"))
        {
            
            if (Physics2D.Raycast(firePoint.position, circle.transform.position, 15, 1))
            {
                lineRenderer.enabled = true;
                UpdateLaser();
                Debug.Log("SecondGet");
                if(circle.transform.parent == firePoint){
                    Debug.Log("hit child");
                    circle.transform.parent = firePoint;
                }
            }
            lineRenderer.enabled = true;
            

                
        }

        if(Input.GetButtonUp("Fire1"))
        {
            DisableLaser();
        }
        
    }

    void EnableLaser()
    {
        lineRenderer.enabled = true;
    }

    void UpdateLaser()
    {
        lineRenderer.SetPosition(0, firePoint.position);
        
        lineRenderer.SetPosition(1, new Vector3(circle.transform.position.x, circle.transform.position.y, 0));
    }

    void DisableLaser()
    {
        lineRenderer.enabled = false;
    }
}
