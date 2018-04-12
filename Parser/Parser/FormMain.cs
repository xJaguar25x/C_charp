using Parser.Core;
using Parser.Core.Avito;
using System;
using System.Windows.Forms;

namespace Parser
{
    public partial class FormMain : Form
    {
        ParserWorker<string[]> parser;

        public FormMain()
        {
            InitializeComponent();

            parser = new ParserWorker<string[]>(
                    new AvitoParser()
                );

            parser.OnCompleted += Parser_OnCompleted;
            parser.OnNewData += Parser_OnNewData;
        }

        private void Parser_OnNewData(object arg1, string[] arg2)
        {
            ListTitles.Items.AddRange(arg2);
        }

        private void Parser_OnCompleted(object obj)
        {
            MessageBox.Show("All works done!");
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            // parser.Settings = new AvitoSettings((int)NumericStart.Value, (int)NumericEnd.Value);
            parser.Settings = new AvitoSettings( Text_Marka.Text, Text_Model.Text, (int)NumericStart.Value, (int)NumericEnd.Value);
            parser.Start();
        }

        private void ButtonAbort_Click(object sender, EventArgs e)
        {
            parser.Abort();
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            ListTitles.Items.Clear();
        }
    }
}
