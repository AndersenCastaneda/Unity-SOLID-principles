using UnityEngine;

public class Collision : MonoBehaviour
{
    private Player player;

    private void Awake() => player = gameObject.GetComponent<Player>();

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<ICollectable>() != null)
        {
            other.GetComponent<ICollectable>().Collect();
            player.SetScore(1);
        }

        if (other.CompareTag("Trap"))
            player.TakeDamage(1);

        if (other.CompareTag("Goal"))
            Player.OnGoal();
    }
}
