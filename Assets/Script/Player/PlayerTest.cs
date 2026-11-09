using UnityEditor.ShaderGraph.Internal;
using UnityEngine;

public class PlayerTest : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Awake()
    {
        Debug.Log("player script");
    }
    // Update is called once per frame
    private void Update()
    {
        transform.position +=
            Vector3.right * moveSpeed * Time.deltaTime;
    }
}
