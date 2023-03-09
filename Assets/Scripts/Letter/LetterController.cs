using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LetterController : IsEnd
{
  private LetterView view;

  private GameObject[] switchers = new GameObject[2];
  private GameObject[] buttons = new GameObject[26];
  private GameObject[] letters = new GameObject[26];
  private GameObject[] password_letters = new GameObject[6];
  private int current_letter = 0;
  private int offset = 97;

  class Element
  {
    public int value;
    public Element next;
  }
  private Element head;
  private Element current;

  void Start()
  {
    view = GameObject.FindObjectOfType<LetterView>();

    init_password_letters();
    init_password_array();
    init_buttons();
    init_letters();
    init_swithers();
  }

  void Update()
  {
    int add = check_switchers();
    for(int i=0; i<26; i=i+1)
    {
      view.ChangeSpriteColor(letters[i], view.white);
    }
    for(int i=0; i<26; i=i+4)
    {
      if(buttons[i].GetComponent<ButtonModel>().isOn && (i+add < 26))
      {
        if(i+add == current.value)
        {
          view.ChangeSpriteColor(password_letters[current_letter], view.black);
          current_letter = current_letter + 1;
          current = current.next;
        }
        view.ChangeSpriteColor(letters[i+add], view.yellow);
      }
    }
  }

  private int check_switchers()
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
    return add;
  }

  private void init_password_letters()
  {
    password_letters[0] = GameObject.Find("S");
    password_letters[1] = GameObject.Find("C");
    password_letters[2] = GameObject.Find("R");
    password_letters[3] = GameObject.Find("E");
    password_letters[4] = GameObject.Find("A");
    password_letters[5] = GameObject.Find("M");
  }

  private void init_password_array()
  {
    head = new Element();
    current = head;

    Element element = head;
    element.value = (int)('s') - offset;
    element.next = new Element();
    element = element.next;

    element.value = (int)('c') - offset;
    element.next = new Element();
    element = element.next;

    element.value = (int)('r') - offset;
    element.next = new Element();
    element = element.next;

    element.value = (int)('e') - offset;
    element.next = new Element();
    element = element.next;

    element.value = (int)('a') - offset;
    element.next = new Element();
    element = element.next;

    element.value = (int)('m') - offset;
    element.next = new Element();
    element = element.next;

    element.value = -1; //end
    element.next = null;
  }

  private void init_buttons()
  {
    string Button_ = "Button_";
    for(int i=0; i<25; i=i+4)
    {
      buttons[i] = GameObject.FindGameObjectWithTag(Button_ + (char)(offset + i));
    }
  }

  private void init_letters()
  {
    string letter_ = "letter_";
    for(int i=0; i<26; i++)
    {
     letters[i] = GameObject.Find(letter_ + (char)(offset + i));
    }
  }

  private void init_swithers()
  {
    switchers[0] = GameObject.FindGameObjectWithTag("Add1");
    switchers[1] = GameObject.FindGameObjectWithTag("Add2");
  }

  override public bool Done()
  {
    if(current.value == -1)
    {
      return true;
    }
    return false;
  }
}