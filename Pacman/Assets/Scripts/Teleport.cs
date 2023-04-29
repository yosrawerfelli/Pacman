
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public Transform teleport;

    private void OnTriggerEnter2D(Collider2D other) {
        Vector3 position = other.transform.position;
        position.x = this.teleport.position.x;
        position.y = this.teleport.position.y;

        other.transform.position = position;
    }

 
}
