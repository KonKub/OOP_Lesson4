using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuildLib
{
    class Building
    {
        private static uint _number = 0;                   //уникальный номер здания
        private float _height;                             //высота здания
        private ushort _floorsAmount;                      //количество этажей
        private ushort _apartmentsAmount;                  //количество квартир в доме
        private ushort _entrancesAmout;                    //количество подъездов

        public Building() 
        {
            _number++;
        }

        public uint Number
        {
            get { return _number; }
        }
        
        public float Height
        {
            get { return _height; }
            set
            {
                if (value < 3) value = 3;
                _height = value;
            }
        }

        public ushort FloorsAmount
        {
            get { return _floorsAmount; }
            set
            {
                if (value == 0) value = 1;
                _floorsAmount = value;
            }
        }

        public ushort ApartmentsAmount
        {
            get { return _apartmentsAmount; }
            set
            {
                if (value < 1) value = 1;
                _apartmentsAmount = value;
            }
        }

        public ushort EntrancesAmout
        {
            get { return _entrancesAmout; }
            set
            {
                if (value < 1) value = 1;
                _entrancesAmout = value;
            }
        }

        public float FloorHeight()                         //высота этажа
        {
            return _height / _floorsAmount;
        }

        public ushort ApartmentsInEntrance()               //количество квартир в подъезде
        {
            return (ushort)(_apartmentsAmount / _entrancesAmout);
        }

        public ushort ApartmentsPerFloor()                //количество квартир на этаже
        {
            return (ushort)(_apartmentsAmount / _entrancesAmout / _floorsAmount);
        }
    }
}
