using System;
using System.Reflection;
using System.Windows.Forms;
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

        }

        private void btn_plugIn_Click(object sender, EventArgs e)
        {
            doProcessEvents(FiniteStateMachine.Events.PlugIn);

        }

        private void btn_switchOn_Click(object sender, EventArgs e)
        {
            if (lbl_myState.Text == "Unplugged")
            {
                doProcessEvents(FiniteStateMachine.Events.SwOn);
            }
            else
            {
                doProcessEvents(FiniteStateMachine.Events.TurnOn);
            }
            //

            
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
            fsm.ProcessEvent(myEvents);

            string myState = fsm.State.ToString();
            lbl_myState.Text = myState;
            ShowPictureOfState(myState);
            GC.Collect();
        }





        private void ShowPictureOfState(string myState)
        {
            switch (myState)
            {
                case "Unplugged":
                    picbx_state.Image = Resources.off_unplugged;
                    break;
                case "On":
                    picbx_state.Image = Resources.on_plugged;
                    break;
                case "Standby":
                    picbx_state.Image = Resources.off_plugged;
                    break;
                case "SwitchOn":
                    picbx_state.Image = Resources.on_unplugged;
                    break;
                default:
                    break;
            }
        }

    }
}
