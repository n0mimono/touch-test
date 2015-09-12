using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class TouchManager : MonoBehaviour,
IPointerDownHandler, IPointerUpHandler, IPointerClickHandler,
IBeginDragHandler, IDragHandler, IEndDragHandler {

	public void OnPointerDown (PointerEventData eventData) {
		Debug.Log ("down, id=" + eventData.pointerId + ", pos=" + eventData.position);
	}

	public void OnPointerUp (PointerEventData eventData) {
		Debug.Log ("up, id=" + eventData.pointerId + ", pos=" + eventData.position);
	}

	public void OnPointerClick (PointerEventData eventData) {
		Debug.Log ("click, id=" + eventData.pointerId + ", pos=" + eventData.position);
	}

	public void OnBeginDrag (PointerEventData eventData) {
		Debug.Log ("begin drag, id=" + eventData.pointerId + ", pos=" + eventData.position);
	}

	public void OnDrag (PointerEventData eventData) {
		Debug.Log ("drag, id=" + eventData.pointerId + ", pos=" + eventData.position);
	}

	public void OnEndDrag (PointerEventData eventData) {
		Debug.Log ("end drag, id=" + eventData.pointerId + ", pos=" + eventData.position);
	}

	void Update () {

		foreach (Touch touch in Input.touches) {
			Debug.Log ("touch"
				+ ", id=" + touch.fingerId
				+ ", phase=" + touch.phase
				+ ", pos=" + touch.position
				+ ", delta pos=" + touch.deltaPosition
				+ ", delta time=" + touch.deltaTime
				+ ", tap count=" + touch.tapCount
			);
		}

	}

}
