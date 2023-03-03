using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrainScript_a : MonoBehaviour
{
    [SerializeField] protected GameObject[] Train;
    protected int randomNumber;
    protected int a;
    protected int number;

    protected virtual void Start()
    {
        number = Random.Range(0, Train.Length);//数字を生成
        Instantiate(Train[number], transform.position, transform.rotation);
    }
    

    public int GetNumberA() //パスワードの3桁目がどの数字になっているか
    {
        if (number == 0)
        {
            a = 0;
        }
        else if (number == 1)
        {
            a = 1;
        }
        else if (number == 2)
        {
            a = 2;
        }
        else if (number == 3)
        {
            a = 3;
        }
        else if (number == 4)
        {
            a = 4;
        }
        else if (number == 5)
        {
            a = 5;
        }
        else if (number == 6)
        {
            a = 6;
        }
        else if (number == 7)
        {
            a = 7;
        }
        else if (number == 8)
        {
            a = 8;
        }
        else if (number == 9)
        {
            a = 9;
        }
        return a;
    }
}
        
