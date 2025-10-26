using UnityEngine;

public class BasicMove : MonoBehaviour {
    public float speed = 3f;

    void Update() {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        transform.Translate(new Vector2(h * speed * Time.deltaTime, v * speed * Time.deltaTime));
    }
}