using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onTypeOfFoodClick : MonoBehaviour {

    public GameObject TypeOfFood,AmountOfFood;
    int X = 33;
    public void onD1Click() {
        Variables.Bill[0, 0] = X;
        change();
    }
    public void onD2Click(){
        Variables.Bill[0, 1] = X;
        change();
    }
    public void onM1Click(){
        Variables.Bill[1, 0] = X;
        change();
    }
    public void onM2Click(){
        Variables.Bill[1, 1] = X;
        change();
    }
    public void onS1Click(){
        Variables.Bill[2, 0] = X;
        change();
    }
    public void onS2Click(){
        Variables.Bill[2, 1] = X;
        change();
    }
    void change(){
        TypeOfFood.active = false;
        AmountOfFood.active = true;
    }
}
