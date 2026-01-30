using UnityEngine;

public class CollectWatermelon : MonoBehaviour
{
    public GameObject door; // assign the door in Inspector
    private bool hasOrange = false;

    // Called when player touches the orange
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            hasOrange = true;            // collect the orange
            Destroy(gameObject);          // remove the orange
            if (door != null)
            {
                Destroy(door);           // banish the door
            }
        }
    }
}
