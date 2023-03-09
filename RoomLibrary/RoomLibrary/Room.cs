﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomLibrary
{
    public class Room
    {
        double roomLength; //Длина комнаты
        double roomWidht;   //Ширина комнаты
        public double RoomLength
        {
            get { return roomLength; }
            set { roomLength = value; } 
        }
        public double RoomWidht
        {
            get { return roomWidht; }
            set { roomWidht = value; }
        }
        /// <summary>
        /// Метод вычисляет периметр комнаты
        /// </summary>
        /// <returns>Возвращает значение периметра</returns>
        public double RoomPerimeter()
        {
            return 2 * (roomLength + roomWidht);
        }
        /// <summary>
        /// Метод вычисляет площадь комнаты
        /// </summary>
        /// <returns>Возвращает значение площади</returns>
        public double RoomArea()
        {
            return roomLength * roomWidht;
        }
        /// <summary>
        /// Метод вычисляет число квадратных метров 
        /// на одного человека
        /// </summary>
        /// <param name="np">Число человек</param>
        /// <returns>Возвращает число кадратных метров</returns>
        public double PersonArea(int np)
        {
            return RoomArea() / np;
        }
        /// <summary>
        /// Информация о комнате
        /// </summary>
        /// <returns>Возвращает строку</returns>
        public string Info()
        {
            return "Комната площадью " + RoomArea() + "кв.м";
        }
    }
    ///<summary>
    ///Класс "жилая комната"
    ///</summary>summary>
    public class LivRoom : Room
    {
        int numWin;     //число окон
        public int NumWin
        { get { return numWin; } set { numWin = value; } }  
        /// <summary>
        /// Метод возвращает информацию о комнате
        /// </summary>
        /// <returns>Возвращаетяс строка с информацией</returns>
        public string Info()
        {
            return "Жилая комната площадью " + RoomArea() + "кв.м, с " + numWin + " за окнами";
        }
        
    }
    public class Office : Room
    {
        int numSockets; //число розеток
        public int NumSockets
        { get { return numSockets; } set { numSockets = value; } }
        /// <summary>
        /// Возвращает максимально возможное число рабочих мест
        /// </summary>
        /// <returns>Возвращает число мест</returns>
        public int NumWorkplaces()
        {
            int num = Convert.ToInt32(Math.Truncate(RoomArea() / 4.5));
            return Math.Min(num, numSockets);
        }
        /// <summary>
        /// Метод возвращает информацию об офисе
        /// </summary>
        /// <returns>Возвращается строка с ифнормацией</returns>
        public string info()
        {
            return "Офис на " + NumWorkplaces() + " рабочих мест";
        }
    }

}
