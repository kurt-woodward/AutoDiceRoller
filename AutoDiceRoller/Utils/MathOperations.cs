//using System;
//using System.Linq;
//using AutoDiceRoller.Models;

//namespace AutoDiceRoller.Utils
//{
//    public interface IMathOperations
//    {
//        int GetMaxRollID();
//        double GetAvgConfLvl();
//        int GetAvgFaceValue();
//    }
//    public class MathOperations : IMathOperations
//    {
//        public int MaxRollId { get; set; }
//        public double AvgConfLvl { get; set; }
//        public double AvgFaceValue { get; set; }

//        private DiceRollerDBContext _context;
//        public MathOperations(DiceRollerDBContext context)
//        {
//            _context = context;
//        }
//        public int GetMaxRollID()
//        {
//            return MaxRollId = Convert.ToInt32(_context.OcrResults.Max());
//            //return _context.OcrResults.Max();
//        }

//        public double GetAvgConfLvl()
//        {
//            return AvgConfLvl = _context.OcrResults.Select() / MaxRollId;
//        }

//        public int GetAvgFaceValue()
//        {
//            AvgFaceValue = _context.OcrResults.Sum() / MaxRollId;
//        }
//    }
//}
