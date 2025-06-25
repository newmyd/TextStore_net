using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextStore
{
    using System.IO;
    using System.Net;
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private string ajax(string url)
        {
            HttpWebRequest requset = WebRequest.Create(url) as HttpWebRequest;//请求

            requset.Method = "POST";//设置请求方式

            HttpWebResponse response = requset.GetResponse() as HttpWebResponse;//通过请求获取响应

            //--------------处理响应消息
            Stream stream = response.GetResponseStream();

            StreamReader read = new StreamReader(stream, Encoding.UTF8);

            string res = read.ReadToEnd();

            return res;
        }
        private int send(string txt, string pswd)
        {
            for (int i = 0; i < txt.Length; ++i)
            {
                if (txt[i] == '&')
                {
                    txt = txt.Remove(i, 1);
                    txt = txt.Insert(i, "%26");
                    i += 2;
                }
                else if (txt[i] == '+')
                {
                    txt = txt.Remove(i, 1);
                    txt = txt.Insert(i, "%2B");
                    i += 2;
                }
                else if (txt[i] == '#')
                {
                    txt = txt.Remove(i, 1);
                    txt = txt.Insert(i, "%23");
                    i += 2;
                }
                else if (txt[i] == '[')
                {
                    txt = txt.Remove(i, 1);
                    txt = txt.Insert(i, "%5B");
                    i += 2;
                }
                else if (txt[i] == ']')
                {
                    txt = txt.Remove(i, 1);
                    txt = txt.Insert(i, "%5D");
                    i += 2;
                }
            }

            string url = "http://192.168.19.170:8080/upload?text=" + txt + "&password=" + pswd;

            string res = ajax(url);

            return toInt(res);
        }

        private string get(int fileId, string pswd)
        {
            string url = "http://192.168.19.170:8080/download?fileId=" + fileId + "&password=" + pswd;

            string res = ajax(url);

            return res;
        }

        private int toInt(string s)
        {
            int res = 0;
            if (s.Length < 1 || s.Length > 10)
                return 0;
            for (int i = 0; i < s.Length; ++i)
                if (s[i] < '0' || s[i] > '9') return 0;
                else res = res * 10 + s[i] - '0';
            return res;
        }
        private void upload_Click(object sender, EventArgs e)
        {
            string text = txt.Text;
            string pswd = pswdU.Text;
            if (text == "")
            {
                resU.Text = "Text is empty";
                return ;
            }
            int res = send(text, pswd);
            if (res > 0) resU.Text = "Success. File Id : " + res;
            else resU.Text = "Upload Error.";
            return ;
        }

        private void download_Click(object sender, EventArgs e)
        {
            string file = fileId.Text;
            string pswd = pswdD.Text;
            int fId = toInt(file);
            if (fId < 1)
            {
                resD.Text = "Text Id is wrong.";
                return ;
            }
            string res = get(fId, pswd);
            if (res == "") res = "Download Error.";
            resD.Text = res;
            return ;
        }
    }
}
