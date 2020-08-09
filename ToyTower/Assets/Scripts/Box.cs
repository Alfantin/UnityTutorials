using UnityEngine;
using UnityEngine.SceneManagement;

public class Box : MonoBehaviour {

    public void createClone() {
        var clone = Instantiate(gameObject, transform.position, Quaternion.identity);
        clone.GetComponent<Rigidbody2D>().gravityScale = 1f;
        clone.gameObject.SetActive(true);
    }

    private void Update() {
        if (transform.position.y < -6f) {
            SceneManager.LoadScene("Gameover");
        }
    }

    private void OnCollisionStay2D(Collision2D collision) {
        if (transform.position.y > Play.instance.height) {
            Play.instance.height = transform.position.y;
        }
    }

}