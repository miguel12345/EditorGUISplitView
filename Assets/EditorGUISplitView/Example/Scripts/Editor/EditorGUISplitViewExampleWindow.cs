using UnityEngine;
using System.Collections;
using UnityEditor;

public class EditorGUISplitViewExampleWindow : EditorWindow {


	EditorGUISplitView horizontalSplitView = new EditorGUISplitView (EditorGUISplitView.Direction.Horizontal);
	EditorGUISplitView verticalSplitView = new EditorGUISplitView (EditorGUISplitView.Direction.Vertical);

	[MenuItem ("Editor GUISpitView/Show Example Window")]
	static void Init ()
	{
		EditorGUISplitViewExampleWindow window = (EditorGUISplitViewExampleWindow)GetWindow (typeof(EditorGUISplitViewExampleWindow));
		window.Show ();
	}

	public void OnGUI ()
	{
		horizontalSplitView.BeginSplitView ();
		DrawView1 ();
		horizontalSplitView.Split ();
		verticalSplitView.BeginSplitView ();
		DrawView2 ();
		verticalSplitView.Split ();
		DrawView2 ();
		verticalSplitView.EndSplitView ();
		horizontalSplitView.EndSplitView ();
		Repaint();
	}


	void DrawView1() {
		EditorGUILayout.LabelField ("A label");
		GUILayout.Button ("A Button");
		EditorGUILayout.Foldout (false, "A Foldout");
	}

	void DrawView2() {
		GUILayout.BeginHorizontal ();
		GUILayout.FlexibleSpace ();
		GUILayout.BeginVertical ();
		GUILayout.FlexibleSpace ();
		GUILayout.Label ("Centered text");
		GUILayout.FlexibleSpace ();
		GUILayout.EndVertical ();
		GUILayout.FlexibleSpace ();
		GUILayout.EndHorizontal ();
	}
}
