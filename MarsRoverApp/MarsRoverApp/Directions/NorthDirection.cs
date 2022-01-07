﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRoverApp
{
    class NorthDirection : DirectionBase
    {
        public NorthDirection(Coordinate Coordinates) : base(Coordinates) { }

        public override bool MoveForward(PlateauCoordinates plateauCoordinates)
        {
            if (!CheckRoverLimits(plateauCoordinates))
                return false;

            Coordinates.Y = Coordinates.Y + 1;
            return true;
        }

        public override DirectionBase TurnLeft()
        {
            return new WestDirection(Coordinates);
        }

        public override DirectionBase TurnRight()
        {
            return new EastDirection(Coordinates);
        }

        public override string GetDirection()
        {
            return DirectionConst.North;
        }

        public override bool CheckRoverLimits(PlateauCoordinates plateauCoordinates)
        {
            if (plateauCoordinates.yMax == Coordinates.Y)
                return false;

            return true;
        }
    }
}
