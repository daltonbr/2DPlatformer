using UnityEngine;

public class AutoMoveCrate : PhysicsObject
{
    void Update()
    {
        targetVelocity = Vector2.left;
    }
}