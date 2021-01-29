# Unity DOTS Entity selection visualizer

Use this tool to draw position and rotation of your Unity DOTS entities in editor.  

![GIF showing tool in action](https://media.giphy.com/media/d5xB37d5q87RrF9uaU/source.gif)

Currently shows position handle and label for selected entities which have Translation and Rotation component on them.

# How to install?
Go to "Package Manager" and add via git.

![How to add git repository based package](https://docs.unity3d.com/uploads/Main/PackageManagerUI-GitURLPackageButton.png)

Enter `git://github.com/eintopf/Unity-DOTS-Entity-Selection-Visualizer`

# How to use?
Open "DOTS -> Selection Visualizer" in the menu bar. This will open a window which activates the entity selection visualization functionality. Attach it as a tab somewhere.
Select an entity in the entity debugger list. You will see the transform handle popup for the entity in scene view.

Feel free to use it and modify it.

# TODO
Find a nicer way to resolve the Unity selection proxy since Resources.FindObjectsOfType isn't the most elegant solution ;) This was the most straight forward solution, since I don't know exactly when the entity selection proxy (ScriptableObject) is created / destroyed.
