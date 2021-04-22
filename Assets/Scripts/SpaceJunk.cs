using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// where to attach this script? 
public class SpaceJunk : MonoBehaviour
{
    public Vector3 direction;

    public BoxCollider perimeterContainerCollider; // assign this to JunkBoundary
    public Vector3 wayPoint; // new point to head towards

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // find a random location within box colliders.
        Vector2 startPoint = FindPointInBounds(perimeterContainerCollider.bounds);

        // place game object (space junk) in that location (transform position?)

        // move game object towards wayPoint (which is a Vector3)
        
    }

    public Vector2 FindPointInBounds(Bounds bounds)
    {
        return new Vector2(
            Random.Range(bounds.min.x, bounds.max.x),
            Random.Range(bounds.min.y, bounds.max.y));
    }
}
