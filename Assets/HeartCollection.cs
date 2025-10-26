using UnityEngine;
using UnityEngine.UI; 

public class HeartCollect : MonoBehaviour {
   public TMPro.TextMeshProUGUI winText; 
    private static int count = 0;
    public int goal = 5;

    void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.name == "Player") {
            count++;
            gameObject.SetActive(false); 
            if (count >= goal) {
                winText.text = "Love Full! You Win!"; 
            }
        }
    }
}