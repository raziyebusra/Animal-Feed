using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;

    bool isReadyForInstantiate;

    void Start()
    {
        isReadyForInstantiate = true;
    }
    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (isReadyForInstantiate && Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine(PreventSpam());
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }
    }

    IEnumerator PreventSpam()
    {
        isReadyForInstantiate = false;
        yield return new WaitForSeconds(2);
        isReadyForInstantiate = true;
    }
}
