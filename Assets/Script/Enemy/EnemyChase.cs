using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class EnemyChase : MonoBehaviour
{
    [Header("Target")]
    [SerializeField] private Transform target;

    [Header("Movement")]
    [SerializeField] private float moveSpeed = 2f;
    [SerializeField] private float stoppingDistance = 0.8f;

    private Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        // Tìm Player nếu chưa gán Target trong Inspector
        if (target == null)
        {
            GameObject player = GameObject.FindGameObjectWithTag("Player");

            if (player != null)
            {
                target = player.transform;
            }
            else
            {
                Debug.LogWarning("Enemy không tìm thấy Player!");
            }
        }
    }
    public void EnemyMove()
    {
        if (target == null)
            return;
        Vector2 currentPosition = rb.position;
        Vector2 targetPosition = target.position;

        // Tính khoảng cách đến Player
        float distance = Vector2.Distance(
            currentPosition,
            targetPosition
        );

        // Nếu đủ gần thì dừng lại
        if (distance <= stoppingDistance)
            return;

        // Tính hướng di chuyển
        Vector2 direction =
            (targetPosition - currentPosition).normalized;

        // Tính vị trí mới
        Vector2 newPosition =
            currentPosition +
            direction * moveSpeed * Time.fixedDeltaTime;

        rb.MovePosition(newPosition);
    }
    private void FixedUpdate()
    {
        
    }
}