using UnityEngine;
using System.Collections;

public class Obstacle : MonoBehaviour {
  private ZeroLayer zeroLayer;

  void Start() {
    zeroLayer = FindObjectOfType<ZeroLayer>();
  }

  void OnMouseOver() {
    if (Input.GetMouseButton(0))
      zeroLayer.otherCube = gameObject;
  }
}