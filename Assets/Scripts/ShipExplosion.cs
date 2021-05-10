using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShipExplosion : MonoBehaviour
{
    Animator animator;

    string animationState = "ShipState";

    enum CharStates
    {
      ShipExplosion = 1,
      explosion = 2
    }
    // Start is called before the first frame update
    void Start()
    {
      GameObject go = GameObject.Find ("PlayerBody");
      animator = go.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    IEnumerator OnTriggerEnter2D(Collider2D theCollision)
    {
      GameObject go = GameObject.Find ("PlayerBody");
      if (theCollision.gameObject.name != "Circle"){
        go.GetComponent<ShipManeuver>().enabled = false;
        animator.SetInteger(animationState, (int) CharStates.ShipExplosion);
        yield return new WaitForSeconds(3);
        if (go){
          Destroy(go);
        }
        Destroy(gameObject);
        SceneManager.LoadScene("StartMenu");
      }
    }

    /*private void UpdateState()
    {
      if (Input.GetKeyDown("p"))
        {
          animator.SetInteger(animationState, (int) CharStates.explosion);
        }
    }*/
}
