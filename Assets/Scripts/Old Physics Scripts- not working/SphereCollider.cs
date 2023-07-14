using UnityEngine;
using UnityEngine.UIElements;

public class SphereCollider : MyCollider
{
    public float Radius { get; private set; }

    public SphereCollider(float radius)
    {
        Radius = Mathf.Max(radius, 0f);
    }

    public override bool Intersects(MyCollider other)
    {
        if (other is SphereCollider otherSphere)
        {
            // Check for intersection between two spheres
            float distance = Vector3.Distance(transform.position, otherSphere.transform.position);
            float minDistance = Radius + otherSphere.Radius;
            return distance <= minDistance;
        }

        return false;
    }

    public override void ResolveCollision(MyCollider other, Rigidbody3D rigidbody)
    {
    }
}
