using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformActivator : MonoBehaviour
{
    [SerializeField] GameObject platformActive;
    private void OnCollisionExit2D(Collision2D collision)
    {
        platformActive.SetActive(true);
    }
}
