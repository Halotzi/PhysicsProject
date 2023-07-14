using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class Rigidbody3D
{
    public Vector3 Position { get; private set; } // Represents the position of the rigidbody in 3D space.
    public Quaternion Rotation { get; private set; } //Represents the rotation of the rigidbody as a quaternion.
    
    public Vector3 Velocity; //Represents the linear velocity of the rigidbody.
    public Vector3 AngularVelocity { get; private set; } //Represents the angular velocity of the rigidbody.
    public Vector3 Acceleration { get; private set; } //Represents the linear acceleration of the rigidbody.
    public Vector3 AngularAcceleration { get; private set; } //Represents the angular acceleration of the rigidbody.
    public float Mass { get; private set; } //Represents the mass of the rigidbody.
    public bool UseGravity { get; set; } // Indicates whether gravity is applied to the rigidbody.
    public bool IsKinematic { get; set; } //Indicates whether the rigidbody is marked as kinematic. A kinematic rigidbody is not affected by forces and behaves as if it has infinite mass.
    public float LinearDamping { get; set; } //Represents the linear damping coefficient, which controls how much the linear velocity of the rigidbody is reduced over time.
    public float AngularDamping { get; set; } //Represents the angular damping coefficient, which controls how much the angular velocity of the rigidbody is reduced over time.
    public bool FreezeRotation { get; set; } //Indicates whether the rotation of the rigidbody is frozen. When set to true, the rotation won't be updated.
    public float Drag { get; set; } //Represents the linear drag coefficient, which determines how much the velocity of the rigidbody is reduced each frame.

    /// <summary>
    /// Constructor method that initializes a new instance of the Rigidbody3D class with the specified mass.
    /// </summary>
    /// <param name="mass"></param>
    public Rigidbody3D(float mass, Vector3 position)
    {
        Mass = Mathf.Max(mass, 0.01f); // Ensure non-zero and positive mass
        Position = Vector3.zero;
        Rotation = Quaternion.identity;
        Velocity = Vector3.zero;
        AngularVelocity = Vector3.zero;
        Acceleration = Vector3.zero;
        AngularAcceleration = Vector3.zero;
        UseGravity = true;
        IsKinematic = false;
        LinearDamping = 0.98f;
        AngularDamping = 0.98f;
        FreezeRotation = false;
        Drag = 0f;
    }

    /// <summary>
    /// Adds a force to the rigidbody. The force parameter represents the applied force vector, and the mode parameter (optional) determines how the force is applied (e.g., Force, Impulse, or Acceleration).
    /// </summary>
    /// <param name="force"></param>
    /// <param name="mode"></param>
    public void AddForce(Vector3 force, ForceMode mode = ForceMode.Force)
    {
        if (IsKinematic)
            return;

        switch (mode)
        {
            case ForceMode.Force:
                Acceleration += force / Mass;
                break;
            case ForceMode.Impulse:
                Acceleration += force / Mass;
                break;
            case ForceMode.Acceleration:
                Acceleration += force;
                break;
        }
    }

    /// <summary>
    /// Adds a torque (momentum) to the rigidbody. The torque parameter represents the applied torque vector, and the mode parameter (optional) determines how the torque is applied (e.g., Force, Impulse, or Acceleration).
    /// </summary>
    /// <param name="torque"></param>
    /// <param name="mode"></param>
    public void AddTorque(Vector3 torque, ForceMode mode = ForceMode.Force)
    {
        if (IsKinematic)
            return;

        switch (mode)
        {
            case ForceMode.Force: //This mode represents a continuous force applied to the rigidbody. כוח מתמשך
                AngularAcceleration += torque / Mass;
                break;
            case ForceMode.Impulse: //This mode represents an instantaneous force or impulse applied to the rigidbody. כוח מיידי
                AngularAcceleration += torque / Mass;
                break;
            case ForceMode.Acceleration: // apply direct acceletation to the rigidbody. האצה ישירה
                AngularAcceleration += torque;
                break;
        }
    }

    /// <summary>
    /// Updates the state of the rigidbody based on the specified deltaTime. It applies gravity, updates the position and rotation, and applies damping if the rigidbody is not kinematic.
    /// </summary>
    /// <param name="deltaTime"></param>
    public void UpdateRigidbody(float deltaTime)
    {
        if (!IsKinematic)
        {
            ApplyGravity();
            UpdatePosition(deltaTime);
            UpdateRotation(deltaTime);
            ApplyDamping();
        }
    }

    /// <summary>
    /// Applies gravity to the rigidbody's acceleration if UseGravity is set to true.
    /// </summary>
    private void ApplyGravity()
    {
        if (UseGravity)
            Acceleration += Physics.gravity;
    }

    /// <summary>
    /// Updates the position of the rigidbody based on the current velocity and acceleration.
    /// </summary>
    /// <param name="deltaTime"></param>
    private void UpdatePosition(float deltaTime)
    {
        Velocity += Acceleration * deltaTime;
        Position += Velocity * deltaTime;
        //Acceleration = Vector3.zero;
    }

    /// <summary>
    /// Updates the rotation of the rigidbody based on the current angular velocity and acceleration. If FreezeRotation is set to true, the rotation won't be updated.
    /// </summary>
    /// <param name="deltaTime"></param>
    private void UpdateRotation(float deltaTime)
    {
        if (!FreezeRotation)
        {
            AngularVelocity += AngularAcceleration * deltaTime;
            Quaternion angularRotation = Quaternion.Euler(AngularVelocity * deltaTime);
            Rotation = angularRotation * Rotation;
            AngularAcceleration = Vector3.zero;
        }
    }

    /// <summary>
    /// Applies damping to the rigidbody's velocity and angular velocity based on the Drag coefficient. 
    /// אחראי על הדעיכה
    /// </summary>
    private void ApplyDamping()
    {
        Velocity *= LinearDamping;
        AngularVelocity *= AngularDamping;
    }

    /// <summary>
    /// Adds a force at a specific position on the rigidbody. 
    /// The force parameter represents the applied force vector, the position parameter represents the position where the force is applied. 
    /// The mode parameter (optional) determines how the force is applied (e.g., Force, Impulse, or Acceleration).
    /// </summary>
    /// <param name="force"></param>
    /// <param name="position"></param>
    /// <param name="mode"></param>
    public void AddForceAtPosition(Vector3 force, Vector3 position, ForceMode mode = ForceMode.Force)
    {
        if (IsKinematic)
            return;

        // Calculate torque based on the force and position
        Vector3 torque = Vector3.Cross(position - Position, force);

        switch (mode)
        {
            case ForceMode.Force:
                AddForce(force, mode);
                AddTorque(torque, mode);
                break;
            case ForceMode.Impulse:
                AddForce(force, mode);
                AddTorque(torque, mode);
                break;
            case ForceMode.Acceleration:
                AddForce(force, mode);
                AddTorque(torque, mode);
                break;
        }
    }
}

public enum ForceMode
{
    Force,
    Impulse,
    Acceleration
}