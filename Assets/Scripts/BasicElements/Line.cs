using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Line {
	private string name;
	public string Name
	{
		get
		{
			return name;
		}
	}

	private Point startPoint;
	public Point StartPoint
	{
		get
		{
			return startPoint;
		}
	}

	private Point endPoint;
	public Point EndPoint
	{
		get
		{
			return endPoint;
		}
	}

	public Line(){}
	public Line(Point _startPoint,Point _endPoint)
	{
		startPoint = new Point();
		endPoint = new Point();
		startPoint = _startPoint;
		endPoint = _endPoint;
		name = _startPoint.Name + _endPoint.Name;
	}

	public float GetLength()
	{
		Vector3 start = StartPoint.Position;
		Vector3 end = EndPoint.Position;
		return (end-start).magnitude;
	}

	public Vector3 GetRotate()
	{
		Vector3 start = StartPoint.Position;
		Vector3 end = EndPoint.Position;
		Vector2 start_point_XZ = new Vector2(start.x,start.z);
		Vector2 end_point_XZ = new Vector2(end.x,end.z);

		return new Vector3(0.0f,GetRotateHelperXZ(start_point_XZ,end_point_XZ),GetRotateHelperXY(end-start));
	}

	private float GetRotateHelperXZ(Vector2 po1,Vector2 po2)
	{
		if(po1.x == po2.x)
		{
			return 90.0f;
		}
		else
		{
			Vector2 tmp = new Vector2(1.0f,0.0f);
			Vector2 VectorTmp = po2 - po1;
			float mul = Vector2.Dot(tmp,VectorTmp);
			float angle = Mathf.Acos(mul/VectorTmp.magnitude)*180.0f/Mathf.PI;

			if(po2.y < po1.y)
			{
				return angle;
			}
			else
			{
				return -1.0f*angle;
			}
		}
	}
	private float GetRotateHelperXY(Vector3 po1)
	{
		if(po1.x == 0.0f && po1.z == 0.0f)
		{
			return 90.0f;
		}
		Vector3 tmp = new Vector3(po1.x,0.0f,po1.z);
		float mul = Vector3.Dot(tmp,po1);
		float angle = Mathf.Acos(mul/po1.magnitude/tmp.magnitude)*180.0f/Mathf.PI;
		if(po1.y > 0.0f)
		{
			return angle;
		}
		else
		{
			if(po1.x > 0.0f)
			{
				return -1.0f*angle;
			}
			if(po1.z > 0.0f)
			{
				return angle;
			}
			return -1.0f*angle;
		}		
	}
}
