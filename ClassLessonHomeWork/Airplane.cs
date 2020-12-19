using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLessonHomeWork
{
    // 1.Разработать один из классов, в соответствии с полученным вариантом.(Самолет)   
    public partial class Airplane
    {   
        // 2.Реализовать не менее пяти закрытых полей(различных типов), представляющих основные характеристики рассматриваемого класса.
        private string nameOfCompany;
        private string codeOfPlane;
        private int countOfPassangers;
        private int countOfCrew;
        private double distanceOfFlight;
        private int countOfEngines;
        private double volumeOfFuel;

        // 5.Создать не менее двух статических полей(различных типов),  представляющих общие характеристики объектов данного класса.        
        static private int countOfCrashes;
        static private int countOfPlanes;

        // 6.Обязательным требованием является реализация нескольких перегруженных конструкторов, аргументы которых определяются студентом,
        // исходя из специфики реализуемого класса, а так же реализация конструктора по умолчанию.
        public Airplane(int countOfPassangers, int countOfCrew, double distanceOfFlight)
        {
            this.countOfPassangers = countOfPassangers;
            this.countOfCrew = countOfCrew;
            this.distanceOfFlight = distanceOfFlight;
        }

        public Airplane(int countOfPassangers, int countOfCrew, string codeOfPlane)
        {
            this.countOfPassangers = countOfPassangers;
            this.countOfCrew = countOfCrew;
            this.codeOfPlane = codeOfPlane;
        }

        public Airplane(double distanceOfFlight, int countOfEngines, double volumeOfFuel)
        {
            this.distanceOfFlight = distanceOfFlight;
            this.countOfEngines = countOfEngines;
            this.volumeOfFuel = volumeOfFuel;
        }

        // 7.Создать статический конструктор.
        static Airplane()
        {
            
        }

        // 3.Создать не менее трех методов управления классом и методы доступа к его закрытым полям.
        public void SetNameOfCompany(string nameOfCompany)
        {
            this.nameOfCompany = nameOfCompany; 
        }
        public string GetNameOfCompany()
        {
            return nameOfCompany;
        }
        public void SetCodeOfPlane(string codeOfPlane)
        {
            this.codeOfPlane = codeOfPlane;
        }
        public string GetCodeOfPlane()
        {
            return codeOfPlane;
        }
        public void SetCountOFPassangers(int countOfPassangers)
        {
            this.countOfPassangers = countOfPassangers;
        }
        public int GetCountOFPassangers()
        {
            return countOfPassangers;
        }
        public void SetCountOfCrew(int countOfCrew)
        {
            this.countOfCrew = countOfCrew;
        }
        public int GetCountOfCrew()
        {
            return countOfCrew;
        }
        public void SetDistanceOfFlight(double distanceOfFlight)
        {
            this.distanceOfFlight = distanceOfFlight;
        }
        public double GetDistanceOfFlight()
        {
            return distanceOfFlight;
        }
        public void SetCountOfEngines(int countOfEngines)
        {
            this.countOfEngines = countOfEngines;
        }
        public int GetCountOfEngines()
        {
            return countOfEngines;
        }
        public void SetVolumeOfFuel(double volumeOfFuel)
        {
            this.volumeOfFuel = volumeOfFuel;
        }
        public double GetVolumeOfFuel()
        {
            return volumeOfFuel;
        }

        public void RefuelPlane(double newFuel)
        {
            volumeOfFuel += newFuel;
        }

        public void InsertPassangers(int newPass)
        {
            countOfPassangers += newPass;
        }

        public void RemovePassangers(int badPass)
        {
            countOfPassangers -= badPass;
        }

       
        

    }
}
