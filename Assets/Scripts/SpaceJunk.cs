using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// deals with each instance of space junk
public class SpaceJunk : MonoBehaviour
{
    public Vector3 origin;
    public Vector3 destination;
    public float speed = 5f;

    // Start is called before the first frame update
    public void Init(Vector3 start, Vector3 target)
    {
        origin = start;
        destination = target;
    }

    // Update is called once per frame
    void Update()    {
        // move game object from origin to destination
        // distance to move each frame = normalized distance vector * speed * time since last frame
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, destination, step);
    }

}
