using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandPattern.ConcreteCommand;
using CommandPattern.Invoker;
using CommandPattern.Receiver;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //Existing stuff in the house
            Light bedRoomLights = new Light();
            AirConditioner acForEntireHouse = new AirConditioner();

            //Create the ON commands
            LightOn turnBedRoomLightsOn = new LightOn(bedRoomLights);
            AirConditionerOn turnOnAc = new AirConditionerOn(acForEntireHouse);

            //Create the OFF commands
            LightOff turnBedRoomLightOff = new LightOff(bedRoomLights);
            AirConditionerOff turnOffAc = new AirConditionerOff(acForEntireHouse);

            //Add the ON to the remote
            RemoteController remote = new RemoteController();
            remote.InsertNewOnCommand(turnBedRoomLightsOn);
            remote.InsertNewOnCommand(turnOnAc);

            //Add the OFF to the remote
            remote.InsertNewOffCommand(turnBedRoomLightOff);
            remote.InsertNewOffCommand(turnOffAc);

            //Turn on the lights and AC
            remote.PressButtonOn(0);
            remote.PressButtonOn(1);

            //Turn off the lights and AC
            remote.PressButtonOff(0);
            remote.PressButtonOff(1);

        }
    }
}
