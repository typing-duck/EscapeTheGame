using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class LetterController : IsDone
{
  private LetterModel model;
  private LetterView view;

  private GameObject[] switchers = new GameObject[2];
  private GameObject[] buttons = new GameObject[26];
  private GameObject[] letters = new GameObject[26];
  private List<GameObject> password_letters = new List<GameObject>();
  private int current_letter = 0;
  private int offset = 65;

  class Element
  {
    public int value;
    public Element next;
  }
  private Element head;
  private Element current;

  void Start()
  {
    model = GameObject.FindObjectOfType<LetterModel>();
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
          view.ChangeSpriteColor(password_letters.ElementAt(current_letter), view.black);
          current_letter = current_letter + 1;
          current = current.next;
          break;
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
    string letter_to_found;
    GameObject letter_found;
    for(int i=0; i<model.password.Length; i++)
    {
     letter_to_found = model.password.Substring(i,1);
     letter_found = GameObject.Find(letter_to_found);
     password_letters.Add(letter_found);
    }
  }

  private void init_password_array()
  {
    head = new Element();
    current = head;

    Element element = head;

    char letter;
    for(int i=0; i<model.password.Length; i++)
    {
      letter = model.password[i];
      element.value = (int)(letter) - offset;
      element.next = new Element();
      element = element.next;
    }
    element.value = -1; //end
    element.next = null;
  }

  private void init_buttons()
  {
    for(int i=0; i<25; i=i+4)
    {
      buttons[i] = GameObject.FindGameObjectWithTag("Button_" + (char)(offset + i));
    }
  }

  private void init_letters()
  {
    for(int i=0; i<26; i++)
    {
     letters[i] = GameObject.Find("letter_" + (char)(offset + i));
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