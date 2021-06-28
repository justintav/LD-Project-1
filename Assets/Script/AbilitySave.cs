using MoreMountains.CorgiEngine;
using UnityEngine;

public class AbilitySave : MonoBehaviour
{
    public static bool isJetpackPermitted;

    private void Start()
    {
        if (isJetpackPermitted)
        {
            PermitJetpack();
        }
    }

    public void PermitJetpack()
    {
        isJetpackPermitted = true;
        GetComponent<CharacterJetpack>().PermitAbility(true);
    }
}
