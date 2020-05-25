using UnityEngine;

#if UNITY_EDITOR
using UnityEditor;
#endif

namespace FrameworkPractise
{
    public class GenerateUnityPackage
    {
#if UNITY_EDITOR
        [MenuItem("Framework/生成Unity Package %e")]
#endif
        private static void GeneratePackage()
        {
            string assetPath = "Assets/Framework";
            string packagePath = System.IO.Path.Combine(Application.dataPath, "../");
            string packageName = "/Framework_" + System.DateTime.Now.ToString("yyyyMMdd_HHmm") + ".unitypackage";

            AssetDatabase.ExportPackage(assetPath, packagePath + packageName, ExportPackageOptions.Recurse);
            EditorApplication.ExecuteMenuItem("Framework/打开项目文件夹");
        }

#if UNITY_EDITOR
        [MenuItem("Framework/打开项目文件夹")]
#endif
        private static void OpenApplicationDataPath()
        {
            Application.OpenURL("file:///" + System.IO.Path.Combine(Application.dataPath, "../"));
        }
    }
}
