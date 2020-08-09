using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(BoxCollider2D))]
public class Box : MonoBehaviour {

    public void drop() {
        var clone = Instantiate(gameObject, transform.position, Quaternion.identity);
        clone.GetComponent<Rigidbody2D>().gravityScale = 1f;
        clone.gameObject.SetActive(true);
        Game.instance.addScore();
    }

    private void Update() {
        if (transform.position.y < -2f) { 
            Game.instance.gameover();
        }
    }

}