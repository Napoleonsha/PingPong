
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallMovement : MonoBehaviour
{
    [SerializeField] Rigidbody rb;
    [SerializeField] float speed = 50f;
    [SerializeField] TMP_Text blueScoreUI;
    [SerializeField] TMP_Text pinkScoreUI;
    private int 
        pinkScore = 0, 
        blueScore = 0;
    private void Update()
    {
        if (Input.anyKeyDown && Time.timeScale == 0)
        {
            Time.timeScale = 1;
            Launch();
        }
    }
    private void Start()
    {
        pinkScore = PlayerPrefs.GetInt("PinkScore", 0);
        blueScore = PlayerPrefs.GetInt("BlueScore", 0);
        pinkScoreUI.text = pinkScore.ToString();
        blueScoreUI.text = blueScore.ToString();
        Launch();
    }

    private void FixedUpdate()
    {
        rb.linearVelocity = rb.linearVelocity.normalized * speed;
    }

    private void Launch()
    {
        rb.linearVelocity = new Vector3(Random.Range(-1f, 1f), 0, Random.Range(-1f, 1f)) * speed;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "PinkScore")
        {
            pinkScore++;
            pinkScoreUI.text = pinkScore.ToString();
            Time.timeScale = 0;
            PlayerPrefs.SetInt("PinkScore", pinkScore);
            SceneManager.LoadScene(0);
        }
        if (other.gameObject.name == "BlueScore")
        {
            blueScore++;
            blueScoreUI.text = blueScore.ToString();
            Time.timeScale = 0;
            PlayerPrefs.SetInt("BlueScore", blueScore);
            SceneManager.LoadScene(0);
        }
        rb.linearVelocity = Vector3.zero;
    }
}
