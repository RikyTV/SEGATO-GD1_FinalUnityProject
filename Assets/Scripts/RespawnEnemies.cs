using UnityEngine;

public class RespawnEnemies : MonoBehaviour
{
    public GameObject EnemyObj;
    public GameObject PlayerObj;
    public KeyCode _Input;

    private GameObject[] gos;

    private void Start()
    {
        gos = GameObject.FindGameObjectsWithTag(EnemyObj.tag);
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag(PlayerObj.tag) && Input.GetKey(_Input))
        {
            foreach (GameObject go in gos)
                go.SetActive(true);
        }
    }
}