using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRoverApp
{
    public class Rover
    {
        private DirectionBase DirectionState;

        public Rover(Coordinate coordinates, string direction)
        {
            switch (direction)
            {
                case DirectionConst.North:
                    this.DirectionState = new NorthDirection(coordinates);
                    break;
                case DirectionConst.South:
                    this.DirectionState = new SouthDirection(coordinates);
                    break;
                case DirectionConst.East:
                    this.DirectionState = new EastDirection(coordinates);
                    break;
                case DirectionConst.West:
                    this.DirectionState = new WestDirection(coordinates);
                    break;
                default:
                    this.DirectionState = new EastDirection(coordinates);
                    break;
            }
        }

        public bool MoveForward(PlateauCoordinates plateauCoordinates)
        {
           return  this.DirectionState.MoveForward(plateauCoordinates);
        }

        public void TurnLeft()
        {
            this.DirectionState = this.DirectionState.TurnLeft();
        }

        public void TurnRight()
        {
            this.DirectionState = this.DirectionState.TurnRight();
        }

        public string GetLocation()
        {
            return this.DirectionState.Coordinates.X + " " + this.DirectionState.Coordinates.Y + " " + this.DirectionState.GetDirection();
        }

        public Coordinate GetCoordinates()
        {
            return this.DirectionState.Coordinates;
        }
    }
}
