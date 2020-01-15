
bool circle(float x, float y, float centerX, float centerY, float radius)
{
	return (pow(x - centerX, 2) + pow(y - centerY, 2) <= radius * radius);
}

float distFromCenter(float x, float y)
{
	return ( sqrt( pow(x-0.5,2) + pow(y-0.5,2) ))*2;
}

float x;
float y;

void CustomDither_float(float2 UV, float minRadius, float maxRadius, float frequency, float2 center, out float Out)
{
	x = UV.x;
	y = UV.y;
	 
	for (int i = 0; i <= frequency; i++)
	{
		for (int j = 0; j <= frequency; j++)
		{
			float ii = i / frequency;
			float jj = j / frequency;
			float dist = clamp( distFromCenter(ii, jj) , 0, 1);
			Out += circle(x, y, ii+center.x/100, jj+center.y/100, lerp(maxRadius /100, minRadius /100, dist ));
		}
	}
}



