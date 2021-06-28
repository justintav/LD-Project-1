using UnityEngine;

public class JetpackEnabler : MonoBehaviour
{
    private void Start()
    {
        if (AbilitySave.isJetpackPermitted)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            var abilitySave = collision.gameObject.GetComponent<AbilitySave>();
            if (abilitySave)
            {
                abilitySave.PermitJetpack();
                Destroy(gameObject);
            }
        }
    }
}
