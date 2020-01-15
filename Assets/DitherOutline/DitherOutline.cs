using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DitherOutline : MonoBehaviour
{
	private new SpriteRenderer renderer;

	public void CreateOutline()
	{
		renderer = GetComponent<SpriteRenderer>();

		GameObject outline = Instantiate(gameObject, transform);

		DestroyImmediate(outline.GetComponent<DitherOutline>());
		outline.name = "Outline";

		outline.transform.localScale = Vector3.one;
		outline.transform.localRotation = Quaternion.identity;
		outline.transform.localPosition = Vector3.zero;

		SpriteRenderer outlineRender = outline.GetComponent<SpriteRenderer>();

		outlineRender.sortingOrder = renderer.sortingOrder - 1;
		Material mat = new Material(Shader.Find("Shader Graphs/DitherOutline"));
		outlineRender.material = mat;

	}

}
