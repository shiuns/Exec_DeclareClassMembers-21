using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _作業_Exec_DeclareClassMembers____21謝孟勳
{
     //將指定文字內容存檔, 由於要存放的文字內容與檔案存放位置都會
     //變化, 所以我們可以將這兩項資訊設計成 method的參數, 由外界
     //傳入
     //請設計一個FileManager class, 內含一個 Save method
     //只需要設定method, 不必實作出功能
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }
    class FileManager
    {
        public string targetFileName { get; set; }
        public string targetPath { get; set; }
        public string content { get; set; }
        public void Save (string targetFileName , string targetPath , string content)
        {

        }
     
    }

}
