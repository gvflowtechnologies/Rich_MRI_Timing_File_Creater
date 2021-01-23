using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rich_MRI_Timing_File_Creater
{
    enum SessionState
    {
        Subject_Data_Entry,
        Session_Data,
        Wait_ForNext_Session

    }

    public partial class FM_MRI_TIming_File_Main : Form
    {
        SessionState CurrentSessionState;
        public FM_MRI_TIming_File_Main()
        {
            InitializeComponent();
            
        }

        private void FM_MRI_TIming_File_Main_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            this.KeyPress+= Key_Keydown;
            CurrentSessionState = SessionState.Subject_Data_Entry;
        }

        void Key_Keydown(object sender, System.Windows.Forms.KeyPressEventArgs  e)
        {
            /* if(CurrentSessionState != SessionState.Session_Data)
             {
                 return;
             }*/
            textBox2.Text += e.KeyChar;
            textBox2.Text += Environment.NewLine;

        }

        private void BTN_Start_Data_Collection_Click(object sender, EventArgs e)
        {
            // S
            CurrentSessionState = SessionState.Subject_Data_Entry;

        }

        private void BTN_Stop_Data_Collection_Click(object sender, EventArgs e)
        {
            CurrentSessionState = SessionState.Wait_ForNext_Session;
        }

        private void BTN_Cancel_Test_Click(object sender, EventArgs e)
        {
            CurrentSessionState = SessionState.Wait_ForNext_Session;
        }
    }
}
