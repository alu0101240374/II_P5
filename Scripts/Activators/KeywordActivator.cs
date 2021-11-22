using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeywordActivator : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        GameManager.manager.startRecognizeKeyword();
    }

    void OnTriggerExit(Collider other)
    {
        GameManager.manager.stopRecognizeKeyword();
    }

    public void startRecording() 
    {
       GameManager.manager.recordMic();
    }
}