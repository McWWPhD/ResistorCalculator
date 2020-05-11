using System;
using System.Windows.Forms.VisualStyles;


namespace ResistorCalculator
{
    public partial class ElectricalResistance
    {
        public double?[,] Table = new double?[13, 4]
           {
        {null,null,null,20}, //"brak"
        {null,null,0.01,10}, //"srebrny"
        {null,null, 0.1, 5}, //"złoty"
        {null,0,1,null}, //"czarny"
        {1, 1, 10,1}, //"brązowy"
        {2, 2, 100, 2}, //"czerwony"
        {3, 3, 1000, null}, //"pomarańczowy"
        {4, 4, 10000, null}, //"żółty"
        {5, 5, 100000, 0.5}, //"zielony"
        {6, 6, 1000000, 0.25}, //"niebieski"
        {7, 7, 10000000, 0.1}, //"fioletowy"
        {8, 8, 100000000, 0.05}, //"szary"
        {9, 9, 1000000000, null} //"biały"
           };

        public double? TableValue(int row, int value)
        {
            return Table[row, value];
        }
    }
}


