using UnityEngine;

public class Launcher : MonoBehaviour
{
    public Rigidbody2D ball; // arraste a bola aqui no Inspector
    public float launchForce = 8f; // ajuste a força conforme necessário
    private bool isCharging = false;
    private bool isBallInContact = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            isCharging = true;
        }

        if (Input.GetKeyUp(KeyCode.DownArrow) && isCharging && isBallInContact)
        {
            ball.AddForce(Vector2.up * launchForce, ForceMode2D.Force);
            isCharging = false;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<Rigidbody2D>() == ball)
        {
            isBallInContact = true;
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<Rigidbody2D>() == ball)
        {
            isBallInContact = false;
        }
    }
}
