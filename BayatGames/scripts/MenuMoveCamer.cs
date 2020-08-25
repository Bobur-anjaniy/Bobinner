using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class MenuMoveCamer : MonoBehaviour
{
    public GameObject menucamer;
    public GameObject Menu;
    public GameObject LvLMenu;
    // Start is called before the first frame update
    void Start()
    {
        menucamer.transform.position = new Vector2(10, 3);
        LvLMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void LvlMenu()
    {
        menucamer.transform.position = new Vector2(40, -25);
        Menu.SetActive(false);
        LvLMenu.SetActive(true);
    }
    public void MainMenu()
    {
        menucamer.transform.position = new Vector2(10, 3);
        Menu.SetActive(true);
        LvLMenu.SetActive(false);
    }
}
