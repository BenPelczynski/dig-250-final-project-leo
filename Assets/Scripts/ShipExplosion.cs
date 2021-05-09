using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShipExplosion : MonoBehaviour
{
    Animator animator;

    string animationState = "ShipState";
    
    public Score score;

    enum CharStates
    {
      ShipExplosion = 1,
      explosion = 2
    }
    // Start is called before the first frame update
    void Start()
    {
      GameObject go = GameObject.Find ("PlayerBody");
      GameObject ball = GameObject.Find ("Circle");
      animator = go.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    IEnumerator OnTriggerEnter2D(Collider2D theCollision)
    {
      GameObject go = GameObject.Find ("PlayerBody");
      GameObject ball = GameObject.Find ("Circle");
	
	if (theCollision.gameObject.name == "PowerUp_Combo(Clone)"){
	 	score.value = score.value + score.points + 500;
      	score.points = score.points + 500;
        	Destroy(theCollision.gameObject);
	 }
	
	else if (theCollision.gameObject.name == "PowerUp_MultiBall(Clone)"){
	 	Debug.Log("hit M");
        	Destroy(theCollision.gameObject);
	 }
	
      else if (theCollision.gameObject.name != "Circle"){
        Debug.Log(theCollision.gameObject.name);
        go.GetComponent<ShipManeuver>().enabled = false;
        ball.GetComponent<Collider2D>().enabled = false;
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
