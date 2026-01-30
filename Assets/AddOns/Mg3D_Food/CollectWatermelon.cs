using UnityEngine;

public class CollectFruit : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            FruitCounter.AddOne(); // increase variable
            Destroy(gameObject);   // remove watermelon
        }
    }
}
