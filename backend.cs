using System;
using System.Collections.Generic;

namespace userPlant
{

    class myPlant
    {
         static string _name { get; set; }
          private static int _waterLevel { get; set; }
          private static int _foodLevel { get; set; }
          private static int  _sunLevel { get; set; }

        //    public string _name 
        //    private string _name 
        //    private string _name 
        //    private string _name 



          //PLANT CONSTRUCTOR
         public  myPlant(string iName, int iWaterLevel, int iFoodLevel, int iSunLevel)
        {
         _name = iName;
         _waterLevel = iWaterLevel;
         _foodLevel = iFoodLevel;
         _sunLevel = iSunLevel;

        }
        public void Water()
        {
        _waterLevel += 2;

        }
        public int getWater()
        {
            return _waterLevel;
        }
         public void Feed()
        {
            _foodLevel += 2;
        }
        public int getfood()
        {
            return _foodLevel;
        }
          public void giveSunshine()
        {
        _sunLevel += 2;

        }
        public int getgiveSunshine()
        {
            return _sunLevel;
        }
       
    }
}