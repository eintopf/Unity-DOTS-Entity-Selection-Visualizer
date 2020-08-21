#if UNITY_EDITOR
using Unity.Entities;
using Unity.Entities.Editor;
using Unity.Transforms;
using UnityEditor;
using UnityEngine;

public class DOTSSelectionVisualizer : EditorWindow
{
    [MenuItem("DOTS/Selection Visualizer")]
    static void Open()
    {
        DOTSSelectionVisualizer win = GetWindow<DOTSSelectionVisualizer>();
        win.titleContent = new GUIContent("DOTS Selection Visualizer");
        win.Show();
    }
    
    void OnEnable()
    {
        SceneView.duringSceneGui += OnSceneGUI;
    }

    void OnDisable()
    {
        SceneView.duringSceneGui -= OnSceneGUI;
    }

    private void OnSceneGUI(SceneView obj)
    {
        var selection = Resources.FindObjectsOfTypeAll<EntitySelectionProxy>();
        if (selection.Length != 0)
        {
            var entity = selection[0].Entity;
            if (entity == Entity.Null) return;

            var em = selection[0].EntityManager;
            
            if (em.HasComponent<Translation>(entity))
            {
                var rot = Quaternion.identity;
                if(em.HasComponent<Rotation>(entity))
                {
                    rot = em.GetComponentData<Rotation>(entity).Value;
                }
                
                var translation = em.GetComponentData<Translation>(entity);
                Handles.PositionHandle(translation.Value, rot);
                Handles.Label(translation.Value, "Selected Entity");
                HandleUtility.Repaint();
            }
        }
    }

    void OnGUI()
    {
        GUILayout.Label("Select entity in entity debugger (needs to have rotation and translation component)");
    }
}
#endif
