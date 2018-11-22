using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point {
	private string name;
	public string Name
	{
		get
		{
			return name;
		}
	}

	private Vector3 position;
	public Vector3 Position
	{
		get
		{
			return position;
		}
	}

	public Point(){}
	public Point(string _name,Vector3 _positon)
	{
		name = _name;
		position = _positon;
	}
}
