using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformActivator : MonoBehaviour
{
    [SerializeField] GameObject platformActive;
    [SerializeField] GameObject bgDeactivate;
    private void OnCollisionExit2D(Collision2D collision)
    {
        platformActive.SetActive(true);
        bgDeactivate.SetActive(false);
    }
}
