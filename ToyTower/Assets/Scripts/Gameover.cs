using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Gameover : MonoBehaviour {

    public Text scoreText;
    public Text bestText;

    private void Start() {

        var bestscore = PlayerPrefs.GetInt("bestscore", 0);
        if (Play.score > bestscore) {
            bestscore = Play.score;
            PlayerPrefs.SetInt("bestscore", bestscore);
        }

        scoreText.text = Play.score.ToString();
        bestText.text = bestscore.ToString();
    }

    public void menu() {
        SceneManager.LoadScene("Menu");
    }

    public void replay() {
        SceneManager.LoadScene("Play");
    }

}