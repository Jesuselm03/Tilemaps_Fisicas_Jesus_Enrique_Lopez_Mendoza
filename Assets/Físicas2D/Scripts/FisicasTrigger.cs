using UnityEngine;

public class FisicasTrigger : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collider)
    {
        Debug.Log($"[Trigger] {name} ha detectado a {collider.gameObject.name}");
    }
}
