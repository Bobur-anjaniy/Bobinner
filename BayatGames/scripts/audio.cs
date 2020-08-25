using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audio : MonoBehaviour
{
    AudioSource M_MyaudioSource;
    bool m_Play;
    bool M_torget;
    bool coinsore = false ;
    bool M_music;
    // Start is called before the first frame update
    void Start()
    {
        M_MyaudioSource = GetComponent<AudioSource>();
        m_Play = true;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (coinsore ||Input.GetKeyDown(KeyCode.F) )
        {
           // if (m_Play == true && M_torget == true)
           // {
                M_MyaudioSource.Play();
                M_torget = false;
                Debug.Log("tanga oldi");
                coinsore = false;
            // }
        }
    }
    public void PlayA()
    {
        coinsore = true;
    }
 
}
