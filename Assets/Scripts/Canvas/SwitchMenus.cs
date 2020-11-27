using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchMenus : MonoBehaviour
{
    public GameObject panelInventaire;
    public GameObject panelCrafting;
    public GameObject panelMachine;
    public bool openInventaire;
    public bool openCrafting;
    public bool openMachine;

    private void Start()
    {
        openInventaire = false;
        openCrafting = false;
        openMachine = false;

        panelInventaire.SetActive(openInventaire);
        panelCrafting.SetActive(openCrafting);
        panelMachine.SetActive(openMachine);
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.I))
        {
            openCrafting = false;
            openMachine = false;
            openInventaire = !openInventaire;
        }
        if (Input.GetKeyDown(KeyCode.U))
        {
            openInventaire = false;
            openMachine = false;
            openCrafting = !openCrafting;
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            openInventaire = false;
            openCrafting = false;
            openMachine = !openMachine;
        }

        panelInventaire.SetActive(openInventaire);
        panelCrafting.SetActive(openCrafting);
        panelMachine.SetActive(openMachine);
    }
}
