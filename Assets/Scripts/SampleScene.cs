using UnityEditor;
using UnityEngine;

namespace com.konsnos.SimpleTabSystem
{
    public class SampleScene : MonoBehaviour
    {
        public void TabChanged(int tabIndex)
        {
            Debug.Log("Tab changed to " + tabIndex);
        }
        
        [MenuItem("konsnos Tools/Clear PlayerPrefs")]
        private static void ClearAllPlayerPrefs()
        {
            PlayerPrefs.DeleteAll();
            PlayerPrefs.Save();
            Debug.Log("PlayerPrefs cleared.");
        }
    }
}
