using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContSystem : ModSystem
{
    void Select() {
        int price = 0;
        price = prices[selPos];
        Comprar(price);
    }

    void Comprar(int price) {
        if (intMoney - price >= 0) {
            intMoney -= price; // Disminuir
        } else {
            imgCartel.SetActive(true); // Cartel
            bolUse = false;
        }
    }
}
