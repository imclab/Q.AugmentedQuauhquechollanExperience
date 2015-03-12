using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;

public class PanelSlide : MonoBehaviour, IPointerDownHandler, IDragHandler {
	
	public Vector2 pointerOffset;
	private RectTransform canvasRectTransform;
	private RectTransform panelRectTransform;
	
	void Awake () {
		Canvas canvas = GetComponentInParent <Canvas>();
		if (canvas != null) {
			canvasRectTransform = canvas.transform as RectTransform;
			panelRectTransform = transform.parent as RectTransform;
		}
	}
	
	public void OnPointerDown (PointerEventData data) {
		panelRectTransform.SetAsLastSibling ();
		RectTransformUtility.ScreenPointToLocalPointInRectangle (panelRectTransform, data.position, data.pressEventCamera, out pointerOffset);
	}
	
	public void OnDrag (PointerEventData data) {
		if (panelRectTransform == null)
			return;
		
		Vector2 localPointerPosition;
		if (RectTransformUtility.ScreenPointToLocalPointInRectangle (
			canvasRectTransform, data.position, data.pressEventCamera, out localPointerPosition
			)) {
			panelRectTransform.localPosition = new Vector2(localPointerPosition.x,localPointerPosition.y - pointerOffset.y);
		}
	}
}