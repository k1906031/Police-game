
using UnityEngine;
using TMPro;

public class Coin : MonoBehaviour
{
    public TextMeshProUGUI textcoins;
    // Start is called before the first frame update
    private float coin = 0;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.tag == "coin")
        {
            coin++;
            textcoins.text = coin.ToString();
            Destroy(other.gameObject);
        }
    }
}
