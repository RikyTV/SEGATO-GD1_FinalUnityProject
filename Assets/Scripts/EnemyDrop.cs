using UnityEngine;

public class EnemyDrop : MonoBehaviour
{
    public GameObject EnemyBody;
    public GameObject PlayerObj;

    private Rigidbody body;

    private void Start()
    {
        body = EnemyBody.GetComponent<Rigidbody>();
    }
    private void OnTriggerEnter(Collider other)
    {
            if (other.gameObject.CompareTag(PlayerObj.tag))
                body.useGravity = true;
    }
}