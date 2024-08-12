using UnityEngine;

public class Obstacle : MonoBehaviour
{

    public float movementSpeed;

    private readonly float[] _fixedPositionX = new float[] { -8.0f, 0.0f, 8.0f };

    void Start() { }

    private void OnEnable() {
        int randomPositionX = Random.Range(0, 3);
        float randomScaleX = Random.Range(2.0f, 6.0f);
        transform.position = new Vector3(_fixedPositionX[randomPositionX], 6.0f, 0);
    }

    private void Update() {
        transform.position += Vector3.down * (movementSpeed * Time.deltaTime);
        if(transform.position.y < -5.25) {
            gameObject.SetActive(false);
        }
    }
}
