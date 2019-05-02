using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frani_Voxel_Map_Editor {
    public static class VarHandler {
        public static List<float> StringToFloatList(string s, char delimiter) {
            List<float> list = new List<float>();

            foreach (var floatString in s.Split(delimiter)) {
                if (floatString != "") {
                    list.Add(float.Parse(floatString));
                }
            }

            return list;
        }
    }

    public static class FileHandler {
        public static string Read(string fileName) {
            if (!System.IO.File.Exists(fileName)) {
                return "";
            }

            return System.IO.File.ReadAllText(fileName);
        }

        public static void Write(string fileName, string text) {
            System.IO.File.WriteAllText(fileName, text);
        }

        public static void WriteFloatList(string fileName, List<float> content, string delimiter) {
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(fileName)) {
                foreach (float value in content) {
                    file.Write(value.ToString() + delimiter);
                }
            }
        }

        public static int FilesInDirectory(string directory) {
            System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(directory);
            return dir.GetFiles().Length;
        }
    }
}
