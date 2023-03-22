using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RestartNPort5000_5000ASeries
{
    class Program
    {
        static void Main(string[] args)
        {
            // NPort 5000A Series
            // create a new telnet connection to hostname "192.168.3.12" on port "23"
            TelnetConnection tg = new TelnetConnection("192.168.3.12", 23);

            // create a new telnet connection to hostname "192.168.3.19" on port "23"
            TelnetConnection th = new TelnetConnection("192.168.3.19", 23);

            // create a new telnet connection to hostname "192.168.3.26" on port "23"
            TelnetConnection ti = new TelnetConnection("192.168.3.26", 23);

            // create a new telnet connection to hostname "192.168.3.28" on port "23"
            TelnetConnection tj = new TelnetConnection("192.168.3.28", 23);

            // create a new telnet connection to hostname "192.168.3.34" on port "23"
            TelnetConnection tk = new TelnetConnection("192.168.3.34", 23);

            // ----------------------------------------------------------------------
            // NPort 5000 Series
            //create a new telnet connection to hostname "192.168.3.27" on port "23"
            TelnetConnection ta = new TelnetConnection("192.168.3.27", 23);

            //create a new telnet connection to hostname "192.168.3.37" on port "23"
            TelnetConnection tb = new TelnetConnection("192.168.3.37", 23);

            //create a new telnet connection to hostname "192.168.3.13" on port "23"
            TelnetConnection tc = new TelnetConnection("192.168.3.13", 23);

            //create a new telnet connection to hostname "192.168.3.14" on port "23"
            TelnetConnection td = new TelnetConnection("192.168.3.14", 23);

            //create a new telnet connection to hostname "192.168.3.15" on port "23"
            TelnetConnection te = new TelnetConnection("192.168.3.15", 23);

            //create a new telnet connection to hostname "192.168.3.17" on port "23"
            TelnetConnection tf = new TelnetConnection("192.168.3.17", 23);

            // login with password "moxa", using a timeout of 100ms, and show server output
            string  s = ta.LoginNPort01("moxa" + Environment.NewLine, 800);
                    s = tb.LoginNPort01("moxa" + Environment.NewLine, 800);
                    s = tc.LoginNPort01("moxa" + Environment.NewLine, 800);
                    s = td.LoginNPort01("moxa" + Environment.NewLine, 800);
                    s = te.LoginNPort01("moxa" + Environment.NewLine, 800);
                    s = tf.LoginNPort01("moxa" + Environment.NewLine, 800);

            // login with user "admin" and password "moxa", using a timeout of 100ms, and show server output
                    s = tg.LoginNPort02("admin" + Environment.NewLine, "moxa" + Environment.NewLine, 800);
                    s = th.LoginNPort02("admin" + Environment.NewLine, "moxa" + Environment.NewLine, 800);
                    s = ti.LoginNPort02("admin" + Environment.NewLine, "moxa" + Environment.NewLine, 800);
                    s = tj.LoginNPort02("admin" + Environment.NewLine, "moxa" + Environment.NewLine, 800);
                    s = tk.LoginNPort02("admin" + Environment.NewLine, "moxa" + Environment.NewLine, 800);

            Console.Write(s);

            // server output should end with "$" or ">", otherwise the connection failed
            string prompt = s.TrimEnd();
            prompt = s.Substring(prompt.Length - 1, 1);
            if (prompt != "$" && prompt != ">" && prompt != ":")
                throw new Exception("Connection failed");

            prompt = "";

            // ta
            ta.WriteLine("s" + Environment.NewLine);
            Thread.Sleep(500);
            ta.WriteLine("y" + Environment.NewLine);
            // tb
            tb.WriteLine("s" + Environment.NewLine);
            Thread.Sleep(500);
            tb.WriteLine("y" + Environment.NewLine);
            // tc
            tc.WriteLine("s" + Environment.NewLine);
            Thread.Sleep(500);
            tc.WriteLine("y" + Environment.NewLine);
            // td
            td.WriteLine("s" + Environment.NewLine);
            Thread.Sleep(500);
            td.WriteLine("y" + Environment.NewLine);
            // te
            te.WriteLine("s" + Environment.NewLine);
            Thread.Sleep(500);
            te.WriteLine("y" + Environment.NewLine);
            // tf
            tf.WriteLine("s" + Environment.NewLine);
            Thread.Sleep(500);
            tf.WriteLine("y" + Environment.NewLine);
            // tg
            tg.WriteLine("s" + Environment.NewLine);
            Thread.Sleep(500);
            tg.WriteLine("y" + Environment.NewLine);
            // th
            th.WriteLine("s" + Environment.NewLine);
            Thread.Sleep(500);
            th.WriteLine("y" + Environment.NewLine);
            // ti
            ti.WriteLine("s" + Environment.NewLine);
            Thread.Sleep(500);
            ti.WriteLine("y" + Environment.NewLine);
            // tj
            tj.WriteLine("s" + Environment.NewLine);
            Thread.Sleep(500);
            tj.WriteLine("y" + Environment.NewLine);
            // tk
            tk.WriteLine("s" + Environment.NewLine);
            Thread.Sleep(500);
            tk.WriteLine("y" + Environment.NewLine);

            /*
            //// while connected
            //while (tc.IsConnected && prompt.Trim() != "exit")
            //{
            //    // display server output
            //    Console.Write(tc.Read());
            //    // send client input to server
            //    prompt = Console.ReadLine();
            //    //tc.WriteLine(prompt);
            //    // display server output
            //    Console.Write(tc.Read());
            //}
            //Console.WriteLine("***DISCONNECTED");
            //Console.ReadLine();
            */
        }
    }
}
