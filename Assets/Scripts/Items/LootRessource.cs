using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LootRessource : Interaction
{
    // Variable qui contiendra le SO 'Item' glissé depuis les assets.
    public SOItem item;

    // Ré-écriture de la méthode virtuelle 'Interagir()'
    // contenue dans 'Interaction.cs' (accessible puisque l'on en hérite)
    // par la méthode LooterRessource().
    public override void Interagir()
    {
        base.Interagir();
        LooterRessource();
    }

    private void LooterRessource()
    {
        Debug.Log("Rammasser: " + item.nomItem);
        Destroy(this.gameObject);
        //// Utilisation du SINGLETON
        //bool estRamasser = Inventaire.instanceInv.AjoutItem(item);
        //// Destruction de l'item si rammasé.
        //if (estRamasser == true) { Destroy(this.gameObject); }
    }
}
