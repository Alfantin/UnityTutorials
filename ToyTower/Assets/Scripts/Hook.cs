using System.Collections;
using UnityEngine;

public class Hook : MonoBehaviour {

    public float speed = 1f;
    public float length = 1f;
    public Box box;

    private void Update() {

        //sol sağ git gel
        transform.position = new Vector3(
            Mathf.PingPong(Time.time * speed, length) * 2f - length,
            Game.instance.cam.orthographicSize * 2f,
            0f
        );

        //herhangi bir tuşa basıldığında kutuyu bırak
        if (Input.anyKeyDown) {
            StartCoroutine(drop());
        }

    }

    private IEnumerator drop() {
        box.gameObject.SetActive(false);
        box.drop();
        yield return new WaitForSeconds(1f);
        box.gameObject.SetActive(true);
    }

}