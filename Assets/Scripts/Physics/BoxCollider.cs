using UnityEngine.UIElements;
using UnityEngine;

public class BoxCollider : MyCollider
{
    [SerializeField] public Vector3 Size;

    public BoxCollider(Vector3 size)
    {
        Size = size;
    }

    public override bool Intersects(MyCollider other)
    {
        if (other is BoxCollider otherBox)
        {
            // Check for intersection between two boxes
            Vector3 minA = transform.position - Size * 0.5f;
            Vector3 maxA = transform.position + Size * 0.5f;
            Vector3 minB = otherBox.transform.position - otherBox.Size * 0.5f;
            Vector3 maxB = otherBox.transform.position + otherBox.Size * 0.5f;

            bool intersectsX = maxA.x >= minB.x && minA.x <= maxB.x;
            bool intersectsY = maxA.y >= minB.y && minA.y <= maxB.y;
            bool intersectsZ = maxA.z >= minB.z && minA.z <= maxB.z;

            return intersectsX && intersectsY && intersectsZ;
        }

        return false;
    }

    public override void ResolveCollision(MyCollider other, Rigidbody3D rigidbody)
    {
        // Implement collision resolution for box-to-box or box-to-sphere collisions
    }
}