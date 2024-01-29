using System;

namespace TheStateMachine
{
    class FiniteStateMachine
    {
        public enum States { Unplugged, Standby, On };
        public States State { get; set; }

        public enum Events { PlugIn, TurnOn, TurnOff, Unplug };

        private Action[,] fsm;

        public FiniteStateMachine()
        {
            fsm = new Action[3, 4] { 
                //PlugIn,       TurnOn,                 TurnOff,            Unplug
                {PowerOn,       DoNothing,              DoNothing,          DoNothing},    //Unplugged
                {DoNothing,     TurnOff,                DoNothing,          PowerOff},     //standby
                {DoNothing,     DoNothing,              TurnOn,             PowerOff} };   //on
        }
        public void ProcessEvent(Events theEvent)
        {
            fsm[(int)State, (int)theEvent].Invoke();
        }

        private void PowerOn() { State = States.Standby; }
        private void PowerOff() { State = States.Unplugged; }
        private void TurnOn() { State = States.Standby; }
        private void TurnOff() { State = States.On; }
        private void DoNothing() { return; }
    }
}
