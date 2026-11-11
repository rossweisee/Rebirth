using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(
            "Player va chạm với: " + collision.gameObject.name
        );

        // Kiểm tra xem đối tượng có tag Enemy không
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("Player vừa chạm vào Enemy!");
        }

        // Kiểm tra va chạm với vật thể có tag Obstacle
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log("Player vừa chạm vào chướng ngại vật!");
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log(
            "Player đi vào vùng Trigger: " + other.gameObject.name
        );
        
        
    }
}