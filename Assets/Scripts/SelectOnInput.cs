using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SelectOnInput : MonoBehaviour
{
  public EventSystem eventSystem;
  public GameObject selectedObject;

  private bool isSelected;

  void Update() {
    if (Input.GetAxisRaw("Vertical") != 0 && !isSelected) {
      eventSystem.SetSelectedGameObject(selectedObject);
      isSelected = true;
    }
  }

  private void OnDisable() {
    isSelected = false;
  }
}
