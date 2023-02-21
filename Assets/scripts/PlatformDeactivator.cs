using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformDeactivator : MonoBehaviour

{
    [SerializeField] GameObject platformDeactive;
    [SerializeField] GameObject bgActivate;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        platformDeactive.SetActive(false);
        bgActivate.SetActive(true);
    }

}
