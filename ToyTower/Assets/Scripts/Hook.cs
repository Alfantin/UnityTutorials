using System.Collections;
using UnityEngine;

public class Hook : MonoBehaviour {

    public Box boxPrefab;

    private void Update() {

        transform.position = new Vector3(
            Mathf.PingPong(Time.time * 1.5f, 2f) * 2f - 2f,
            Play.instance.cam.orthographicSize * 2f,
            0f
        );

        if (boxPrefab.gameObject.activeSelf && Input.anyKeyDown) {
            StartCoroutine(drop());
        }

    }

    private IEnumerator drop() {
        Play.instance.addScore();
        boxPrefab.gameObject.SetActive(false);
        boxPrefab.createClone();
        yield return new WaitForSeconds(1f);
        boxPrefab.gameObject.SetActive(true);
    }

}