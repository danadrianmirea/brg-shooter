using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player; // Assign the player object in the Inspector
    private Vector3 offset;

    void Start()
    {
        if (player != null)
        {
            offset = transform.position - player.position;
        }
        else
        {
            Debug.LogError("Player not assigned in FollowPlayer script!");
        }
    }

    void LateUpdate()
    {
        if (player != null)
        {
            transform.position = player.position + offset;
        }
    }
}
