using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;

namespace Vsite.CSharp.Testovi
{
    [TestClass]
    public abstract class ConsoleTest
    {
        protected class ConsoleTestWriter : StringWriter
        {
            public override void WriteLine(string text)
            {
                output.Enqueue(text);
            }

            public string Get()
            {
                if (output.Count > 0)
                    return output.Dequeue();
                return string.Empty;
            }

            Queue<string> output = new Queue<string>();
        }

        protected ConsoleTestWriter cw = null;

        [TestInitialize()]
        public virtual void Initialize()
        {
            cw = new ConsoleTestWriter();
            Console.SetOut(cw);
        }

        [TestCleanup()]
        public virtual void Cleanup()
        {
            cw.Dispose();
        }
    }
}
