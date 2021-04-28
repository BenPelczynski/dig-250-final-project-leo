using UnityEngine;
using System.Collections;

 public class Rotation : MonoBehaviour
 {
     public GameObject target;
     public float speed = 200;
     public Vector3 direction = Vector3.up;


     void FixedUpdate()
     {
         AddTorqueImpulse(7.0f);
         

        //  transform.RotateAround(target.transform.position, direction, speed * Time.deltaTime);
		//transform.Rotate(direction, Space.Self);
    }

    public void AddTorqueImpulse(float angularChangeInDegrees)
        {
            var body = GetComponent<Rigidbody2D>();
            var impulse = (angularChangeInDegrees * Mathf.Deg2Rad) * body.inertia;

            body.AddTorque(impulse, ForceMode2D.Impulse);
        }

 }
