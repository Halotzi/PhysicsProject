using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class MyCollider : MonoBehaviour 
{
    public abstract bool Intersects(MyCollider other);
    public abstract void ResolveCollision(MyCollider other, Rigidbody3D rigidbody);
}

