using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    Animator animator;

    string animationState = "AnimationState";

    enum CharStates
    {
      explosion = 1
    }
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    IEnumerator OnCollisionEnter2D(Collision2D theCollision)
    {
      if(theCollision.gameObject.name == "Circle")
      {
        animator.SetInteger(animationState, (int) CharStates.explosion);
        yield return new WaitForSeconds(3);
        Destroy(gameObject);
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