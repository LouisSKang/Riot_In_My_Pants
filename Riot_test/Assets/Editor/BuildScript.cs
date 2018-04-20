// C# example
using UnityEditor;

class BuildScript
{
	static void PerformBuild ()
	{
		string[] scenes = { "Assets/MyScene.unity" };
		BuildPipeline.BuildPlayer(scenes, ...);
	}
}