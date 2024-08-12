using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{

    private PlayerStats _playerStats;

    public float movementSpeed;
    public Score score;

    private void Start() { }

    private void Update() {
        if(Input.GetKey(KeyCode.LeftArrow)) {
            transform.position += Vector3.left * (movementSpeed * Time.deltaTime);
        } else if(Input.GetKey(KeyCode.RightArrow)) {
            transform.position += Vector3.right * (movementSpeed * Time.deltaTime);
        }
    }

    private void OnTriggerEnter2D(Collider2D collider) {
        if(collider.gameObject.CompareTag("Obstacle")) {
            score.CalculateHighScore();
            score.ResetCakes();
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        } else if(collider.gameObject.CompareTag("Cake")) {
            score.AddCakeToScore();
        }
    }

}
