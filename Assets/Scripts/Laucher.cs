using UnityEngine;

public class Launcher : MonoBehaviour
{
    public Rigidbody2D ball; // arraste a bola aqui no Inspector
    public float launchForce = 8f; // ajuste a força conforme necessário
    private bool isCharging = false;

    void Update()
    {
        // Pressionar seta para baixo começa o carregamento
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            isCharging = true;
        }

        // Soltar a seta para baixo lança a bola
        if (Input.GetKeyUp(KeyCode.DownArrow) && isCharging)
        {
            ball.AddForce(Vector2.up * launchForce, ForceMode2D.Force);
            isCharging = false; 
        }
    }
}
