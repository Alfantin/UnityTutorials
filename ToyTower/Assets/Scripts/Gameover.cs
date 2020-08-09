using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Gameover : MonoBehaviour {

    public static int currentScore;

    public Text scoreText;
    public Text bestText;

    private void Start() {

        var bestscore = PlayerPrefs.GetInt("bestscore", 0);
        if (currentScore > bestscore) {
            bestscore = currentScore;
            PlayerPrefs.SetInt("bestscore", bestscore);
        }

        scoreText.text = currentScore.ToString();
        bestText.text = bestscore.ToString();
    }

    public void menu() {
        SceneManager.LoadScene("Menu");
    }

    public void replay() {
        SceneManager.LoadScene("Play");
    }

}