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

        
        if(Input.GetButtonDown("Fire1"))
        {
            if (Physics2D.Raycast(firePoint.position, circle.transform.position, 15, 1)){
            EnableLaser();  
            }
          
        }
        

        if(Input.GetButton("Fire1"))
        {
            UpdateLaser();
            if (Physics2D.Raycast(firePoint.position, circle.transform.position, 15, 1))
            {
                if(circle.transform.parent != firePoint){
                    circle.transform.parent = firePoint;
                }
            }
                
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
        var mousePos = (Vector2)cam.ScreenToWorldPoint(Input.mousePosition);


        lineRenderer.SetPosition(0, firePoint.position);
        
        lineRenderer.SetPosition(1, new Vector3(circle.transform.position.x * 1.2f, circle.transform.position.y * 1.2f, 0));
    }

    void DisableLaser()
    {
        lineRenderer.enabled = false;
    }
}
