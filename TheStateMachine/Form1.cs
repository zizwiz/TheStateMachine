using System;
using System.Reflection;
using System.Windows.Forms;

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

           fsm.ProcessEvent(FiniteStateMachine.Events.Unplug);
           lbl_myState.Text = fsm.State.ToString();
        }

        private void btn_plugIn_Click(object sender, EventArgs e)
        {
            fsm.ProcessEvent(FiniteStateMachine.Events.PlugIn);
            lbl_myState.Text = fsm.State.ToString();

        }

        private void btn_switchOn_Click(object sender, EventArgs e)
        {
            fsm.ProcessEvent(FiniteStateMachine.Events.TurnOn);
            lbl_myState.Text = fsm.State.ToString();

        }

        private void btn_switchOff_Click(object sender, EventArgs e)
        {
           fsm.ProcessEvent(FiniteStateMachine.Events.TurnOff);
            lbl_myState.Text = fsm.State.ToString();
        }

        private void btn_unplug_Click(object sender, EventArgs e)
        {
            fsm.ProcessEvent(FiniteStateMachine.Events.Unplug);
            lbl_myState.Text = fsm.State.ToString();
        }

    }
}
