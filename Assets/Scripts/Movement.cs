using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Movement : MonoBehaviour
{
    private Rigidbody rb;
    private readonly float speed = 880f;

    private void OnEnable()
    {
        Player.OnDead += StopMovement;
        Player.OnGoal += StopMovement;
    }

    private void OnDisable()
    {
        Player.OnDead -= StopMovement;
        Player.OnGoal -= StopMovement;
    }

    private void Awake() => rb = gameObject.GetComponent<Rigidbody>();

    private void Start() => rb.constraints = RigidbodyConstraints.FreezePositionY;

    private void FixedUpdate() => Perform();

    private void Perform() => rb.AddForce(new Vector3(InputManager.horizontal, 0, InputManager.vertical) * speed * Time.fixedDeltaTime);

    private void StopMovement()
    {
        rb.drag = 2;
        this.enabled = false;
    }
}
