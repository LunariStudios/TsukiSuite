# <img src="https://github.com/LunariStudios/TsukiSuite/blob/master/Tsuki-Assets/128w/TsukiLogo_Black_128px.png?raw=true"/> TsukiSuite
<p>
    <img src="https://img.shields.io/github/license/LAJE-Studio/UnityUtilities.svg">
    <img src="https://img.shields.io/github/last-commit/LAJE-Studio/UnityUtilities.svg">
</p>

TsukiSuit is an open source, free for commercial use group of libraries created for making Unity Development more pleasant.    

Each library can be compared as a version of Google's [Guava](https://github.com/google/guava), but created for Unity  

Currently, only two of those exists, but more will be added as the need for them surface
* Tsuki Runtime _(Core libraries, available everywhere)_  
and
* Tsuki Editor _(Editor specific libraries, available only on the Editor)_
## Features and examples
* Collection extensions
```csharp
List<int> list = new List<int>();
if (list.IsEmpty()) {
    Debug.Log("Is empty!");
}
```
```csharp
public struct Data {
    public string Name;
    public int Priority;
}

List<Data> data = PopulateListWithRandomData();
Data withHighestPriority = data.MaxBy(d => d.Priority)
```
* Color Utility and HSV Color class
```csharp
Color color = ColorUtility.RandomColor();
Color newColor = color.SetHue(Mathf.Sin(Time.time));
```
```csharp
Color a = new Color(1, 0, 1, 1);
ColorHSV b = a;
ColorHSV colorHSV = new ColorHSV(0, 1, 1, 1);
Color c = colorHSV;
```
* Loads of extensions methods (Rect, Color, Vector, UI, Collections)
```csharp
var skin = EditorGUIUtility.GetBuiltinSkin(EditorSkin.Inspector);
// Bonus: A list of hidden UnityEditor GUIStyles!
var style = skin.GetStyle(GUISkinProperties.CNEntryInfo);
var labelRect = position.GetLine(2); 
EditorGUI.LabelField(labelRect, "I am on the third with the console info style!", style);
```
```csharp
// No need to declare a copy of Graphic.color
Text.SetAlpha(Mathf.Sin(Time.time));
Text.SetHue(Mathf.Cos(Time.time));
```
* And many more!
## Planned features
* Code Generation tool using T4 templates.
* Best practices knowledge base.