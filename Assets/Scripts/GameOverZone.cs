using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverZone : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // Reinicia a cena atual
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
