using UnityEngine;

public class FisicasEstatico : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log($"[Static] {name} ha colisionado con {collision.gameObject.name}");
    }
}
