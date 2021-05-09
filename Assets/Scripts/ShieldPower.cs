using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldPower : MonoBehaviour
{

    public GameObject shield;
    // private int shieldHealth = 0;
    public GameObject ship;
    

    // Start is called before the first frame update
    void Start()
    {
        Rigidbody2D rb = shield.AddComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > 30.0)
      {
      	Destroy(gameObject);
      }  
        
    }

    // void OnCollisionEnter2D(Collision2D col)
    // {
    //     Debug.Log("OnCollisionEnter2D");
    //     shieldHealth++;
    // }
}
