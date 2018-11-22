using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointManager : MonoBehaviour {

	public string PointName;
	public Vector3 PointPosition;
	public Point point;

	void Start()
	{
		point = new Point(PointName,PointPosition);
	}	

	public void DrawPoint()
	{
		point = new Point(PointName,PointPosition);
		this.transform.localPosition = PointPosition;
		this.transform.name = PointName;
	}
}
