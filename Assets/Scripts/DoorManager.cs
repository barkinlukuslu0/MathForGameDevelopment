using UnityEngine;

public class DoorManager : MonoBehaviour
{
    int doorType = AttributeManager.MAGIC;

    void OnCollisionEnter(Collision collision)
    {
        // BitMask 
        // If there is a match with player's attribute and door attribute door will be open. "attributes & doorType" this is there for checking the match.
        if ((collision.gameObject.GetComponent<AttributeManager>().attributes & doorType) != 0)
        {
            this.GetComponent<BoxCollider>().isTrigger = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        this.GetComponent<BoxCollider>().isTrigger = false;
    }
}
