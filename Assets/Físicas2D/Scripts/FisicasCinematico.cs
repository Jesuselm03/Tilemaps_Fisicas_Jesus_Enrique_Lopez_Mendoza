using UnityEngine;

public class FisicasCinematico : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)

    {
        Debug.Log($"[Kinematic] {name} ha colisionado con {collision.gameObject.name}");
    }

}
