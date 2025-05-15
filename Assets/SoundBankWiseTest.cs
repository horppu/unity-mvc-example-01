using UnityEngine;
using System.Collections.Generic;
using System.Linq;

using AK; // AKBankManager


public class SoundBankWiseTest : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        AkBankManager.LoadBank("test_sb", true, true);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
