using UnityEngine;

public class FisicasDinamico : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log($"[Dynamic] {name} ha colisionado con {collision.gameObject.name}");
    }
}
