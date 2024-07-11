using UnityEngine;

public class DeactivateSelf : MonoBehaviour
{
    public GameObject Obj;
    public KeyCode _Input;
    public  GameObject TriggerObj;

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag(TriggerObj.tag) && Input.GetKey(_Input))
            Obj.SetActive(false);
    }
}