using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Game : MonoBehaviour {

    public static Game instance;

    public Text scoreText;
    public Hook hook;
    public Camera cam;

    private int score;
    private float orthographicSize = 0f;

    private void Awake() {
        instance = this;
        orthographicSize = cam.orthographicSize;
    }

    public void addScore() {
        score++;
        scoreText.text = score.ToString();
        if (score > 3) {
            orthographicSize += 0.5f;
        }
    }

    private void Update() {
        cam.orthographicSize = Mathf.Lerp(cam.orthographicSize, orthographicSize, Time.deltaTime * 5f);
        cam.transform.position = new Vector3(0f, cam.orthographicSize, cam.transform.position.z);
    }

    public void gameover() {
        Gameover.currentScore = score; //sahneler arası veri transfori için static 
        SceneManager.LoadScene("Gameover");
    }

}