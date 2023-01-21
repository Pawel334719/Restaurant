using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class onResetButtonClick : MonoBehaviour {

    public Text BillText;
    public GameObject numbersLayout,foodLayout;
    public void OnResetButtonClick(){
        BillText.text = null;
        numbersLayout.active = false;
        foodLayout.active = true;

        int x = 0;
        while (x < 3)
        {
            int y = 0;
            while (y < 2)
            {
                Variables.Bill[x, y] = 0;
                y++;
            }
            x++;
        }
    }
}
