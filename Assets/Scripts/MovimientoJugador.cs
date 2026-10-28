
using UnityEngine;

public class MovimientoJugador : MonoBehaviour
{
    public float speed = 5f;
    public bool jugador1 = true;
    public float ajusteRotacion = 0f;

    private Vector2 move;
    private Rigidbody2D rigidbody2D;

    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        move = Vector2.zero;
        if (jugador1)
        {
            if (Input.GetKey(KeyCode.W))
                move = Vector2.up;
            else if (Input.GetKey(KeyCode.S))
                move = Vector2.down;
            else if (Input.GetKey(KeyCode.A))
                move = Vector2.left;
            else if (Input.GetKey(KeyCode.D))
                move = Vector2.right;
        }
        else
        {
            if (Input.GetKey(KeyCode.UpArrow))
                move = Vector2.up;
            else if (Input.GetKey(KeyCode.DownArrow))
                move = Vector2.down;
            else if (Input.GetKey(KeyCode.LeftArrow))
                move = Vector2.left;
            else if (Input.GetKey(KeyCode.RightArrow))
                move = Vector2.right;
        }
    }

    private void FixedUpdate()
    {
        rigidbody2D.linearVelocity = move * speed;
        if (move != Vector2.zero)
        {
            float angulo = Mathf.Atan2(move.y, move.x)
                           * Mathf.Rad2Deg;

            rigidbody2D.MoveRotation(angulo + ajusteRotacion);
        }
    }
}
