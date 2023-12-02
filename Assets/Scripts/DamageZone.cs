using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageZone : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        SpelunkerController controller = other.GetComponent<SpelunkerController >();

        if (controller != null)
        {
            controller.ChangeHealth(-1);
        }
    }

}
