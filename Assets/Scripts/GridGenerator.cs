using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GridGenerator : MonoBehaviour
{
  [SerializeField] private GameObject cell;
  [SerializeField] private Letter letter;
  private GameObject _cellOne;
  [SerializeField] private List<GameObject> myList;
  [SerializeField] private string currentLetter;

  private void Start()
  {
    for (var i = 0; i < 100; i++)
  {
    var myCell = Instantiate(cell, this.transform, true);
    myCell.transform.localScale = Vector3.one;
    myList.Add(myCell);
  }
    InvokeRepeating(nameof(ShowLetter), 1,1 );
    
  }

  private void ShowLetter()
  {
    
    myList[2].GetComponent<Image>().sprite = letter.letters[1];
  }
}
