using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineManager : MonoBehaviour {

	public PointManager StartPoint;
	public PointManager EndPoint;

	private Point startPoint;
	private Point endPoint;
	private Line line;

	public void DrawLine()
	{
		StartPoint.DrawPoint();
		EndPoint.DrawPoint();
		line = new Line(StartPoint.point,EndPoint.point);

		this.transform.localPosition = (StartPoint.transform.localPosition+EndPoint.transform.localPosition)/2.0f;

		this.transform.localScale = new Vector3(line.GetLength(),0.1f,0.1f);
		this.transform.localRotation = Quaternion.Euler(line.GetRotate());
		this.transform.name = line.Name;
	}
}