using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

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
    StartCoroutine(coroutineShowLetter());
  }
 
  private IEnumerator coroutineShowLetter()
  {
    var currentCell = Random.Range(0, 100);
    myList[currentCell].GetComponent<Image>().sprite = letter.letters[Random.Range(0,26)];
    yield return new WaitForSeconds(3f);
    myList[currentCell].GetComponent<Image>().sprite = letter.letters[26];
    yield return new WaitForSeconds(0.3f);
    StartCoroutine(coroutineShowLetter());
  }
 
}
