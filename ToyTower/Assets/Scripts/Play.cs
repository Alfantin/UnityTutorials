using UnityEngine;
using UnityEngine.UI;

public class Play : MonoBehaviour {

    public static Play instance;
    public static int score;

    public Text scoreText;
    public Camera cam;
    public Transform target;
    public float height { get; set; }

    private void Awake() {
        instance = this;
        score = 0;
    }

    public void addScore() {
        scoreText.text = (++score).ToString();
    }

    private void Update() {
        cam.orthographicSize = Mathf.Lerp(cam.orthographicSize, Mathf.LerpUnclamped(5f, 10f, height / 12f), Time.deltaTime * 1f);
        cam.transform.position = new Vector3(0f, cam.orthographicSize, cam.transform.position.z);
    }

}