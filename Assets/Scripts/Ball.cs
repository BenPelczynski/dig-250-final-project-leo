using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
  bool start_press = false;
  public float speed;
  public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      if (start_press == false)
      {
        if (Input.GetKeyDown("space"))
        {
          Launch();
          start_press = true;
        }
      }
    }
    private void Launch()
    {
      float x = Random.Range(0, 2) == 0 ? -1 : 1;
      float y = Random.Range(0, 2) == 0 ? -1 : 1;
      rb.velocity = new Vector2(speed * x, speed * y);
    }
}
