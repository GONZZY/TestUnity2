using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSControllerComponent : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    float elapsedTime = 0;
    private float timeBetweenLogs = 1;
    private int nbFrames = 0;
    private void Awake()
    {
        QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = 30;
    }

    private void Update()
    {
        nbFrames++;
        elapsedTime += Time.deltaTime;
        if (elapsedTime > timeBetweenLogs)
        {
            Debug.Log(nbFrames / elapsedTime);
            elapsedTime -= timeBetweenLogs;
            nbFrames = 0;
        }

    }
}
