using System;
using System.Collections.Generic;

namespace MidtermExam.Prob02
{
    /// <summary>
    /// ข้อ 02: จำลองประวัติการเปิดเว็บด้วย Stack สองชุด ตามหลัก LIFO
    /// (สมาชิกที่ใส่ล่าสุดถูกนำออกก่อน) นักศึกษาทำเฉพาะเมธอดในคลาสนี้
    /// ส่วนแยกคำสั่งจากข้อความเตรียมไว้แล้วใน BrowserNavigation.cs
    /// </summary>
    public class StudentWebBrowser

    {

        private Stack<string> backStack = new Stack<string>();

        private Stack<string> forwardStack = new Stack<string>();

        private string currentUrl = "";

        public void Open(string url)

        {

            backStack.Push(currentUrl);

            currentUrl = url;

            forwardStack.Clear();

        }

        public void Back()

        {

            if (backStack.Count > 0)

            {

                forwardStack.Push(currentUrl);

                currentUrl = backStack.Pop();

            }

        }

        public void Forward()

        {

            if (forwardStack.Count > 0)

            {

                backStack.Push(currentUrl);

                currentUrl = forwardStack.Pop();

            }

        }

        public string Current()

        {

            return currentUrl;

        }

    }

}
