using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForwardComponent : MonoBehaviour
{
    [SerializeField] private float normeVitesseParSeconde = 60;
    Vector3 déplacementFrame;
    void Update()
    {
        déplacementFrame = Vector3.forward * (normeVitesseParSeconde * Time.deltaTime);
        transform.Translate(Vector3.forward * (normeVitesseParSeconde * Time.deltaTime), Space.Self);
        //Debug.Log(déplacementFrame);
    }
}
