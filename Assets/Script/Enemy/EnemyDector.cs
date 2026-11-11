using UnityEngine;

public class EnemyDetector : MonoBehaviour
{
    [SerializeField] private float detectionRadius = 5f;
    [SerializeField] private LayerMask targetLayer;
    [SerializeField] EnemyChase chase;
    private void Update()
    {
        Collider2D[] targets = Physics2D.OverlapCircleAll(
            transform.position,
            detectionRadius,
            targetLayer
        );

        foreach (Collider2D target in targets)
        {            
            Debug.Log("Phát hiện mục tiêu: " + target.name);
            chase.EnemyMove();
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;

        Gizmos.DrawWireSphere(
            transform.position,
            detectionRadius
        );
    }
}