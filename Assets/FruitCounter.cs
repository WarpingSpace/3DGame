using UnityEngine;
using UnityEngine.UI;

public class FruitCounter : MonoBehaviour
{
    public static int count = 0;   // the variable
    public Text counterText;

    void Start()
    {
 	count = 0; // reset every time Play starts
        counterText.text = count.ToString();
    }

    public static void AddOne()
    {
        count++;
    }

    void Update()
    {
        counterText.text = count.ToString();
    }
}
