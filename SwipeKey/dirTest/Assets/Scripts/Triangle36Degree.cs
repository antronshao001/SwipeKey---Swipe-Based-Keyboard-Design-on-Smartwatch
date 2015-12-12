using UnityEngine;
using System.Collections;

public class Triangle36Degree 
{
	public bool checkSwipe(float xdir, float ydir, float slope, int currRed)
	{
		Debug.Log ("36 degree");
		float height35 = Mathf.Tan (Mathf.Deg2Rad * 35 );
		float height70 = Mathf.Tan (Mathf.Deg2Rad * 70 );

		
		if (ydir > 0) { // Upper part
			if( (slope < 0) && (slope > -1.0f * height35) ) // Upper Left
			{
				if(currRed == 5)
					return true;
				
				Debug.Log ("Upper Left");
			}
			else if( (slope < -1.0f * height35) && (slope > -1.0 * height70)) // Upper upper Left
			{
				if(currRed == 4)
					return true;
				
				Debug.Log ("Upper upper Left");
			}
			else if( (slope > 0) && (slope < height35) ) // Upper Right
			{
				if(currRed == 11)
					return true;
				
				Debug.Log ("Upper Right");
			}
			else if( (slope > height35) && (slope < height70) ) // Upper upper Right
			{
				if(currRed == 2)
					return true;
				
				Debug.Log ("Upper upper Right");
			}
			else
			{
				if(currRed == 3)
					return true;
				
				Debug.Log ("Up");
			}
			
			
		} else { // Lower part
			if( (slope < 0) && (slope > -1.0f * height35) ) // Lower Right
			{
				if(currRed == 10)
					return true;
				
				Debug.Log ("Lower Right");
			}
			else if( (slope < -1.0f * height35) && (slope > -1.0 * height70)) // Lower Lower Right
			{
				if(currRed == 9)
					return true;
				
				Debug.Log ("Lower Lower Right");
			}
			else if( (slope > 0) && (slope < height35) ) // Lower Left
			{
				if(currRed == 6)
					return true;
				
				Debug.Log ("Lower Left");
			}
			else if( (slope > height35) && (slope < height70) ) // Lower Lower Left
			{
				if(currRed == 7)
					return true;
				
				Debug.Log ("Lower Lower Left");
			}
			else
			{
				if(currRed == 8)
					return true;
				
			}
		}
		return false;
	}
}