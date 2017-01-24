using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiscordBot2
{
    public class TextBoxStreamWriter : TextWriter
    {
        TextBox _output = null;

        public TextBoxStreamWriter(TextBox output)
        {
            _output = output;
        }

        [DebuggerStepThrough]
        public override void Write(char value)
        {
            base.Write(value);
            if (_output.InvokeRequired)
            {
                _output.Invoke((MethodInvoker)delegate { _output.AppendText(value.ToString()); });
            }
            else
            {
                _output.AppendText(value.ToString());
            }
        }

        public override Encoding Encoding
        {
            get { return System.Text.Encoding.UTF8; }
        }
    }
}
