using System;

namespace TheStateMachine
{
    class FiniteStateMachine
    { 
        /// <summary>
        /// Declare any variables
        /// </summary>
        public States State { get; set; } //returns the resultant state
        private Action[,] fsm; //declare the 2 dimensional array that will house the finite state machine (fsm)

        /// <summary>
        /// Define the enum of states and events
        /// </summary>
        public enum States { Unplugged, Standby, On, SwitchOn };
        public enum Events { PlugIn, TurnOn, TurnOff, Unplug, SwOn }; 
        
        /// <summary>
        /// Write the Finite State Machine table as 2 dimensional array
        /// </summary>
        public FiniteStateMachine()
        {
            fsm = new Action[4, 5] { 
              //PluggedIn,      On,           Off,           Unplugged    SwOn when unplugged
                {PowerOn,       DoNothing,    DoNothing,     DoNothing,       SwitchOn},      //Unplugged
                {DoNothing,     TurnOn,       DoNothing,     PowerOff,        DoNothing},     //standby
                {DoNothing,     DoNothing,    TurnOff,       PowerOff,        DoNothing},     // on
                {TurnOn,        DoNothing,    PowerOff,      DoNothing,       DoNothing}};    //SwitchOn
        }

        /// <summary>
        /// The worker that will move us to the resultant state
        /// </summary>
        /// <param name="theEvent"></param>
        public void ProcessEvent(Events theEvent)
        {
            fsm[(int)State, (int)theEvent].Invoke();
        }

        /// <summary>
        /// The set of functions that will change the state.
        /// </summary>
        private void PowerOn() { State = States.Standby; }
        private void PowerOff() { State = States.Unplugged; }
        private void TurnOn() { State = States.On; }
        private void TurnOff() { State = States.Standby; }
        private void SwitchOn() { State = States.SwitchOn; }
        private void DoNothing() { return; }
    }
}
