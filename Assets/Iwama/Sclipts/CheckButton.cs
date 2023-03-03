using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckButton : text
{
    public string inputString = null;

    [SerializeField] private TrainScript_a trainA;
    [SerializeField] private TrainScript_b trainB;
    [SerializeField] private TrainScript_c trainC;
    [SerializeField] private GameObject KeyDoor;
    [SerializeField] private GameObject Enemy;

   
    public AudioClip[] sounds;
    private AudioSource audioSource;

    private void Start()
    {
      Debug.Log(inputString);
      audioSource = GetComponent<AudioSource>();
    }

    public string InputString {
        set { this.inputString = value; }
        get { return this.inputString; }
    }

    public override void Push_Button(int number)//番号のボタンが押されたら
    {
        this.inputString += number;
        Debug.Log(inputString);
    }

    public void PushButtonCheck()//チェックボタンが押されたら
    {
        TrainScript_a A = trainA.GetComponent<TrainScript_a>();
        A.GetNumberA();

        TrainScript_b B = trainB.GetComponent<TrainScript_b>();
        B.GetNumberB();

        TrainScript_c C = trainC.GetComponent<TrainScript_c>();
        C.GetNumberC();

        int a = A.GetNumberA();
        int b = B.GetNumberB();
        int c = C.GetNumberC();
        
        int saveNum = 0;

        if (inputString != "")
        {
           saveNum = int.Parse(inputString);
        }
        

       int keyNum = a * 100 + b * 10 + c;

        if (saveNum == keyNum) //数字が合っていたら
        {
            Destroy(KeyDoor);
            Panel.SetActive(false);

        }
        else
        {
            Instantiate(Enemy, new Vector3(-47, 64, 0), Quaternion.identity);

            audioSource.clip = sounds[0];
            audioSource.Play();
            inputString = "";
       }
    }
  
}
