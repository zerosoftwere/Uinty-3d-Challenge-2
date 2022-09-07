using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;

    private float inputDelay = 0f;

    // Update is called once per frame
    void Update()
    {
        UpdateInputDelay();

        // On spacebar press, send dog and delay the next input by 1 secound.
        if (Input.GetKeyDown(KeyCode.Space) && inputDelay == 0)
        {
            inputDelay = 1f;
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }
    }

    // Update Delay on button press.
    private void UpdateInputDelay()
    {
        if (inputDelay > 0f)
        {
            inputDelay -= Time.deltaTime;
        }
        if (inputDelay < 0f)
        {
            inputDelay = 0f;
        }
    }
}
