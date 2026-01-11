
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallMovement : MonoBehaviour
{
    [SerializeField] Rigidbody rb;
    [SerializeField] float speed = 50f;
    [SerializeField] TMP_Text blueScoreUI;
    [SerializeField] TMP_Text pinkScoreUI;
    [SerializeField] AudioSource SFX;
    [SerializeField] AudioClip scoreSound;
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
    void ReloadScene()
    {
        Time.timeScale = 0;
        SceneManager.LoadScene(1);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "PinkScore")
        {
            pinkScore++;
            pinkScoreUI.text = pinkScore.ToString();
            SFX.PlayOneShot(scoreSound);
            Invoke(nameof(ReloadScene), 0.5f);
            PlayerPrefs.SetInt("PinkScore", pinkScore);
        }
        if (other.gameObject.name == "BlueScore")
        {
            blueScore++;
            blueScoreUI.text = blueScore.ToString();
            SFX.PlayOneShot(scoreSound);
            Invoke(nameof(ReloadScene), 0.5f);
            PlayerPrefs.SetInt("BlueScore", blueScore);
        }
        rb.linearVelocity = Vector3.zero;
        
    }
}
