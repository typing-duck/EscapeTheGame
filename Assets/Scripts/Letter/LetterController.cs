using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LetterController : IsEnd
{
  private GameObject[] switchers = new GameObject[2];
  private GameObject[] buttons = new GameObject[26];
  private GameObject[] letters = new GameObject[26];
  public Tuple<char, bool>[] password = 
  {
    Tuple.Create('t', false),
    Tuple.Create('i', false),
    Tuple.Create('m', false),
    Tuple.Create('e', false)
  }; 

  void Start()
  {
    init_buttons();
    init_letters();
    init_swithers();
  }

  void Update()
  {
    int add = 0;
    if(switchers[0].GetComponent<SwitchModel>().isOn)
    {
      add = add + 1;
    }
    if(switchers[1].GetComponent<SwitchModel>().isOn)
    {
      add = add + 2;
    }
    for(int i=0; i<25; i=i+4)
    {
      if(buttons[i].GetComponent<ButtonModel>().isOn)
      {
        Debug.Log(letters[i+add].name);
      }
    }
  }

  private void init_buttons()
  {
    buttons[0] = GameObject.FindGameObjectWithTag("Button_a");
    buttons[4] = GameObject.FindGameObjectWithTag("Button_e");
    buttons[8] = GameObject.FindGameObjectWithTag("Button_i");
    buttons[12] = GameObject.FindGameObjectWithTag("Button_m");
    buttons[16] = GameObject.FindGameObjectWithTag("Button_q");
    buttons[20] = GameObject.FindGameObjectWithTag("Button_u");
    buttons[24] = GameObject.FindGameObjectWithTag("Button_y");
  }

  private void init_letters()
  {
    letters[0] = GameObject.Find("letter_a");
    letters[1] = GameObject.Find("letter_b");
    letters[2] = GameObject.Find("letter_c");
    letters[3] = GameObject.Find("letter_d");
    letters[4] = GameObject.Find("letter_e");
    letters[5] = GameObject.Find("letter_f");
    letters[6] = GameObject.Find("letter_g");
    letters[7] = GameObject.Find("letter_h");
    letters[8] = GameObject.Find("letter_i");
    letters[9] = GameObject.Find("letter_j");
    letters[10] = GameObject.Find("letter_k");
    letters[11] = GameObject.Find("letter_l");
    letters[12] = GameObject.Find("letter_m");
    letters[13] = GameObject.Find("letter_n");
    letters[14] = GameObject.Find("letter_o");
    letters[15] = GameObject.Find("letter_p");
    letters[16] = GameObject.Find("letter_q");
    letters[17] = GameObject.Find("letter_r");
    letters[18] = GameObject.Find("letter_s");
    letters[19] = GameObject.Find("letter_t");
    letters[20] = GameObject.Find("letter_u");
    letters[21] = GameObject.Find("letter_v");
    letters[22] = GameObject.Find("letter_w");
    letters[23] = GameObject.Find("letter_x");
    letters[24] = GameObject.Find("letter_y");
    letters[25] = GameObject.Find("letter_z");
  }

  private void init_swithers()
  {
    switchers[0] = GameObject.FindGameObjectWithTag("Add1");
    switchers[1] = GameObject.FindGameObjectWithTag("Add2");
  }

  override public bool Done()
  {
     foreach(var letter in password)
     {
      if(letter.Item2 == false)
      {
        return false;
      }
     }
     return true;
  }
}