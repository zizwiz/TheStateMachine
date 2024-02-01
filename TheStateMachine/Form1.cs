using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using CenteredMessagebox;
using TheStateMachine.Properties;

namespace TheStateMachine
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        FiniteStateMachine fsm = new FiniteStateMachine();

        private void Form1_Load(object sender, EventArgs e)
        {
            Text += " : v" + Assembly.GetExecutingAssembly().GetName().Version; // put in the version number

            doProcessEvents(FiniteStateMachine.Events.Unplug);

            webbrwser_explain.Navigate(new Uri(String.Format("file:///{0}", Path.GetFullPath("explanation.mht"))));
        }

        private void btn_plugIn_Click(object sender, EventArgs e)
        {
            doProcessEvents(FiniteStateMachine.Events.PlugIn);
        }

        private void btn_switchOn_Click(object sender, EventArgs e)
        {
            if (lbl_myState.Text == "Unplugged")
            {
                //If not plugged on all we do is put the electric switch on
                doProcessEvents(FiniteStateMachine.Events.SwOn);
            }
            else
            {
                //If plugged in we can switch on
                doProcessEvents(FiniteStateMachine.Events.TurnOn);
            }
        }

        private void btn_switchOff_Click(object sender, EventArgs e)
        {
            doProcessEvents(FiniteStateMachine.Events.TurnOff);
        }


        private void btn_unplug_Click(object sender, EventArgs e)
        {
            doProcessEvents(FiniteStateMachine.Events.Unplug);
        }


        private void doProcessEvents(FiniteStateMachine.Events myEvents)
        {
            fsm.ProcessEvent(myEvents); // Send event to state machine

            string myState = fsm.State.ToString(); //Get the new state even is the same
            lbl_myState.Text = myState; // Change the label to show present state
            picbx_state.Image = (Image)Resources.ResourceManager.GetObject(myState); //change the image

            GC.Collect();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_about_Click(object sender, EventArgs e)
        {
            MsgBox.Show("Build with Jetbrains Rider\rhttps://www.jetbrains.com/rider/", "About", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void webbrwser_explain_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            // webbrwser_explain.Size = new Size(webbrwser_explain.Document.Body.ScrollRectangle.Width, 659);

            if (IsHorizontalScrollbarPresent)
            {
                // webbrwser_explain.Size = new Size(webbrwser_explain.Document.Body.ScrollRectangle.Width, webbrwser_explain.Document.Body.ScrollRectangle.Height);
                //ActiveForm.Size = new Size(webbrwser_explain.Document.Body.ScrollRectangle.Width, webbrwser_explain.Document.Body.ScrollRectangle.Height);
            }
        }

        public bool IsHorizontalScrollbarPresent
        {
            get
            {
                var widthofScrollableArea = webbrwser_explain.Document.Body.ScrollRectangle.Width;
                var widthofControl = webbrwser_explain.Document.Window.Size.Width;

               return widthofScrollableArea > widthofControl;
            }
        }
    }
}
