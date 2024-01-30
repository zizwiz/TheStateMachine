using System;

namespace TheStateMachine
{
    class FiniteStateMachine
    {
        public enum States { Unplugged, Standby, On, SwitchOn };
        public States State { get; set; }

        public enum Events { PlugIn, TurnOn, TurnOff, Unplug, SwOn }; 

        private Action[,] fsm;

        public FiniteStateMachine()
        {
            fsm = new Action[4, 5] { 
                //PlugIn,       TurnOn,       TurnOff,       Unplug       SwOn
                {PowerOn,       DoNothing,    DoNothing,     DoNothing,   SwitchOn},      //Unplugged
                {DoNothing,     TurnOff,      DoNothing,     PowerOff,    DoNothing},     //standby
                {DoNothing,     DoNothing,    TurnOn,        PowerOff,    DoNothing},     // on
                {TurnOff,       DoNothing,    PowerOff,      DoNothing,   DoNothing}};    //SwitchOn
        }
        public void ProcessEvent(Events theEvent)
        {
            fsm[(int)State, (int)theEvent].Invoke();
        }

        private void PowerOn() { State = States.Standby; }
        private void PowerOff() { State = States.Unplugged; }
        private void TurnOn() { State = States.Standby; }
        private void TurnOff() { State = States.On; }
        private void SwitchOn() { State = States.SwitchOn; }
        private void DoNothing() { return; }
    }
}
